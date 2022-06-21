using System;

namespace pract7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 7
            //try
            //{
            //    Console.WriteLine("Введите n: ");
            //    int n = int.Parse(Console.ReadLine());
            //    double[] array = new double[n];

            //    Console.WriteLine("Введите k: ");
            //    double k = double.Parse(Console.ReadLine());

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("Введите элемент " + i);
            //        array[i] = double.Parse(Console.ReadLine());
            //    }

            //    double sum = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (array[i] > k) sum += array[i];
            //    }
            //    Console.WriteLine("Сумма элементов: " + Math.Round(sum, 2));
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Неверный ввод данных! повторите попытку");
            //}

            //Задание 9
            try
            {
                Console.WriteLine("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите m: ");
                int m = int.Parse(Console.ReadLine()); ;
                int[,] array2 = new int[n, m];

                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array2[i, j] = rand.Next(0, 10);
                        Console.Write(array2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Введите номер строки по которой хотите найти сумму: ");
                int x = int.Parse(Console.ReadLine());
                int sum = 0;

                try
                {
                    for (int i = 0; i < m; i++)
                    {
                        int temp = array2[x, i];
                        for (int j = 0; j < m; j++)
                        {
                            if (i == j) continue;
                            else if (array2[x, j] == temp) sum += temp;
                        }
                    }
                    Console.WriteLine(sum);
                }
                catch
                {
                    Console.WriteLine("Введен неверный номер строки");
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод!");
            }
        }
    }
}
