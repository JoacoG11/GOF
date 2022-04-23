using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        private string Url;
        public string Content;
        public string[] ContentLines;
        public bool[,] Board; 
        
        public Tablero ()
        {
            string url = "../../assets/board.txt";
            this.Url = url;

            string content = File.ReadAllText(url);
            this.Content = content;

            string[] contentLines = content.Split("\n");
            this.ContentLines = contentLines;

            bool[,] board = new bool [content.Length, contentLines[0].Length];
            this.Board = board;
        }
        public void ArmarTablero()
        {  
            for (int y=0; y < ContentLines.Length; y++)
            {
                for (int x=0; x < ContentLines[y].Length; x++)
                {
                    if (ContentLines[y][x] == '1')
                    {
                        Board[x,y] = true;
                    }
                }
            }   
        }
    }
}
