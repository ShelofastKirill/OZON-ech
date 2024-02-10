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
            for(int i = 0; i < n; i++)
            {
                int tmin = 15;
                int tmax = 30;
                bool b = true;
                int n2= Convert.ToInt32(Console.ReadLine());
                for(int i2 = 0;i2 < n2; i2++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    if (input[0]=="<=" && Convert.ToInt32(input[1])<=tmax && Convert.ToInt32(input[1]) >= tmin)
                    {
                        tmax = Convert.ToInt32(input[1]);
                    }
                    else if(input[0] == ">=" && Convert.ToInt32(input[1]) >= tmin && Convert.ToInt32(input[1])<=tmax)
                    {
                        tmin = Convert.ToInt32(input[1]);
                    }else if (input[0] == ">=" && Convert.ToInt32(input[1]) >= tmax)
                    {
                        b=false;
                    }else if (input[0] == "<=" && Convert.ToInt32(input[1]) <= tmin)
                    {
                        b=false;
                    }
                    if (b)
                    {
                        Console.WriteLine(tmin);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
            }
        }
    }
}
