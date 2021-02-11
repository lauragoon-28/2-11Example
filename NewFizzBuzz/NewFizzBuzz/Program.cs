using System;

namespace NewFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);//Generate a random number between 1 and 100
            int divisibleBy3Remainder = randomNumber % 3;
            bool isDivisibleBy3 = randomNumber % 3 == 0;
            randomNumber = 20;

            if (randomNumber % 3 == 0
              && randomNumber % 5 == 0)// === true)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (randomNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNumber % 3 ==0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randomNumber);
            }
            
        }
    }
}
