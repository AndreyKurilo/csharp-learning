using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_AK
{
    class Program
    {
        static void Main(string[] args)
        {
            byte q = 255;
            Console.WriteLine($"{q.GetType().Name} переменной q присвоено значение {q}");
            sbyte w = -128;
            Console.WriteLine($"{w.GetType().Name} переменной w присвоено значение {w}");
            short e = w;
            Console.WriteLine($"Неявное преобразование: short {e} = sbyte {w}");
            ushort r = q;
            Console.WriteLine($"Неявное преобразование: ushort {r} = byte {q}");
            int t = e;
            Console.WriteLine($"Неявное преобразование: int {t} = short {e}");
            uint y = r;
            Console.WriteLine($"Неявное преобразование: uint {y} = ushort {r}");
            long u = t;
            Console.WriteLine($"Неявное преобразование: long {u} = int {t}");
            ulong i = y;
            Console.WriteLine($"Неявное преобразование: ulong {i} = uint {y}");
            float o = t;
            Console.WriteLine($"Неявное преобразование: float {o} = int {t}");
            double p = o;
            Console.WriteLine($"Неявное преобразование: double {p} = float {o}");
            decimal a = u;
            Console.WriteLine($"Неявное преобразование: decimal {a} = long {u}");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            a *= -1234567890.0987654321m;
            Console.WriteLine($"Переменной decimal a присвоено значеник {a}");
            p = (double)a;
            Console.WriteLine($"Явное преобразование переменной {a.GetType().Name} a {a} в переменную {p.GetType().Name} p {p}");
            o = (float)p;
            Console.WriteLine($"Явное преобразование переменной {p.GetType().Name} p {p} " +
                $"в переменную {o.GetType().Name} o {o}");
            u = (long)o;
            Console.WriteLine($"Явное преобразование переменной {o.GetType().Name} o {o} " +
                $"в переменную {u.GetType().Name} u {u}");
            t = (int)u;
            Console.WriteLine($"Явное преобразование переменной {u.GetType().Name} u {u} " +
                $"в переменную {t.GetType().Name} t {t}");
            e = (short)t;
            Console.WriteLine($"Явное преобразование переменной {t.GetType().Name} t {t} " +
                $"в переменную {e.GetType().Name} e {e}");
            q = (byte)e;
            Console.WriteLine($"Явное преобразование переменной {e.GetType().Name} e {e} " +
                $"в переменную {q.GetType().Name} q {q}");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Явные преобразования с проверкой");
            Console.WriteLine("    ");

            a *= -1234567890.0987654321m;
            Console.WriteLine($"Переменной decimal a присвоено значение {a}");
            
            Console.WriteLine($"Проверка преобразования переменной {a.GetType().Name} a {a} в переменную {p.GetType().Name} p {p}");
            try
            { p = checked((double)a); }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);                
            }
            Console.WriteLine($"Проверка преобразования переменной {p.GetType().Name} p {p} " +
                $"в переменную {o.GetType().Name} o {o}");
            try
            { o = checked((float)p); }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);               
            }
            Console.WriteLine($"Проверка преобразования переменной {o.GetType().Name} o {o} " +
                $"в переменную {u.GetType().Name} u {u}");
            try
            {
                u = checked((long)o);
            }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine($"Проверка преобразования переменной {u.GetType().Name} u {u} " +
                $"в переменную {t.GetType().Name} t {t}");
            try
            { t = checked((int)u); }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine($"Проверка преобразования переменной {t.GetType().Name} t {t} " +
                $"в переменную {e.GetType().Name} e {e}");
            try
            { e = checked((short)t); }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine($"Проверка преобразования переменной {e.GetType().Name} e {e} " +
                $"в переменную {q.GetType().Name} q {q}");
            try
            { q = checked((byte)e); }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Types Min, Max");
            Console.WriteLine("    ");
            Console.WriteLine($"{typeof(byte).Name}; Min value: {byte.MinValue}; Max value: {byte.MaxValue}");
            Console.WriteLine($"{typeof(sbyte).Name}; Min value: {sbyte.MinValue}; Max value: {sbyte.MaxValue}");
            Console.WriteLine($"{typeof(short).Name}; Min value: {short.MinValue}; Max value: {short.MaxValue}");
            Console.WriteLine($"{typeof(long).Name}; Min value: {long.MinValue}; Max value: {long.MaxValue}");
            Console.WriteLine($"{typeof(float).Name}; Min value: {float.MinValue}; Max value: {float.MaxValue}");
            Console.WriteLine($"{typeof(decimal).Name}; Min value: {decimal.MinValue}; Max value: {decimal.MaxValue}");
            Console.WriteLine($"{typeof(double).Name}; Min value: {double.MinValue}; Max value: {double.MaxValue}");
            Console.WriteLine(" ");
            short a1 = 64;
            int b1 = 128;
            byte c1 = 11;
            long l1 = (a1 + b1) * c1 / b1;
            float a2 = 64.3f;
            double b4 = 128.5;
            decimal c2 = 11.11m;
            double d2 = (double)((a2 + b4) * (double)c2 / b4);
            Console.WriteLine("Арифметические действия");
            Console.WriteLine($"Целочисленные типы l1 = (a1({a1}) + b1({b1})) * c2({c1}) / b1({b1}) = {l1}");
            Console.WriteLine($"Типы с плавающей точкой  d2 = (a2({a2}) + b4({b4})) * c2({c2}) / b4({b4}) = {d2}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Сложение строк");
            Console.WriteLine(" ");
            string str1 = "My name is";
            string str2 = " Andrey";
            string str3 = str1 + str2;
            Console.WriteLine(str3);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Булевы операции");
            Console.WriteLine(" ");
            bool bl = true & true; 
            Console.WriteLine($"Оператор & И - если оба операнда 'true' результат 'true' - остальное - 'false'" +
                $"bool bl = true & true = {bl}");
            bool bl12 = true && false; 
            Console.WriteLine($"Оператор && - логический 'И' - не проверяет 2й операнд, если 1й - 'false'" +
                $"bool bl12 = true & true = {bl12}");
            bool bl11 = false ^ true; 
            Console.WriteLine($"Оператор ^ - аналог ' != ' bool bl2 = true ^ true = {bl11}");
            bool bl2 = true | false; 
            Console.WriteLine($@"Оператор | - 'или' - даст 'true' если хоть один операнд 'true'"+
            $"bool bl2 = true | true = {bl2}");
            bool bl3 = true || false; 
            Console.WriteLine($@"Оператор || - условный 'или' - 2й оператор не проверяется, если 1й- 'true'" +
            $"bool bl3 = true || true = {bl3}");

            Console.ReadKey();
        }
    }
}
