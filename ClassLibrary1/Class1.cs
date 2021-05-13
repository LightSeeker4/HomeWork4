using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyArray
    {
        int[] a;
        
        public MyArray(int n, int s, int m) //конструктор, создающий массив n размера и заполняющий массив числами от s с заданным шагом m.
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            a[i] = m*i+s;
        }
        
         public int MaxCount //свойство MaxCount, возвращающее количество максимальных элементов.

        {
            get
            {
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > max) max = a[i];

                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

        public int Sum //Создать свойство Sum, которое возвращает сумму элементов массива,
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) sum += a[i];
                return sum;
            }
        }

        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
       public string Inverse()
        {
            int[] b = new int[a.Length];
            a.CopyTo(b, 0);
            for (int i = 0; i < b.Length; i++)
                b[i] = -b[i];
            string s = "";              // костыль с выводом. пришлось преобразовать в string, не понимаю как можно нормально через return передать массив, чтобы при вызове скрипта не писало просто "System.Int32[]"
            foreach (int v in b)
                s = s + v + " ";
            return s;

        }
        public override string ToString()
            {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
