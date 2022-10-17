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
            //app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Reuben Sweetman";

            //text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text colour
            Console.ResetColor();

        }
    }
}
