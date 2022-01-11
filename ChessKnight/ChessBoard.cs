using System;
using System.Collections.Generic;
using System.Text;

namespace ChessKnight
{
    class ChessBoard
    {
        public int[,] chessBoard;
        char x;
        char y;

        public ChessBoard()
        {
            this.chessBoard = new int[,]{{2, 3, 4, 4, 4, 4, 3, 2}, {3, 4, 6, 6, 6, 6, 4, 3},
            {4, 6, 8, 8, 8, 8, 6, 4}, {4, 6, 8, 8, 8, 8, 6, 4}, {4, 6, 8, 8, 8, 8, 6, 4},
            {4, 6, 8, 8, 8, 8, 6, 4}, {3, 4, 6, 6, 6, 6, 4, 3}, {2, 3, 4, 4, 4, 4, 3, 2}};
        }

        public int[,] getChessBoard()
        {
            return chessBoard;
        }

        public char getX(int xValue)
        {
            switch (xValue)
            {
                case 0:
                    x = 'A';
                    break;
                case 1:
                    x = 'B';
                    break;
                case 2:
                    x = 'C';
                    break;
                case 3:
                    x = 'D';
                    break;
                case 4:
                    x = 'E';
                    break;
                case 5:
                    x = 'F';
                    break;
                case 6:
                    x = 'G';
                    break;
                case 7:
                    x = 'H';
                    break;
            }
            return x;
        }

        public void setX(char x)
        {
            this.x = x;
        }

        public char getY(int yValue)
        {
            switch (yValue)
            {
                case 0:
                    y = '8';
                    break;
                case 1:
                    y = '7';
                    break;
                case 2:
                    y = '6';
                    break;
                case 3:
                    y = '5';
                    break;
                case 4:
                    y = '4';
                    break;
                case 5:
                    y = '3';
                    break;
                case 6:
                    y = '2';
                    break;
                case 7:
                    y = '1';
                    break;
            }
            return y;
        }

        public void printChessBoard()
        {
            for(int i = 0; i < 8; i++)
            {
                Console.Write(" " + (8 - i) + " " + " | ");
                for(int j = 0; j < 8; j++)
                {
                    Console.Write(" ");
                    if(chessBoard[i, j] == 9)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(chessBoard[i, j]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("    __________________________");
            Console.WriteLine("       A  B  C  D  E  F  G  H");
        }

        public void changeCellsAfterMove(int xCoordinate, int yCoordinate)
        {
            chessBoard[xCoordinate, yCoordinate] = 9;

            if ((xCoordinate - 1) >= 0 && (xCoordinate - 1) < 8)
            {
                if ((yCoordinate - 2) >= 0 && (yCoordinate - 2) < 8)
                {
                    if (chessBoard[(xCoordinate - 1), (yCoordinate - 2)] != 9)
                        chessBoard[(xCoordinate - 1), (yCoordinate - 2)] = chessBoard[(xCoordinate - 1), (yCoordinate - 2)] - 1;
                }
            }
            if ((xCoordinate - 1) >= 0 && (xCoordinate - 1) < 8)
            {
                if ((yCoordinate + 2) >= 0 && (yCoordinate + 2) < 8)
                {
                    if (chessBoard[(xCoordinate - 1), (yCoordinate + 2)] != 9)
                        chessBoard[(xCoordinate - 1), (yCoordinate + 2)] = chessBoard[(xCoordinate - 1), (yCoordinate + 2)] - 1;
                }
            }
            if ((xCoordinate - 2) >= 0 && (xCoordinate - 2) < 8)
            {
                if ((yCoordinate - 1) >= 0 && (yCoordinate - 1) < 8)
                {
                    if (chessBoard[(xCoordinate - 2), (yCoordinate - 1)] != 9)
                        chessBoard[(xCoordinate - 2), (yCoordinate - 1)] = chessBoard[(xCoordinate - 2), (yCoordinate - 1)] - 1;
                }
            }
            if ((xCoordinate - 2) >= 0 && (xCoordinate - 2) < 8)
            {
                if ((yCoordinate + 1) >= 0 && (yCoordinate + 1) < 8)
                {
                    if (chessBoard[(xCoordinate - 2), (yCoordinate + 1)] != 9)
                        chessBoard[(xCoordinate - 2), (yCoordinate + 1)] = chessBoard[(xCoordinate - 2), (yCoordinate + 1)] - 1;
                }
            }
            if ((xCoordinate + 1) >= 0 && (xCoordinate + 1) < 8)
            {
                if ((yCoordinate - 2) >= 0 && (yCoordinate - 2) < 8)
                {
                    if (chessBoard[(xCoordinate + 1), (yCoordinate - 2)] != 9)
                        chessBoard[(xCoordinate + 1), (yCoordinate - 2)] = chessBoard[(xCoordinate + 1), (yCoordinate - 2)] - 1;
                }
            }
            if ((xCoordinate + 1) >= 0 && (xCoordinate + 1) < 8)
            {
                if ((yCoordinate + 2) >= 0 && (yCoordinate + 2) < 8)
                {
                    if (chessBoard[(xCoordinate + 1), (yCoordinate + 2)] != 9)
                        chessBoard[(xCoordinate + 1), (yCoordinate + 2)] = chessBoard[(xCoordinate + 1), (yCoordinate + 2)] - 1;
                }
            }
            if ((xCoordinate + 2) >= 0 && (xCoordinate + 2) < 8)
            {
                if ((yCoordinate - 1) >= 0 && (yCoordinate - 1) < 8)
                {
                    if (chessBoard[(xCoordinate + 2), (yCoordinate - 1)] != 9)
                        chessBoard[(xCoordinate + 2), (yCoordinate - 1)] = chessBoard[(xCoordinate + 2), (yCoordinate - 1)] - 1;
                }
            }
            if ((xCoordinate + 2) >= 0 && (xCoordinate + 2) < 8)
            {
                if ((yCoordinate + 1) >= 0 && (yCoordinate + 1) < 8)
                {
                    if (chessBoard[(xCoordinate + 2), (yCoordinate + 1)] != 9)
                        chessBoard[(xCoordinate + 2), (yCoordinate + 1)] = chessBoard[(xCoordinate + 2), (yCoordinate + 1)] - 1;
                }
            }
        }
    }
}
