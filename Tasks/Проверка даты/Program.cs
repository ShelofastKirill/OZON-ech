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
            int[,] arr = new int[n, 3];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                }
            }
            int[] months = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for(int i = 0; i < n; i++)
            {
                if (arr[i, 2] % 4 == 0 && (arr[i, 2] % 100 != 0 || arr[i, 2] % 400 == 0) && arr[i, 1] == 2 && arr[i, 0] <= 29)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    if (arr[i, 0] <= months[arr[i, 1] - 1])
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
}
