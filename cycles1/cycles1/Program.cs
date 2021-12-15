using System;

namespace cycles1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти сумму четных чисел и их количество в диапазоне от 1 до 99.
            int counter = 0;
            int sum = 0;
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 == 0)
                {
                    counter ++;
                    sum = sum + i;
                } 
            }
            Console.WriteLine($"Количество четных чисел:{counter}");
            Console.WriteLine($"Сумма четных чисел:{sum}");
            Console.ReadKey();
        }
    }
}
