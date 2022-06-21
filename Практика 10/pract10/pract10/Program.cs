using System;

namespace pract10
{
    internal class Program
    {
        //Процедура заполняющая массив числами и вычисляющая минимальное значение столбца
        static void func(double[,] array, int N, int M, out double min)
        {
            if(N != 0 && N <= 10)
            {
                Console.WriteLine("Введите значения зарплат работников за каждый месяц:");
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Работник {i + 1}: ");
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write($"Зарплата за {j + 1} месяц: ");
                        do
                        {
                            array[i, j] = Convert.ToDouble(Console.ReadLine());
                            if (array[i, j] <= 0) Console.WriteLine("Введите верную зп - выше 0");
                        }while(array[i, j] <= 0);
                    }
                }
            }
            else
            {
                Console.WriteLine("Сотрудников не может быть 0 или больше 10-ти");
            }


            //определение минимального элемента первого столбца
            min = array[0, 0];
            for (int i = 0; i < N; i++)
            {
                if (array[i, 0] < min) min = array[i, 0];
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите кол-во работников:");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите кол-во месяцев:");
                int M;
                do
                {
                    M = Convert.ToInt32(Console.ReadLine());
                    if (M < 1 || M > 12) Console.WriteLine("Введено неверное значение! Повторите попытку!");
                } while (M < 1 || M > 12);
                double[,] B = new double[N, M];


                func(B, N, M, out double min);
                Console.WriteLine();


                //Вывод массива на консоль
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Работник {i + 1}: ");
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write(B[i, j] + " ");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine();
                Console.WriteLine($"Минимальное значение для первого столбца: {min}");
            }
            catch
            {
                Console.WriteLine("Неверный ввод!");
            }

            
        }
    }
}
