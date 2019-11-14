using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PROJECTED_RAISES = 0.04;
            double employee1Salary = 130.00;
            double employee2Salary = 140.00;
            double employee3Salary = 160.00;
            double emplNew1Salary = employee1Salary + (employee1Salary * PROJECTED_RAISES);
            double emplNew2Salary = employee2Salary + (employee2Salary * PROJECTED_RAISES);
            double emplNew3Salary = employee3Salary + (employee3Salary * PROJECTED_RAISES);
            Console.WriteLine("The salary of this employee is $" + employee1Salary + ". The salary for next year will be $" +
                emplNew1Salary + ".");
            Console.WriteLine("The salary of this employee is $" + employee2Salary + ". The salary for next year will be $" +
               emplNew2Salary + ".");
            Console.WriteLine("The salary of this employee is $" + employee3Salary + ". The salary for next year will be $" +
               emplNew3Salary + ".");

            {
                double emp1Sal;
                double emp2Sal;
                double emp3Sal;

                Console.WriteLine("What is employee 1's salary this year >>>");
                emp1Sal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is employee 1's salary this year >>>");
                emp1Sal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is employee 1's salary this year >>>");
                emp1Sal = Convert.ToDouble(Console.ReadLine());

                emp1Sal = emp1Sal * PROJECTED_RAISES;
                Console.WriteLine("Employee 1 salary is {0}", emp1Sal);
            }



        }
    }
}
