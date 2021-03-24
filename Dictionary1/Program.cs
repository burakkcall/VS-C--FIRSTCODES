using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bizim belirleyecegimiz bir KEY e uygun olarak değer saklar.Key türünü belirlememiz şart(stringer, int ...)

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // Veri ekliyoruz
            AdYas.Add("Amy", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Burak", 21);
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            // değer sayma özelliği vardır
            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman sayısı:" + " "+ eleman);

            // Silme işlemi de vardır
            AdYas.Remove("Burak");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }

            // Anahtarları içeren koleksiyon döndürür.
            Dictionary<string, int>.KeyCollection AnahtarListesi = AdYas.Keys;

            foreach (var ANAHTAR in AnahtarListesi)
            {
                Console.WriteLine(ANAHTAR);
            }

            Dictionary<string, int>.ValueCollection DegerListesi = AdYas.Values;
            foreach (var DEGER in DegerListesi)
            {
                Console.WriteLine(DEGER);
            }


        }
    }
}
