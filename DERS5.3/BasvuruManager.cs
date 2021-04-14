using System.Collections.Generic;

namespace Ders5._2
{
    public class BasvuruManager
    {
        public void Basvuru(ICredictBaseManager credictBaseManager,ILoggerService loggerService)
        {
            credictBaseManager.Hesap();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICredictBaseManager> kredi)
        {
            foreach (var krediler in kredi)
            {
                krediler.Hesap();
                
            } 
        }
    }
}