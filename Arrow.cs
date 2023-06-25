using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    public class Arrow : Player
    {

        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;

            if (Exit.BoolExit == true)
            {
                return;
            }


            DrawField();
            DrawArrow();
            DrawPlayer();
            Prize.DrawPrize();
            Exit.DrawExit();

            do
                {
                    keyInfo = Console.ReadKey(true);
                    int[] arrowPath = AutomaticArrow.MoveElement(Arrow.playerX, Arrow.playerY, arrowX, arrowY);
                    
                    

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:
                        if (BoolArrow == true)
                        {
                            PlayerMovement.DrawPlayerMovement();
                            Prize.DrawPrize();
                            Exit.DrawExit();
                            break;
                        }
                        if (arrowY != (playerY - arrowDistance) && (arrowX == (playerX - arrowDistance) || arrowX == (playerX + arrowDistance))) arrowY--;
                            Console.Clear();
                            DrawField();
                            DrawArrow();
                            DrawPlayer();
                            Prize.DrawPrize();
                            Exit.DrawExit();
                        break;
                        case ConsoleKey.A:
                        if (BoolArrow == true)
                        {
                            break;
                        }
                        if (arrowX != (playerX - arrowDistance) && (arrowY == (playerY - arrowDistance) || arrowY == (playerY + arrowDistance))) arrowX--;
                            Console.Clear();
                            DrawField();
                            DrawArrow();
                            DrawPlayer();
                            Prize.DrawPrize();
                            Exit.DrawExit();
                        break;
                        case ConsoleKey.S:
                        if (BoolArrow == true)
                        {
                            break;
                        }
                        if (arrowY != (playerY + arrowDistance) && (arrowX == (playerX - arrowDistance) || arrowX == (playerX + arrowDistance))) arrowY++;
                            Console.Clear();
                            DrawField();
                            DrawArrow();
                            DrawPlayer();
                            Prize.DrawPrize();
                            Exit.DrawExit();
                        break;
                        case ConsoleKey.D:
                        if (BoolArrow == true)
                        {
                            break;
                        }
                        if (arrowX != (playerX + arrowDistance) && (arrowY == (playerY - arrowDistance) || arrowY == (playerY + arrowDistance))) arrowX++;
                            Console.Clear();
                            DrawField();
                            DrawArrow();
                            DrawPlayer();
                            Prize.DrawPrize();
                            Exit.DrawExit();
                        break;
                        case ConsoleKey.Spacebar:
                        if (BoolArrow == false)
                        {
                            BoolArrow = true;
                            Console.Clear();
                            DrawField();
                            DrawPlayer();
                            AutomaticArrow.DrawArrowPath(arrowPath, AutomaticArrow.automaticArrowX, AutomaticArrow.automaticArrowY);
                            Prize.DrawPrize();
                            Exit.DrawExit();
                            break;
                        } else break;
                        case ConsoleKey.F:
                            arrowX = playerX;
                            arrowY = playerY - arrowDistance;
                            BoolArrow = false;
                            Console.Clear();
                            DrawField();
                            DrawArrow();
                            DrawPlayer();
                            Prize.DrawPrize();
                            Exit.DrawExit();
                        break;
                    } 
                } while (keyInfo.Key != ConsoleKey.Escape);
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
    }
}