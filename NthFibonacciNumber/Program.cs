/***********************************************************************************
 * Hard level of difficulty
 * 
 * Create a function to return the Nth number in the Fibonacci sequence as a string.
 * 
 * Examples
 * Fibonacci(10) ➞ "55"
 * Fibonacci(20) ➞ "6765"
 * Fibonacci(30) ➞ "832040"
 * Fibonacci(40) ➞ "102334155"
 * Fibonacci(50) ➞ "12586269025"
 * Fibonacci(60) ➞ "1548008755920"
 * 
 * Notes
 * Your function is expected to calculate numbers greater than UInt64.MaxValue where 
 * n can be as large as but not greater than 200.
***********************************************************************************/
using System;
using System.Numerics;

namespace NthFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //int n = 20;
            //int n = 30;
            //int n = 40;
            //int n = 50;
            int n = 60; 
            Console.Write("{0} ", Fibonacci(n));
        }

        static public BigInteger Fibonacci(int n)
        {
            //Takes too long
            /*
             if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
            */

            BigInteger a = 0, b = 1, c = 0;

            if (n == 0) 
                return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

    }
}
