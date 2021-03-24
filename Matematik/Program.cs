using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            ISLEMLER sonucver = new ISLEMLER();

           sonucver.ToplamaYap(15, 10);
            sonucver.TOPLA(5, 153);

            ISLEMLER topla = new ISLEMLER();
            topla.TOPLA(100, 200);
            

        }


    } 
}
