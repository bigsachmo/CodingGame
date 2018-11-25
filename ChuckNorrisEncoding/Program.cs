using System;

namespace ChuckNorrisEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string MESSAGE ="%";
            //char[] chars = str.ToCharArray();
            string binary = string.Empty;
            foreach (char c in MESSAGE)
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(new char[] {c});
                foreach (Byte b in bytes)
                {
                    string strb = Convert.ToString(b,2);
                    while (strb.Length < 7)
                    {
                        strb = "0" + strb;
                    }

                    binary += strb;
                }
                //Console.Error.WriteLine(c + " " + binary + " " + binary.Length);
            }

            string ChuckCodedStr = string.Empty;
            if (binary[0] == '0')
            {
                ChuckCodedStr = "00 0";
            }
            if (binary[0] == '1')
            {
                ChuckCodedStr = "0 0";
            }
            for (int i = 1; i < binary.Length; i++)
            {
                if (binary[i].Equals(binary[i - 1])){ ChuckCodedStr += "0";}
                else
                {
                    if (binary[i] == '0'){ChuckCodedStr += " 00 0";}
                    if (binary[i] == '1'){ChuckCodedStr += " 0 0";}
                }
            }
            Console.WriteLine(ChuckCodedStr);
       }
    }
}
