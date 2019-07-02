using System;
using System.Collections.Generic;
using System.Text;

namespace RugbyScore
{
    public class ComputeRugbyScore
    {
        public static string ComputeScore(int score)
        {
            List<Tuple<int,int,int>> possibleCores = new List<Tuple<int, int, int>>();
            string result = "";
            int FULL_TRY = 7;
            int TRY = 5;
            int PEN = 3;

            int NbrFullTry = 0;
            int NbrConversion = 0;
            int NbrPen = 0;

            while(true)
            {
                NbrPen ++;
                
                if  (currentScore(NbrFullTry, NbrConversion, NbrPen) == score)
                {
                    possibleCores.Add(new  Tuple<int, int, int> (NbrFullTry, NbrConversion, NbrPen));
                }


                if (currentScore(NbrFullTry, NbrConversion, NbrPen) > score)
                {
                    break;
                }
            }



            return result;
        }

        private static int currentScore(int simpleTry, int conversion, int pen)
        {
            return simpleTry * 5 + conversion * 2 + pen *3; 
        }
    }
}
