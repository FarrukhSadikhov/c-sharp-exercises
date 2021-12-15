using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа запрашивает 3 числа и выводит наибольший из них.
            try { 
            Console.WriteLine("Введите три числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.Write("наибольший из чисел:");
                Console.WriteLine(a);
            }
            else if (b>a && b > c)
            {
                Console.Write("наибольший из чисел:");
                Console.WriteLine(b);
            }
            else
            {
                Console.Write("наибольший из чисел:");
                Console.WriteLine(c);
            }
            }
            catch
            {
                Console.Write("ввелите коректные данные");
            }
            Console.ReadKey();
        }
    }
}
