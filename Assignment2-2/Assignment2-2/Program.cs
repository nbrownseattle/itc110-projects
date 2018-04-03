using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Program
    {
        /// <summary>
        /// This program shows examples of integers
        /// using quotient and remainder
        /// nicole brown 10/6/2016
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Main(string[] args)
        {


            Console.WriteLine("Enter the first integer");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer");
            int number2 = int.Parse(Console.ReadLine());

            int answer = number / number2;

            Console.WriteLine("The quotient of {0} / {1} = {2}", number, number2, answer);

            int answer2 = number % number2;

            Console.WriteLine("The remainder of {0} / {1} = {2}", number, number2, answer2);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }//end main
    }//end program
}