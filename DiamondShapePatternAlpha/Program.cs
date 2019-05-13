using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShapePatternAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letter = new char[26]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };

            int letter_number = 0;

            // array of strings
            string[] diamond = new string[52];

            // get the letter
            Console.WriteLine("Please enter a letter between A and Z ");
            char enter_letter = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            // search for the letter in the array
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == enter_letter)
                {
                    letter_number = i;
                    break;
                }
            }

            // construct the diamond
            for (int i = 0; i < letter_number; i++)
            {
                // add initial spaces
                for (int j = 0; j < letter_number - i; j++)
                {
                    diamond[i] += " ";
                }

                // add letter first time
                diamond[i] += letter[i];

                // add space between letters
                if (letter[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamond[i] += " ";
                    }

                    // add letter second time
                    diamond[i] += letter[i];
                }

                // draw the first part of the diamond
                Console.WriteLine(diamond[i]);
            }

            for (int i = letter_number - 1; i >= 0; i--)
            {
                // draw the second part of the diamond
                // writing the diamon array in reverse order
                Console.WriteLine(diamond[i]);
               
            }
            Console.ReadKey();


        }
        
    }
    
}

