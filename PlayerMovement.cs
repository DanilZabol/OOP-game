using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    internal class PlayerMovement : AutomaticArrow
    {
        public static void DrawPlayerMovement()
        {
            if (arrowFullPath.Count == 0)
            {
                return;
            }

            Console.SetCursorPosition(playerX, playerY);
            Console.Write(" ");

            playerX += arrowFullPath[0];
            playerY += arrowFullPath[1];

            Console.SetCursorPosition(playerX, playerY);
            Console.Write(PlayerSymbol);

            arrowFullPath.RemoveAt(0);
            arrowFullPath.RemoveAt(0);
        }
    }
}
