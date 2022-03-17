using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 108;
            musteri1.Adi = "Kenan";
            musteri1.yas = 32;
            musteri1.soyad = "gül";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 109;
            musteri2.Adi = "Pelin";
            musteri2.yas = 32;
            musteri2.soyad = "Çiftegül";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 105;
            musteri3.Adi = "Adnan";
            musteri3.yas = 32;
            musteri3.soyad = "Mirza";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriCıkar(musteri2);



            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.MusteriListeleme(Musteriler);



        }
    }
}
