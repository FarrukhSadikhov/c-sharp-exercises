using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Программа запрашивает год(4 - х значное число) и выводит к какому веку относится этот год.
            try
            {
                Console.Write("Введите год :");
                int year = Convert.ToInt32(Console.ReadLine());
                if (1000 <= year && year <= 9999 )
                {
                    int century = year/100 + 1;
                    Console.WriteLine($"Век :{century}");
                }
                else if (year < 0)
                {
                    Console.WriteLine("Введите положителтное число ");
                }
                else if (year <= 1000 || year >= 9999)
                {
                    Console.WriteLine("Введите 4 - х значное число");
                }
            }
            catch
            {
                Console.WriteLine("Введите корректные данные");
            }
            Console.ReadKey();
        }
    }
}
