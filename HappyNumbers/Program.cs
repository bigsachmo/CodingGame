using System;
using System.Collections.Generic;

namespace HappyNumbers
{
    public class Program
    {

        internal static string HAPPY = " :)";
        internal static string UNHAPPY = " :(";
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> numbers = new List<string>();
            
            for (int i = 0; i < N; i++)
            {
                string x = Console.ReadLine();
                numbers.Add(x);
            }

            foreach (var number in numbers)
            {
                if (ComputeNextNumbersFull(number).Equals("1"))
                {
                    Console.WriteLine(number + HAPPY);
                }
                else
                {
                    Console.WriteLine(number + UNHAPPY);
                }

            }

           
        }

        public static string ComputeNextNumbersFull(string seed)
        {
            int i = 0;
            List<string> seeds = new List<string>();
            while (true)
            {
                string newSeed = ComputeNextNumber(seed);
                
                Console.Error.WriteLine("New seed: " + newSeed);
                if (newSeed.Equals("1"))
                {
                    return newSeed;
                }

                if (seeds.Contains(newSeed))
                {
                    Console.Error.WriteLine("Loops: " + i);
                    return newSeed;
                }

                if(newSeed.Equals(seed))
                {
                    return newSeed;
                }
                
                seed = newSeed;
                if (i >= 1000)
                {
                    Console.Error.WriteLine("Loops: " + i);
                    return newSeed;
                }
                seeds.Add(newSeed);
                i++;
            }
        }

        public static string ComputeNextNumber(string s)
        {
            int newNumber = 0;
            for (int i = 0; i < s.Length ; i++)
            {
                int d = int.Parse(s[i].ToString());
                newNumber += d * d;
            }
            return newNumber.ToString();
        }
    }
}
