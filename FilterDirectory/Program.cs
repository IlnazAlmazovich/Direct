using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilterDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Фильтрация папок и файлов

            string path = "C:\\Users\\Пользователь\\Desktop\\Direct";
            // Найдём папки которые начинаются на слово "список"
            DirectoryInfo directory = new DirectoryInfo(path);//создаём экземпляр класса и передаём туда путь
            DirectoryInfo[] infos = directory.GetDirectories("список*.");//создаём массив и прописываем то что нам необходимо найти
            Console.WriteLine("-Список каталогов которые начинаются на слово 'список'");
            foreach (DirectoryInfo i in infos) //перебераем массив
            {

               Console.WriteLine(i);// выводим названия

            }
            Console.WriteLine();

            //Получим файлы с расширением .txt
            DirectoryInfo fa = new DirectoryInfo(path);
            FileInfo[] files = fa.GetFiles("*.txt");
            Console.WriteLine("-Список фалйлов с расширение .txt");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();

        }
    }
}
