using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_3_nbrown
{
    class Program
    {
        /*This program uses an array
         * using doubles
         * Nicole Brown 10/27/2016*/

        static void Main(string[] args)
        {

            double[] myArray = new double[10];

            for (int i = 0; i<10; i++)

            {
                Console.WriteLine("Enter a number, it can be a decimal");
                myArray[i] = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("the total of your numbers is {0}",myArray.Sum());
            Console.WriteLine("the average of your numbers is {0}",(double)myArray.Average());


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
