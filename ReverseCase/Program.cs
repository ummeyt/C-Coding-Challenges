/*************************************************************************
 * Medium Level of Difficulty
 * 
 * Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
 * Examples
 * ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
 * ReverseCase("MANY THANKS") ➞ "many thanks"
 * ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
**************************************************************************/
using System;

namespace ReverseCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] line = inputString.ToCharArray();
            line = reverseCase(ref line);
            Console.WriteLine(line);
        }

        public static char[] reverseCase(ref char[] line)
        {
            char[] currLetter = line;

            for (int i= 0; i < currLetter.Length; i++)
            {
                if (Char.IsUpper(currLetter[i]))
                {
                    currLetter[i] = Char.ToLower(currLetter[i]);
                }
                else //else it's lower
                {
                    currLetter[i] = Char.ToUpper(currLetter[i]);
                }              
            }

            return line;
        }
    }

}
