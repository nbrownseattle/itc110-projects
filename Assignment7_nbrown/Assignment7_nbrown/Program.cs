using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_nbrown
{
    class Program
    {// This program....
        static void Main(string[] args)
        {
            const int MAX_NUMBER = 500;                                               
           int NumberToGuess = random.Next(MAX_NUMBER) + 1;
            int userGuess = 0;
            int guesses = 0;


            Console.WriteLine("Welcome to Guess the Number");
            Console.WriteLine("The number is between 1 and {0}.", MAX_NUMBER);

            for (int i = 0; i < 11;i++)
            {
               

                Console.WriteLine("Please enter your guess: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > NumberToGuess)

                {

                    Console.WriteLine("{0} is too high! Please try again, userGuess");
                }

                else if (userGuess < NumberToGuess)
                {
                    Console.WriteLine("{0} is too low! Please try again, userGuess");

                }

                else
                {
                    Console.WriteLine("{0} is correct! Congratulations.", userGuess);
                    Console.WriteLine("Score: {0}", 10 - guesses);
                    
                }
                Console.WriteLine("Game over! Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
