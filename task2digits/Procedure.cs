using System;
using System.Collections.Generic;
using System.Text;

namespace task2digits
{
    class Procedure
    {
        public static void exploring2digitsNumber(int divider)
        {
            for(int i = 10; i < 100; i++)
            {
                byte counter = 0;
                int firstDigit = i / 10;
                int secondDigit = i % 10;
                if(firstDigit == divider | secondDigit == divider)
                {
                    Console.WriteLine("Number " + i + " contains " + divider);
                    counter++;
                }
                if(i % divider == 0)
                {
                    Console.WriteLine(divider + " is divider of " + i);
                    counter++;
                }
                if (counter != 0) Console.WriteLine();
            }
        }
    }
}
