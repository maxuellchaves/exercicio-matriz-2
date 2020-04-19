using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(' ');
            int line = int.Parse(vect[0]);
            int column = int.Parse(vect[1]);
            int[,] mat = new int[line, column];

            for( int i = 0; i < line; i++)
            {
                string[] add = Console.ReadLine().Split(' ');

                for(int c = 0; c < column; c++)
                {
                    mat[i, c] = int.Parse(add[c]);
                }

            }

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < line; i++)
            {
                for(int c = 0; c < column; c++)
                {
                    if (mat[i, c] == n)
                    {
                        Console.WriteLine("Position: {0},{1} : ",i,c);
                        if (c > 0)
                        {
                            Console.WriteLine("Left: "+mat[i,c-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: "+mat[i-1,c]);
                        }

                        if (c< column - 1)
                        {
                            Console.WriteLine("Right: "+mat[i,c+1]);
                        }
                        if (i < line - 1)
                        {
                            Console.WriteLine("Down: "+mat[i+1,c]);
                        }

                    }
                }
            }

        }
    }
}
