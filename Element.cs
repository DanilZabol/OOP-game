using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    public class Element
    {
        public static int fieldWidth = 40;
        public static int fieldHeight = 20;
        public static int playerX = 1;
        public static int playerY = 1;
        public static int arrowDistance = 1;
        public static int arrowX = playerX;
        public static int arrowY = playerY - arrowDistance;
        public static bool BoolArrow = false;
        public static int PrizeCounter = 0;
        public static bool BoolPrize = false;
        public static bool BoolExit = false;


        public static List<int> arrowFullPath = new List<int>();

    }
}