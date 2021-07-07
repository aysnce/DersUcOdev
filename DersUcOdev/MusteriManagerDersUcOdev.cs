using System;
using System.Collections.Generic;
using System.Text;

namespace DersUcOdev
{
    class MusteriManagerDersUcOdev
    {
        public void Ekle(MusteriDersUcOdev musteri) 
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(MusteriDersUcOdev musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Güncelle(MusteriDersUcOdev musteri)
        {
            Console.WriteLine("Müşteri güncellendi : " + musteri.Ad + " " + musteri.Soyad);
        }


    }
}
