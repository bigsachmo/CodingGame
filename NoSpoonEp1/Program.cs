using System;
using System.Text;

namespace NoSpoonEp1
{
    public class Program
    {
        public static char[,] Grid ;
        public static int X;
        public static int Y;
        public static StringBuilder OutPut = new StringBuilder();
        static void Main(string[] args)
        {
            X = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            Y = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            Grid = new char[X,Y];
            for (int i = 0; i < Y; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 or .
                FillGridWithLine(line, i);
            }
            WalkTheGrid();
            Console.Write(OutPut.ToString());
        }

        public static void WalkTheGrid()
        {
            string displayLine = string.Empty;
            
            for (int xx = 0; xx < X; xx++)
            {
                for (int yy = 0; yy < Y; yy++)
                {
                    if (Grid[xx, yy].Equals('0')) //It 's a node
                    {
                        string rightPoint = string.Empty;
                        string downPoint = string.Empty;
                        if (xx == X - 1 || Grid[xx + 1 , yy].Equals('.')) { rightPoint = " -1 -1"; }
                        else { rightPoint = string.Format(" {0} {1}", xx + 1, yy); };

                        if (yy == Y - 1 || Grid[xx, yy + 1 ].Equals('.')) { downPoint = " -1 -1"; }
                        else { downPoint = string.Format(" {0} {1}", xx, yy + 1); };

                        OutPut.AppendLine(string.Format("{0} {1}{2}{3}", xx, yy, rightPoint, downPoint));
                    }
                    
                }

            }
        }

        public static void FillGridWithLine(string line, int height)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Grid[i, height] = line[i];
            }
        }
    }
}
