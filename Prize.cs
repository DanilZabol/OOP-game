using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    internal class Prize : Field
    {
        public static int PrizeX = 1;
        public static int PrizeY = 5;
        public static char PrizeSymbol = '$';

        public static void DrawPrize()
        {
            if (PrizeX == Player.playerY && PrizeY == Player.playerX)
            {
                BoolPrize = true;
                PrizeCounter++;

                FieldArray[PrizeY, PrizeX] = ' ';

                Console.SetCursorPosition(2, fieldHeight + 1);
                Console.WriteLine("Кiлькiсть монеток: " + Prize.PrizeCounter);
                return;
            }
            if (BoolPrize == false)
            {
                Console.SetCursorPosition(PrizeY, PrizeX);
                Console.Write(PrizeSymbol);

            }

            Console.SetCursorPosition(2, fieldHeight + 1);
            Console.WriteLine("Кiлькiсть монеток: " + Prize.PrizeCounter);
        }

        public static void DrawPrizeCounter()
        {

            Console.SetCursorPosition(2, fieldHeight + 1);
            Console.WriteLine("Кiлькiсть монеток: " + Prize.PrizeCounter);
        }
    }
}
