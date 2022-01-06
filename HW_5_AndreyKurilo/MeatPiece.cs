using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_AndreyKurilo
{
    public class MeatPiece
    {
        private uint weight;

        public MeatPiece(uint weight)
        {
           this.weight = weight;
        }

        public uint GetWeight()
        {
            return weight;
        }
    }
}
