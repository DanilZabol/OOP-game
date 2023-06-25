using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    internal class Exit : Field
    {
        public static int ExitX = 10;
        public static int ExitY = 11;
        public static char ExitSymbol = 'O';

        public static void DrawExit()
        {
            if (ExitX == Player.playerY && ExitY == Player.playerX)
            {
                BoolExit = true;

                Console.Clear();
                Console.SetCursorPosition(5, 5);
                Console.Write("гра завершена");

                return;
            }
            if (BoolExit == false)
            {
                Console.SetCursorPosition(ExitY, ExitX);
                Console.Write(ExitSymbol);

            }
        }
    }
}
