using System;

namespace Lesson3Coding.OperatorsExamples
{
    public class AssignmentOperatorsExample : IExample
    {
        public void Run()
        {
            ConsoleHelper.WriteHeader("Операторы присваивания");
            ConsoleHelper.WriteHeader("Оператор присваивания");
            int a;

            a = 5;
            Console.WriteLine($"Пример: a=5: {a}");
            
            a = 5;
            Console.WriteLine($"Пример: a+=2: {a += 2}");

            a = 5;
            Console.WriteLine($"Пример: a-=2: {a -= 2}");

            int? b = null;
            Console.WriteLine($"Пример: b??=:{b??=4}");
        }
    }
}
