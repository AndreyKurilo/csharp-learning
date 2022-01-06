using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Operations
{
    public class LogicalOperations
    {
        public void Run()
        {
            LogicalOps();
        }

        private void LogicalOps()
        {
            byte a = 0b_0001;
            byte b = 0b_0010;
            byte c = 0b_0100;
            byte d = 0b_1000;
            byte e = 0b_1001;
            byte f = 0b_1100;

            byte[] varArray = new byte[] { a, b, c, d, e, f };

            Console.WriteLine();
            ConsoleHelper.WriteHeader("Логические операторы");
            Console.WriteLine();

            ConsoleHelper.WriteHeader("Operator &");
            Console.WriteLine();
            Console.WriteLine();

            for (byte i = 0; i < (varArray.Length - 1); i += 2)
            {
                ConsoleHelper.WriteSubHead("Expression: ");
                Console.WriteLine($"{Convert.ToString(varArray[i], toBase: 2).PadLeft(4, '0')}" +
                    $" & {Convert.ToString(varArray[i + 1], toBase: 2).PadLeft(4, '0')}");

                int v = varArray[i] & varArray[i + 1];

                ConsoleHelper.WriteSubHead("Makes: ");
                Console.WriteLine(Convert.ToString(v, toBase: 2).PadLeft(4, '0'));
                Console.WriteLine();
                Console.WriteLine();
            }

            ConsoleHelper.WriteHeader("Operator ^");
            Console.WriteLine();
            Console.WriteLine();

            for (byte i = 0; i < (varArray.Length - 1); i += 2)
            {
                ConsoleHelper.WriteSubHead("Expression: ");
                Console.WriteLine($"{Convert.ToString(varArray[i], toBase: 2).PadLeft(4, '0')}" +
                    $" ^ {Convert.ToString(varArray[i + 1], toBase: 2).PadLeft(4, '0')}");

                int v = varArray[i] ^ varArray[i + 1];

                ConsoleHelper.WriteSubHead("Makes: ");
                Console.WriteLine(Convert.ToString(v, toBase: 2).PadLeft(4, '0'));
                Console.WriteLine();
                Console.WriteLine();
            }

            ConsoleHelper.WriteHeader("Operator |");
            Console.WriteLine();
            
            for (byte i = 0; i < (varArray.Length - 1); i += 2)
            {
                ConsoleHelper.WriteSubHead("Expression: ");
                Console.WriteLine($"{Convert.ToString(varArray[i], toBase: 2).PadLeft(4, '0')}" +
                    $" | {Convert.ToString(varArray[i + 1], toBase: 2).PadLeft(4, '0')}");
                
                int v = varArray[i] | varArray[i + 1];
                
                ConsoleHelper.WriteSubHead("Makes: ");
                Console.WriteLine(Convert.ToString(v, toBase: 2).PadLeft(4, '0'));
                Console.WriteLine();
            }
            //bool bl = true & true;
            //Console.WriteLine($"Оператор & И - если оба операнда 'true' результат 'true' - остальное - 'false'" +
            //    $"bool bl = true & true = {bl}");
            //bool bl12 = true && false;
            //Console.WriteLine($"Оператор && - логический 'И' - не проверяет 2й операнд, если 1й - 'false'" +
            //    $"bool bl12 = true & true = {bl12}");
            //bool bl11 = false ^ true;
            //Console.WriteLine($"Оператор ^ - аналог ' != ' bool bl2 = true ^ true = {bl11}");
            //bool bl2 = true | false;
            //Console.WriteLine($@"Оператор | - 'или' - даст 'true' если хоть один операнд 'true'" +
            //$"bool bl2 = true | true = {bl2}");
            //bool bl3 = true || false;
            //Console.WriteLine($@"Оператор || - условный 'или' - 2й оператор не проверяется, если 1й- 'true'" +
            //$"bool bl3 = true || true = {bl3}");

        }
    }
}
