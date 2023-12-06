using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directori
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Получение спискка файлов
            // В данном примере использован класс Directory
            string path = "C:\\Users\\Пользователь\\Desktop\\Direct";
            //Создаём на рабочем столе папку в нутри ещё две папки и внутри одной из них файл
            // если папка существует
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(path); //с помощью массива получаем все подкаталоги текущего каталога
                foreach (string s in dirs) //перебираем массив
                {
                    Console.WriteLine(s); // выводим названия каталогов
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);// с помощью массива получаем все файлы в каталоге
                foreach (string s in files)// перебираем названия
                {
                    Console.WriteLine(s);// выводим названия
                }
            }
            else
            {
                Console.WriteLine("Такого каталога нет");
            }
            Console.ReadKey();
        }
    }
}
