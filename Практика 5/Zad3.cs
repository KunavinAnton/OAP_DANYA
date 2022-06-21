using System;

namespace Pract5_Individ_Var7
{
    internal class Program
    {
        static int[] Input()
        {
            int[] a = new int[30];
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Sum (int[] a)
        {
            int pos = 0;
            int neg = 0;

            foreach (int elem in a)
            {
                if(elem > 0) pos++;
                else if (elem < 0) neg++;
            }
            Console.WriteLine("Кол-во положительных: " + pos);
            Console.WriteLine("Кол-во отрицательных: " + neg);
        }
        static void Main(string[] args)
        {
            int[] a = Input();
            Sum(a);
        }
    }
}
