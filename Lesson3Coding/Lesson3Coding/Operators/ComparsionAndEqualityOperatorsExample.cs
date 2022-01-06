using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3Coding.OperatorsExamples
{
    public class ComparsionAndEqualityOperatorsExample : IExample
    {
        public void Run()
        {
            ConsoleHelper.WriteHeader("Операторы отношения.");
            ComparsionExamples();
            EqualityExamples();
        }

        private void ComparsionExamples()
        {
            ConsoleHelper.WriteHeader("Операторы сравнения.");
            int a = 1, b = 2, c=2;
            Console.WriteLine($"Пример: {a}>{b}: {a > b}");
            Console.WriteLine($"Пример: {a}>={b}: {a >= b}");
            Console.WriteLine($"Пример: {b}>={c}: {b >=c}");

            Console.WriteLine($"Пример: {a}<{b}: {a < b}");
            Console.WriteLine($"Пример: {a}<={b}: {a <= b}");
            Console.WriteLine($"Пример: {b}<={c}: {b <= c}");

            Console.WriteLine();
        }

        private void EqualityExamples()
        {
            ConsoleHelper.WriteHeader("Операторы равенства.");
            int a = 1, b = 2, c = 2;
            Console.WriteLine($"Пример: {a}=={b}: {a == b}");
            Console.WriteLine($"Пример: {b}=={c}: {b == c}");
            Console.WriteLine($"Пример: {a}!={b}: {a != b}");
            Console.WriteLine($"Пример: {b}!={c}: {b != c}");

            Console.WriteLine();
        }
    }
}
