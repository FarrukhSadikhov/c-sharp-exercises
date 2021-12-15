using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Программа запрашивает 2 числа.Выводит на экран их частное.
            При попытке разделить на 0, говорит, что на ноль делить нельзя.*/
            try
            {
            Console.Write("первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a / b;
            if (b != 0)
            { 
                Console.WriteLine($"Результат: {c}");
            }
            else
            {
                Console.WriteLine("На ноль нельзя делить!");
            }
            }
            catch
            {
                Console.WriteLine("Ввдите корректные данные");
            }
            Console.ReadKey();
        }
    }
}
