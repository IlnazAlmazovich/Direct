using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //удаление каталога
            string path = "C:\\Users\\Пользователь\\Desktop\\Direct"; //задаём путь
            DirectoryInfo dirInfo = new DirectoryInfo(path); //создаём экземпляр класса и передаём туда путь к каталогу
            if (dirInfo.Exists) // проверяем существует ли каталог
            {
                dirInfo.Delete();// с помощью метода Delete удаляем каталог
                Console.WriteLine("Каталог удален");
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }
            Console.ReadKey();
        }
    }
}
