using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AK_6._1
{
    public partial class CostOfTrip
    {
        static float litersPerKm;
        public double litersSpent;
        static double litersToGallons = 0.264172;
        static double gallonsSpent = 0;

        public void Сonsumption(int distanceKm)
        {
            Console.Write("Enter your car's consumption (liters)");
            litersPerKm = Convert.ToSingle(Console.ReadLine());
            litersSpent = distanceKm * litersPerKm / 100;
            Console.WriteLine("Liters spent: {0:#.##}", litersSpent);
        }

        public static void Gallons(double litersSpent)
        {
            gallonsSpent = litersSpent * litersToGallons;
            Console.WriteLine("Gallons spent: {0:#.###}", gallonsSpent);
        }
    }

    public partial class CostOfTrip
    {
        int distance;
        static double gasPricePerLiter = 2.15;
        double tripCost;
        public void Run()
        {
            Console.WriteLine("Enter distance to raid, km");
            distance = Convert.ToInt16(Console.ReadLine());
            
            Сonsumption(distance);
            Gallons(litersSpent);


            tripCost = litersSpent * gasPricePerLiter;
            Console.WriteLine("Cost of trip: {0:#.##} rubles", tripCost);

        }
    }
}
