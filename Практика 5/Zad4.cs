using System;

namespace Pract5_Individ_Var7
{
    internal class Program
    {
        static int[] Input()
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Print(int[] a, int j)
        {
            for (int i = 0; i < j; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = Input();
            int[] b = new int[10];

            int j = 0;
            for(int i = 0; i < b.Length; i++)
            {
                if(a[i] % 2 == 0)
                {
                    b[j] = i;
                    j++;
                }
            }
            Print(b, j);
        }
    }
}
