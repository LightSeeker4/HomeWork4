using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Алексей Сазонов
    //    1. Дан целочисленный массив из 20 элементов.
    //    Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    //    Заполнить случайными числами.
    //    Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    //    В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array1 = new MyArray(20, -10000, 10000); 
            Console.WriteLine($"Массив: {array1.ToString()}\nКоличество пар: {array1.SumTwoDivThree()}");
        }
    }
}
