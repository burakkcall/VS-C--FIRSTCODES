using System;
using System.Linq;

namespace Ogren2_Metod
{
    class Program
    {
        static void Main(string[] args)
        {

      

            Console.WriteLine(Fonksiyon(2,4,1,2,1,9,9,9));

         



            foreach (var ogrenci in students)
            {
                Console.WriteLine(ogrenci);
            }


            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }
            

            
        }
        static int Fonksiyon(params int[] numbers)      // PARAMS metodu ile aynı tipte istedigimiz kadar parametre gönderebiliriz.
        {
            return numbers.Sum();
        }
        static string[] students = new[] { "Engin", "Derin", "Salih" };


        static string[,] regions = new string[7, 3]     //7 Bölge ve 3 Şehre göre ayırmak istersek yani Çok Boyutlu Dizi yi kullanırız.
        {
            {"İst","İzm","Bal" },
            {"Ank","Kon","Afyon" },
            {"Ant","Adana","Mer" },
            {"1","11","11" },
            {"2","22","222" },
            {"3","33","333" },
            {"4","44","444" }
        };

        


    }

  
    
}


    
