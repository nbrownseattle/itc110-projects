using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1_nbrown
{
    class Program
    {
        /*This assignment shows example
         * of loops using random to
         * show numbers between 1
         *  through 50*
         *  nicole brown 10/20/2016*/
         
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randomNumbers = new int[10];
            for (int i = 1; i < randomNumbers.Length; i++)

                {

                randomNumbers[i] = rand.Next(1, 50);
                }

            for (int i = 0; i < randomNumbers.Length; i++)

                {
                Console.WriteLine(randomNumbers[i]);
                }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
