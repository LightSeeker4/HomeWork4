using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Алексей Сазонов
    //2. Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) Добавьте статический метод для считывания массива из текстового файла.
    //Метод должен возвращать массив целых чисел;
    //в)* Добавьте обработку ситуации отсутствия файла на диске.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nКол-во пар по условию 1 задачи: {StaticClass.SumTwoDivThree(StaticClass.MyArray("file.txt"))}");
        }
    }
}