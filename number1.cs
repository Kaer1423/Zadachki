﻿using System;
class Program
{
    static void Main()
    {
        int a, b;
        Console.Write("Введите число a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите число b: ");
        b = int.Parse(Console.ReadLine());
        int i;
        int ob = 0;
        for (i = 2; i < System.Math.Max(a, b); i++)
            if ((a % i == 0) && (b % i == 0))
            {
                ob = i;
                break;
            }
        if (ob != 0)
            Console.WriteLine("Наименьший общий делитель: " + ob);
        else
            Console.WriteLine("Наименьшего общего делителя нет.");
        Console.ReadKey();
    }
}