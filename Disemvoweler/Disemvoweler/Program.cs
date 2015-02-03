/*
 *   Programmer :   Patrick Yee
 *   Date :         February 2, 2015
 *   Description:   Take in a string of a sentence and remove the spaces, vowels, and constansts.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            // keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Takes in a string puts the vowels into a string and the constants in another.
        /// </summary>
        /// <param name="input">A sentence string</param>
        /// <returns>no vowels in the input string</returns>
        public static string Disemvoweler(string input)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            string vowelsRemoved = null;
            string disemvoweledRemoved = null;
            bool isVowel = false;

            // looks at each element of input.
            // we are going to ignore punctuation and spaces.
            for (int i = 0; i < input.Length; i++)
            {
                // we want to look for only the letters.
                if (Char.IsLetter(input[i]))
                {
                    // TODO: look at the char at the index of input 
                    // if the char is a vowel, place in vowelsRemoved.
                    for (int vowelInd = 0; vowelInd < vowels.Length; vowelInd++)
                    {
                        if (input[i].ToString().ToLower() == vowels[vowelInd].ToString())
                        {
                            vowelsRemoved += input[i];
                            isVowel = true;             // a vowel is found
                            break;
                        }
                    }
                    // if the vowel is found, I want to skip the character
                    if (!isVowel)
                    {
                        disemvoweledRemoved += input[i];
                    }
                    // reset for the next character
                    isVowel = false;
                }
            }

           // Write out the various string results
           Console.WriteLine("Original: " + input);
           Console.WriteLine("Disemvoweled: " + disemvoweledRemoved );
           Console.WriteLine("Vowels Removed: " + vowelsRemoved); 
           // Return the Disemvoweled string as well for testing
           return disemvoweledRemoved;
        }
    }
}
