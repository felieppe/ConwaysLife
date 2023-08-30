using System.Text;
using Library;

namespace ConwaysLife;
public class Printer
{
    private bool[,] B;
    private int Width;
    private int Height;

    public Printer(bool[,] b, int width, int height) {
        this.B = b;
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
                    if(B[x,y])
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
            
            SetBoard(new GameLogic(B).Game());
            Thread.Sleep(300);
        }
    }

    public void SetBoard(bool[,] b) {
        this.B = b;
    }
    public void SetWidth(int width) {
        this.Width = width;
    }
    public void SetHeight(int height) {
        this.Height = height;
    }

    public bool[,] GetBoard() {
        return this.B;
    }
    public int GetWidth() {
        return this.Width;
    }
    public int GetHeight() {
        return this.Height;
    }
}
