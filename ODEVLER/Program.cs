using System;

namespace ODEVLER
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            int yas;
            

            Console.WriteLine("İsim girin:" + "Soyad:");
            isim = Console.ReadLine();
            string soyad = Console.ReadLine();                                 // Süslü parantez içine girdiğin INDEX SAYISINI 
            Console.WriteLine("Merhaba {1}", isim, soyad);              //virgülden sonra gelen değere karşılık yazdırır.

            Console.WriteLine("Yaşınızı girin:");
            yas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("İsminiz = {0}, Yaşınız : {1}", isim, yas);
            //Console.ReadKey();      // Ekranda en son bu komutların gözükmesini sağlar

            int boy = 181;
            int kilo = 70;

            if (kilo > 80 && boy > 180)     // ALT GR + Çizgili işaret VEYA yapar.  ( && VE işareti , || VEYA işareti )
            {
                Console.WriteLine("girersin");
            }
            else
            {
                Console.WriteLine("GİRİLMEZ");
            }


            


            Customer customer1 = new Customer(2, "BURAK");

            Console.WriteLine(customer1.FirstName);

        }
    }

    class Customer
    {
        public Customer(int ıd, string firstName)
        {
            ID = ıd;
            FirstName = firstName;

            Console.WriteLine("Çalıştı");
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
    }

   

}







