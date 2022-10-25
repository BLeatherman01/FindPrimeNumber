using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeTest
{
     class PrimeNumber
    {
        public int GetPrime(int num)
        {
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
                       
                        return number;
                    }
                }
                number++;
            }
        }
    }
}
