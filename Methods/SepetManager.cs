using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        private object urun;

        // syntax -- Parametremiz urun
        public void Ekle(Product urun)        // def gibi
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi :" +  urun.Adi);
        }

        public void Ekle2 (string urunAdi, string Aciklama, double Fiyat, int stokAdeti) 
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi :" + urunAdi +" " + Aciklama);
        }

    }
}

            
