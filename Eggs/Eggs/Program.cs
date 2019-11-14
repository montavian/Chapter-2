using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dozenEggs = 12;
            int numEggs = 127;
            int cartonOfEggs;
            int eggsRemaining;

            Console.WriteLine("how many eggs are ther? >>>>");
            numEggs = Convert.ToInt32(Console.ReadLine());
            cartonOfEggs = numEggs / dozenEggs;
            eggsRemaining = numEggs % dozenEggs;

            Console.WriteLine("The number of eggs collected was {0}, we have {1} cartons of eggs and, " + "{2} eggs remaining"
                , numEggs, cartonOfEggs, eggsRemaining);

        }
    }
}
