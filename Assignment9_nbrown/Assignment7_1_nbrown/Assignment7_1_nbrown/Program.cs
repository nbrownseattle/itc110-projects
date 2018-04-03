using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_nbrown
{
    class Program
    { //This program is an example of a guessing game
      //Creates a method to select a random number between 1 and 500
      //Creates a method for user guesses
      //Loops through guesses until correct guess is made (shows score) or exits after 10 incorrect guesses
      //Nicole Brown 11/21/2016



       static void Main(string[] args)

        {//main
            Program p = new Program(); //instantiate the class Program
            p.GuessNumber();
        }//end main

        private int GetNumber()
        {
            
            Random gnum = new Random();
            int num = gnum.Next(0, 501);
            return num;
        }//cose get number method


        private void GuessNumber()
        {
            Console.WriteLine("Welcome to Guess the Number");
            Console.WriteLine("The number is between 1 and 500. You have ten guesses.");
            int numberToGuess = GetNumber();//calls get number

           
            for (int i = 0; i < 11; i++)
            {

                Console.WriteLine("Please enter your guess: ");
                int userGuess=int.Parse(Console.ReadLine());

                if (userGuess == numberToGuess)
                {
                    Console.WriteLine("Your guess is correct! Congratulations.");
                    Console.WriteLine("Score: {0}", 10 - i);
                    break;

                }//end if

                else if (userGuess > numberToGuess)
                {

                    Console.WriteLine("Your guess is too high! Please try again.");
                }//end else if

                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Your guess is too low! Please try again.");

                }//end else if


                
            }//end for loop

            Console.WriteLine("Game over! Press any key to exit.");
            Console.ReadKey();
           
        }//end guess number
    }//end class
}//end namespace
