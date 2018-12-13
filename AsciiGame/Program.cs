using System;
using System.Text;

namespace AsciiGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // int L = int.Parse(Console.ReadLine());
            // int H = int.Parse(Console.ReadLine());
            //string T = Console.ReadLine();
            // for (int i = 0; i < H; i++)
            // {
            //     string ROW = Console.ReadLine();
            // }

            int L = 4;
            int H = 5;
            string T = "M@nHattan";
            string[] rows = new string[H];
            rows[0] = " #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### ";
            rows[1] = "# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # ";
            rows[2] = "### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## ";
            rows[3] = "# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       ";
            rows[4] = "# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  ";

            string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int[] letterIndexes = new int[T.Length];

            for (int i = 0; i < T.Length; i++)
            {
                int letterIndex = Array.IndexOf(alphabet, T[i].ToString().ToUpper());
                if (letterIndex == -1)
                {
                    letterIndex = 26;
                }
                letterIndexes[i] = letterIndex;
            }


            StringBuilder word = new StringBuilder();
            for (int line = 0; line < H; line++)
            {
                StringBuilder lineLetter = new StringBuilder();
                foreach (int letterIndex in letterIndexes)
                {
                    string letter = rows[line].Substring(letterIndex * L, L);
                    lineLetter.Append(letter);
                }
                // Console.WriteLine(letter);
                word.AppendLine(lineLetter.ToString());
            }
            // Console.WriteLine();
            Console.Write(word.ToString());

        }
    }
}
