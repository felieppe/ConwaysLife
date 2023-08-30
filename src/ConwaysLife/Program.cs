using Library;

namespace ConwaysLife {
    class Program {
        static void Main(string[] args) {
            string boardPath = "../../assets/board.txt";
            Importer importer = new Importer(boardPath);

            Board board = new Board(importer.LoadBoard());
            Printer printer = new Printer(board, 20, 20);

            printer.Print();
        }
    }
}