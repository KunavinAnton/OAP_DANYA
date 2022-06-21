using System;
using System.Text;

namespace Pract9_Var7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder a = new StringBuilder("кол около колокола");
            Console.WriteLine("Дана строка {0}", a);
            char b = 'о';
            char c = 'а';
            int k = 0;
            for (int x = 0; x < a.Length; x++)
            {
                if (a[x] == b)
                {
                    k++;
                    a[x] = c;
                }
            }
            Console.WriteLine("Символ {0} содержится в ней {1} раз", b, k);
            Console.WriteLine(a);

            //Задание 2. Вариант 7
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            if(str.Length % 2 == 0)
            {
                int index = str.Length / 2;
                str = str.Remove(index - 1, 2);
            }
            else
            {
                int index = str.Length / 2;
                str = str.Remove(index, 1);
            }
            Console.WriteLine(str);

            //Задание 3. Вариант 7
            Console.WriteLine("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите слово: ");
            string word = Console.ReadLine();

            int count = 0;
            string[] array = str1.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string elem in array)
            {
                if (elem == word) count++;
            }
            Console.WriteLine($"Слово {word} встречается раз {count}");
        }
    }
}
