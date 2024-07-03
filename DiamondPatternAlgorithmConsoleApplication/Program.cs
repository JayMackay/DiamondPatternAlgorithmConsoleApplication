using DiamondPatternAlgorithmConsoleApplication.Services;
using System;

namespace DiamondPatternAlgorithmConsoleApplication
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a letter from the alphabet to generate a diamond pattern or input '?' to quit:");

            while(true)
            {
                string input = Console.ReadLine();

                // Handle multiple letter inputs only taking the first value or null
                char character = input.Length > 0 ? input[0] : '\0';

                // Check if user wants to quit
                if(character == '?')
                {
                    break; // Exit the while loop if '?' is entered
                }

                // Create an instance of DiamondPatternService
                var diamondPatternService = new DiamondPatternService();

                // Generate and print the diamond pattern
                try
                {
                    string pattern = diamondPatternService.BuildDiamond(character);
                    Console.WriteLine(pattern);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}