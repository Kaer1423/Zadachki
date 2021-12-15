using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем массив чисел и необходимые переменные
            var arr = new int[] { 1, 1, 3, 7, 7, 5, 6, 7, 8, 9, 4, 4 };
            int count = 1;
            int oldCount = 2;
            int result = 0;

            //Создаем цик для каждого елемента массива
            for (int i = 0; i < arr.Length; i++)
            {
                //Внутри цикла начинаем проверку следующего элемента в массиве путем создания вложеного цикла.
                // Если элемент больше на 1, то записываем в count
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] - 1) count++;
                    else count = 1;
                    if (count > oldCount)
                    {
                        result = count;
                        oldCount = count;
                    }
                    break;
                }
            }
            //выводи результат на консоль (максимальное колличество элементов по возрастанию)
            Console.WriteLine(result + " штуки");
        }
    }
}
