using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3Coding.OperatorsExamples
{
    public class AriphmeticOperatorsExample : IExample
    {
        public void Run()
        {
            UnaryOperatorsExamples();
            BinaryOperatorsExamples();
            OperationsPriority();
        }

        private void UnaryOperatorsExamples()
        {
            ConsoleHelper.WriteHeader("Пример унарных операторов.");

            var a = 0;
            ConsoleHelper.WriteHeader("Оператор инкремента");
            Console.WriteLine($"Значение переменной а={a}");
            Console.WriteLine($"Префиксный оператор инкремента: {++a}");
            Console.WriteLine($"Постфиксный оператори инкремента: {a++}");
            Console.WriteLine($"Значение переменной а={a}");

            Console.WriteLine();

            a = 0;
            ConsoleHelper.WriteHeader("Оператор декремента");
            Console.WriteLine($"Значение переменной а={a}");
            Console.WriteLine($"Префиксный оператор декремента: {--a}");
            Console.WriteLine($"Постфиксный оператори декремента: {a--}");
            Console.WriteLine($"Значение переменной а={a}");

            Console.WriteLine();

            a = 1;
            ConsoleHelper.WriteHeader("Оператор унарного плюса");
            Console.WriteLine($"Значение переменной a={a}");
            Console.WriteLine($"Значение переменной a с унарным плюсом={+a}");
            Console.WriteLine($"Значение переменной a с унарным минусом={-a}");
            Console.WriteLine($"Значение переменной a={a}");

            Console.WriteLine();
        }

        private void BinaryOperatorsExamples()
        {
            ConsoleHelper.WriteHeader("Пример бинарных операторов.");

            var a = 5;
            var b = 2;
            Console.WriteLine($"a = {a}. Тип: {(a).GetType()}, a = {b}. Тип: {(b).GetType()}");
            Console.WriteLine($"Сложение: a + b={a + b}. Тип: {(a + b).GetType()}");
            Console.WriteLine($"Разность: a - b={a - b}. Тип: {(a - b).GetType()}");
            Console.WriteLine($"Умножение: a * b={a * b}. Тип: {(a * b).GetType()}");
            Console.WriteLine($"Деление: a / b={a / b}. Тип: {(a / b).GetType()}");
            Console.WriteLine($"Деление: (double)a / b={(double)a / b}. Тип: {((double)a / b).GetType()}");
            Console.WriteLine($"Деление: a / (double)b={a / (double)b}. Тип: {(a / (double)b).GetType()}");
            Console.WriteLine($"Деление: (double)a / (double)b={(double)a / (double)b}. Тип: {((double)a / (double)b).GetType()}");
            Console.WriteLine($"Остаток от деления: a + b={a % b}. Тип: {(a % b).GetType()}");

            Console.WriteLine();
        }

        private void OperationsPriority()
        {
            ConsoleHelper.WriteHeader("Приоритет и ассоциативность операторов");
            int a, b, c;

            a = 5; b = 3; c = 1;            
            Console.WriteLine($"Пример последовательности операций: -{a}++ * --{b} +{c}: {-a++ * --b + c}");
            
            a = 4; b = 3; c = 2;
            Console.WriteLine($"Пример последовательности операций: {a} + {b} * {c}: {a + b * c}");

            a = 4; b = 3; c = 2;
            Console.WriteLine($"Пример последовательности операций: ({a} + {b}) * {c}: {(a + b) * c}");
            
            Console.WriteLine();
        }
    }
}
