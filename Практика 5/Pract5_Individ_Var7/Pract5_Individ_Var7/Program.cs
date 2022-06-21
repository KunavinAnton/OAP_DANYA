using System;

namespace Pract5_Individ_Var7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] mass1 = new int[] { 20, 120, 3, 7 };

                //Задание 2_1
                Console.Write("Массив в обратном порядке: ");
                for (int i = mass1.Length - 1; i >= 0; i--)
                {
                    Console.Write(mass1[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine();

                //Задание 2_2
                Console.Write("Введите число А: ");
                int A = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < mass1.Length; i++) Console.Write(mass1[i] * 2 + " ");
                Console.WriteLine();
                for (int i = 0; i < mass1.Length; i++) Console.Write(mass1[i] - A + " ");
                Console.WriteLine();
                for (int i = 0; i < mass1.Length; i++) Console.Write(mass1[i] / mass1[0] + " ");

                Console.WriteLine();
                Console.WriteLine();

                //Задание 2_3
                Console.Write("Элементы заканчивающиеся нулем: ");
                for (int i = 0; i < mass1.Length; i++)
                {
                    if (mass1[i] % 10 == 0)
                    {
                        Console.Write(mass1[i] + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
            }
            

            //Вариант 7

            //Задание 1
            int[] mass2 = { 45, 6, 8, 2, 90 };
            int min = mass2[0];
            for (int i = 0; i < mass2.Length; i++)
            {
                if (min > mass2[i]) min = mass2[i];
            }
            Console.WriteLine("Минимальное " + min);

            Console.WriteLine();
            //Задание 8
            for (int i = 15; i <= 30; i++)
            {
                double F = Math.Round((i * 1.8) + 32, 2);
                Console.WriteLine($"{i} === {F}");
            }
        }
    }
}
