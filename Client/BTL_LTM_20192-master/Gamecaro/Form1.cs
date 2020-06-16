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
        }

        #region Player function

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            pnlChessBoard.Enabled = false;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

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
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
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
                socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
            }
            catch { }
        }

        #endregion close app

        private void btnLAN_Click(object sender, EventArgs e)
        {
            if (!isConnect)
            {
                if (!socket.ConnectServer())
                {
                    MessageBox.Show("Không thể kết nối đến server.", "Thông báo", MessageBoxButtons.OK);
                    isConnect = false;
                }
                else
                {
                    isConnect = true;

                    //cap nhat giao dien
                    btnLAN.Text = "DISCONNECT";
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));


                    Listen();
                }
            }
            else
            {
                isConnect = false;
                btnLAN.Text = "CONNECT";
                socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                socket.client.Close();
            }
        }

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
                    MessageBox.Show(data.Message);
                    break;

                case (int)SocketCommand.PLAYER1:
                    MessageBox.Show(data.Message);
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = true;
                    }));
                    break;

                case (int)SocketCommand.PLAYER2:
                    MessageBox.Show(data.Message);
                    break;

                case (int)SocketCommand.SERVER_OUT:
                    MessageBox.Show(data.Message);
                    pnlChessBoard.Enabled = false;
                    btnLAN.Text = "CONNECT";
                    socket.client.Close();
                    isConnect = false;
                    break;

                //old
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
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
                    MessageBox.Show(data.Message);
                    pnlChessBoard.Enabled = false;
                    break;

                case (int)SocketCommand.QUIT:
                    MessageBox.Show(data.Message);
                    pnlChessBoard.Enabled = false;
                    break;

                default:
                    break;
            }

            Listen();
        }
    }
}