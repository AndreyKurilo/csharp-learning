using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka.Properties
{
    class Nybble
    {
        //Создание 4-битового типа с именем Nybble
        int val; //Основа типа - встроенный тип int
        public Nybble() { val = 0; }
        public Nybble(int i)
        {
            val = i;
            val = val & 0xF; //Выделяем младшие 4бита.
        }
        //Перегружаем бинарный оператор "+"для сложения Nybble + Nybble.
        public static Nybble operator +(Nybble opl, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = opl.val + op2.val;
            result.val = result.val & 0xF; //Оставляем младшие 4 бита.

            return result;
        }
        //Перегружаем бинарный оператор "+" для сложения Nybble + int.
        public static Nybble operator +(Nybble opl, int op2)
        {
            Nybble result = new Nybble();
            result.val = opl.val + op2;
            result.val = result.val & 0xF;  //Оставляем младшие 4 бита.
            return result;
        }

        //Перегружаем бинарный оператор "+ " для сложения int + Nybble.
        public static Nybble operator +(int opl, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = opl + op2.val;
            result.val = result.val & 0xF; //Оставляем младшие 4 бита.

            return result;
        }
        //Перегружаем оператор "++".
        public static Nybble operator ++(Nybble op)
        {
            op.val++;
            op.val = op.val & 0xF; //Оставляем младшие 4 бита,
            return op;
        }

        //Перегружаем оператор ">".
        public static bool operator >(Nybble opl, Nybble op2)
        {
            if (opl.val > op2.val) return true;
            else return false;
        }

        //Перегружаем оператор "<".
        public static bool operator <(Nybble opl, Nybble op2)
        {
            if (opl.val < op2.val) return true;
            else return false;
        }

        //Преобразование Nybble-объекта в значение типа int.
        public static implicit operator int(Nybble op)
        {
            return op.val;
        }

        //Преобразование int-значения в Nybble-объект.
        public static implicit operator Nybble(int op)
        {
            return new Nybble(op);
        }
    }
}
