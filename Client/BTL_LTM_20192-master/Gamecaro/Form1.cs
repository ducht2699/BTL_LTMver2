using CurrentTimeNameSpace;
using SocketDataNameSpace;
using SocketManagerNamespace;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Gamecaro
{
    public partial class Form1 : Form
    {
        #region Properties

        public CurrentTime time = new CurrentTime();
        private ChessBoardManager ChessBoard;

        private SocketManager socket;

        private bool isConnect = false;

        #endregion Properties

        public Form1()
        {
            InitializeComponent();

            //ngan bao loi xung dot
            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            socket = new SocketManager();

            NewGame();
            pnlChessBoard.Enabled = false;
            btnSendChat.Enabled = false;
            tbChat.Enabled = false;
            newGameToolStripMenuItem.Enabled = false;

            
        }

        #region Player function

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            pnlChessBoard.Enabled = false;

            socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            Listen();
        }

        #endregion Player function

        #region game function

        private void EndGame()
        {
            pnlChessBoard.Enabled = false;
        }

        private void NewGame()
        {
            ChessBoard.DrawChessBoard();
        }

        private void Quit()
        {
            Application.Exit();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.END_GAME, "", new Point()));
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
            newGameToolStripMenuItem.Enabled = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        #endregion game function

        #region close app

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.QUIT, "", new Point()));
            }
            catch { }
        }

        #endregion close app

        #region event

        private void btnLAN_Click(object sender, EventArgs e)
        {
            if (!isConnect && txbPlayerName.Text != "" && txbPlayerName.Text != "[SERVER]")
            {
                if (!socket.ConnectServer())
                {
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: Không thể kết nối đến server");
                    isConnect = false;
                }
                else
                {
                    socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.QUIT, "", new Point()));
                    isConnect = true;

                    //cap nhat giao dien
                    btnLAN.Text = "DISCONNECT";
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: Kết nối thành công!");
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                        txbPlayerName.Enabled = false;
                        tbChat.Enabled = true;
                    }));
                    //gui ten cho server
                    Listen();
                    btnSendChat.Enabled = true;
                }
            }
            else if (!isConnect && txbPlayerName.Text == "" || txbPlayerName.Text == "[SERVER]")
            {
                MessageBox.Show("Tên Lỗi, mời nhập lại!");
            }
            else
            {
                tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: DISCONNECTED!!!");
                isConnect = false;
                btnSendChat.Enabled = false;
                btnLAN.Text = "CONNECT";
                txbIP.Text = "127.0.0.1";
                txbPlayerName.Enabled = true;
                pnlChessBoard.Enabled = false;
                tbChat.Enabled = false;
                newGameToolStripMenuItem.Enabled = false;
                socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.QUIT, "", new Point()));
                socket.client.Close();
            }
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            if (tbChat.Text.Trim() != "")
            {
                socket.Send(new SocketData("", txbPlayerName.Text, (int)SocketCommand.CHAT, tbChat.Text, new Point()));
                tbLogChat.AppendText("\r\n\r\nYOU: " + tbChat.Text + "\r\n[" + time.getCurrentTime() + "]\r\n");
                tbChat.Text = "";
            }
        }
        private void txbPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (txbPlayerName.Enabled == true && e.KeyCode == Keys.Enter)
            {
                btnLAN_Click(null, null);
            }
        }
        private void tbChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbChat.Enabled == true && e.KeyCode == Keys.Enter)
            {
                btnSendChat_Click(null, null);
            }
        }
        #endregion event

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = "127.0.0.1";
        }

        private void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch (Exception)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                //new
                case (int)SocketCommand.WAITING:
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                    txbIP.Text = data.PlayerSocket;
                    pctbMark.Image = Image.FromFile(Application.StartupPath + "\\Resources\\OPlayer.png");
                    tbLogChat.Text = "";
                    newGameToolStripMenuItem.Enabled = false;
                    tbChat.Enabled = false;
                    btnSendChat.Enabled = false;
                    break;

                case (int)SocketCommand.CHAT:
                    tbLogChat.AppendText("\r\n[" + time.getCurrentTime() + " - " + data.PlayerName + "]: " + data.Message);
                    break;

                case (int)SocketCommand.PLAYER1:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                        ChessBoard.CurPlayer = new Player(txbPlayerName.Text, Image.FromFile(Application.StartupPath + "\\Resources\\OPlayer.png"));
                        ChessBoard.OtherPlayer = new Player(txbPlayerName.Text, Image.FromFile(Application.StartupPath + "\\Resources\\XPlayer.png"));
                        NewGame();
                        pctbMark.Image = Image.FromFile(Application.StartupPath + "\\Resources\\OPlayer.png");
                        pnlChessBoard.Enabled = true;
                        tbChat.Enabled = true;
                        btnSendChat.Enabled = true;
                        tbLogChat.Text = "";
                        newGameToolStripMenuItem.Enabled = false;
                        txbIP.Text = data.PlayerSocket;
                    }));

                    break;

                case (int)SocketCommand.PLAYER2:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                        ChessBoard.CurPlayer = new Player(txbPlayerName.Text, Image.FromFile(Application.StartupPath + "\\Resources\\XPlayer.png"));
                        ChessBoard.OtherPlayer = new Player(txbPlayerName.Text, Image.FromFile(Application.StartupPath + "\\Resources\\OPlayer.png"));
                        tbLogChat.Text = "";
                        newGameToolStripMenuItem.Enabled = false;
                        pctbMark.Image = Image.FromFile(Application.StartupPath + "\\Resources\\XPlayer.png");
                        txbIP.Text = data.PlayerSocket;
                        tbChat.Enabled = true;
                        btnSendChat.Enabled = true;
                    }));

                    break;

                case (int)SocketCommand.SERVER_OUT:
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                    pnlChessBoard.Enabled = false;
                    btnLAN.Text = "CONNECT";
                    socket.client.Close();
                    txbPlayerName.Enabled = true;
                    tbChat.Enabled = false;
                    btnSendChat.Enabled = false;
                    isConnect = false;
                    break;

                //old
                case (int)SocketCommand.NOTIFY:
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                        newGameToolStripMenuItem.Enabled = false;
                    }));
                    break;

                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pnlChessBoard.Enabled = true;
                        ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;

                case (int)SocketCommand.END_GAME:
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                    pnlChessBoard.Enabled = false;
                    newGameToolStripMenuItem.Enabled = true;
                    tbChat.Enabled = true;
                    btnSendChat.Enabled = true;
                    break;

                case (int)SocketCommand.QUIT:
                    tbLog.AppendText("\r\n[" + time.getCurrentTime() + "]: " + data.Message);
                    pnlChessBoard.Enabled = false;
                    tbChat.Enabled = false;
                    btnSendChat.Enabled = false;
                    break;

                default:
                    break;
            }

            Listen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}