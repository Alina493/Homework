#region Автор
//Каменко Алина Александровна
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкета
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.*/

            Console.WriteLine("Введите Ваше имя: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию: ");
            string s2 = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст: ");
            string s3 = Console.ReadLine();

            Console.WriteLine("Введите Ваш рост: ");
            string s4 = Console.ReadLine();

            Console.WriteLine("Введите Ваш вес: ");
            string s5 = Console.ReadLine();

            string s6 = s1 + s2 + s3 + s4 + s5;
            System.Console.WriteLine(s6);

            Console.WriteLine("Ваши данные: Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", s1, s2, s3, s4, s5);

            Console.WriteLine($"Ваши данные: Имя: {s1}, Фамилия: {s2}, Возраст: {s3}, Рост: {s4}, Вес: {s5}");

            Console.ReadLine();

            #endregion

            Console.Clear();

            #region Task2 /*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах*/

            double m, h;

            Console.WriteLine("Введите вес: ");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост в см: ");
            h = Convert.ToDouble(Console.ReadLine());
            h = h * 0.01;

            var i = (m / (h * h));

            Console.WriteLine("Ваш ИМТ равен: " + i);
            Console.ReadLine();

            #endregion

            Console.Clear();

            #region Task4 /*обмена значениями двух переменных типа int без использования вспомогательных методов*/

            var a = 12;
            var b = 14;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a}, {b}");
            Console.ReadLine();

            #endregion

            Console.Clear();

            #region Task5, a, b /*Написать программу, которая выводит на экран ваше имя, фамилию и город проживания в центре экрана.*/
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);

        }

        static void Main()
        {
            Print("Алина Каменко, С-Пб\n", 50, 12);

            Console.ReadLine();

            #endregion
        }
    }
}
