using System;

namespace LogicalProgram
{
    public class Porogram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWelcome to Logical Programs problems");

            bool check = true;

            while (check)
            {
                Console.WriteLine("Select Options : \n" +
                    "1)Program for Fibonacci Series\n" +
                    "2)Program for Perfect Number\n" +
                    "3)Program for Prime Number\n" +
                    "4)Program fir Reverse numbers\n" +
                    "5)Program for Stop Watch\n");

                int option = Convert.ToInt32(Console.ReadLine());
            start:
                switch (option)
                {
                    case 1:
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        FibonacciSeries.fibonacciSeries();

                        Console.WriteLine("\tFibonacci Series Program :");
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 2:
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("\tPerfect Number Program");
                        PerfectNumbers.perfectNumbers();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 3:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("\tPrime Number Program");
                        PrimeNumbers.primeNumbers();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 4:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("\tReverse Number Program");
                        ReverseNumbers.reverseNumber();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 5:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("\tStop Watch Program");
                        StopWatch.stopWatch();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    default:
                        Console.WriteLine("Please Choose Proper selection\n\n\n");
                        break;
                        goto start;

                }


            }
        }
    }
}