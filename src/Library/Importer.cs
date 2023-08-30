namespace ConwaysLife;

public class Importer {
    private string Url;
    private int FileLines = 0;

    public Importer(string url) {
        this.Url = url;
    }

    public bool[,] LoadBoard() {
        string content = File.ReadAllText(Url);
        string[] contentLines = content.Split('\n');

        this.FileLines = contentLines.Length;

        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int y = 0; y < contentLines.Length;y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if(contentLines[y][x] == '1')
                {
                    board[x,y] = true;
                }
            }
        }

        return board;
    }

    public void SetUrl(string url) {
        this.Url = url;
    }

    public string GetUrl() {
        return this.Url;
    }
    public int GetFileLines() {
        return this.FileLines;
    }
}