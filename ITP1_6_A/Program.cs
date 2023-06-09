﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_6_A
{
    class Program
    {
        static void Main()
        {
            int Input1 = int.Parse(Console.ReadLine());
            string[] Numbers = Console.ReadLine().Split(' ');

            List<int> Input2 = Numbers.Select(n => int.Parse(n)).ToList();

            Input2.Reverse();
            Console.WriteLine("{0}" , string.Join(' ', Input2));
        }
    }
}