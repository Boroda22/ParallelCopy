using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCopy.Service
{
    interface ICopyService
    {
        /// <summary>
        /// Метод копирования данных
        /// </summary>
        /// <param name="source"> источник копирования</param>
        /// <param name="destination"> приемник копирования</param>
        void Copy(string source, string destination);
    }
}
