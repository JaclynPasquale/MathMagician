using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Mathgician");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok, I'm going to do some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else if ("Fibonacci" == desiredMaths)
            {
                PrintFibonacciSequence();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimes();
            }
            else
            {
                Console.WriteLine("Well, actually... I lied...");
            }
            Console.WriteLine("Press Any Key to Exit...");
            Console.ReadKey();

        }

        private static void PrintPrimes()
        {
            int number;
            int i;
            bool isPrime;

            for (number = 2; number < 1000000000; number++)
            {
                isPrime = true;
                for (i = 2; i <= number / 2; i++)
                {
                    if ((number % i) == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                    Console.WriteLine(number);
                    System.Threading.Thread.Sleep(10);
            }
        }

        private static void PrintFibonacciSequence()
        {
            // 1, 3, 5, 8, 13, 
            int previous = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(10);
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            int nextInteger = 0;

            while (true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
    }
}
