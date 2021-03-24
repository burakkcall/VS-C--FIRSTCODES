using System;

namespace BurakStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not Repeat your self - Kendini tekrarlama
            // kategoriEtiketi -- DEĞER TUTUCU

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            // double : Ondalıklı sayılar için
            bool sistemeGirisyapmismi = true; // ya da True

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşitti Butonu");
            }

            if (sistemeGirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
                Console.WriteLine();
            }

            Console.WriteLine();
        }


    }
}



