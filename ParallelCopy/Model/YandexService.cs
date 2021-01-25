using ParallelCopy.Service;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCopy.Model
{
    /// <summary>
    /// Класс для работы с сервисом яндекса
    /// </summary>
    class YandexService : ICopyService
    {
        /// <summary>
        /// Процедура копирования файлов
        /// </summary>
        /// <param name="source"> источник</param>
        /// <param name="destination"> приемник</param>
        public void Copy(string source, string destination)
        {
            // Вывод сообщений о состоянии копирования можно было бы вынести в класс главной модели
            Console.WriteLine($"Загрузка файла {source} ...");
            File.Copy(source, Path.Combine(destination, Path.GetFileName(source)));
            Console.WriteLine($"Загрузка файла {source} завершена");
        }
    }
}
