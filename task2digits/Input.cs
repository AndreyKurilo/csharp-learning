using System;
using System.Collections.Generic;
using System.Text;

namespace task2digits
{
    class Input
    {
        private int divider;

        public int getDivider()
        {
            Console.WriteLine("Enter single digit 1 - 9 or other symbol to cancel");
            divider = Convert.ToInt32(Console.ReadLine());
            return divider;
        }
    }
}
