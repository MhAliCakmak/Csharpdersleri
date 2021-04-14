using System;

namespace Ders5._2
{
    public class NeedCredictManager :ICredictBaseManager
    {
        public void Hesap()
        {
            Console.WriteLine("İhtiyac kredisi verildi ödeme bekleniyor . ");
        }

        public void Biseyap()
        {
            throw new System.NotImplementedException();
        }
    }
}