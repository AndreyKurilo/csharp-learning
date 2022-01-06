using System;

namespace HW_4_AndreyKurilo.Actions
{
    public class ArrayComparison
    {
        public void Run()
        {
            ArraysOperations();            
        }

        private void ArraysOperations()
        {
                    
            var arraysInit = new ArraysInit();
            arraysInit.Run();

            Console.WriteLine("Arrayses elements comparison");

            byte i = 0;

            foreach (int element1 in arraysInit.array1)
            {
                byte k = 0;
                foreach (int element2 in arraysInit.array2)
                {
                    if (element1 == element2) k++;
                }
                Console.WriteLine($"Arrays's 1  Element {i+1} = {element1} has {k} comparison(s) in Array 2");
                i++;
            }
        }
    }
}
