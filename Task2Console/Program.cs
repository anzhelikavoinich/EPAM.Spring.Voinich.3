﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 255;
            Console.WriteLine(num.GetHexadecimalNotation());
            Console.ReadKey();
        }
    }
}
