using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    public class Field : Element
    {
        static double doubleValueWidth = fieldWidth + 0.2 * fieldWidth;
        static int WindowSizeWidth = Convert.ToInt32(doubleValueWidth);
        static double doubleValueHeight = fieldHeight + 0.2 * fieldHeight;
        static int WindowSizeHeight = Convert.ToInt32(doubleValueHeight);
        

        //вывод поля
        public static char[,] FieldArray { get; private set; }


        public static void DrawField()
        {
            Console.SetWindowSize(WindowSizeWidth, WindowSizeHeight);

            FieldArray = new char[fieldHeight, fieldWidth];

            // Заполнение поля

            for (int y = 0; y < fieldHeight; y++)
            {
                for (int x = 0; x < fieldWidth; x++)
                {
                    if (x == 0 || x == fieldWidth - 1 || y == 0 || y == fieldHeight - 1)
                    {
                        FieldArray[y, x] = Wall.WallSymbol;
                    }
                    else
                    {
                        FieldArray[y, x] = ' ';
                    }
                }
            }


            // вывод поля

            for (int y = 0; y < fieldHeight; y++)
            {
                for (int x = 0; x < fieldWidth; x++)
                {
                    Console.Write(FieldArray[y, x]);
                }
                Console.WriteLine();
            }

            FieldArray[10, 10] = Wall.WallSymbol;
            Console.SetCursorPosition(10, 10);
            Console.Write(Wall.WallSymbol);
        }
    }
}