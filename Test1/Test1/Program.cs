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
        /// This program shows an example of 
        /// a tip calculator
        /// nicole brown 10/6/2016
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Main(string[] args)
        {

            Program p = new Program();
            p.GetValue();

        }
        private void GetValue()
        {

            Console.WriteLine("Enter meal price");
            double meal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter tip percentage");
            double tip = double.Parse(Console.ReadLine());


            double tax = .092;
            double taxcalc = meal * tax;
            double mealplustax = taxcalc + meal;
            double tip2 = tip / 100 * mealplustax;
            double total = tip2 + taxcalc + meal;
            Console.WriteLine("Meal price: {0}", meal);
            Console.WriteLine("Tip:@ {0}% = ${1:0.00}", tip, tip2);
            Console.WriteLine("Tax:@ 9.2% = ${0:0.00}", taxcalc);
            Console.WriteLine("___________________");
            Console.WriteLine("Total: ${0:0.00}", total);


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}


