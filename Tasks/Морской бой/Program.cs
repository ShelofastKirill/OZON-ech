using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, 10];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                }
            }
            for(int i = 0; i < n; i++)
            {
                int count = 0;
                int[] example = { 1, 1, 1, 1, 2, 2, 2, 3, 3, 4 };
                for (int j = 0;j < 10; j++)
                {
                    for(int jj=0; jj<10; jj++)
                    {
                        if (arr[i, j] == example[jj])
                        {
                            example[jj] = -1;
                            count++;
                            break;
                        }
                    }
                }
                if (count==10)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
