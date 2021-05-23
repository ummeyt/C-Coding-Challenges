/**********************************************************************
 * Practice Code Problem
 * 
 * Write a program that prints the numbers from 1 to 100. 
 * But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
 * For numbers which are multiples of both three and five print “FizzBuzz”."
***********************************************************************/
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzBuzz(15);
        }

        /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

public static void fizzBuzz(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("FizzBuzz");
                else if ((i % 3 == 0) && (i % 5 != 0))
                    Console.WriteLine("Fizz");
                else if ((i % 5 == 0) && (i % 3 != 0))
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

    }
}

