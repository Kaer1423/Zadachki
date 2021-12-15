using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Создаем новый файл (если он есть, то перезаписываем) и записываем в него строки с различными датами
            File.WriteAllText("test.txt", "10/09/2001" +"\n" +
                                          "15:10:2021" +"\n" +
                                          "14/09/2012 14:50 "+"\n" +
                                          "10/09" + "\n" +
                                          "2-03-2007" + "\n" +
                                          "09:12:2008" + "\n");

            //Читаем файл, и разбиваем его по строкам
            string[] lines = File.ReadAllLines("test.txt");
            foreach (string s in lines)
            {
                //Путем создания исключения проверяем каждую строку на соответствие формата.
                //Если формат подходит, то выводим эту строку в консоль. Если не подходит, то вывовим дополнительно строку с предупреждением.
                try
                {
                    DateTime dt = DateTime.ParseExact(s, "dd:MM:yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine(s);

                }


                catch
                {
                    Console.WriteLine("Не правильный формат даты-->\t "+s);
                }
            }

        }
    }
}
