using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class TestCls
    {
        //Console.WriteLine("Program to Create 4*4 table");
        //int width = 0, height = 0;
        //Console.Write("Enter Height :");
        //height = int.Parse(Console.ReadLine());
        //Console.Write("Enter Width :");
        //width = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= height; i++)
        //{
        //    for (int j = 1; j <= width; j++)
        //    {
        //        if ((i == 1 || i == height) || (j == 1 || j == width))
        //            Console.Write(" * "); //prints at border place                      
        //        else
        //            Console.Write(" * "); //prints inside other than border                   
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();

        ////Console.ReadKey();

        //int player = 0;

        //string[,] grid = new string[4, 4] {{"   ","   ","   ","   "},
        //                                   {"   ","   ","   ","   "},
        //                                   {"   ","   ","   ","   "},
        //                                   {"   ","   ","   ","   "} };


        //string box = System.IO.File.ReadAllText(@"C:\\Users\\viren\\Desktop\\data\\Box.txt");

        //Console.WriteLine(box);
        //Console.ReadLine();

        //while (true)
        //{
        //    Console.WriteLine("Enter Coordinate in 'x,y' Format");
        //    string update = Console.ReadLine();

        //    if (player == 0)
        //    {
        //        string[] coords = update.Split(',');
        //        var x = int.Parse(coords[0]) - 1;
        //        var y = int.Parse(coords[1]) - 1;
        //        grid[x, y] = " X ";
        //        player++;
        //    }
        //    else
        //    {
        //        string[] coords = update.Split(',');
        //        var x = int.Parse(coords[0]) - 1;
        //        var y = int.Parse(coords[1]) - 1;
        //        grid[x, y] = " 0 ";
        //        player--;
        //    }

        //    UpdateGrid(grid, box);
        //}
        
        public static void UpdateGrid(string[,] grid, string box, string box1)
        {
            Console.Clear();

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    box = box.Replace((i + 1) + "," + (j + 1), grid[i, j]);
                }
            }

            // In the case not required as clearning the console default the cursor back to 0,0, but left in 
            // as an example
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(box);
        }
        public void Test(string[] args)
        {
            //DrawSquare(4);
            //Console.ReadLine();

            //int num = 4;//int.Parse(Console.ReadLine());
            //int[,] mat = new int[num, num];
            //SolveMagicSquare(mat, num);
            //Odd(num);

            //int n;
            //Console.Write("Enter order of square: ");
            //int.TryParse(Console.ReadLine(), out n);

            //if (n < 3)
            //{
            //    Console.WriteLine("\nError: n must be greater than 2\n");
            //    //return -1;
            //}

            //List<List<int>> matrix = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    List<int> temp = new List<int>();
            //    for (int j = 0; j < n; j++)
            //    {
            //        temp.Add(0);
            //    }
            //    matrix.Add(temp);
            //}

            //MagicSquare(matrix, n);

            ////Print results

            //PrintMagicSquare(matrix, n);

            //Console.ReadKey();

            ////return 0;
            //Console.ReadLine();


            //DrawBox(5, 5);
            Console.ReadKey();
            //const int matrix_rows = 5;
            //const int matrix_columns = 4;
            //double[,] matrix = new double[matrix_rows, matrix_columns];
            //for (int i = 0; i < matrix_rows; i++)
            //{
            //    for (int j = 0; j < matrix_columns; j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine("-");
            //}
            //Console.ReadKey();
        }
        //static void DrawBox(int w, int h)
        //{
        //    DrawLine(w, '*', '*');
        //    for (int i = 1; i < h - 1; ++i)
        //        DrawLine(w, '*', ' ');
        //    DrawLine(w, '*', '*');
        //}
        //static void DrawLine(int w, char ends, char mids)
        //{
        //    Console.Write(ends);
        //    for (int i = 1; i < w - 1; ++i)
        //        Console.Write(mids);
        //    Console.WriteLine(ends);
        //}



        ////static void OddMagicSquare(List<List<int>> matrix, int n)
        ////{
        ////    int nsqr = n * n;
        ////    int i = 0, j = n / 2; // start position

        ////    for (int k = 1; k <= nsqr; ++k)
        ////    {
        ////        matrix[i][j] = k;
        ////        i--;
        ////        j++;

        ////        if (k % n == 0)
        ////        {
        ////            i += 2;
        ////            j--;
        ////        }
        ////        else if (j == n)
        ////        {
        ////            j -= n;
        ////        }
        ////        else if (i < 0)
        ////        {
        ////            i += n;
        ////        }
        ////    }
        ////}

        ////static void MagicSquare(List<List<int>> matrix, int n)
        ////{
        ////    if (n % 2 == 1) // n is Odd
        ////    {
        ////        OddMagicSquare(matrix, n);
        ////    }
        ////    else if (n % 4 == 0) // doubly even order
        ////    {
        ////        DoublyEvenMagicSquare(matrix, n);
        ////    }
        ////    else // singly even order
        ////    {
        ////        SinglyEvenMagicSquare(matrix, n);
        ////    }
        ////}
        ////static void DoublyEvenMagicSquare(List<List<int>> matrix, int n)
        ////{
        ////    List<List<int>> I = new List<List<int>>();

        ////    for (int k = 0; k < n; k++)
        ////    {
        ////        List<int> temp = new List<int>();
        ////        for (int l = 0; l < n; l++)
        ////        {
        ////            temp.Add(0);
        ////        }
        ////        I.Add(temp);
        ////    }

        ////    List<List<int>> J = new List<List<int>>();

        ////    for (int k = 0; k < n; k++)
        ////    {
        ////        List<int> temp = new List<int>();
        ////        for (int l = 0; l < n; l++)
        ////        {
        ////            temp.Add(0);
        ////        }
        ////        J.Add(temp);
        ////    }

        ////    int i, j;

        ////    //prepare I, J

        ////    int index = 1;
        ////    for (i = 0; i < n; i++)
        ////    {
        ////        for (j = 0; j < n; j++)
        ////        {
        ////            I[i][j] = ((i + 1) % 4) / 2;
        ////            J[j][i] = ((i + 1) % 4) / 2;
        ////            matrix[i][j] = index;
        ////            index++;
        ////        }
        ////    }

        ////    for (i = 0; i < n; i++)
        ////    {
        ////        for (j = 0; j < n; j++)
        ////        {
        ////            if (I[i][j] == J[i][j])
        ////                matrix[i][j] = n * n + 1 - matrix[i][j];
        ////        }
        ////    }
        ////}
        ////static void SinglyEvenMagicSquare(List<List<int>> matrix, int n)
        ////{
        ////    int p = n / 2;

        ////    List<List<int>> M = new List<List<int>>();

        ////    for (int m = 0; m < p; m++)
        ////    {
        ////        List<int> list = new List<int>();
        ////        for (int q = 0; q < p; q++)
        ////        {
        ////            list.Add(0);
        ////        }
        ////        M.Add(list);
        ////    }

        ////    MagicSquare(M, p);

        ////    int i, j, k;

        ////    for (i = 0; i < p; i++)
        ////    {
        ////        for (j = 0; j < p; j++)
        ////        {
        ////            matrix[i][j] = M[i][j];
        ////            matrix[i + p][j] = M[i][j] + 3 * p * p;
        ////            matrix[i][j + p] = M[i][j] + 2 * p * p;
        ////            matrix[i + p][j + p] = M[i][j] + p * p;
        ////        }
        ////    }
        ////    if (n == 2) return;

        ////    List<int> I = new List<int>();
        ////    for (int m = 0; m < p; m++)
        ////    {
        ////        I.Add(0);
        ////    }

        ////    List<int> J = new List<int>();

        ////    for (i = 0; i < p; i++)
        ////    {
        ////        I[i] = i + 1;
        ////    }

        ////    k = (n - 2) / 4;

        ////    for (i = 1; i <= k; i++)
        ////    {
        ////        J.Add(i);
        ////    }

        ////    for (i = n - k + 2; i <= n; i++)
        ////    {
        ////        J.Add(i);
        ////    }

        ////    int temp;

        ////    for (i = 1; i <= p; i++)
        ////    {
        ////        for (j = 1; j <= J.Count; j++)
        ////        {
        ////            temp = matrix[i - 1][J[j - 1] - 1];
        ////            matrix[i - 1][J[j - 1] - 1] = matrix[i + p - 1][J[j - 1] - 1];
        ////            matrix[i + p - 1][J[j - 1] - 1] = temp;
        ////        }

        ////        //j=1, i

        ////        //i=k+1, k+1+p
        ////    }

        ////    i = k;
        ////    j = 0;
        ////    temp = matrix[i][j]; matrix[i][j] = matrix[i + p][j]; matrix[i + p][j] = temp;

        ////    j = i;
        ////    temp = matrix[i + p][j]; matrix[i + p][j] = matrix[i][j]; matrix[i][j] = temp;
        ////}

        ////static void PrintMagicSquare(List<List<int>> matrix, int n)
        ////{
        ////    Console.WriteLine();

        ////    for (int i = 0; i < n; i++)
        ////    {
        ////        for (int j = 0; j < n; j++)
        ////        {
        ////            Console.Write(" {0, 3}", matrix[i][j]);
        ////        }

        ////        Console.WriteLine();
        ////    }

        ////    Console.WriteLine();
        ////}

        //public static void Odd(int n)// odd method
        //{

        //    int[,] magicSquareOdd = new int[n, n];

        //    int i;
        //    int j;
        //    // Initialize position for 1 
        //    i = n / 2;
        //    j = n - 1;

        //    // One by one put all values in magic square 
        //    for (int num = 1; num <= n * n;)
        //    {
        //        if (i == -1 && j == n) //3rd condition 
        //        {
        //            j = n - 2;
        //            i = 0;
        //        }

        //        else
        //        {
        //            //1st condition helper if next number  
        //            // goes to out of square's right side 
        //            if (j == n)
        //                j = 0;
        //            //1st condition helper if next number is  
        //            // goes to out of square's upper side 
        //            if (i < 0)
        //                i = n - 1;
        //        }
        //        //2nd condition 

        //        if (magicSquareOdd[i, j] != 0)
        //        {
        //            j -= 2;
        //            i++;
        //            continue;
        //        }

        //        else
        //        {
        //            //set number 
        //            magicSquareOdd[i, j] = num++;
        //            //1st condition 
        //            j++; i--;
        //        }
        //    }
        //    // print magic square 
        //    Console.WriteLine("The Magic Square for " + n + " is : ");
        //    Console.ReadLine();
        //    for (i = 0; i < n; i++)
        //    {

        //        for (j = 0; j < n; j++)
        //            Console.Write(" " + magicSquareOdd[i, j] + " ");
        //        Console.WriteLine();
        //        Console.ReadLine();
        //    }
        //    Console.WriteLine(" The sum of each row or column is : " + n * (n * n + 1) / 2 + "");
        //    Console.ReadLine();

        //}

        //public static bool SolveMagicSquare(int[,] mat, int num)
        //{
        //    if (num <= 0)
        //    {
        //        return false;
        //    }
        //    for (int i = 0; i < mat.GetLength(0); i++)
        //        for (int j = 0; j < mat.GetLength(1); j++) mat[i, j] = 0;
        //    //i = line , j= column
        //    mat[0, mat.GetLength(1) / 2] = 1;
        //    for (int i = 0, j = mat.GetLength(1) / 2, process = 2; process <= num * num; process++)
        //    {
        //        if ((i - 1) > 0 && j + 1 < mat.GetLength(1) && mat[i - 1, j + 1] == 0)
        //        {
        //            i = i - 1; j = j + 1;
        //            mat[i, j] = process;
        //        }
        //        else if ((i - 1) > 0 && j + 1 < mat.GetLength(1) && mat[i - 1, j + 1] != 0)
        //        {
        //            i = i + 1;
        //            mat[i, j] = process;
        //        }
        //        else if (i == 0 && j == num - 1)
        //        {
        //            i = 1; j = num - 1;
        //            mat[i, j] = process;
        //        }
        //        else
        //        {
        //            if ((i - 1) < 0 && j + 1 < mat.GetLength(1))
        //            {
        //                i = num - 1; j = j + 1;
        //                mat[i, j] = process;
        //            }
        //            else if ((j + 1) == mat.GetLength(1) && (i - 1) > 0 && (i - 1) < mat.GetLength(0))
        //            {
        //                i = i - 1; j = 0;
        //                mat[i, j] = process;
        //            }
        //            else if ((j + 1) == mat.GetLength(1) && (i - 1) == 0)
        //            {
        //                i = 0; j = 0;
        //                mat[i, j] = process;
        //            }
        //            else if ((j + 1) == mat.GetLength(1) && (i - 1) < 0)
        //            {
        //                i = i - 1; j = 0;
        //                mat[i, j] = process;
        //            }
        //            else if (i - 1 < mat.GetLength(0) && j + 1 < mat.GetLength(1) && mat[i - 1, j + 1] != 0)
        //            {
        //                i = i + 1; mat[i, j] = process;
        //            }
        //            else if ((i - 1) == 0 && j + 1 < mat.GetLength(1) && mat[i - 1, j + 1] == 0)
        //            {
        //                i = i - 1; j = j + 1;
        //                mat[i, j] = process;
        //            }
        //        }
        //    }
        //    return true;
        //}

        //public static void DrawSquare(int sideLength)
        //{
        //    for (int row = 1; row <= sideLength; row++)
        //    {
        //        for (int col = 1; col <= sideLength; col++)
        //        {
        //            if (col <= row)
        //                Console.Write('*');
        //            else
        //                Console.Write('#');
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }

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



