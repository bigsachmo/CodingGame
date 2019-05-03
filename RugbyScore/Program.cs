using System;

namespace RugbyScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string answer = ComputeRugbyScore.ComputeScore(N);
            Console.WriteLine(answer);
        }
    }
}
