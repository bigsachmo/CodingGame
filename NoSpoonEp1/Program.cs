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

                        //Have to find next right point
                        int nextRight = FindNextRightPoint(xx,yy);
                        if (nextRight == -1)
                        {
                            rightPoint = " -1 -1";
                        }
                        else
                        { rightPoint = string.Format(" {0} {1}", nextRight, yy); }

                        int nextDown = FindNextDownPoint(xx, yy);
                        if (nextDown == -1)
                        {
                            downPoint = " -1 -1";
                        }
                        else
                        { downPoint = string.Format(" {0} {1}", xx, nextDown); }

                        //Have to find next down point
                       
                        OutPut.AppendLine(string.Format("{0} {1}{2}{3}", xx, yy, rightPoint, downPoint));
                    }
                    
                }

            }
        }

        private static int FindNextDownPoint(int currentX, int currentY)
        {
            for (int i = currentY + 1; i < Y; i++)
            {
                if (Grid[currentX, i].Equals('0')) { return i; }
                if (i == Y - 1) { return -1; }

            }
            return -1;
        }

        private static int FindNextRightPoint(int currentX, int currentY)
        {
            for (int i = currentX + 1; i < X; i++)
            {
                if (Grid[i, currentY].Equals('0')) { return i; }
                if (i == X - 1) { return -1; }
            }
            return -1; 
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
