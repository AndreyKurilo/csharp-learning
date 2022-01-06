using System;

namespace Lesson3Coding.OperatorsExamples
{
    public class LogicalOperatorsExample : IExample
    {
        public void Run()
        {
            ConsoleHelper.WriteHeader("Логические операторы");

            Console.WriteLine($"Пример {true} & {true}:");
            Console.WriteLine(CalculateWithResult(true) & CalculateWithResult(true));

            Console.WriteLine($"Пример {true} & {false}:");
            Console.WriteLine(CalculateWithResult(true) & CalculateWithResult(false));

            Console.WriteLine($"Пример {false} & {true}:");
            Console.WriteLine(CalculateWithResult(false) & CalculateWithResult(true));

            Console.WriteLine($"Пример {false} & {false}:");
            Console.WriteLine(CalculateWithResult(false) & CalculateWithResult(false));

            Console.WriteLine();
            
            Console.WriteLine($"Пример {true} | {true}:");
            Console.WriteLine(CalculateWithResult(true) | CalculateWithResult(true));

            Console.WriteLine($"Пример {true} | {false}:");
            Console.WriteLine(CalculateWithResult(true) | CalculateWithResult(false));

            Console.WriteLine($"Пример {false} | {true}:");
            Console.WriteLine(CalculateWithResult(false) | CalculateWithResult(true));

            Console.WriteLine($"Пример {false} | {false}:");
            Console.WriteLine(CalculateWithResult(false) | CalculateWithResult(false));

            Console.WriteLine();

            Console.WriteLine($"Пример {true} && {true}:");
            Console.WriteLine(CalculateWithResult(true) && CalculateWithResult(true));

            Console.WriteLine($"Пример {true} && {false}:");
            Console.WriteLine(CalculateWithResult(true) && CalculateWithResult(false));

            Console.WriteLine($"Пример {false} && {true}:");
            Console.WriteLine(CalculateWithResult(false) && CalculateWithResult(true));

            Console.WriteLine($"Пример {false} && {false}:");
            Console.WriteLine(CalculateWithResult(false) && CalculateWithResult(false));

            Console.WriteLine();

            Console.WriteLine($"Пример {true} || {true}:");
            Console.WriteLine(CalculateWithResult(true) || CalculateWithResult(true));

            Console.WriteLine($"Пример {true} || {false}:");
            Console.WriteLine(CalculateWithResult(true) || CalculateWithResult(false));

            Console.WriteLine($"Пример {false} || {true}:");
            Console.WriteLine(CalculateWithResult(false) || CalculateWithResult(true));

            Console.WriteLine($"Пример {false} || {false}:");
            Console.WriteLine(CalculateWithResult(false) || CalculateWithResult(false));

            Console.WriteLine();

            Console.WriteLine($"Пример {true} ^ {true}: {true ^ true}");
            Console.WriteLine($"Пример {true} ^ {false}: {true ^ false}");
            Console.WriteLine($"Пример {false} ^ {true}: {false ^ true}");
            Console.WriteLine($"Пример {false} ^ {false}: {false ^ false}");

            Console.WriteLine();

            Console.WriteLine($"Пример !{true}: {!true}");
            Console.WriteLine($"Пример !{false}: {!false}");

            Console.WriteLine();
        }

        private bool CalculateWithResult(bool result)
        {
            ConsoleHelper.WriteInfo($"Calculate return: {result}");
            return result;
        }
    }
}
