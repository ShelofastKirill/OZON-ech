using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[m];
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    arr[j] = Convert.ToInt32(input[j]);
                }
                //======================================================
                List<int> otvet = new List<int>();
                int l = 0;
                int r = 0;
                while (l < arr.Length)
                {
                    r = l;
                    int s = 0;
                    int x = 0;
                    bool b = true;
                    otvet.Add(arr[l]);
                    while (r + 1 < arr.Length && arr[l] == arr[r + 1] + x + 1)
                    {
                        s--;
                        x++;
                        r++;
                        b = false;
                    }
                    if (b)
                    {
                        while (r + 1 < arr.Length && arr[l] == arr[r + 1] + x - 1)
                        {
                            s++;
                            x--;
                            r++;
                        }
                    }
                    otvet.Add(s);
                    l = r+1;
                }
                //======================================================
                Console.WriteLine(otvet.Count);
                for (int jj = 0; jj < otvet.Count; jj++)
                {
                    Console.WriteLine(otvet[jj]);
                }
            }
        }
    }
}
