using System;
using System.Collections.Generic;
using System.Text;

namespace DENEME1
{
    interface IKrediManager
    {


        double faizOrani = 0.15;

        public void KrediTutari(int anapara)
        {
            double Sonuc = anapara + faizOrani * anapara;
            Console.WriteLine(Sonuc);
        }


    }
   
}
