using System;

namespace Ders5._2
{
    public class FileLoggerService :ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosya loglandı");
        }
    }
}