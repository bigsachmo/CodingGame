using System;

namespace AsciiGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // int L = int.Parse(Console.ReadLine());
            // int H = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();
            // for (int i = 0; i < H; i++)
            // {
            //     string ROW = Console.ReadLine();
            // }
            string[] alphabet = new string[]{"A","B","C","D", "E","F","G","H","I","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            Console.WriteLine(Array.IndexOf(alphabet,"1"));

            for (int j =0; j < T.Length; j++)
            {
                Console.WriteLine(T[j]);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("answer");
        }
    }
}
