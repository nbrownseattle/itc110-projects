using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_4_nbrown
{
    class Program
    {
        /*This program is an example
         * of a do loop
         * nicole brown 10/20/2016*/
        static void Main(string[] args)
        {
            string continues = "yes";
            do
            {
                Console.WriteLine("to continue type 'yes', to quit type stop");
                continues = Console.ReadLine();
                continues = continues.ToLower();
            }
            while(!continues.Equals("stop"));



                {
                Console.WriteLine("Thank you!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }//end main
    }//end class
}//end namespace
