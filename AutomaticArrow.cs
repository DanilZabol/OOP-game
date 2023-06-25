using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace OOPreb
{
    public class AutomaticArrow : Arrow
    {
        public static int automaticArrowX;
        public static int automaticArrowY;

        //метод который считает путь
        public static int[] MoveElement(int playerX, int playerY, int arrowX, int arrowY)
        {
            int dx = arrowX - playerX;
            int dy = arrowY - playerY;


            int stepX = Math.Sign(dx);
            int stepY = Math.Sign(dy);

            int steps = Math.Max(Math.Abs(arrowX - playerX), Math.Abs(arrowY - playerY)) + 1; // Общее количество шагов

            int[] arrowPath = new int[steps * 2]; // Массив для хранения изменений координат

            int currentX = playerX;
            int currentY = playerY;

            for (int i = 0; i < steps; i++)
            {
                currentX += dx;
                currentY += dy;

                arrowPath[i * 2] = dx;
                arrowPath[i * 2 + 1] = dy;
            }

            return arrowPath;
        }

        public static void DrawArrowPath(int[] arrowPath, int automaticArrowX, int automaticArrowY)
        {
            arrowFullPath.Clear();

            automaticArrowX = playerX;
            automaticArrowY = playerY;


            while (FieldArray[automaticArrowY, automaticArrowX] != Wall.WallSymbol)
            {
                for (int i = 0; i < arrowPath.Length; i+=2)
                {
                    automaticArrowX += arrowPath[i];
                    automaticArrowY += arrowPath[i + 1];
                    if (FieldArray[automaticArrowY, automaticArrowX] != Wall.WallSymbol)
                    {
                        Console.SetCursorPosition(automaticArrowX, automaticArrowY);
                        Console.Write("*");

                        arrowFullPath.Add(arrowPath[i]);
                        arrowFullPath.Add(arrowPath[i + 1]);


                        Thread.Sleep(80);
                    }
                    else break;
                    Prize.DrawPrize();
                    Exit.DrawExit();
                }
            }
        }
    }
}