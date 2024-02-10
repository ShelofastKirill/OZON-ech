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
            string[] s = new string[n];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();
                int j = 0;
                string otvet = "";
                while (j < s[i].Length)
                {
                    if ((s[i][j] >= 'A' && s[i][j] <= 'Z') && (j + 1 < s[i].Length && s[i][j + 1] >= '0' && s[i][j + 1] <= '9') && (j + 2 < s[i].Length && s[i][j + 2] >= '0' && s[i][j + 2] <= '9') && (j + 3 < s[i].Length && s[i][j + 3] >= 'A' && s[i][j + 3] <= 'Z') && (j + 4 < s[i].Length && s[i][j + 4] >= 'A' && s[i][j + 4] <= 'Z'))
                    {
                        if (j + 4 < s[i].Length)
                            otvet = otvet + s[i][j] + s[i][j + 1] + s[i][j + 2] + s[i][j + 3] + s[i][j + 4] + " ";
                        j += 5;
                    }
                    else if ((s[i][j] >= 'A' && s[i][j] <= 'Z') && (j + 1 < s[i].Length && s[i][j + 1] >= '0' && s[i][j + 1] <= '9') && (j + 2 < s[i].Length && s[i][j + 2] >= 'A' && s[i][j + 2] <= 'Z') && (j + 3 < s[i].Length && s[i][j + 3] >= 'A' && s[i][j + 3] <= 'Z'))
                    {
                        if (j + 3 < s[i].Length)
                            otvet = otvet + s[i][j] + s[i][j + 1] + s[i][j + 2] + s[i][j + 3] + " ";
                        j += 4;
                    }
                    else
                    {
                        otvet = "-";
                        break;
                    }
                }
                Console.WriteLine(otvet);
            }
        }
    }
}
