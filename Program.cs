﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            int[] oldNUmbers = { 1, 2, 3, 4, 5 };
            int number = oldNUmbers[2];
            Console.WriteLine(number);
            int i = 0;
            for(;i < 5; i++)
            {
                Console.WriteLine(oldNUmbers[i]);
            }
            while (i < 5)
            {
                Console.WriteLine(oldNUmbers[i]);
                //Console.WriteLine("\n");
                i += 1;
            }
            i = 0;
            do
            {
                Console.WriteLine(oldNUmbers[i]);
                i += 1;
            } while (oldNUmbers[i] > 4);
            Console.ReadKey();
            //Console.ReadKey();
        }
    }
}
