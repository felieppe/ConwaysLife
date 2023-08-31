using System.Runtime.InteropServices;
using Library;

namespace ConwaysLife {
    class Program {
        static void Main(string[] args) {
            string boardPath = "../../assets/board.txt";
            
            Importer importer = new Importer(boardPath);
            Board board = new Board(importer.LoadBoard());
                
            int lines = importer.GetFileLines();
            Printer printer = new Printer(board, lines, lines);
            printer.Print();
        }
    }
}