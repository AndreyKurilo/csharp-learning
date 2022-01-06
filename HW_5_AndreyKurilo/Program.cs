using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_AndreyKurilo
{
    class Program
    {
        const uint MeatPieceWeight = 25;
        const uint WeightForOneGuest = 250;

        static void Main(string[] args)
        {
            List<MeatPiece> meatsPieces = new List<MeatPiece>();
            List<Skewer> skewers = new List<Skewer>();

            int guestsNumber = GetGuestsCount();

            PopulateMeatPieces(meatsPieces, guestsNumber);
            FillSkewers(meatsPieces, skewers);

            Console.WriteLine("Skewers count: " + skewers.Count);
        }

        private static int GetGuestsCount()
        {
            Console.Write("Input number of guests: ");
            int guestsNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Prepare to cook {guestsNumber * WeightForOneGuest} gramm of meat pieces.");

            return guestsNumber;
        }

        private static void FillSkewers(List<MeatPiece> meatsPieces, List<Skewer> skewers)
        {
            while (meatsPieces.Count > 0)
            {
                Skewer skewer = new Skewer();
                skewers.Add(skewer);

                while (skewer.IsFull() == false)
                {
                    if (meatsPieces.Count > 0)
                    {
                        var meatPiece = meatsPieces.Last();
                        meatsPieces.Remove(meatPiece);
                        skewer.PutOn(meatPiece);
                    }
                }
            }
        }

        private static void PopulateMeatPieces(List<MeatPiece> meatsPieces, int guestsNumber)
        {
            var portion = guestsNumber * WeightForOneGuest / MeatPieceWeight;

            for (int i = 0; i < portion; i++)
            {
                meatsPieces.Add(new MeatPiece(MeatPieceWeight));
            }
        }
    }
}
