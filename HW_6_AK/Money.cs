using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_AK
{
    class Money
    {
        int distance;
        static double gasPricePerLiter = 1.85;
        double tripCost;
        public void Run()
        {
            Console.WriteLine("Enter distance to raid");
            distance = Convert.ToInt16(Console.ReadLine());
            Сonsumption trip = new Сonsumption(distance);

            Сonsumption.Gallons(trip.litersSpent);

           
            tripCost = trip.litersSpent * gasPricePerLiter;
            Console.WriteLine($"Cost of trip: {tripCost} rubles");

        }
    }
}
