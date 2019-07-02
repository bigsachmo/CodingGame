using System;

namespace ShadowsKnight
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] inputs;
            // inputs = Console.ReadLine().Split(' ');
            // int W = int.Parse(inputs[0]); // width of the building.
            // int H = int.Parse(inputs[1]); // height of the building.
            // int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            // inputs = Console.ReadLine().Split(' ');
            // int X0 = int.Parse(inputs[0]);
            // int Y0 = int.Parse(inputs[1]);

            int W = 4;
            int H = 8;
            int N = 6;
            int X0 = 2;
            int Y0 = 3;

            W--;
            H--;
            int minX = 0;
            int minY = 0;

            int jump = 0;
            // game loop
            while (true)
            {
                Console.Error.WriteLine("Enter Movement: ");
                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
                int[] newBuilding = GetNewBuilding (bombDir, new int[]{ minX, minY, W,H}, new int[] {X0,Y0});
                
                minX = newBuilding[0];
                minY = newBuilding[1];
                W = newBuilding[2];
                H = newBuilding[3];
                
                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                int[] newPosition = MoveTo(newBuilding);
                X0 = newPosition[0];
                Y0 = newPosition[1];
                // the location of the next window Batman should jump to.
                Console.WriteLine(X0 + " " + Y0);
                jump++;
                if (jump >= N)
                {
                    Console.Error.WriteLine("Too many jumps");
                    break;

                }
            }
        }


        static int[] MoveTo(int[] rectangle)
        {
            int minX = rectangle[0];
            int minY = rectangle[1];
            int X = rectangle[2];
            int Y = rectangle[3];

            int newX = ((X + (2* minX)) / 2);
            int newY = ((Y + (2* minY)) / 2);
            
            if (newX < minX){ newX = minX;}
            if (newX > X) {newX = X;}
            if (newY < minY) { newY = minY;}
            if (newY > Y){ newY = Y;}
            
            Console.Error.WriteLine("New Position: X: " + newX + " Y: " + newY );
            return new int[]{ newX, newY};
 
        }
        static int[] GetNewBuilding(string bombDir, int[] rectangle , int[] position)
        {
            int minX = rectangle[0];
            int minY = rectangle[1];
            int X = rectangle[2];
            int Y = rectangle[3];
            switch (bombDir)
            {
                case "U":
                    minX = position[0];
                    X = position[0];
                    Y = position[1] - 1;
                  break;
                
                case "D":
                    minX = position[0];
                    X = position[0];
                    minY = position[1] +1;
                break;
                
                case "L":
                    Y = position[1];
                    minY = position[1];
                    X = position[0] - 1;
                    
                break;
                
                case "R":
                    Y = position[1];
                    minY = position[1];
                    minX = position[0] + 1;
                break;

                case "UR":
                    Y = position[1] -1;
                    minX = position[0] +1;
                break;

                case "DR":
                    minY = position[1] +1;
                    minX = position[0] + 1;
                break;

                case "UL":
                    Y = position[1] - 1;
                    X = position[0] - 1;
                break;

                case "DL":
                    X = position[0] - 1;
                    minY = position[1] + 1;
                break;

                default:
                break;
            }
            if (minX < rectangle[0])
            { minX = rectangle[0];}
            if (minY < rectangle[1])
            { minY = rectangle[1];}
            if (X > rectangle[2])
            {X = rectangle[2];}

            if (Y > rectangle[3])
            {Y = rectangle[3];}
            Console.Error.WriteLine(minX + " " + minY + " " + X + " " + Y );
            return new int[] { minX,minY,X,Y};
        }
    }
}
