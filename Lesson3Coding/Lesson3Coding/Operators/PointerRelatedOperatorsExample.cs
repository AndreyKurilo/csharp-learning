using System;

namespace Lesson3Coding.OperatorsExamples
{
    public class PointerRelatedOperatorsExample : IExample
    {
        public void Run()
        {
            ConsoleHelper.WriteHeader("Операторы, связанные с указателем");
            OperatorAdressOf();
            PointerIndirectionOperator();
            PointerMemberAccessOperator();
            PointerElementAccessOperator();
        }

        private void OperatorAdressOf()
        {
            ConsoleHelper.WriteHeader("Оператор address-of &");

            unsafe
            {
                int number = 27;
                int* pointerToNumber = &number;

                Console.WriteLine($"Value of the variable: {number}");
                Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");
            }

            Console.WriteLine();
        }

        private void PointerIndirectionOperator()
        {
            ConsoleHelper.WriteHeader("Оператор косвенного обращения указателя *");

            unsafe
            {
                char letter = 'A';
                char* pointerToLetter = &letter;
                Console.WriteLine($"Value of the `letter` variable: {letter}");
                Console.WriteLine($"Address of the `letter` variable: {(long)pointerToLetter:X}");

                *pointerToLetter = 'Z';
                Console.WriteLine($"Value of the `letter` variable after update: {letter}");
            }

            Console.WriteLine();
        }

        private unsafe void PointerMemberAccessOperator()
        {
            ConsoleHelper.WriteHeader("Оператор доступа к члену указателя ->");

            Coords coords;
            Coords* p = &coords;
            p->X = 3;
            p->Y = 4;
            Console.WriteLine(p->ToString());  // output: (3, 4)

            Console.WriteLine();
        }

        private struct Coords
        {
            public int X;
            public int Y;
            public override string ToString() => $"({X}, {Y})";
        }

        private void PointerElementAccessOperator() 
        {
            ConsoleHelper.WriteHeader("Оператор доступа к элементу указателя []");

            unsafe
            {
                char* pointerToChars = stackalloc char[123];

                for (int i = 65; i < 123; i++)
                {
                    pointerToChars[i] = (char)i;
                }

                Console.Write("Uppercase letters: ");
                for (int i = 65; i < 91; i++)
                {
                    Console.Write(pointerToChars[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
