﻿using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("введите имя ");
            String Name1 = Console.ReadLine();
            Console.WriteLine($"Привет {Name1}");
            Console.ReadKey();
        }
    }
}
