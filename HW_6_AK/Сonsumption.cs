using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_AK
{
    public class Сonsumption
    {
        //uint distance;
        static float litersPerKm = 10;
        public double litersSpent;
        static double litersToGallons = 0.264172;
        static double gallonsSpent = 0;

        public Сonsumption (int distanceKm)
        {
            Console.Write("Enter your car's consumption (liters)");
            litersPerKm = Convert.ToSingle(Console.ReadLine());
            litersSpent = distanceKm * litersPerKm / 100;
            Console.WriteLine($"Liters spent: {litersSpent}");
        }

        public static void  Gallons (double litersSpent)
        {
            gallonsSpent = litersSpent * litersToGallons;
            Console.WriteLine($"Gallons spent: {gallonsSpent}");
        }
    }
}
