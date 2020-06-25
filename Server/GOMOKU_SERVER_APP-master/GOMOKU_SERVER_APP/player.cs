using SocketManagerNamespace;

namespace GOMOKU_SERVER_APP
{
    internal class player
    {
        private SocketManager player1Socket; // nguoi choi 1
        private string status; // WAITING - MATCHED1 - MATCHED2
        private SocketManager player2Socket; // doi thu

        public SocketManager Player1Socket { get => player1Socket; set => player1Socket = value; }
        public string Status { get => status; set => status = value; }
        public SocketManager Player2Socket { get => player2Socket; set => player2Socket = value; }
    }
}