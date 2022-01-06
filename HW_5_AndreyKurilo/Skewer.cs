using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_AndreyKurilo
{
    public class Skewer
    {
        private List<MeatPiece> meatPieces;
        private const int Size = 5;

        public Skewer()
        {
            meatPieces = new List<MeatPiece>();
        }

        public void PutOn(MeatPiece meatPiece)
        {
            if (IsFull() == false)
            {
                meatPieces.Add(meatPiece);
            }
        }

        public MeatPiece PutOff()
        {
            var meatPiece = meatPieces.Last();
            meatPieces.Remove(meatPiece);

            return meatPiece;
        }

        public bool IsFull() => meatPieces.Count >= Size;
    }
}
