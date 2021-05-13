using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //Алексей Сазонов
    //4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    //Создайте структуру Account, содержащую Login и Password.


    /*
     class Program
    {
        //Алексей Сазонов
        //4. Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел
        //(Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу:
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла DO WHILE ограничить ввод пароля тремя попытками.
        static void Main(string[] args)
        {
           



     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Users.MyArray("usersBase.txt"));
            Console.WriteLine();

        }
    }
}
