using System;

namespace DersUcOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriDersUcOdev Musteri1 = new MusteriDersUcOdev();
            Musteri1.Ad = "Aysun";
            Musteri1.Soyad = "İnce";
            Musteri1.Id = 1200;
            Musteri1.TcKimlikNo = 23456789;
            Musteri1.Yas = 20;

            MusteriDersUcOdev Musteri2 = new MusteriDersUcOdev();
            Musteri2.Ad = "Ayşe";
            Musteri2.Soyad = "İnce";
            Musteri2.Id = 1270;
            Musteri2.TcKimlikNo = 98765432;
            Musteri2.Yas = 27;

            MusteriDersUcOdev Musteri3 = new MusteriDersUcOdev();
            Musteri3.Ad = "Elif";
            Musteri3.Soyad = "İnce";
            Musteri3.Id = 1300;
            Musteri3.TcKimlikNo = 13579246;
            Musteri3.Yas = 30;

            MusteriDersUcOdev[] Musteriler = new MusteriDersUcOdev[] { Musteri1, Musteri2, Musteri3 };

            foreach (MusteriDersUcOdev musteriler in Musteriler) 
            {
                Console.WriteLine("Müşteri ismi :" + musteriler.Ad);
                Console.WriteLine("Müşteri soyismi :" + musteriler.Soyad);
                Console.WriteLine("Müşteri Id numarası :" + musteriler.Id);
                Console.WriteLine("Müşteri Tc kimlik numarası :" + musteriler.TcKimlikNo);
                Console.WriteLine("Müşteri yaşı :" + musteriler.Yas);
            }
            Console.WriteLine("--------------");

            MusteriManagerDersUcOdev MusteriManager = new MusteriManagerDersUcOdev();
            MusteriManager.Ekle(Musteri1);
            MusteriManager.Sil(Musteri3);
            MusteriManager.Güncelle(Musteri2);

            Console.ReadLine();

        }
       
    }
}