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
            if (args.Length > 1)
            {
                num = Int16.Parse(args[1]);
            }
            Console.WriteLine($"Num: {num}");
        }
    }
}
