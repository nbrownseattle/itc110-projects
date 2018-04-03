using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example
{
    class Program
        /*This program shows an example
         * of a while loop that also displays
         * the count of loops
         * nicole brown 10/20/2016*/
    {
        static void Main(string[] args)
        {
            string choice = "yes";
            int counter = 0;

            while (choice.Equals("yes"))
            {
               counter++;
               Console.WriteLine(counter);
               Console.WriteLine("Enter yes to continue or no to stop and exit");
               choice = Console.ReadLine();

                }

            {
                Console.WriteLine("Thank you!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }//end main
    }//end class
}//end namespace
