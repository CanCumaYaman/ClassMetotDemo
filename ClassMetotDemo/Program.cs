using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Can Cuma";
            musteri1.Soyad = "Yaman";
            musteri1.Adres = "Ankara";
            musteri1.Sube = "Sincan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ayşegül";
            musteri2.Soyad = "Özkılıç";
            musteri2.Adres = "Manisa";
            musteri2.Sube = "Soma";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Sabit";
            musteri3.Soyad = "Kıyıcı";
            musteri3.Adres = "Yozgat";
            musteri3.Sube = "Yerköy";
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager manager = new MusteriManager();
            manager.ekle(musteri1);
            manager.ekle(musteri2);
            manager.ekle(musteri3);
            Console.WriteLine("--------------------------------");
            manager.listele(musteriler);
            Console.WriteLine("--------------------------------");
            manager.sil(musteri1);
            manager.sil(musteri2);
            manager.sil(musteri3);
        }
    }
}
