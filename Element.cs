using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    internal class Element
    {
        public static int fieldWidth = 40;
        public static int fieldHeight = 20;
        public static int playerX = fieldWidth / 2;
        public static int playerY = fieldHeight / 2;
        public static int arrowDistance = 2;
        public static int arrowX = playerX;
        public static int arrowY = playerY - arrowDistance;
        public static bool BoolArrow = true;
    }
}