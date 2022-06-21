using System;

namespace Pract5_Individ_Var7
{
    internal class Program
    {
        static int[] Input()
        {
            Random random = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 7 - random.Next(10);
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = Input();
            Console.WriteLine("Отрицательные элементы массива и их индекс: ");
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] < 0)
                {
                    Console.WriteLine($"a[{i}] = {a[i]}");
                }
            }
        }
    }
}
