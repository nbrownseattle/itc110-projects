using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3_nbrown
{
    class Program
    {
        /* This probram shows an example
         * using decimals to assign a letter grades
         */
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetValue();
        }
        private void GetValue()
        {
            Console.WriteLine("Enter a grade point between 0 and 4");
            double number = double.Parse(Console.ReadLine());

        

        if (number < 0 || number > 4)

            {
                Console.WriteLine("Invalid entry please enter a valid number");
            }

        else if (number < 1)
            {
                Console.WriteLine("You got an F in this class");
            }
        else if (number < 2 && number > .9)

            {
                Console.WriteLine("You got a D in this class");
            }
        else if (number < 3 && number > 1.9)

            {
                Console.WriteLine("You got a C in this class");
            }
        else if (number < 3.5 && number > 2.9)
            {
                Console.WriteLine("You got a B in this class");
            }
        else
            {
                Console.WriteLine("congratulations! You got a A in this class");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }//end main
    }//end class
}//end namespace
