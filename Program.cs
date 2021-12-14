using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 1, 3, 7, 7, 5, 6, 7, 8, 9, 4, 4 };
            int count = 1;
            int oldCount = 2;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
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
            Console.WriteLine(result + " штуки");
        }
    }
}
