using ConwaysLife;

namespace Library
{
    public class Screen
    {
        private string BoardPath = "";
        private List<string> MenuOptions = new List<string> {
            "PLAY", "EXIT"
        };

        public Screen() {}

        public void ShowHeader() {
            Console.Clear();
            
            string header = @" 
   ___ ___  _  ___      _____   _____   _    ___ ___ ___ 
  / __/ _ \| \| \ \    / /_\ \ / / __| | |  |_ _| __| __|
 | (_| (_) | .` |\ \/\/ / _ \ V /\__ \ | |__ | || _|| _| 
  \___\___/|_|\_| \_/\_/_/ \_\_| |___/ |____|___|_| |___|                           
";

            Console.Write(header);
        }
        private bool ShowBoardPrompt() {
            ShowHeader();

            Console.WriteLine("\nBoard file path:");
            string? path = Console.ReadLine();
            if (!string.IsNullOrEmpty(path)) {
                if (File.Exists(path)) {
                    this.BoardPath = path;
                    return true;
                } else {
                    ShowHeader();

                    Console.WriteLine("\nInvalid board file path!");
                    Console.WriteLine("Press ENTER to return to the main menu...");
                    Console.ReadLine();

                    return false;
                }
            } else { return false; }
        }

        public void ShowHomeMenu() {
            ShowHeader();

            Console.WriteLine("\nMAIN MENU\n");

            // Display options
            int x = 1;
            foreach (string opt in this.MenuOptions) {
                Console.WriteLine("[" + x + "] - " + opt);
                x++;
            }

            Console.WriteLine("\nSelect an option:");

            int option = 0;
            while (true) {
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt >= 1 && opt <= 2) {
                    option = opt;
                }
                break;
            }

            switch (option) {
                case 1:
                    Play();
                    break;
                case 2:
                    Console.Clear();
                    System.Environment.Exit(1);
                    break;
            }
        }

        public void Play() {
            Console.Clear();

            if (ShowBoardPrompt()) {
                Console.Clear();

                Importer importer = new Importer(BoardPath);
                Board board = new Board(importer.LoadBoard());
                
                int lines = importer.GetFileLines();
                Printer printer = new Printer(board, lines, lines);
                printer.Print();
            } else { ShowHomeMenu(); }
        }
    }
}