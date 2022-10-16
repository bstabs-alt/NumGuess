using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NumGuess
{
    internal class Program
    {
        static int num = 0;
        static void Main(string[] args)
        {
            if (args[1] != null) 
            {
                num = Int16.Parse(args[1]);
            }
            Console.WriteLine(num);
            Environment.Exit(1);
        }
    }
}
