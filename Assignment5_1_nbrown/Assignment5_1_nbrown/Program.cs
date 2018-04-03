using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1_nbrown
{
    class Program
    {
        /*This program is an example
         * of an array and loops using
         * 50 random numbers
         * nicole brown 10/27/2016*/
        static void Main(string[] args)

        {
            int[] myArray = new int[50];
            Random rand = new Random();
            for (int i = 1; i < 50; i++)

            {
                myArray[i] = rand.Next(1, 300);

                Console.WriteLine(myArray[i]);

            }
            int even = 0;
            foreach (int i in myArray)

            {
                if (i % 2 == 0)
                    even++;
            }

            Console.WriteLine("There are {0} even numbers in this array", even);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }//end main
    }//end class
}//end namespace
