using System;

namespace FindPrimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber gpn = new PrimeNumber();

            bool askAgain = true;
            while (askAgain)
            {
                try
                {
                    gpn.GetPrime();
                }
               
                catch(FormatException e) 
                {
                    gpn.GetPrime();
                }

                askAgain = GoAgain();
            }
        }

        public static bool GoAgain()
        {
            Console.WriteLine("\nDo you want to find another prime number? Please enter Yes or No");
            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "yes" || userInput == "y")
            {

                return true;
            }
            else if (userInput == "no" || userInput == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Yes or No");
                return GoAgain();
            }
        }
    }
}