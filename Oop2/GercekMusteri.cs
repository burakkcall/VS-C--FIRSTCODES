using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class GercekMusteri:Musteri
    {
        // public int Id { get; set; }
        // public string MusteriNo { get; set; }      Musteri class ının alt yapıyısı oldugunu belli ettik zaten.(Gerçek - Tüzel)
        // Musteri class ı EBEVEYN GİBİ
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
