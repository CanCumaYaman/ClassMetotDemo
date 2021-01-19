using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" Sistemimize eklenmiştir.");
        }
        public void listele(Musteri[] musteriler)
        {
            foreach(var item in musteriler)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Adres + " " + item.Sube);
            }

        }
        public void sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" " +musteri.Soyad + " Veritabanımızdan silinmiştir.");
        }
    }
}
