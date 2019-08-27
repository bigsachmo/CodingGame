using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace RugbyScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string answer = ComputeRugbyScore.ComputeScore(N);
            
        }
    }

    public class ComputeRugbyScore
    {
        public static string ComputeScore(int score)
        {
            StringBuilder results = new StringBuilder();
            int tries = 0;
            int pens = 0;
            while ( tries * 5 <= score)
            {
                //test each solution with that number of tries ==> first only with penalties or drops
                for (int icons = 0; icons <= tries; icons++)
                {
                    int newScore = currentScore(tries, icons, pens);
                    while (newScore <= score)
                    {
                        if (newScore == score)
                        {
                            Console.WriteLine(string.Format("{0} {1} {2}", tries, icons, pens));
                            results.AppendLine(string.Format("{0} {1} {2}", tries, icons, pens));
                        }
                        pens++;
                        newScore = currentScore(tries, icons, pens);
                    }
                    pens = 0;
                }
                tries++;
            }
            return results.ToString();
        }

        private static int currentScore(int simpleTry, int conversion, int pen)
        {
            return simpleTry * 5 + conversion * 2 + pen * 3;
        }
    }
}
