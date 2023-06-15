using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    class Player : Field
    {
        //метод, рисующий игрока
        public static void DrawPlayer()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("Ь");
        }

        /*static void Arrow()
        {
            int arrowX = playerX;
            int arrowY = playerY - 2;
            Console.SetCursorPosition(arrowX, arrowY);
            Console.Write("@");
        }*/

    }
}