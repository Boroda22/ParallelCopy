using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCopy.Model
{
    class MainModel
    {
        /// <summary>
        /// Источник для копирования
        /// </summary>
        private string source = String.Empty;
        /// <summary>
        /// Приемник копирования
        /// </summary>
        private string destination = String.Empty;
        /// <summary>
        /// Сервис копирования
        /// </summary>
        private YandexService yandexService;




        /// <summary>
        /// Метод копирования файлов
        /// </summary>
        public void CopyFiles()
        {
            var sourceFiles = Directory.GetFiles(source);
            Parallel.ForEach(sourceFiles, (currentFile) =>
            {
                yandexService.Copy(currentFile, destination);
            });
        }

        /// <summary>
        /// Главная модель
        /// </summary>
        /// <param name="copyParams"> Массив параметров, 1-й параметр - источник, 2-й параметр - приемник</param>
        public MainModel(string[] copyParams, YandexService service)
        {
            source = copyParams[0];
            destination = copyParams[1];
            yandexService = service;
        }
    }
}
