using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_nbrown
{
    class Program
    {
        /*This program shows an example of
         * working with odd and even numbers
         * nicole brown 10/13/2016
         */
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetValue();
        }

           private void GetValue()
        {
           
            Console.WriteLine("Enter a number");
            double number = double.Parse(Console.ReadLine());
            
            if (number % 2 == 0)

            {
                Console.WriteLine("You have entered an Even number");
            }

            else
            {
                Console.WriteLine("You have entered an Odd number");
            }

           

        Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }//end main
    }//end class
}//end namespace
