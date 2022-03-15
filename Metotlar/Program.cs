using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 14;
            urun2.Aciklama = "çileeek";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..............");

            }

            // instance - örnek (class ornegi olusturmak)
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("ekle2 ile :");
            sepetManager.Ekle2("Armut", "yeşil armut", 13,1);
            sepetManager.Ekle2 ("Elma", "yeşil elma", 19,4);
            sepetManager.Ekle2 ("kiraz", "kirmizi kiraz", 15,5);





        }
    }
}
