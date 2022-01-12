using System;

namespace task2digits
     //https://c-sharp.pro/z1-циклы-и-условные-операторы-простейш
     //Z1.10. Найти все двузначные числа, которые делятся на n или содержат цифру n.
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            int divider = input.getDivider();
            Procedure.exploring2digitsNumber(divider);
        }
    }
}
