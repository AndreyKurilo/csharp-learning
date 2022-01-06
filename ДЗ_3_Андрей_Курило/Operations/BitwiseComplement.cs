using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Operations
{
    public class BitwiseComplement
    {
        public void Run()
        {
            Bitwise();
        }

        private void Bitwise()
        {
            byte a = 0b_0001;
            byte b = 0b_0010;
            byte c = 0b_0100;
            byte d = 0b_1000;
            byte e = 0b_1001;
            byte f = 0b_1100;


            ConsoleHelper.WriteHeader("Операция побитового дополнения: ( ~ ) ");
            Console.WriteLine($" ");
            ConsoleHelper.WriteSubHead("До обработки: ");
            Console.WriteLine($"{Convert.ToString(a, toBase: 2).PadLeft(4, '0')}");
            ConsoleHelper.WriteSubHead("После обработки: ");
            Console.WriteLine($"{Convert.ToString((byte)~a, toBase: 2)}");
            Console.WriteLine($" ");
            ConsoleHelper.WriteSubHead("До обработки: ");
            Console.WriteLine($"{Convert.ToString(b, toBase: 2).PadLeft(4, '0')}");
            ConsoleHelper.WriteSubHead("После обработки: ");
            Console.WriteLine($"{Convert.ToString((byte)~b, toBase: 2)}");
            Console.WriteLine($" ");
            ConsoleHelper.WriteSubHead("До обработки: ");
            Console.WriteLine($"{Convert.ToString(c, toBase: 2).PadLeft(4, '0')}");
            ConsoleHelper.WriteSubHead("После обработки: ");
            Console.WriteLine($"{Convert.ToString((byte)~c, toBase: 2)}");
            Console.WriteLine($" ");
            ConsoleHelper.WriteSubHead("До обработки: ");
            Console.WriteLine($"{Convert.ToString(d, toBase: 2).PadLeft(4, '0')}");
            ConsoleHelper.WriteSubHead("После обработки: ");
            Console.WriteLine($"{Convert.ToString((byte)~d, toBase: 2)}");
            Console.WriteLine($" ");
            ConsoleHelper.WriteSubHead("До обработки: ");
            Console.WriteLine($"{Convert.ToString(e, toBase: 2).PadLeft(4, '0')}");
            ConsoleHelper.WriteSubHead("После обработки: ");
            Console.WriteLine($"{Convert.ToString((byte)~e, toBase: 2)}");
            Console.WriteLine($" ");
            ConsoleHelper.WriteSubHead("До обработки: ");
            Console.WriteLine($"{Convert.ToString(f, toBase: 2).PadLeft(4, '0')}");
            ConsoleHelper.WriteSubHead("После обработки: ");
            Console.WriteLine($"{Convert.ToString((byte)~f, toBase: 2)}");
        }
    }
}
