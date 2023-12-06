using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание каталога
            string path = "C:\\Users\\Пользователь\\Direct";//указываем путь где необходимо создать каталог
           // string path = @"C:\Users\Пользователь";
            string path2 = @"Desktop\Direct2";// указываем путь где необходимо создать подкаталог
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists) //проверяем, а нету ли такой каталога, так как если она существует,
                                 //то ее создать будет нельзя, и приложение выбросит ошибку
            {
                dirInfo.Create();// создаём каталог
                Console.WriteLine("каталог создан");
            }
            else
            {
                Console.WriteLine("Каталог уже существует");
            }
            dirInfo.CreateSubdirectory(path2);// создаёт подкаталог по указанному пути
            Console.ReadKey();
        }
    }
}
