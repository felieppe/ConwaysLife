using System.Text;
using Library;

namespace ConwaysLife;
public class Printer
{
    private Board Board;
    private int Width;
    private int Height;

    public Printer(Board board, int width, int height) {
        this.Board = board;
        this.Width = width;
        this.Height = height;
    }

    public void Print() {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if(Board.GetBoard()[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            
            Board.SetBoard(new GameLogic(Board.GetBoard()).Game());
            Thread.Sleep(300);
        }
    }

    public void SetWidth(int width) {
        this.Width = width;
    }
    public void SetHeight(int height) {
        this.Height = height;
    }

    public int GetWidth() {
        return this.Width;
    }
    public int GetHeight() {
        return this.Height;
    }
}
