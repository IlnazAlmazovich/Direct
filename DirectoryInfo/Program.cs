using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получение Разной информации 
            string path = "C:\\Users\\Пользователь\\Desktop\\Direct";// задаём путь к каталогу
            DirectoryInfo directory = new DirectoryInfo(path);
            //с помощью разных методов получаем информацию
            Console.WriteLine($"Полное имя: {directory.FullName}");
            Console.WriteLine($"Имя: {directory.Name}");
            Console.WriteLine($"Родительский каталог: {directory.Parent}");
            Console.WriteLine($"Время создания: {directory.CreationTime}");
            Console.WriteLine($"Атрибуты: {directory.Attributes}");
            Console.WriteLine($"Диск: {directory.Root}");

            Console.ReadKey();
        }
    }
}
