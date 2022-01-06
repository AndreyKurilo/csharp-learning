using System;
using System.Collections.Generic;
using System.Text;

namespace ChessKnight
{
    class Input
    {
        private String startCell;

        public String getStartCell()
        {
            Console.WriteLine("Enter start cell using Chess style");
            Console.WriteLine("First symbol from this set: A B C D E F G H");
            Console.WriteLine("Second symbol - digit - from this set: 1 - 8");
            Console.WriteLine("For example G7");
            startCell = Console.ReadLine();
            return startCell;
        }
    }
}
