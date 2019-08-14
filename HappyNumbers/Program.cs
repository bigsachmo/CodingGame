using System;
using System.Collections.Generic;

namespace HappyNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> numbers = new HashSet<string>();
            string Happy = " :)";
            string unHappy = " :(";
            for (int i = 0; i < N; i++)
            {
                string x = Console.ReadLine();
                numbers.Add(x);
                
            }

            foreach (string s in numbers)
            {
                string hn = ComputeNextNumber(s);
                
            }
            
        }

        public static string ComputeNextNumbersFull(string v)
        {
            throw new NotImplementedException();
        }

        public static string ComputeNextNumber(string s)
        {
            int newNumber = 0;
            for (int i = 0; i < s.Length ; i++)
            {
                Console.Error.WriteLine(s[i]);
                int d = int.Parse(s[i].ToString());
                newNumber += d * d;
            }
            Console.Error.WriteLine("New Number: " + newNumber);
            return newNumber.ToString();
        }
    }
}
