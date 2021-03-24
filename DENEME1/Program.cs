using System;

namespace DENEME1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ana paranız ne kadar ?");
            int anapara = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kredi seçiniz : \n1- Kredi1 \n2-Kredi 2 \n3- Kredi 3");
            //int secim = Convert.ToInt32(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("Kredi 1i seçtiniz");
            //        double faizOrani1 = 0.10;
            //        kredi1.KrediTutari(anapara, faizOrani);
            //        break;
            //    case 2:
            //        Console.WriteLine("Kredi 2i seçtiniz");
            //        double faizOrani2 = 0.15;
            //        kredi2.KrediTutari(anapara, faizOrani1);
            //        break;
            //    case 3:
            //        Console.WriteLine("Kredi 3ü seçtiniz");
            //        double faizOrani3 = 0.20;
            //        kredi3.KrediTutari(anapara, faizOrani2);
            //        break;
            //}









            IKrediManager[] krediDizi = new IKrediManager[] { new Kredi1(), new Kredi2(), new Kredi3() };

            foreach (var kredi in krediDizi)
            {
                kredi.KrediTutari(anapara);

            }









        }
    }


}
