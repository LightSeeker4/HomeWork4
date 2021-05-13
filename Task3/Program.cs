using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task3
{
    //Алексей Сазонов
    //    3.
    //а) Дописать класс для работы с одномерным массивом.
    //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    //Создать свойство Sum, которое возвращает сумму элементов массива,
    //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
    //метод Multi, умножающий каждый элемент массива на определённое число,
    //свойство MaxCount, возвращающее количество максимальных элементов.
    //б)** Создать библиотеку содержащую класс для работы с массивом.
    //Продемонстрировать работу библиотеки
    //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(6, 5, 1);

            Console.WriteLine(arr.ToString());
            Console.WriteLine(arr.MaxCount);
            Console.WriteLine(arr.Sum);
            Console.WriteLine(arr.Inverse());

        }
    }
}
