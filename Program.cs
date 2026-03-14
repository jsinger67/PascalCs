using System;
using System.IO;
using PascalCs;

namespace PascalCs
{
    class Program
    {
        // Parses a file provided on the command line and prints the semantic result.
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a file name as first parameter!");
                return;
            }

            string fileName = args[0];
            // Read the full input so the parser can process it in one pass.
            string input = File.ReadAllText(fileName);
            // User actions collect the typed parse result during semantic callbacks.
            PascalCsActions actions = new PascalCsUserActions();

            try
            {
                PascalCsParser.Parse(input, fileName, actions);
                Console.WriteLine("Success!");
                Console.WriteLine(actions.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
