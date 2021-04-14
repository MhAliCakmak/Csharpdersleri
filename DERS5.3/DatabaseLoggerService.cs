using System;

namespace Ders5._2
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanina loglandı");
        }
    }


   
}