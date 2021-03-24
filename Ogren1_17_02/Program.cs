using System;

namespace Ogren1_Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass m1 = new MyClass();
            //MyClass m2= new MyClass();

        }





        // Geriye değer göndermeyen, Parametre almayan Metod
        public void Metod1()
        {
            Console.WriteLine("Geriye değer göndermez.");
        }
       


        // Geriye değer göndermeyen, Parametre alan Metod
        public void Metod2(bool x, decimal m)
        {
            Console.WriteLine(x + " " + m);
        }

        // Geriye değer gönderen, Parametre almayan Metod ( Eğer metodumuz geriye değer döndürecek tipte ise o tipte bir değeri göndermek zorunda.
        private int Metod3()
        {
            Console.WriteLine("Return den önce her türlü işlemi yapabiliriz. RETURN geriye değer gönderen bir komuttur.");
            return 10;
        }

        // Geriye değer gönderen, Parametre alan Metod
        private string Metod4(string x)
        {
            return "abc String";
        }
    }

    /// <summary>
    /// MyClass ımıza bir Açıklama Yapalım /// 3 slash ile üstüne.
    /// </summary>
    class MyClass
    {   // THIS KEYWORD U NE İŞE YARAR?

        // 1- Sınıfın Nesnesini Temsil Eder
        public void X()
        {
            this.X();
        }

        // 2- Aynı isimde Field ile Metod Parametrelerini ayırmak için kullanılır
        int a;
        public void Y(int a)    
        {
            this.a          // Yukarıdaki field daki 'a' ya ulaşmak istiyorsan This kullanırsın. 
            a               // Parametre 'a' yı temsil ediyor
        }

        



    }

}
        
       




