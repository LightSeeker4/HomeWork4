using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class StaticClass
    {
        public static int SumTwoDivThree(int[] a)   // проверка из 1 задачи
        {
            int count = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if ((a[i] + a[i - 1]) % 3 != 0) count++;
            }
            return count;
        }

        public static int[] MyArray(string Path)    // проверяем на месте ли файл, тащим из него массив, преобразуем в массив целых чисел
        {
            string path = Path;
            string[] lines = new string[0];

            if (File.Exists(path))
            {
                Console.WriteLine("File found");
                lines = File.ReadAllLines(path);
            }
            else
            {
                Console.WriteLine("File not found");
            }

            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write($"{lines[i]} ");
            }
            int[] numbers = Array.ConvertAll(lines, int.Parse);
            return numbers;
        }
    }
}
