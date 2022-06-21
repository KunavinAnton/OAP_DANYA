using System;

namespace Zad2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Random rn = new Random();

            Console.WriteLine("Задание 1");
            int[] array = new int[10];
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rn.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) sum += array[i];
            }
            Console.WriteLine($"Сумма элементов с четными индексами: {sum}");

            Console.WriteLine();
            Console.WriteLine("Задание 2");
            //Задание 2
            int[] array2 = new int[10];
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rn.Next(-100, 100);
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Элементы которые больше своего индекса: ");
            for(int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > i) Console.Write(array2[i] + " ");
            }
        }
    }
}
