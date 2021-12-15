using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем массив чисел, и необходимые переменные
            var arr = new int[] { 1, 12, 34, 7, 71, 52, 678, 7, 81, 92, 4, 45 };
            int count = 0;
            string temp;

            // Создаем цикл для каждого елемента массива
            for (int i = 0; i < arr.Length; i++)
            {
                //Каждый елемент массива переводим в строку, для сравнения каждого символа внутри строки
                temp = arr[i].ToString();
                if (temp.Length > 1)
                {
                    // Создаем вложенный цикл, где проверяем каждую последующую цифру (чтобы она была на 1 больше)
                    for (int j=1; j< temp.Length;j++)
                    {
                        int oldNumber = Convert.ToInt32(temp[j-1]);
                        int number = Convert.ToInt32(temp[j]);
                        if (number != oldNumber + 1) break;
                        if (number == temp[temp.Length-1]) count++;
                    }
                }
            }
            // Выводи на консоль колличество числе, где цифры идут по возрастающей
            Console.WriteLine(count + " штуки");
        }
    }
}
