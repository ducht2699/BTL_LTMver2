using CurrentTimeNameSpace;
using SocketDataNameSpace;
using SocketManagerNamespace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GOMOKU_SERVER_APP
{
    public partial class Form1 : Form
    {
        #region Properties

        private CurrentTime time = new CurrentTime();

        //tao mang luu tru thong tin nguoi choi
        private static List<player> playerList = new List<player>();

        public static int numPlayer = 0;
        public static int MAX_PLAYER = 100;

        public const int BUFFER_SIZE = 1024;
        private static ASCIIEncoding encoding = new ASCIIEncoding();
        public static bool isRunning = false;

        private TcpListener listener;

        internal static List<player> PlayerList { get => playerList; set => playerList = value; }

        #endregion Properties

        public Form1()
        {
            InitializeComponent();

            //ngan bao loi xung dot
            Control.CheckForIllegalCrossThreadCalls = false;

            tbLog.Enabled = false;
            lbPlayer.Enabled = false;
            tbChat.Enabled = false;
            btnSend.Enabled = false;
            btnDelete.Enabled = false;
            panel2.Enabled = false;
            btnDetails.Enabled = false;
            this.Size = new Size(585, 380);
        }

        #region other method

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion other method

        #region event

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Thread thClickButton = new Thread(() =>
            {
                if (!isRunning)
                {
                    isRunning = true;

                    //tao server
                    listener = new TcpListener(IPAddress.Any, 8000);

                    //listen
                    listener.Start();

                    tbLog.AppendText("[" + time.getCurrentTime() + "]: Server started!!!");

                    //dieu chinh giao dien

                    btnStartServer.Text = "Stop Server";
                    lbPlayer.Enabled = true;
                    tbLog.Enabled = true;
                    btnStartServer.BackColor = Color.Red;
                    try
                    {
                        while (true)
                        {
                            Socket newClient = listener.AcceptSocket();

                            //tao nguoi choi moi
                            SocketManager temp = new SocketManager();
                            temp.client = newClient;

                            //lay ten cua nguoi choi
                            SocketData playerData = (SocketData)temp.Receive();

                            player newPlayer = new player();
                            newPlayer.Player1Socket = temp;
                            newPlayer.Player1Socket.playerName = playerData.PlayerName;
                            newPlayer.Status = "WAITING";
                            newPlayer.Player2Socket = null;

                            //xu ly nguoi choi
                            if (addPlayer(newPlayer))
                            {
                                tbChat.Enabled = true;
                                btnSend.Enabled = true;
                                btnDelete.Enabled = true;
                                btnDetails.Enabled = true;
                                //tạo luồng chấp nhận kết nối và thêm vào danh sách người chơi + xử lý
                                Thread chapNhanKetNoi = new Thread(ClientThread);
                                chapNhanKetNoi.IsBackground = true;
                                chapNhanKetNoi.Start(newPlayer);
                            }
                            else
                            {
                                //thong bao va ngat ket noi client
                                newPlayer.Player1Socket.Send(new SocketData("", newPlayer.Player1Socket.playerName, (int)SocketCommand.SERVER_OUT, "Lỗi kết nối, mời thử lại!", new Point()));
                                newClient.Close();
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    isRunning = false;
                    //dieu chinh giao dien
                    btnStartServer.Text = "Start Server";
                    lbPlayer.Enabled = false;
                    btnStartServer.BackColor = Color.LimeGreen;
                    try
                    {
                        //stop server, send msg to all client and disconnect
                        StopServer();
                    }
                    catch (Exception)
                    {
                    }
                }
            });
            thClickButton.IsBackground = true;
            thClickButton.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isRunning)
            {
                StopServer();
                listener.Stop();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Thread Nhantin = new Thread(() =>
            {
                if (tbChat.Enabled == true && tbChat.Text.Trim() != "")
                {
                    foreach (object itemList in lbPlayer.SelectedItems)
                    {
                        for (int i = 0; i < playerList.Count; i++)
                        {
                            if (itemList.ToString() == playerList[i].Player1Socket.client.RemoteEndPoint.ToString() + " - " + playerList[i].Player1Socket.playerName)
                            {
                                playerList[i].Player1Socket.Send(new SocketData("", "[SERVER]", (int)SocketCommand.CHAT, tbChat.Text.Trim(), new Point()));
                            }
                        }
                    }
                    tbChat.Text = "";
                }
            });
            Nhantin.IsBackground = true;
            Nhantin.Start();
        }

        private void tbChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Size = new Size(585, 380);
            //ngat ket noi
            for (int i = 0; i < playerList.Count; i++)
            {
                for (int j = 0; j < lbPlayer.SelectedItems.Count; j++)

                {
                    if (playerList[i].Player1Socket.client.RemoteEndPoint + " - " + playerList[i].Player1Socket.playerName == lbPlayer.SelectedItems[j].ToString())
                    {
                        if (playerList[i].Player2Socket != null)
                        {
                            //thay ddoir trnag thai doi thu
                            for (int t = 0; t < playerList.Count; t++)

                            {
                                if (playerList[t].Player2Socket != null)
                                {
                                    if (playerList[t].Player2Socket.client == playerList[i].Player1Socket.client)
                                    {
                                        playerList[t].Player1Socket.Send(new SocketData("", playerList[t].Player1Socket.playerName, (int)SocketCommand.QUIT, playerList[t].Player2Socket.playerName + " đã thoát! Chờ đối thủ khác!", new Point()));
                                        playerList[t].Status = "WAITMATCH";
                                        playerList[t].Player2Socket = null;
                                        playerList[i].Player2Socket = null;
                                        break;
                                    }
                                }
                            }
                        }

                        //ngat ket noi
                        lbPlayer.SelectedItems.Remove(lbPlayer.SelectedItems[j]);
                        playerList[i].Player1Socket.Send(new SocketData("", "[SERVER]", (int)SocketCommand.SERVER_OUT, "Bạn đã bị server ngắt kết nối!", new Point()));
                        tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + playerList[i].Player1Socket.client.RemoteEndPoint + " - " + playerList[i].Player1Socket.playerName + " DISCONNECTED!");
                        playerList[i].Player1Socket.client.Close();
                        playerList[i].Status = "DELETE";
                        break;
                    }
                }
            }
            //cap nhat giao dien
            int index = 0;
            bool check = false;
            do
            {
                if (playerList[index].Status == "DELETE")
                {
                    playerList.Remove(playerList[index]);
                    check = true;
                }
                else check = false;

                if (check)
                {
                    continue;
                }
                else
                {
                    index++;
                }
            } while (index < playerList.Count);
            lbPlayer.Items.Clear();

            if (playerList.Count != 0)
            {
                for (int i = 0; i < playerList.Count; i++)
                {
                    lbPlayer.Items.Add(playerList[i].Player1Socket.client.RemoteEndPoint.ToString() + " - " + playerList[i].Player1Socket.playerName);
                }

                //match player khac
                for (int i = 0; i < playerList.Count; i++)
                {
                    if (playerList[i].Status == "WAITMATCH")
                    {
                        playerList[i].Status = "WAITING";
                        
                        matchPlayerAfter(playerList[i]);
                    }
                }
            }
        }

        private void lbPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(null, null);
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnDetails_Click(null, null);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Size = new Size(585, 380);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lbPlayer.SelectedItem != null && lbPlayer.SelectedItems.Count == 1)
            {
                this.Size = new Size(951, 380);
                updateImage();
                updateDetails();
            }
            else
            {
                tbLog.AppendText("\r\nERROR!!! Select 1 player only!");
            }
        }
        private void lbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlayer.SelectedItems.Count > 1)
            {
                this.Size = new Size(585, 380);
            }
            else
            {
                updateDetails();
            }
            
        }
        #endregion event

        #region done method

        public void updateDetails()
        {
            if (this.Size == new Size(951, 380) && lbPlayer.SelectedItems.Count == 1)
            {
                for (int i = 0; i < playerList.Count; i++)
                {
                    if (playerList[i].Player1Socket.client.RemoteEndPoint + " - " + playerList[i].Player1Socket.playerName == lbPlayer.SelectedItem.ToString())
                    {
                        labelName.Text = playerList[i].Player1Socket.playerName;
                        labelSocket.Text = playerList[i].Player1Socket.client.RemoteEndPoint.ToString();
                        labelStatus.Text = playerList[i].Status;
                        if (playerList[i].Player1Socket.isPlayer1)
                        {
                            ptbMark.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\O_image.png");
                        }
                        else
                        {
                            ptbMark.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X_image.png");
                        }
                        if (playerList[i].Player2Socket != null)
                        {
                            panel2.Enabled = true;
                            labelNameRival.Text = playerList[i].Player2Socket.playerName;
                            labelSocketRival.Text = playerList[i].Player2Socket.client.RemoteEndPoint.ToString();
                            for (int j = 0; j < playerList.Count; j++)
                            {
                                if (playerList[i].Player2Socket.client == playerList[j].Player1Socket.client)
                                {
                                    labelStatusRival.Text = playerList[j].Status;
                                    if (playerList[j].Player1Socket.isPlayer1)
                                    {
                                        ptbMarkRival.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\O_image.png");
                                    }
                                    else
                                    {
                                        ptbMarkRival.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X_image.png");
                                    }
                                }
                                
                            }
                        }
                        else
                        {
                            ptbMarkRival.BackgroundImage = null ;
                            panel2.Enabled = false;
                        }

                        break;
                    }
                }
            }

        }

        public void updateImage()
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].Status == "MATCH1")
                {
                    playerList[i].Player1Socket.isPlayer1 = true;
                    playerList[i].Player2Socket.isPlayer1 = false;
                }
                else
                if (playerList[i].Status == "MATCH2")
                {
                    playerList[i].Player2Socket.isPlayer1 = true;
                    playerList[i].Player1Socket.isPlayer1 = false;
                }
            }
        }
        private void matchPlayer(player newPlayer)
        {
            bool checkMatch = false;
            try
            {
                //tim va luu thong tin doi thu
                for (int i = 0; i < playerList.Count; i++)

                {
                    //neu gap player dang doi
                    if (newPlayer.Player1Socket.client != playerList[i].Player1Socket.client && playerList[i].Status == "WAITING")
                    {
                        checkMatch = true;
                        //thay doi trang thai của player 1 (player đang đợi)
                        playerList[i].Status = "MATCHED1";
                        playerList[i].Player1Socket.isPlayer1 = true;
                        playerList[i].Player2Socket = newPlayer.Player1Socket;

                        //tìm và thay đổi thông tin player 2 (player mới kết nối đến)
                        for (int j = 0; j < playerList.Count; j++)
                        {
                            if (newPlayer.Player1Socket.client == playerList[j].Player1Socket.client)
                            {
                                playerList[j].Status = "MATCHED2";
                                playerList[j].Player1Socket.isPlayer1 = false;
                                playerList[j].Player2Socket = playerList[i].Player1Socket;
                                tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + playerList[j].Player2Socket.client.RemoteEndPoint + " - " + playerList[j].Player2Socket.playerName + "  matched to  " + playerList[j].Player1Socket.client.RemoteEndPoint + " - " + playerList[j].Player1Socket.playerName);
                                break;
                            }
                        }
                        break;
                    }
                }

                if (!checkMatch)
                {
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + newPlayer.Player1Socket.client.RemoteEndPoint + " - " + newPlayer.Player1Socket.playerName + " WAITING...");
                }
                //thong bao cho client
                if (newPlayer.Status == "WAITING")
                {
                    newPlayer.Player1Socket.Send(new SocketData(newPlayer.Player1Socket.client.RemoteEndPoint.ToString(), newPlayer.Player1Socket.playerName, (int)SocketCommand.WAITING, "Chờ đối thủ!", new Point()));
                }
                else if (newPlayer.Status == "MATCHED2")
                {
                    newPlayer.Player1Socket.Send(new SocketData(newPlayer.Player1Socket.client.RemoteEndPoint.ToString(), newPlayer.Player1Socket.playerName, (int)SocketCommand.PLAYER2, "Đã kết nối với \"" + newPlayer.Player2Socket.playerName + "\", chờ đối thủ đánh trước!", new Point()));
                    newPlayer.Player2Socket.Send(new SocketData(newPlayer.Player2Socket.client.RemoteEndPoint.ToString(), newPlayer.Player2Socket.playerName, (int)SocketCommand.PLAYER1, "Đã kết nối với \"" + newPlayer.Player1Socket.playerName + "\", mời bạn đánh trước!", new Point()));
                }
                updateImage();
                updateDetails();
            }
            catch (Exception)
            {
            }
        }

        private void matchPlayerAfter(player newPlayer)
        {
            bool checkMatch = false;

            try
            {
                //tim va luu thong tin doi thu
                for (int i = 0; i < playerList.Count; i++)

                {
                    //neu gap player dang doi
                    if (newPlayer.Player1Socket.client != playerList[i].Player1Socket.client && playerList[i].Status == "WAITING")
                    {
                        checkMatch = true;
                        //thay doi trang thai của player 1 (player đang đợi)
                        playerList[i].Status = "MATCHED1";
                        playerList[i].Player1Socket.isPlayer1 = true;
                        playerList[i].Player2Socket = newPlayer.Player1Socket;

                        //tìm và thay đổi thông tin player 2 (player mới kết nối đến)
                        for (int j = 0; j < playerList.Count; j++)

                        {
                            if (newPlayer.Player1Socket.client == playerList[j].Player1Socket.client)
                            {
                                playerList[j].Status = "MATCHED2";
                                playerList[j].Player1Socket.isPlayer1 = false;
                                playerList[j].Player2Socket = playerList[i].Player1Socket;
                                tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + playerList[j].Player2Socket.client.RemoteEndPoint + " - " + playerList[j].Player2Socket.playerName + "  matched to  " + playerList[j].Player1Socket.client.RemoteEndPoint + " - " + playerList[j].Player1Socket.playerName);
                                break;
                            }
                        }

                        break;
                    }
                }

                if (!checkMatch)
                {
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + newPlayer.Player1Socket.client.RemoteEndPoint + " - " + newPlayer.Player1Socket.playerName + " WAITING...");
                }

                //thong bao cho client
                if (newPlayer.Status == "MATCHED2")
                {
                    newPlayer.Player1Socket.Send(new SocketData(newPlayer.Player1Socket.client.RemoteEndPoint.ToString(), newPlayer.Player1Socket.playerName, (int)SocketCommand.PLAYER2, "Đã kết nối với \"" + newPlayer.Player2Socket.playerName + "\", chờ đối thủ đánh trước!", new Point()));
                    newPlayer.Player2Socket.Send(new SocketData(newPlayer.Player2Socket.client.RemoteEndPoint.ToString(), newPlayer.Player2Socket.playerName, (int)SocketCommand.PLAYER1, "Đã kết nối với \"" + newPlayer.Player1Socket.playerName + "\", mời bạn đánh trước!", new Point()));
                }
                updateImage();
                updateDetails();
            }
            catch (Exception)
            {
            }
        }

        private bool addPlayer(player newPlayer)
        {
            bool check = false;
            //kiem tra so luong nguoi choi
            if (numPlayer == MAX_PLAYER)
            {
                check = false;
            }
            else
            {
                check = true;
                //add nguoi choi
                numPlayer++;
                playerList.Add(newPlayer);
                tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: new player: " + newPlayer.Player1Socket.client.RemoteEndPoint);
                matchPlayer(newPlayer);
                //xu ly trang thai

                lbPlayer.Items.Add(newPlayer.Player1Socket.client.RemoteEndPoint.ToString() + " - " + newPlayer.Player1Socket.playerName);
                updateImage();
                updateDetails();
            }
            return check;
        }

        private void erasePlayer(player deletePlayer)
        {
            if (deletePlayer.Player2Socket != null)
            {
                //cap nhat trang thai doi thu
                for (int i = 0; i < playerList.Count; i++)

                {
                    if (playerList[i].Player1Socket.client == deletePlayer.Player2Socket.client)
                    {
                        playerList[i].Status = "WAITING";
                        //gui cho doi thu
                        playerList[i].Player1Socket.Send(new SocketData("", playerList[i].Player1Socket.playerName, (int)SocketCommand.QUIT, playerList[i].Player2Socket.playerName + " đã thoát! Chờ đối thủ khác!", new Point()));

                        playerList[i].Player2Socket = null;

                        matchPlayerAfter(playerList[i]);
                        break;
                    }
                }
            }

           for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i] == deletePlayer)
                {
                    //ngat ket noi
                    try
                    {
                        deletePlayer.Player1Socket.client.Close();
                    }
                    catch
                    {
                    }

                    //xoa khoi danh sach
                    playerList.Remove(playerList[i]);
                    numPlayer--;
                    break;
                }
            }

            if (playerList.Count == 0)
            {
                tbChat.Enabled = false;
                btnSend.Enabled = false;
                btnDelete.Enabled = false;
                btnDetails.Enabled = false;
            }

            if (lbPlayer.SelectedItem == null)
            {
                this.Size = new Size(585, 380);
            }
            else
            {
                updateDetails();
            }
        }

        private void ClientThread(object cli)
        {
            player newPlayer = (player)cli;

            //xử lý truyền nhận
            try
            {
                do
                {
                    //nhận dữ liệu từ player 1
                    SocketData temp = (SocketData)newPlayer.Player1Socket.Receive();

                    //xử lý dữ liệu ở đây !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if (temp.Command == (int)SocketCommand.QUIT)
                    {
                        //cap nhat giao dien
                        tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + newPlayer.Player1Socket.client.RemoteEndPoint + " - " + newPlayer.Player1Socket.playerName + " QUIT!!!");
                        foreach (String item in lbPlayer.Items)
                        {
                            if (item == newPlayer.Player1Socket.client.RemoteEndPoint.ToString() + " - " + newPlayer.Player1Socket.playerName)
                            {
                                
                                
                                lbPlayer.Items.Remove(item);
                                //xoa khoi danh sach
                                erasePlayer(newPlayer);

                                break;
                            }
                        }
                    }
                    else if (temp.Command == (int)SocketCommand.END_GAME)
                    {
                        newPlayer.Player2Socket.Send(new SocketData("", newPlayer.Player1Socket.playerName, (int)SocketCommand.END_GAME, "Đã 5 con trên một hàng, " + newPlayer.Player1Socket.playerName + " WIN!!!", new Point()));
                        newPlayer.Player1Socket.Send(new SocketData("", newPlayer.Player2Socket.playerName, (int)SocketCommand.END_GAME, "Đã 5 con trên một hàng, " + newPlayer.Player1Socket.playerName + " WIN!!!", new Point()));
                    }
                    else
                    {
                        //chuyển dữ liệu cho player 2
                        newPlayer.Player2Socket.Send(temp);
                    }
                } while (true);
            }
            catch (Exception)
            {
            }
        }

        private void StopServer()
        {
            tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: Server stopped!!!\r\n");
            try
            {
                //gui tin nhan
                for (int i = 0; i < playerList.Count; i++)

                {
                    playerList[i].Player1Socket.Send(new SocketData("", playerList[i].Player1Socket.playerName, (int)SocketCommand.SERVER_OUT, "Server đã tắt, bạn bị ngắt kết nối", new Point()));
                    playerList[i].Player1Socket.client.Close();
                }
                playerList.Clear();

                //xoá toàn bộ danh sách player (giao diện)
                lbPlayer.Items.Clear();

                //stop server
                listener.Stop();
                this.Size = new Size(585, 380);
            }
            catch (Exception)
            {
            }
        }

        #endregion done method


    }
}