using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.Title = "Работа с консолью";
            Console.Title = "Работа с консолью";
            Console.WriteLine("WindowWidth : " + Console.WindowWidth);
            Console.WriteLine("WindowHeight: " + Console.WindowHeight);
            Console.WriteLine("Строка 1");//вывод строки (по умолчанию - белый цвет шрифта на черном фоне)
            Console.BackgroundColor = ConsoleColor.White;//свойство установки белого цвета фона для текста
            Console.ForegroundColor = ConsoleColor.Red;// свойство установки красного цвета шрифта
            Console.WriteLine("Строка 2");// выводим строку
            Console.ResetColor();// метод сброса настройки цвета на стандартные
            Console.WriteLine("Строка 3");// выводим строку
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем синий цвет шрифта
            Console.WriteLine("Строка 4"); // выводим строку
            Console.CursorVisible = false; // инициализациядля невидимого курсора
            bool saveCursorVisibile = Console.CursorVisible;
            //Console.CursorVisible = true; // инициализациядля видимого курсора
            //bool saveCursorVisibile = Console.CursorVisible;
            Console.WriteLine("\a");
            Console.ReadKey();
        }
        static void Func()
        {
            for (int x = 1; x <= 25; x++)
            {
                Console.WriteLine("#");
            }    
        }
    }
}
