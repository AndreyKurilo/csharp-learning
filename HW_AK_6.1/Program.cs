using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Программа высчитывает расход бензина в литрах и галлонах,
 * а также перекладывает их стоимость в бел рубли*/

namespace HW_AK_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            new CostOfTrip().Run();

            Console.ReadKey();
        }
    }
}
