using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            const double RENTAL_CHARGE_ADAY = 20.00;
            const double CENTS_PER_MILE = 0.25;
            double miles;
            double days;
            double totalFee;
            Console.WriteLine("How many miles did you drive this car >>>");
            miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many days did you drive this car >>>");
            days = Convert.ToDouble(Console.ReadLine());
            totalFee = (miles * CENTS_PER_MILE) + (days * RENTAL_CHARGE_ADAY);
            Console.WriteLine("Your total fee is ${0}", totalFee);





        }
    }
}
