using System;

namespace cycles2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Проверить простое ли число? 
            (число называется простым, если оно делится только само на себя и на 1).*/
            try
            {
                Console.Write("Введите число :");
                int count = 0;
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                        Console.WriteLine($"составное число ");
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine($"простое число ");
                }
            }
            catch
            {
                Console.WriteLine("Вводите корректнык данные");
            }
           
            Console.ReadKey();
        }
    }
}
