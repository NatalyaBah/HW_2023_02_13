using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2023_02_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory + @"\Users\Наталья\Desktop\Test");
            directoryInfo.Create();
            FileInfo fileInfo = new FileInfo(directoryInfo + @"\test.txt");
            fileInfo.Create();
            Console.WriteLine("Полное имя: {0}", directoryInfo.FullName);
            Console.WriteLine("Имя: {0}", directoryInfo.Name);
            Console.WriteLine("Родительский каталог: {0}", directoryInfo.Parent);
            Console.WriteLine("Время создания: {0}", directoryInfo.CreationTime.ToString());
            Console.WriteLine("Атрибуты: {0}", directoryInfo.Attributes);
            Console.WriteLine("Root: {0}", directoryInfo.Root);
            Console.WriteLine("///////////////////////////");
            Console.WriteLine("Имя файла: {0}", fileInfo.Name);
            Console.WriteLine("Размер: {0}", fileInfo.Length);
            Console.WriteLine("Атребуты: {0}", fileInfo.Attributes);
            Console.WriteLine("///////////////////////////");
            try
            {
                DirectoryInfo[] d = directoryInfo.GetDirectories();
                Console.WriteLine("Количество подкаталогов: {0}", d.Length);
            }
            catch (Exception e)
            {

                Console.WriteLine("Что-то пошло не так: {0}", e.ToString());
            }
        }
    }
}
