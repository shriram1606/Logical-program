﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;

            Console.Write("enter the limit :");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            for(i=0;i<=count;i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
