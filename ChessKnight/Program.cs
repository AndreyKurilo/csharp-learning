using System;

namespace ChessKnight
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.defineStartCell();
            knight.move();
        }
    }
}
