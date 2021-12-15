using System;

namespace cycles5
{
    class Program
    {
        static void Main(string[] args)
        {
             /* Вывести число, которое является зеркальным отображением
              последовательности цифр заданного числа, например, задано число
              123, вывести 321.*/
            try
            {
                int number = int.Parse(Console.ReadLine());
                int reveredNum;
                while (number != 0)
                {
                    reveredNum = number % 10;
                    number = number / 10;
                    if (number < 0)
                    {
                        number = number * (-1);
                    }
                    Console.Write(reveredNum);
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
