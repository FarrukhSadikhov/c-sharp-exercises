﻿using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
         // Получить строковое название дня недели по номеру дня.
            Console.Write("Нажмите номер дня:");
            try
            {
                int day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case (1):
                        Console.WriteLine("Понедельник");
                        break;
                    case (2):
                        Console.WriteLine("Вторник");
                        break;
                    case (3):
                        Console.WriteLine("Среда");
                        break;
                    case (4):
                        Console.WriteLine("Четверг");
                        break;
                    case (5):
                        Console.WriteLine("Пятница");
                        break;
                    case (6):
                        Console.WriteLine("Суббота");
                        break;
                    case (7):
                        Console.WriteLine("Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Не существует");
                        break;
                }
            }
            catch
            {
                Console.Write("Введите коррктные данные");
            }
            
            Console.ReadKey();

        }
    }
}
