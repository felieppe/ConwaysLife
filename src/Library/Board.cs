namespace Library
{
    public class Board
    {
        private bool[,] B;
        public Board(bool[,] b) {
            this.B = b;
        }

        public void SetBoard(bool[,] b) {
            this.B = b;
        }

        public bool[,] GetBoard() {
            return this.B;
        }
    }
}