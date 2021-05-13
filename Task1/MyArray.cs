using System;

namespace Task1
{
    class MyArray
    {
        int[] a;

        public MyArray (int n, int min, int max)    // конструктор массива, в аргументы задаются размер массива и рамки псевдо-рандомайзера
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        
        internal int SumTwoDivThree()       //находим пары чисел, одно из которых делится на 3.  a/3 + b/3 = (a+b)/3
        {
            int count = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if ((a[i] + a[i - 1]) % 3 != 0) count++;

                //Сначала затупил с суммой и сделал вот так:
                //if (a[i] % 3 == 0 && a[i - 1] % 3 != 0) count++;
                //if (a[i] % 3 != 0 && a[i - 1] % 3 == 0) count++;
            }
            return count;
        }
        public override string ToString()   // выводит массив виде строки
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
