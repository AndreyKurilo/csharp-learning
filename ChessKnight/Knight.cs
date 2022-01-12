using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChessKnight
{
    class Knight
    {
        private int xCoordinate;
        private int yCoordinate;
        private int nextX;
        private int nextY;


        public Knight() { }
        public Knight(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }

        public void set_x_Coordinate(char xCoordinate)
        {
            switch (xCoordinate)
            {
                case 'A':
                    this.xCoordinate = 0;
                    break;
                case 'B':
                    this.xCoordinate = 1;
                    break;
                case 'C':
                    this.xCoordinate = 2;
                    break;
                case 'D':
                    this.xCoordinate = 3;
                    break;
                case 'E':
                    this.xCoordinate = 4;
                    break;
                case 'F':
                    this.xCoordinate = 5;
                    break;
                case 'G':
                    this.xCoordinate = 6;
                    break;
                case 'H':
                    this.xCoordinate = 7;
                    break;
                default:
                    Console.WriteLine("Wrong cell name");
                    break;
            }
        }
        public void set_y_Coordinate(char yCoordinate)
        {
            switch (yCoordinate)
            {
                case '8':
                    this.xCoordinate = 0;
                    break;
                case '7':
                    this.xCoordinate = 1;
                    break;
                case '6':
                    this.xCoordinate = 2;
                    break;
                case '5':
                    this.xCoordinate = 3;
                    break;
                case '4':
                    this.xCoordinate = 4;
                    break;
                case '3':
                    this.xCoordinate = 5;
                    break;
                case '2':
                    this.xCoordinate = 6;
                    break;
                case '1':
                    this.xCoordinate = 7;
                    break;
                default:
                    Console.WriteLine("Wrong cell name");
                    break;
            }
        }

        public void defineStartCell()
        {
            Input input = new Input();
            string startCell = input.getStartCell();            
            set_x_Coordinate(Char.ToUpper(startCell[0]));
            set_y_Coordinate(startCell[1]);
        }

        public void move()
        {
            ChessBoard chessBoard = new ChessBoard();
            nextX = xCoordinate;
            nextY = yCoordinate;
            for (int i = 0; i < 64; i++)
            {
                chessBoard.changeCellsAfterMove(xCoordinate, yCoordinate);
                Console.WriteLine();
                Console.WriteLine("Chess Knight Move № " + (i + 1));
                chessBoard.printChessBoard();
                chooseNextCell(xCoordinate, yCoordinate, chessBoard);
                if (nextX == xCoordinate && nextY == yCoordinate)
                {
                    Console.WriteLine("Total steps: " + (i + 1));
                    if (i == 63) Console.WriteLine("All cells are filled");
                    Console.WriteLine("Knight cannot move");
                    break;
                }
                else
                {
                    xCoordinate = nextX;
                    yCoordinate = nextY;
                    Thread.Sleep(1000);
                }
            }

        }

        private void chooseNextCell(int xCoordinate, int yCoordinate, ChessBoard chessBoard)
        {
            nextX = xCoordinate;
            nextY = yCoordinate;

            if ((xCoordinate - 1) >= 0 && (xCoordinate - 1) < 8)
            {
                if ((yCoordinate - 2) >= 0 && (yCoordinate - 2) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate - 1), (yCoordinate - 2)] != 9)
                    {
                        nextX = xCoordinate - 1;
                        nextY = yCoordinate - 2;
                    }
                }
            }
            if ((xCoordinate - 1) >= 0 && (xCoordinate - 1) < 8)
            {
                if ((yCoordinate + 2) >= 0 && (yCoordinate + 2) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate - 1), (yCoordinate + 2)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate - 1), (yCoordinate + 2)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate - 1;
                            nextY = yCoordinate + 2;
                        }
                    }
                }
            }
            if ((xCoordinate - 2) >= 0 && (xCoordinate - 2) < 8)
            {
                if ((yCoordinate - 1) >= 0 && (yCoordinate - 1) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate - 2), (yCoordinate - 1)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate - 2), (yCoordinate - 1)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate - 2;
                            nextY = yCoordinate - 1;
                        }
                    }
                }
            }
            if ((xCoordinate - 2) >= 0 && (xCoordinate - 2) < 8)
            {
                if ((yCoordinate + 1) >= 0 && (yCoordinate + 1) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate - 2), (yCoordinate + 1)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate - 2), (yCoordinate + 1)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate - 2;
                            nextY = yCoordinate + 1;
                        }
                    }
                }
            }
            if ((xCoordinate + 1) >= 0 && (xCoordinate + 1) < 8)
            {
                if ((yCoordinate - 2) >= 0 && (yCoordinate - 2) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate + 1), (yCoordinate - 2)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate + 1), (yCoordinate - 2)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate + 1;
                            nextY = yCoordinate - 2;
                        }
                    }
                }
            }
            if ((xCoordinate + 1) >= 0 && (xCoordinate + 1) < 8)
            {
                if ((yCoordinate + 2) >= 0 && (yCoordinate + 2) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate + 1), (yCoordinate + 2)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate + 1), (yCoordinate + 2)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate + 1;
                            nextY = yCoordinate + 2;
                        }
                    }
                }
            }
            if ((xCoordinate + 2) >= 0 && (xCoordinate + 2) < 8)
            {
                if ((yCoordinate - 1) >= 0 && (yCoordinate - 1) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate + 2), (yCoordinate - 1)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate + 2), (yCoordinate - 1)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate + 2;
                            nextY = yCoordinate - 1;
                        }
                    }
                }
            }
            if ((xCoordinate + 2) >= 0 && (xCoordinate + 2) < 8)
            {
                if ((yCoordinate + 1) >= 0 && (yCoordinate + 1) < 8)
                {
                    if (chessBoard.getChessBoard()[(xCoordinate + 2), (yCoordinate + 1)] != 9)
                    {
                        if (chessBoard.getChessBoard()[(xCoordinate + 2), (yCoordinate + 1)]
                                < chessBoard.getChessBoard()[nextX, nextY])
                        {
                            nextX = xCoordinate + 2;
                            nextY = yCoordinate + 1;
                        }
                    }
                }
            }
            if (nextX != xCoordinate && nextY != yCoordinate)
                Console.WriteLine("Next move to " + chessBoard.getY(nextY) + chessBoard.getX(nextX));
        }

    }
}
