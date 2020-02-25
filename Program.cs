using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class Program
    {
        static void Main(string[] args)
        {       

            Console.WriteLine("Program for create matrix!");
            int width = 0, height = 0;
            Console.Write("Enter Height :");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter Width :");
            width = int.Parse(Console.ReadLine());


            StringBuilder sb = new StringBuilder();
            StringBuilder sbMatrix = new StringBuilder();
            sb.Append(" -");
            for (int i = 1; i <= width * 6; i++)
            {
                sb.Append("-");
            }
            Console.WriteLine(sb.ToString());
            sbMatrix.Append(sb.ToString() + "\n");
            int[,] igrid = new int[width, height];
            String[,] gridVal = new string[width, height];

            for (int y = 0; y < height; y++)
            {
                sbMatrix.Append(" | ");
                Console.Write(" | "); //prints at border place                 
                for (int x = 0; x < width; x++)
                {
                    igrid[x, y] = x * y;
                    gridVal[x, y] = ("" + x + "," + y + "").ToString();
                    Console.Write("" + x + "," + y + "");
                    sbMatrix.Append("" + x + "," + y + "");
                    Console.Write(" | "); //prints inside other than border    
                    sbMatrix.Append(" | ");
                }
                sbMatrix.Append("\n");
                Console.WriteLine();
                Console.WriteLine(sb.ToString());               
                sbMatrix.Append(sb.ToString() + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("Press commands!");

            int playerX = 0; //horizontal coordinate
            int playerY = 0; //vertical coordinate

            bool isTrue = false;

            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            if (!Char.IsNumber(key.KeyChar) || key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Non-numeric input"); return;
            }
            do
            {
                //key = Console.ReadKey(true);                
                int keyVal = int.Parse(key.KeyChar.ToString());
                switch (keyVal)
                {
                    case 0:
                        //if (playerY > 0) //quit simulation and print results to stout
                        //    playerY--;
                        System.Environment.Exit(0);
                        break;
                    case 1:  //move forward one step
                        if (playerX < gridVal.GetLength(1) - 1)
                            playerX++;
                        break;
                    case 2:  //move backwards one step
                        if (playerY < gridVal.GetLength(0) - 1)
                            playerY++;
                        break;
                    case 3:  //Rotate clockwise 90 degrees (eg north to east)
                             //if (playerY < gridVal.GetLength(0) - 1)
                             //    playerY++;
                        if (playerY > 0)
                            playerY--;
                        break;
                    case 4:  //Rotate counterclockwise 90 degrees (eg west to south)
                        if (playerX > 0)
                            playerX--;
                        //if (playerY > 0)
                        //    playerY--;
                        break;
                }
                Console.Clear(); //clear console to redraw field                             
                StringBuilder sbMatrixF = new StringBuilder();
                int widthNew = 0, heightNew = 0;

                for (heightNew = 0; heightNew < gridVal.GetLength(1); heightNew++)
                {
                    widthNew = 0;
                    for (widthNew = 0; widthNew < gridVal.GetLength(0); widthNew++)
                    {
                        Console.Write(gridVal[widthNew, heightNew] + "  "); //draw place                      

                        sbMatrixF.Append(gridVal[widthNew, heightNew] + "\t");
                    }
                    Console.WriteLine();
                }
                if (isTrue == false)
                {
                    Console.SetCursorPosition(((widthNew) * 5) - ((playerX) * 5), heightNew - 1 - playerY);
                    isTrue = true;
                }
                else
                {
                    Console.SetCursorPosition(((widthNew - 1) * 5) - (playerX * 5), heightNew - 1 - playerY);
                }
                key = Console.ReadKey(true); //read new key
            }
            while (key.Key != ConsoleKey.Enter); // Stops Receving Keys Once Enter is Pressed            
            Console.ReadKey();
        }
    }
}
