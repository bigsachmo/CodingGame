using System;

namespace AsciiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string E = @"
### 
#   
##  
#   
### 
            ";

            string B = @"
##  
# # 
##  
# # 
##        
            ";
            Console.Write (E + " " +B);
        }
    }
}
