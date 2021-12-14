using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "((строка ((вторая))"; // Строка, в которой ищем правильность расстановки скобок

            var tuple = Check(str);
            if (tuple.Item1)
                Console.WriteLine("Правильность расстановки скобок правильная.");
            else if (tuple.Item2 >= 0)
                Console.WriteLine($"В позизиции {tuple.Item2} обнаружена непарная закрывающая скобка!");
            else
                Console.WriteLine($"В строке не хватает {tuple.Item3} закрывающих скобок!");

            Console.ReadKey();
        }



        // Проверка парных закрывающих скобок
        // <param name="str">строка, в которой проверяется парность скобок</param>
        
        private static Tuple<bool, int, int> Check(string str)
        {
            int counter = 0;
            for (int i = 0, len = str.Length; i < len; ++i)
            {
                var c = str[i];
                switch (c)
                {
                    case '(':
                        ++counter;
                        break;
                    case ')':
                        if (counter > 0)
                            --counter;
                        else
                            return new Tuple<bool, int, int>(false, i, 0);
                        break;
                }
            }
            return counter > 0 ? new Tuple<bool, int, int>(false, -1, counter) : new Tuple<bool, int, int>(true, -1, 0);
        }
    }
    
}
