using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    class Arrow : Player
    {
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;

            DrawField();
            DrawArrow();
            DrawPlayer();

            if (BoolArrow == true)
            {
                do
                {
                    keyInfo = Console.ReadKey(true);
                    Console.Clear();

                    //int CheckfieldWidth = fieldWidth - 2;
                    //int CheckfieldHeight = fieldHeight - 2;
                    //test
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:
                            if (arrowY != (playerY - arrowDistance) && (arrowX == (playerX - arrowDistance) || arrowX == (playerX + arrowDistance))) arrowY--;
                            break;
                        case ConsoleKey.A:
                            if (arrowX != (playerX - arrowDistance) && (arrowY == (playerY - arrowDistance) || arrowY == (playerY + arrowDistance))) arrowX--;
                            break;
                        case ConsoleKey.S:
                            if (arrowY != (playerY + arrowDistance) && (arrowX == (playerX - arrowDistance) || arrowX == (playerX + arrowDistance))) arrowY++;
                            break;
                        case ConsoleKey.D:
                            if (arrowX != (playerX + arrowDistance) && (arrowY == (playerY - arrowDistance) || arrowY == (playerY + arrowDistance))) arrowX++;
                            break;
                        case ConsoleKey.Spacebar:
                            MovementArrow();
                            break;
                    }

                    DrawField();
                    DrawArrow();
                    DrawPlayer();
                } while (keyInfo.Key != ConsoleKey.Escape);
            }
        }

        static void DrawArrow()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.SetCursorPosition(arrowX, arrowY);

            if (arrowY == (playerY - arrowDistance) && arrowX >= (playerX - (arrowDistance - 1)) && arrowX <= (playerX + (arrowDistance - 1)))
            {
                Console.Write("↑");
            }

            if (arrowY == (playerY - arrowDistance) && arrowX == (playerX - arrowDistance))
            {
                Console.Write('\u005C');  // " \ "
            }

            if (arrowX == (playerX - arrowDistance) && arrowY >= (playerY - (arrowDistance - 1)) && arrowY <= (playerY + (arrowDistance - 1)))
            {
                Console.Write("←");
            }

            if (arrowY == (playerY + arrowDistance) && arrowX == (playerX - arrowDistance))
            {
                Console.Write("/");
            }

            if (arrowY == (playerY + arrowDistance) && arrowX >= (playerX - (arrowDistance - 1)) && arrowX <= (playerX + (arrowDistance - 1)))
            {
                Console.Write("↓");
            }

            if (arrowY == (playerY + arrowDistance) && arrowX == (playerX + arrowDistance))
            {
                Console.Write('\u005C');  // " \ "
            }

            if (arrowX == (playerX + arrowDistance) && arrowY >= (playerY - (arrowDistance - 1)) && arrowY <= (playerY + (arrowDistance - 1)))
            {
                Console.Write("→");
            }

            if (arrowY == (playerY - arrowDistance) && arrowX == (playerX + arrowDistance))
            {
                Console.Write("/");
            }
        }



        static void MovementArrow()
        {
            // новая система координат с центром в игроке
            playerX = 0;
            playerY = 0;
            //arrowX = 


            // условие количества стрелок
            int ArrowCounter = 0;
            if (ArrowCounter > 2)
            {
                BoolArrow = false;
            }


            int nextX = arrowX + 1;
            int nextY = arrowY + 1;


            char[,] field = Field.FieldArray;

            while (true)
            {
                if (field[nextY, nextX] != Wall.WallSymbol)
                {
                    arrowX = nextX;
                    arrowY = nextY;
                }
                else
                {
                    ArrowCounter++;
                    break;
                }
                // Обновление координат элемента
                // ...

                // Отрисовка элемента
                // ...

                // Задержка перед следующим обновлением
                // ...
            }
        }

        /*static bool shoot = false;
        static int arrowX;
        static int arrowY;
        static void ShootArrow()
        {
            arrowX = Program.arrowX;
            arrowY = Program.arrowY - 2;
            shoot = false;
        }

        static void DrawArrow()
        {
            Console.SetCursorPosition(arrowX, arrowY);
            Console.Write("@");
        }

        static void MoveArrow()
        {
            if (arrowY > 1)
                arrowY--;
        }*/
    }
}