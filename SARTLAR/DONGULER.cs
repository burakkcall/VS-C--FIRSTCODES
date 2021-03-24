using System;

namespace SARTLAR
{
    class DONGULER
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i= i+2) // i+=2
            {
                Console.WriteLine(i);
            }
            // array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel", "Java", "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {

            }

            Console.WriteLine("-- Sayfa Sonu --");
        }
    }
}
