using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Магазин делает скидку от основной цены 50 манат, если стоимость покупки больше 500 манат, и 100 манат,
            если стоимость покупки больше 1000 манат.Программа запрашивает цену и возвращает цену со скидкой.*/
            try
            {
                Console.Write("Введите цену:");
                double price = Convert.ToDouble(Console.ReadLine());
                if(0 <= price && price <= 500)
                {
                    Console.Write($"Скидки нет: {price}");
                }
                else if (500 < price && price <= 1000)
                {
                    Console.Write($"Скидка 50 манат:{price - 50}");
                }
                else if (1000 < price)
                {
                    Console.Write($"Скидка 100 манат:{price - 100}");
                }
                else if(price < 0)
                {
                    Console.Write($"Вводите положительное число");
                }
            }
            catch
            {
                Console.Write("Введите корректные данные:");
            }
            Console.ReadKey();
        }
    }
}
