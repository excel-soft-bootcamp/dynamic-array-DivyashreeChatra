﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicNumberArray _dynamic = new DynamicNumberArray(5);
            _dynamic[0] = 10;
            _dynamic[1] = 20;
            _dynamic[2] = 30;
            _dynamic[3] = 40;
            _dynamic[4] = 50;
            _dynamic[5] = 60;

            int value = _dynamic[5];
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }

}