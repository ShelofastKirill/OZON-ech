using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int kol = Convert.ToInt32(Console.ReadLine());
                int[] otvet = new int[kol];
                for(int x = 0; x < kol; x++)
                {
                    otvet[x] = x+1;
                }
                string s = Console.ReadLine();
                string[] str = s.Split(',');
                if (str.Length == 0)
                {
                    str[0] = s;
                }
                for(int j = 0; j < str.Length; j++)
                {
                    bool b = true;
                    for(int k = 0; k < str[j].Length; k++)
                    {
                        if (str[j][k] == '-')
                        {
                            string[] tire = str[j].Split('-');
                            for(int l = Convert.ToInt32(tire[0]); l <= Convert.ToInt32(tire[1]); l++)
                            {
                                otvet[l-1] = -1;
                            }
                            b = false;
                            break;
                        }
                    }
                    if (b)
                    {
                        otvet[Convert.ToInt32(str[j])-1] = -1;
                    }
                }
                //====================================================
                int left = 0;
                int right = 0;
                string o = "";
                while (left < kol)
                {
                    right = left;
                    int sum = 0;
                    while (right <= kol - 1 && otvet[right] != -1)
                    {
                        right++;
                        sum++;
                    }
                    if (otvet[left] != -1)
                    {
                        if (sum <= 1)
                        {
                            o = o + otvet[left] + ",";
                        }
                        else
                        {
                            o = o + otvet[left] + "-" + otvet[right - 1] + ",";
                        }
                    }
                    left = right + 1;
                }
                o = o.TrimEnd(',');
                Console.WriteLine(o);
                //====================================================
            }
        }
    }
}
