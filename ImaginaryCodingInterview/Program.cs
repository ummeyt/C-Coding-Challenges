/*************************************************************************
 * Hard level of difficulty
 * 
 * Create a function to check if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.
 * 
 * The criteria for a candidate to be qualified in the coding interview is:
 * 
 * The candidate should have complete all the questions.
 * The maximum time given to complete the interview is 120 minutes.
 * The maximum time given for very easy questions is 5 minutes each.
 * The maximum time given for easy questions is 10 minutes each.
 * The maximum time given for medium questions is 15 minutes each.
 * The maximum time given for hard questions is 20 minutes each.
 * If all the above conditions are satisfied, return "qualified", else return "disqualified".
 * 
 * You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.
 * 
 * Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].
 * 
 * The maximum time to complete the interview includes a buffer time of 20 minutes.
 * 
 * Examples
 * Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20], 120 } ➞ "qualified"
 * Interview(new int [] { 2, 3, 8, 6, 5, 12, 10, 18], 64 } ➞  "qualified"
 * 
 * Interview(new int [] { 5, 5, 10, 10, 25, 15, 20, 20], 120 } ➞ "disqualified"
 * // Exceeded the time limit for a medium question.
 * 
 * Interview(new int [] { 5, 5, 10, 10, 15, 15, 20], 120 } ➞ "disqualified"
 * // Did not complete all the questions.
 * 
 * Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20], 130 } ➞ "disqualified"
 * // Solved all the questions in their respected time limits but exceeded the total time limit of the interview.
 * 
 * Notes
 * Try to solve the problem using only array methods.
**************************************************************************/
using System;
using System.Linq;

namespace ImaginaryCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ 5, 5, 10, 10, 15, 15, 20, 20, 120 }; //➞ "qualified"
            //{ 2, 3, 8, 6, 5, 12, 10, 18, 64 }; //➞ "qualified"
            //{ 5, 5, 10, 10, 25, 15, 20, 20, 120 }; //➞ "disqualified"
            //{ 5, 5, 10, 10, 15, 15, 20, 20, 130 }; //➞ "disqualified"
            //{ 5, 5, 10, 10, 15, 15, 20, 120 }; //➞ "disqualified"
            Console.WriteLine("Array: ");
            string line = Console.ReadLine();
            //splits string by ',' & converts the split string to int[]
            int[] input = line.Split(',').Select(x => int.Parse(x)).ToArray();
            //Array.ForEach(input, Console.WriteLine);    //prints what's in array
            string result = Interview(ref input);
            Console.WriteLine(result);
        }

        static public string Interview(ref int[] arrayList)
        {
            string result = "disqualified";

            if (arrayList.Length == 9)
            {
                if ((arrayList[0] <= 5) && (arrayList[1] <= 5))
                {
                    result = "qualified";
                    if ((arrayList[2] <= 10) && (arrayList[3] <= 10))
                    {
                        result = "qualified";
                        if ((arrayList[4] <= 15) && (arrayList[5] <= 15))
                        {
                            result = "qualified";
                            if ((arrayList[6] <= 20) && (arrayList[7] <= 20))
                            {
                                if (arrayList[8] <= 120)  //arrayList.Sum()
                                {
                                    result = "qualified";
                                }
                                else
                                    result = "disqualified";
                            }
                        }
                        else
                            result = "disqualified";
                    }
                    else
                        result = "disqualified";
                }
                else
                {
                    result = "disqualified";
                }
            }
            else
                Console.WriteLine("FORMAT ERROR: There should only be 9 numbers in the array.");
            
            return result;
        }
    }
}
