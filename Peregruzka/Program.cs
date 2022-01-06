using Peregruzka.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka
{
    class Program
    {        
        public static void Main()
        {
            Nybble nybble1 = new Nybble(1);
            Nybble nybble2 = new Nybble(10);
            Nybble nybble3 = new Nybble();
            int t;

            Console.WriteLine("a:" + (int)nybble1);

            Console.WriteLine("b:" + (int)nybble2);

            //Используем Nybble-объект в if-инструкции,
            if (nybble1 < nybble2) Console.WriteLine("а меньше b\n");

            //Суммируем два Nybble-объекта.
            nybble3 = nybble1 + nybble2;
            Console.WriteLine("с после сложения с = a + b:" + (int)nybble3);


            //Суммируем int-значение с Nybble-объектом.
            nybble1 += 5;
            Console.WriteLine("а после сложения а +=5:" + (int)nybble1);
            Console.WriteLine();

            //Используем Nybble-объект в int-выражении,
            t = nybble1 * 2 + 3;
            Console.WriteLine("Результат выражения а*2 + 3:" + t);
            Console.WriteLine();

            //Иллюстрируем присваивание Nybble-объекту int-значения и переполнение.
            nybble1 = 19;
            Console.WriteLine("Результат присваивания а = 19:" + (int)nybble1);
            Console.WriteLine();

            //Используем Nybble-объект для управления циклом.
            Console.WriteLine("Управляем for-циклом с помощью Nybble-объекта.");
            for (nybble1 = 0; nybble1 < 10; nybble1++)
                Console.Write((int)nybble1 + "");
                Console.WriteLine();
        }
    }
}
