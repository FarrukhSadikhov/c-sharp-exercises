using System;

namespace cycles4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Посчитать сумму цифр заданного числа.
            Console.WriteLine("Введите натуральное число:");
            try 
            {
                uint number = uint.Parse(Console.ReadLine());
                uint sum = 0;
                if (number < 0)    
                {
                    Console.WriteLine("Не вводить отрицательные числа");                 
                }
                else
                {               
                while (number != 0)
                {
                    sum = sum + number % 10;
                    number = number / 10;                 
                }
                Console.WriteLine(sum);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка! Было введено некорректное значение!!!");
            }
            Console.ReadKey();
            
        }
    }
}
