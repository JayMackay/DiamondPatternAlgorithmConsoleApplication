using DiamondPatternAlgorithmConsoleApplication.Interfaces;
using System;
using System.Linq;

namespace DiamondPatternAlgorithmConsoleApplication.Services
{
    public class DiamondPatternService : IDiamondPatternService
    {
        public string BuildDiamond(char characterInput)
        {
            // Convert input character to uppercase
            characterInput = char.ToUpper(characterInput);

            // Validate input character
            if(!char.IsLetter(characterInput))
            {
                throw new ArgumentException("Please only input a single valid character from the alphabet.");
            }

            // Radius is the distance from the center point of the 2D array of the diamond pattern
            int radius = characterInput - 'A';

            // Width to calculate the maxium size of the diamond pattern
            int width = radius * 2 + 1;


            char[][] diamond = new char[width][];

            for(int i = 0; i <= radius; i++)
            {
                diamond[i] = new string(' ', width).ToCharArray();
                diamond[i][radius - i] = (char)('A' + i);
                diamond[i][radius + i] = (char)('A' + i);
            }

            for(int i = radius - 1; i >= 0; i--)
            {
                diamond[width - i - 1] = diamond[i];
            }

            return string.Join("\n", diamond.Select(row => new string(row))) + "\n";
        }
    }
}