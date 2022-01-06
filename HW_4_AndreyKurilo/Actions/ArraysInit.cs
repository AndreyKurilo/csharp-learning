using System;

namespace HW_4_AndreyKurilo.Actions
{
    class ArraysInit
    {
        public int array1Size = 0;
        public int array2Size = 0;
        public int[] array1;
        public int[] array2;

        public void Run()
        {
            ArraysCreation();

        }

        public void ArraysCreation()
        {
            byte a = 0;
            byte q = 1;

            do
            {
                Console.WriteLine("Input Array1 size (number from 1 to 20)");
                array1Size = Convert.ToInt16(Console.ReadLine());

                if (array1Size >= 1 || array1Size <= 20)
                {
                    a = 1;
                }
                else
                {
                    Console.WriteLine("Incorrect number");
                }
                q++;
                if (q > 10)
                {
                    Console.WriteLine("Too many attemps");
                    break;
                }
            }
            while (a != 1);

            array1 = new int[array1Size];

            int i = 0;

            Console.WriteLine($"Input array's 1 elements - {array1Size} numbers from -1000 to 1000");
            Console.WriteLine("(Inputting from array's start to array's end)");
            for (i = 0; i < array1Size; i++)
            {
                Console.WriteLine($"Input {i+1} element");
                array1[i] = Convert.ToInt16(Console.ReadLine());

                string message = (array1[i] >= 1000 && array1[i] <= -1000) ?
                    "Number incorrect" : $"Number {array1[i]} accepted";

                Console.WriteLine($"{message}");
                Console.WriteLine();

                if ( i > array1Size - 1)
                    Console.WriteLine("Array 1 fullfiled");
            }

            byte b = 0;
            byte w = 1;

            do
            {
                Console.WriteLine("Input Array2 size (number from 1 to 20");
                array2Size = Convert.ToInt16(Console.ReadLine());

                if (array2Size >= 1 || array2Size <= 20)
                {
                    b = 1;
                }
                else
                {
                    Console.WriteLine("Incorrect number");
                }
                w++;
                if (w > 10)
                {
                    Console.WriteLine("Too many attemps");
                    break;
                }
            }
            while (b != 1);

            array2 = new int[array2Size];

            //int j = 0;

            Console.WriteLine($"Input array's 2 elements - {array2Size} numbers from -1000 to 1000");
            Console.WriteLine("(Inputting from array's end to array's start)");
            for (int j = (array2Size - 1); j > -1 ; j--)
            {
                Console.WriteLine($"Input {j} element");
                array2[j] = Convert.ToInt16(Console.ReadLine());

                string message = (array2[j] >= 1000 && array2[j] <= -1000) ? 
                    "Number incorrect" : $"Number {array2[i]} accepted";

                Console.WriteLine($"{message}");
                Console.WriteLine();
                if (j < 0)
                    Console.WriteLine("Array 2 fullfiled");
            }
        }
    }
}
