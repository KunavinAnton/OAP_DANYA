using System;

namespace pract3_oap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вариант 7

            //Задание 3
            Console.WriteLine("Введите угол 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите угол 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a + b >= 180 || a + b <= 0)
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            else if (180 - (a + b) == 90)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник существует");
            }

            //Задание 19
            Console.WriteLine("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 <= number2)
            {
                number1 = 0;
            }
            Console.WriteLine($"{number1} {number2}");
        }
    }
}
