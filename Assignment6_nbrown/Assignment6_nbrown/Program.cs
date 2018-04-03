using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_nbrown
{
    class Program
    {

        /*This progam utilizes methods to calculate GPA
         * Creates two methods to take grades/credits input from user
         * Creates a method to loop throughinputs
         * Creates a method to calculate gpa
         * Creates a method to display results
         */
        static void Main(string[] args)//method that starts the program.
        {
            Program p = new Program(); //instantiate the class Program
            p.Display(); //call Display method 
        }

        private void Display()
        {
            GetInput();
        }

        private void GetInput()
        {
            Console.WriteLine("How many grades would you like to enter?");
            int numberOfEntries = 0;
            bool goodEntry = false;

            while (!goodEntry)
            {
                goodEntry = int.TryParse(Console.ReadLine(), out numberOfEntries);
                if (!goodEntry)
                    Console.WriteLine("Please enter a valid integer.");
            }
            double[] grades = GetGrades(numberOfEntries);
            double[] credits = GetCredits(numberOfEntries);
            Info(grades, credits);
        }

        private double[] GetGrades(int numberOfEntries)
        {
            double[] grades = new double[numberOfEntries];
            double grade = 0;

            for (int i = 0; i < numberOfEntries; i++)
            {
                Console.WriteLine("Please enter grade number {0}.", (i + 1));
                Double.TryParse(Console.ReadLine(), out grade);
                grades[i] = grade;
            }
            return grades;
        }

        private double[] GetCredits(int numberOfEntries)
        {
            double[] credits = new double[numberOfEntries];
            double credit = 0;

            for (int i = 0; i < numberOfEntries; i++)
            {
                Console.WriteLine("Please enter the credits for grade number {0}.", (i + 1));
                Double.TryParse(Console.ReadLine(), out credit);
                credits[i] = credit;
            }
            return credits;
        }

        private double CalcGPA(double[] grades, double[] credits)
        {
            double weight = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                weight = weight + grades[i] * credits[i];
            }

            double totalCredits = 0;
            for (int i = 0; i < credits.Length; i++)
            {
                totalCredits = totalCredits + credits[i];
            }

            double gpa = weight / totalCredits;
            return gpa;
        }

        private void Info(double[] grades, double[] credits)//Uses void since this is the last method.
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Grade: " + grades[i] + " Credits: " + credits[i]);
            }
            double gpa = CalcGPA(grades, credits);
            Console.WriteLine("The overall GPA is {0:0.00}", gpa);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }//end main
    }//end class
}//end namespace
