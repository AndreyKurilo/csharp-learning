using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework.Operations
{
    class LeftRightShiftOperator
    {
        public void Run()
        {
            LeftRightShift();
        }

        private void LeftRightShift()
        {
            byte a = 0b_0001;
            byte b = 0b_0010;
            byte c = 0b_0100;
            byte d = 0b_1000;
            byte e = 0b_1001;
            byte f = 0b_1100;

            byte[] varArray = new byte[] {a, b, c, d, e, f};

            Console.WriteLine("   ");
            ConsoleHelper.WriteHeader("Оператор сдвига влево <<");
            Console.WriteLine("   ");

            for (byte i = 0; i < varArray.Length; i++)
            {
                ConsoleHelper.WriteSubHead("Before: ");
                Console.WriteLine($"binary: {Convert.ToString(varArray[i], toBase: 2).PadLeft(4, '0')}" +
                    $" decimal: {varArray[i]}");
                int a1 = varArray[i] << 4;
                Console.WriteLine($"Shift {varArray[i]} << 4");
                ConsoleHelper.WriteSubHead("After: ");
                Console.WriteLine($"binary: {Convert.ToString(a1, toBase: 2)} decimal: {a1}");
                Console.WriteLine("   ");
            }

            Console.WriteLine("   ");
            ConsoleHelper.WriteHeader("Оператор сдвига вправо >>");
            Console.WriteLine("   ");

            for (byte j = 0; j < varArray.Length; j++)
            {
                ConsoleHelper.WriteSubHead("Before: ");
                Console.WriteLine($"binary: {Convert.ToString(varArray[j], toBase: 8).PadLeft(4, '0')}" +
                    $" decimal: {varArray[j]}");
                int b1 = varArray[j] >> 4;
                Console.WriteLine($"Shift {varArray[j]} >> 4");
                ConsoleHelper.WriteSubHead("After: ");
                Console.WriteLine($"binary: {Convert.ToString(b1, toBase: 2)} decimal: {b1}");
                Console.WriteLine("   ");
            }
        }
    }
}
