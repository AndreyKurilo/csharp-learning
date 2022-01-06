using System;

namespace Lesson3Coding.OperatorsExamples
{
    public class BitwiseAndShiftOperatorsExample : IExample
    {
        public void Run()
        {
            BitwiseComplementOperator();
            LeftShiftOperator();
            RightShiftOperator();
            LogicalExclusiveOROperator1();
            LogicalExclusiveOROperator2();
            LogicalANDOperator();
        }

        private void BitwiseComplementOperator()
        {
            ConsoleHelper.WriteHeader("Оператор побитового дополнения ~");

            uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~a;
            Console.WriteLine($"~{a}:");
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            
            Console.WriteLine();
        }

        private void LeftShiftOperator()
        {
            ConsoleHelper.WriteHeader("Оператор сдвига влево <<");

            uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");

            uint y = x << 4;
            Console.WriteLine($"{x} << 4");
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");

            Console.WriteLine();
        }

        private void RightShiftOperator()
        {
            ConsoleHelper.WriteHeader("Оператор сдвига вправо >>");

            uint x = 0b_1001;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2),4}");

            uint y = x >> 2;
            Console.WriteLine($"{x} >> 2");
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2),4}");

            int a = int.MinValue;
            Console.WriteLine($"Before: {Convert.ToString(a, toBase: 2)}");

            int b = a >> 3;
            Console.WriteLine($"{a} >> 3");
            Console.WriteLine($"After:  {Convert.ToString(b, toBase: 2)}");

            uint c = 0b_1000_0000_0000_0000_0000_0000_0000_0000;
            Console.WriteLine($"Before: {Convert.ToString(c, toBase: 2),32}");

            uint d = c >> 3;
            Console.WriteLine($"{c} >> 3");
            Console.WriteLine($"After:  {Convert.ToString(d, toBase: 2),32}");

            Console.WriteLine();
            ConsoleHelper.WriteHeader("Примеры №2:");
            a = 0b_1001;
            b = 0b_0110;

            Console.WriteLine($"~\t{Convert.ToString(a, toBase: 2).PadLeft(32, '0')}\r\n\t{Convert.ToString(~a, toBase: 2).PadLeft(32, '0')}");
            Console.WriteLine();
            Console.WriteLine($"\t{Convert.ToString(a, toBase: 2).PadLeft(32, '0')} ^\r\n\t{Convert.ToString(b, toBase: 2).PadLeft(32, '0')} =\r\n\t{Convert.ToString(a^b, toBase: 2).PadLeft(32, '0')}");
            Console.WriteLine();
            Console.WriteLine($"\t{Convert.ToString(a, toBase: 2).PadLeft(32, '0')} |\r\n\t{Convert.ToString(b, toBase: 2).PadLeft(32, '0')} =\r\n\t{Convert.ToString(a | b, toBase: 2).PadLeft(32, '0')}");
            Console.WriteLine();
            Console.WriteLine($"\t{Convert.ToString(a, toBase: 2).PadLeft(32, '0')} &\r\n\t{Convert.ToString(b, toBase: 2).PadLeft(32, '0')} =\r\n\t{Convert.ToString(a & b, toBase: 2).PadLeft(32, '0')}");
            Console.WriteLine();
            Console.WriteLine($"\t{Convert.ToString(a, toBase: 2).PadLeft(32, '0')} >> 4\r\n\t{Convert.ToString(a >> 4, toBase: 2).PadLeft(32, '0')}");
            Console.WriteLine();
            Console.WriteLine($"\t{Convert.ToString(a, toBase: 2).PadLeft(32, '0')} << 4\r\n\t{Convert.ToString(a << 4, toBase: 2).PadLeft(32, '0')}");
            Console.WriteLine();
        }

        private void LogicalExclusiveOROperator1()
        {
            ConsoleHelper.WriteHeader("Оператор логического исключения ИЛИ ^");

            uint a = 0b_1111_1000;
            uint b = 0b_0001_1100;
            uint c = a ^ b;
            Console.WriteLine($"{a} ^ {b}");
            Console.WriteLine(Convert.ToString(c, toBase: 2));

            Console.WriteLine();
        }

        private void LogicalExclusiveOROperator2()
        {
            ConsoleHelper.WriteHeader("Оператор логического исключения ИЛИ |");

            uint a = 0b_1010_0000;
            uint b = 0b_1001_0001;
            uint c = a | b;
            Console.WriteLine($"{a} | {b}");
            Console.WriteLine(Convert.ToString(c, toBase: 2));

            Console.WriteLine();
        }

        private void LogicalANDOperator()
        {
            ConsoleHelper.WriteHeader("Оператор логического И &");

            uint a = 0b_1111_1000;
            uint b = 0b_1001_1101;
            uint c = a & b;
            Console.WriteLine($"{a} & {b}");
            Console.WriteLine(Convert.ToString(c, toBase: 2));

            Console.WriteLine();
        }
    }
}
