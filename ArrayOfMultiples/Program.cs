/******************************************************************************
Medium level of difficulty

Create a function that takes two numbers as arguments (num, length) and returns an array of 
multiples of num until the array length reaches length.

Examples
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]

Note: Notice that num is also included in the returned array.
*******************************************************************************/
using System;

namespace ArrayOfMultiples
{
    class Program
    {
        static void Main()
        {
            int multiplesOfNum = 7;
            int arrayLength = 5;
            int[] arrayList = new int[arrayLength];

            arrayList = ArrayOfMultiples(ref multiplesOfNum, ref arrayLength);

            Console.Write("[");
            foreach (var i in arrayList)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("]");
        }

        public static int[] ArrayOfMultiples(ref int multiplesOfNum, ref int arrayLength)
        {
            int[] arrayList = new int[arrayLength];
            
            for (int i=0; i < arrayLength; i++)
            {
                arrayList[i] = ((i+1) * multiplesOfNum);
            }

            return arrayList;
        }
    }
}
