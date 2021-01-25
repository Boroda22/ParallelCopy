using ParallelCopy.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCopy
{
    /*
     * Программа копирования файлов,
     * каталог копирования указывается в качестве первого параметра
     * каталог назначения указывается в качестве второго параметра
     * Можно прикрутить взаимодействие с API Яндекса через RestSharp
     */
    class Program
    {
        static void Main(string[] args)
        {
            // обязательно должно быть два параметра - источник и приемник
            if (args.Length != 2)
            {
                Console.WriteLine("Вы не указали параметры копирования.\nДля выхода нажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            // проверку на валидность параметров опустил

            YandexService yandexSevice = new YandexService();

            MainModel mainModel = new MainModel(args, yandexSevice);
            mainModel.CopyFiles();
            Console.WriteLine("Копирование завершено, для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
