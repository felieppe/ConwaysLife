using System.Diagnostics.CodeAnalysis;

namespace Library
{
    public class GameLogic
    {
        private bool[,] GameBoard {get; set;}
        public GameLogic(bool[,] gb) {
            this.GameBoard = gb;
        }

        public void SetGameBoard(bool[,] gb) {
            this.GameBoard = gb;
        }

        public bool[,] GetGameBoard() {
            return GameBoard;
        }

        public bool[,] Game() {
            int boardWidth = GameBoard.GetLength(0);
            int boardHeight = GameBoard.GetLength(1);

            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i <= x + 1; i++)
                    {
                        for (int j = y-1; j <= y + 1; j++)
                        {
                            if(i>=0 && i < boardWidth && j >= 0 && j < boardHeight && GameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(GameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (GameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false;
                    }
                    else if (GameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false;
                    }
                    else if (!GameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = GameBoard[x,y];
                    }
                }
            }

            return cloneboard;
        }
    }
}