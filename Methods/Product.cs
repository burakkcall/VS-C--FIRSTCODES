using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        

        //public int Id; ( Bu FIELD dir.Aşağıdaki ise Property --( GET - SET olmadan da çalışır; get istenilen değer ise set verilen değerdir.

        // Propperty -- Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int stokAdedi { get; set; }

    }
}
