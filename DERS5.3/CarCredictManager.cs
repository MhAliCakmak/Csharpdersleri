using System;

namespace Ders5._2
{
    public class CarCredictManager :ICredictBaseManager
    {
        public void Hesap()
        {
            Console.WriteLine("Arac kredisi alındı ödeme bekleniyor .");
        }

        public void Biseyap()
        {
            throw new System.NotImplementedException();
        }
    }
}