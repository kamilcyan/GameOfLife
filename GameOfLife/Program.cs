using System;

namespace GameOfLife
{
    class Program
    {
        public int gridWidth = 50;
        public int gridHeight = 20;
        public int iteracja = 0;
        static void Main(string[] args)
        {
            Program prog = new Program();
            bool[,] table = prog.Table();

            table[0, 0] = true;
            table[10, 10] = true;
            table[10, 11] = true;
            table[11, 10] = true;
            table[11, 11] = true;


            prog.Draw(table);

            Console.ReadLine();
        }

        public void Rozmnazaj()
        {
            iteracja++;


        }

        public bool[,] Table()
        {

            var grid = new bool[gridHeight, gridWidth];

            for(int i = 0; i < gridHeight; i++)
            {
                for(int j = 0; j < gridWidth; j++)
                {
                    grid[i, j] = false;
                }
            }

            return grid;
        }

        public void Draw(bool[,] table)
        {
            int iloscSasiadow = 0; 

            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    if (table[i, j] == false)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");

                    }
                }
                Console.Write("\n");
            }

            iloscSasiadow += neigbourCheck(10, 11, neigbourCheckTable(table));
            Console.WriteLine("Neigbours: " + iloscSasiadow);
        }

        public char[,] neigbourCheckTable(bool[,] table)
        {

            var tablicaSpr = new char[gridHeight, gridWidth];

            for (int a = 0; a < gridHeight; a++)
            {
                for (int b = 0; b < gridWidth; b++)
                {
                    if (table[a, b] == false)
                    {
                        tablicaSpr[a, b] = '-';
                    }
                    else
                    {
                        tablicaSpr[a, b] = 't';
                    }
                }
            }

            return tablicaSpr;
        }

        public int neigbourCheck(int a, int b, char[,] table)
        {
            int neigbour = 0;

            if (table[a + 1, b] == 't' && table[a + 1, b] != 's')
            {
                neigbour++;
                table[a + 1, b] = 's';
            }
            if (a == 0)
            {
                a = 1;
                if (table[a - 1, b] == 't' && table[a - 1, b] != 's')
                {
                    neigbour++;
                    table[a - 1, b] = 's';
                }
            }
            else
            {
                if (table[a - 1, b] == 't' && table[a - 1, b] != 's')
                {
                    neigbour++;
                    table[a - 1, b] = 's';
                }
            }
            if (b == gridWidth - 1)
            {
                b = gridWidth - 2;
                if (table[a, b + 1] == 't' && table[a, b + 1] != 's')
                {
                    neigbour++;
                    table[a, b + 1] = 's';
                }
            }
            else
            {
                if (table[a, b + 1] == 't' && table[a, b + 1] != 's')
                {
                    neigbour++;
                    table[a, b + 1] = 's';
                }
            }
            if (b == 0)
            {
                b = 1;
                if (table[a, b - 1] == 't' && table[a, b - 1] != 's')
                {
                    neigbour++;
                    table[a, b - 1] = 's';
                }
            }
            else
            {
                if (table[a, b - 1] == 't' && table[a, b - 1] != 's')
                {
                    neigbour++;
                    table[a, b - 1] = 's';
                }
            }
            if (a == gridHeight - 1)
            {
                a = gridHeight - 2;
                if (b == gridWidth - 1)
                {
                    b = gridWidth - 2;
                    if (table[a + 1, b + 1] == 't' && table[a + 1, b + 1] != 's')
                    {
                        neigbour++;
                        table[a + 1, b + 1] = 's';
                    }
                }
                else
                {
                    if (table[a + 1, b + 1] == 't' && table[a + 1, b + 1] != 's')
                    {
                        neigbour++;
                        table[a + 1, b + 1] = 's';
                    }
                }
            }
            else if (b == gridWidth - 1)
            {
                b = gridWidth - 2;
                if (table[a + 1, b + 1] == 't' && table[a + 1, b + 1] != 's')
                {
                    neigbour++;
                    table[a + 1, b + 1] = 's';
                }
            }
            else
            {
                if (table[a + 1, b + 1] == 't' && table[a + 1, b + 1] != 's')
                {
                    neigbour++;
                    table[a + 1, b + 1] = 's';
                }
            }
            if (a == gridHeight - 1)
            {
                a = gridHeight - 2;
                if (b == 0)
                {
                    b = 1;
                    if (table[a + 1, b - 1] == 't' && table[a + 1, b - 1] != 's')
                    {
                        neigbour++;
                        table[a + 1, b - 1] = 's';
                    }
                }
            }
            else
            {
                if (b == 0)
                {
                    b = 1;
                    if (table[a + 1, b - 1] == 't' && table[a + 1, b - 1] != 's')
                    {
                        neigbour++;
                        table[a + 1, b - 1] = 's';
                    }
                }
            }
            if (a == 0)
            {
                a = 1;
                if (b == 0)
                {
                    b = 1;
                    if (table[a - 1, b - 1] == 't' && table[a - 1, b - 1] != 's')
                    {
                        neigbour++;
                        table[a - 1, b - 1] = 's';
                    }
                }
            }else if (b == 0)
            {
                b = 1;
                if (table[a - 1, b - 1] == 't' && table[a - 1, b - 1] != 's')
                {
                    neigbour++;
                    table[a - 1, b - 1] = 's';
                }
            }
            else
            {
                if (table[a - 1, b - 1] == 't' && table[a - 1, b - 1] != 's')
                {
                    neigbour++;
                    table[a - 1, b - 1] = 's';
                }
            }
            if (a == 0)
            {
                a = 1;
                if (b == gridWidth - 1)
                {
                    b = gridWidth - 2;
                    if (table[a - 1, b + 1] == 't' && table[a - 1, b + 1] != 's')
                    {
                        neigbour++;
                        table[a - 1, b + 1] = 's';
                    }
                }
            }else if (b == gridWidth - 1)
            {
                b = gridWidth - 2;
                if (table[a - 1, b + 1] == 't' && table[a - 1, b + 1] != 's')
                {
                    neigbour++;
                    table[a - 1, b + 1] = 's';
                }
            }
            else
            {
                if (table[a - 1, b + 1] == 't' && table[a - 1, b + 1] != 's')
                {
                    neigbour++;
                    table[a - 1, b + 1] = 's';
                }
            }

            return neigbour;
        }
    }

}
