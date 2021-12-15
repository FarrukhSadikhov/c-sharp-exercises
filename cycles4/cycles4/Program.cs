using System;

namespace cycles4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Посчитать сумму цифр заданного числа.
            try 
            {
                int number = int.Parse(Console.ReadLine());
                int sum = 0;
                while (number != 0)
                {
                    sum = sum + number % 10;
                    number = number / 10;
                }
                Console.WriteLine(sum);
            }
            catch
            {
                Console.WriteLine("Введите числовое значение!!!");
            }
            Console.ReadKey();
            
        }
    }
}
