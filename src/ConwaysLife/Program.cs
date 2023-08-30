namespace ConwaysLife {
    class Program {
        static void Main(string[] args) {
            /*
            
                Needed classes:
                    - Importer
                        - LoadBoard()
                    - Board
                    - GameLogic
                        - Game()
                    - Printer
                        - Print()

                Cosas para hacer:
                    - Agregar validacion de datos en los SETs.
            
            */

            Importer imp = new Importer("");
            Printer printer = new Printer(imp.LoadBoard(), 10, 10);
        }
    }
}