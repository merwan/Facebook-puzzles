using System;
using System.IO;

namespace Facebook.Puzzles
{
    public class HoppityHop
    {
        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must provide a file name");
                return;
            }
            var filename = args[0];

            var content = File.ReadAllLines(filename);

            if (content.Length == 0)
            {
                Console.WriteLine("The input file must contain an integer");
                return;
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
        }
    }
}