using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        private static SepetManager instance;
        public void Ekle(Urun urun ) 
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi );
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyati, double stokAdedi) 
        
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi  +  Fiyati + Aciklama);
        }

    }
}
