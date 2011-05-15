using System;
using System.IO;

namespace Facebook.HoppityHop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must provide a file name");
                Exit();
                return;
            }
            var filename = args[0];

            var content = File.ReadAllLines(filename);

            if (content.Length == 0)
            {
                Console.WriteLine("The input file must contain an integer");
            }

            var max = Convert.ToInt32(content[0]);

            for (var i = 1; i <= max; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Hop");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Hoppity");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Hophop");
                }
            }

            Exit();
        }

        private static void Exit()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}