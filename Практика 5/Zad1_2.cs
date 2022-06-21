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
        static int Sum(int[] a)
        {
            int sum = 0;
            Console.WriteLine("Введите число k: ");
            int k = int.Parse(Console.ReadLine());

            foreach (int elem in a)
            {
                if(elem % k == 0)
                {
                    sum += elem;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] a = Input();
            Console.WriteLine("Сумма: " + Sum(a));
        }
    }
}
