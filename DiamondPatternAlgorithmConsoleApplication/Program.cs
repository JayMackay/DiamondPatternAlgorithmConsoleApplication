using DiamondPatternAlgorithmConsoleApplication.Services;
using System;

namespace DiamondPatternAlgorithmConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a letter from the alphabet to generate a diamond pattern:");

            while(true)
            {
                string input = Console.ReadLine();

                // Create an instance of DiamondPatternService
                var diamondPatternService = new DiamondPatternService();

                // Generate and print the diamond pattern
                try
                {
                    string pattern = diamondPatternService.BuildDiamond(input[0]);
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