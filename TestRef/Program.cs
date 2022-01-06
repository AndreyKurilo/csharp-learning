using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before: a - {a}, b - {b}");

            Test ts = new Test(a, b);
            Console.WriteLine($"After: a - {a}, b - {b}");
            Test ts2 = ts;

        }
    }
}
