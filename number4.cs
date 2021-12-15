using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "((строка ((вторая))"; // Строка, в которой ищем правильность расстановки скобок


            var tuple = Check(str); // Передаем методу строку
            if (tuple.Item1) //Используем в условии компоненты из метода
                Console.WriteLine("Правильность расстановки скобок правильная.");
            else if (tuple.Item2 >= 0)
                Console.WriteLine($"В позизиции {tuple.Item2} обнаружена непарная закрывающая скобка!");
            else
                Console.WriteLine($"В строке не хватает {tuple.Item3} закрывающих скобок!");

            Console.ReadKey();
        }



        // Создаем метод Check, который проверяет парность закрытия скобок.
        // Метод возвращает кортеж из 3 компонентов (1- соответсвует ли количество скобок открытых к закрытым
        //                                          2- позиция лишней скобки
        //                                          3- колличество скобок)
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
