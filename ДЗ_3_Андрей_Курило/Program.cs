using Homework.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            new BitwiseComplement().Run();
            new LeftRightShiftOperator().Run();
            new LogicalOperations().Run();

            Console.ReadKey();
        }
    }
}
