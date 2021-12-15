using System;
class Program
{
    static void Main()
    {
        //Создаем две переменных для хранения двух чисел и вводим их через консоль
        int a, b;
        Console.Write("Введите число a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите число b: ");
        b = int.Parse(Console.ReadLine());
        int i;
        int ob = 0;
        //Создаем цикл, который будет искать значения от 2 до максимального числа (a или d)
        //Внутри цикла ставим условие, чтобы при деление на это число, не было остатка
        for (i = 2; i < System.Math.Max(a, b); i++)
            if ((a % i == 0) && (b % i == 0))
            {
                ob = i;
                break;
            }
        //Если число в цикле было найдено (по условию что два числа на него деляться без остатка) - в консоль выводится ответ
        //Если не было найдено - ответ не выводится
        if (ob != 0)
            Console.WriteLine("Наименьший общий делитель: " + ob);
        else
            Console.WriteLine("Наименьшего общего делителя нет.");
        Console.ReadKey();
    }
}