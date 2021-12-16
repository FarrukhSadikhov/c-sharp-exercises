using System;

namespace cycles3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вычислить факториал числа n. n! = 1 * 2 *…*n - 1 * n; !.
            //факториал бывает только у натуральных чисел и у нуля.У отрицательных -факториала не бывает.
            try
            {
                Console.WriteLine($"Вычислить факториал числа :");
                int number = Convert.ToInt32(Console.ReadLine());
                int factorial = 1;
                if(number < 0)
                {
                    Console.Write("У отрицательных чисел факториала не бывает");
                }
                else if(number >0) 
                {
                    while (number > 0)
                    {
                        factorial = factorial * number;
                        number--;
                    }
                    Console.WriteLine($"факториал этого числа равен :{factorial}");
                }
            }
            catch
            {
                Console.WriteLine("Введите числовое значение!!!");
            }
            Console.ReadKey();
        }
    }
}
