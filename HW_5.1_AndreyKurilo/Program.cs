using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Программа рассчитывает сколько гостей можно накормить шашлыком 
 из доступного мяса*/ 

namespace HW_5._1_AndreyKurilo
{
    class Program
    {        
        static void Main()
        {
            uint meatWeight = MeatInPresence();
            uint guestsNumber = ArrivalsGuests();

            List<MeatPiece> meatsPieces = new List<MeatPiece>();
            
            for (uint i = 0; i < meatWeight; i += MeatPiece.MeatPieceWeight)
            {
                var piece = new MeatPiece();
                meatsPieces.Add(piece);
                Console.WriteLine($"{meatsPieces.Count} meats pieces created");
            }

            List<Skewer> skewers = new List<Skewer>();
                        
            for (uint j = 0; j < meatsPieces.Count; j += Skewer.PiecesOnSkewer)
            {                             
                    var skewer = new Skewer();
                    skewers.Add(skewer);
                    Console.WriteLine($"{skewers.Count} skewers created");
                
                if ((skewers.Count % Guest.SkewerForGuest) == 0)                
                    Console.WriteLine($"{skewers.Count / Guest.SkewerForGuest} guest fed");
                if (skewers.Count / Guest.SkewerForGuest == guestsNumber)                                    
                    break;                                
            }

            if (guestsNumber > skewers.Count / Guest.SkewerForGuest)
                Console.WriteLine($"{guestsNumber - skewers.Count / Guest.SkewerForGuest} is/are left hungry");
        }

        private static uint MeatInPresence()
        {
            Console.Write("Input weight of meat (grammes) in presence ");
            uint meatWeight = Convert.ToUInt32(Console.ReadLine());

            return meatWeight;
        }

        private static uint ArrivalsGuests()
        {
            Console.Write("Input number of guests ");
            uint guestsNumber = Convert.ToUInt32(Console.ReadLine());
            while (guestsNumber < 0)
            {
                Console.Write("Input number of guests ");
                guestsNumber = Convert.ToUInt32(Console.ReadLine());
            }
            return guestsNumber;
        }
    }

}
