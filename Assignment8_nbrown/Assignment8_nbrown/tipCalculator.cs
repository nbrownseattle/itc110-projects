using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_nbrown
{
    public class tipCalculator
    {
        private double mealAmount;
        private double tipAmount;
        public tipCalculator()
        {
            Meal = 0;
            Tip = 0;
        }

        public tipCalculator(double mealAmount, double tipAmount)
        {
            Meal = mealAmount;
            Tip = tipAmount;
        }

        public double Meal
        {
            set { mealAmount = value; }
            get { return mealAmount; }
        }
        public double Tip
        {
            get { return tipAmount; }
            set { tipAmount = value; }
        }
        public double GetTax()
        {
            return Meal * .09;
        }
        public double CalculateTip()
        {
            return Meal * (Tip/100);
        }
        public double CalculateTotal()
        {
            return CalculateTip() + GetTax() + Meal;
        }
    }
}
