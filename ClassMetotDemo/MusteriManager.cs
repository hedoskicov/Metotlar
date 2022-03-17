using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "numaralı müşteri listeye eklendi");
        }
         
        public void MusteriCıkar(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli musteri listeden silindi");
        }

        public void MusteriListeleme(Musteri[] Musteriler)
        {
            foreach (Musteri musteriler in Musteriler)
            {
                Console.WriteLine(musteriler.soyad);
            }
        }




    }
}
