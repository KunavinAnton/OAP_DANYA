using System;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();

            int[] array = new int[20];
            Console.WriteLine("Массив: ");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rn.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            int sum_pos = 0;
            int sum_neg = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0) sum_pos += array[i];
                if(array[i] < 0) sum_neg += array[i];
            }
            Console.WriteLine($"Сумма положительных: {sum_pos}");
            Console.WriteLine($"Сумма отрицательных: {sum_neg}");
        }
    }
}
