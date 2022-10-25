using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeTest
{
     class PrimeNumber
    {
        public int GetPrime()
        {
            Console.WriteLine("Please enter a positive integer");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            //negative check
            if (num <= 0)
            {
                GetPrime();
            }
            int primeCount = 0;
            int number = 2; 
            while (true)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeCount++;
                    if (primeCount == num)
                    {
                        Console.WriteLine($"The number {num} Prime Number is {number}");
                        return number;
                    }
                }
                number++;
            }
            
        }
    }
}
