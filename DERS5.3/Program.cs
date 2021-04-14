using System.Collections.Generic;

namespace Ders5._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICredictBaseManager needCredictManager = new NeedCredictManager();
            

            ICredictBaseManager carCredictManager = new CarCredictManager();
            

            ICredictBaseManager homeCredictManager = new HomeCredictManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuru(needCredictManager,databaseLoggerService);
            
            

            List<ICredictBaseManager> kredi = new List<ICredictBaseManager>() {needCredictManager,homeCredictManager,carCredictManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(kredi);
            

        }
    }
}