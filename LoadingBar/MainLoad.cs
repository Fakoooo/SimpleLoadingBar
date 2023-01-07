using System;
using System.Threading;

namespace LoadingBar
{
    internal static class Program
    {
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  
            _____  _____ _____ _____ 
     /\    / ____|/ ____|_   _|_   _|
    /  \  | (___ | |      | |   | |  
   / /\ \  \___ \| |      | |   | |  
  / ____ \ ____) | |____ _| |_ _| |_ 
 /_/    \_\_____/ \_____|_____|_____|  ");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("Loading...");
            Console.Write("[");

            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("=");
                Thread.Sleep(50);
            }

            Console.WriteLine("]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done!");
            Console.ResetColor();
        }
    }
}
