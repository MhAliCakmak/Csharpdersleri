namespace oop3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Mehmet Cakmak
            RealMusteri musteri1 = new RealMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Ad = "mehmet";
            musteri1.Soyad = "Cakmak";
            musteri1.TcNo = "12364578952";
            
            //Yazılım Team

            FakeMusteri musteri2 = new FakeMusteri();
            musteri2.Id = 2;
            musteri1.MusteriNo = "54331";
            musteri2.SirketName = "Yazılım Team";
            musteri2.VergiNo = "123454";
            
            //surprises
            Musteri musteri3 = new RealMusteri();
            Musteri musteri4 = new FakeMusteri();
            CustomerManager.Add(musteri3);
            CustomerManager.Add(musteri4);
            


        }
    }
}