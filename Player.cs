using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    public class Player : Field
    {
        public static char PlayerSymbol = 'Q';
        public static void DrawPlayer()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(PlayerSymbol);
        }
    }
}