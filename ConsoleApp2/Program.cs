using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            ///*
            int[,] table = new int[,]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            //*/
            int wait = 50;
            int threshold = 10;
            int arrayRows = 22;
            int arrayCols = 22;
            int width = 45;
            int height = 23;

            //int[,] table = new int[arrayRows, arrayCols];

            Random rnd = new Random();
            //for (int i = 0; i < arrayRows; i++)
            //{
            //    for (int j = 0; j < arrayCols; j++)
            //    {
            //        table[i, j] = rnd.Next(0, 2);

            //    }
            //}

            int[,] tableTemp = new int[arrayRows, arrayCols];

            int[,] tableNext = new int[arrayRows, arrayCols];


            int sum = 0;
            int screensum = 0;
            int repeatedscreensum = 0;
            int index = 0;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;

            //for (int i = 0; i < 500; i++)
            while (true)
            {
                for (int b = 0; b < arrayRows; b++)
                {
                    for (int k = 0; k < arrayCols; k++)
                    {
                        screensum += table[b, k];
                        if (table[b, k] == 1)
                        {
                            Console.Write(" O");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                        
                        for (int z = -1; z < 2; z++)
                        {
                            for (int f = -1; f < 2; f++)
                            {
                                int col = (b + z + arrayRows) % arrayCols;
                                int row = (k + f + arrayRows) % arrayCols;

                                sum += table[col,row];
                                
                            }
                        }
                        sum -= table[b, k];

                        if (table[b,k] == 0 && sum == 3)
                        {
                            tableNext[b,k] = 1;
                        }
                        else if (table[b,k] == 1 && (sum < 2 || sum > 3))
                        {
                            tableNext[b,k] = 0;
                        }
                        else
                        {
                            tableNext[b, k] = table[b, k];
                        }
                        sum = 0;
                        
                    }
                    
                    Console.WriteLine();
                    
                }
                //Console.WriteLine(screensum);

                System.Threading.Thread.Sleep(wait);

                if (screensum == repeatedscreensum)
                {
                    index += 1;
                    if (index > threshold)
                    {
                        //Random rnd = new Random();
                        for (int i = 0; i < arrayRows; i++)
                        {
                            for (int j = 0; j < arrayCols; j++)
                            {
                                tableNext[i, j] = rnd.Next(0, 2);
                                
                            }
                        }
                        
                    }
                }
                if (screensum != repeatedscreensum)
                {
                    index = 0;
                }
                if (repeatedscreensum != screensum )
                {
                    repeatedscreensum = screensum;
                }

                screensum = 0;
                tableTemp = table;
                table = tableNext;
                tableNext = tableTemp;
                Console.Clear();
            }
            //Console.ReadLine();
        }
    }
}
