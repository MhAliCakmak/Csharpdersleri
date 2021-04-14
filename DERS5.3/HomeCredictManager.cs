using System;

namespace Ders5._2
{
    public class HomeCredictManager : ICredictBaseManager
    {
        public void Hesap()
        {
            Console.WriteLine("Ev kredisi hesaplandı ödeme bekleniyor");
        }

        public void Biseyap()
        {
            throw new System.NotImplementedException();
        }
    }
}