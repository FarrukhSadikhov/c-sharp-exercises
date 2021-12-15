using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая спрашивает какая погода на улице.
            При вводе от - 20 до 5 говорит, что холодно. От 6 до 15 - прохладно, от 16 до 20 - тепло, от 21 до 35 - жарко, от 36 до 45 - очень жарко.
            При вводе других значений говорит, что не верит, что такая температура может быть.*/
            try
            {
            Console.Write("Введите температуру:");
            // t - это температура.
            double t = Convert.ToDouble(Console.ReadLine());
            if (t>=-20 && t<=5)
                {
                    Console.WriteLine("холодно");
                }
            else if (t>=6 && t<=15)
                {
                    Console.WriteLine("прохладно");
                }
            else if (t>=-16 && t<=20)
                {
                    Console.WriteLine("тепло");
                }
            else if (t>=21 && t<=35)
                {
                    Console.WriteLine("жарко");
                }
            else if (t>=36 && t<=45)
                {
                    Console.WriteLine("очень жарко");
                }
            else  
                {
                    Console.WriteLine("Не верю,что такая температура может быть");
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
