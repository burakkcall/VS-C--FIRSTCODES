using System;

namespace AbstractClasslar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
    abstract class Ornek
    // BU SINIF İÇERİSİNDE ( ABSTRACT ) Property veya Metodlar, bu sınıftan Kalıtım alan her sınıfta yazılmak veya uygulanmak zorundadır.
    // Sadece imzaları yazacagız, gövdeler yok. Abstractlar dan NESNE YARATILMAZ fakat referansı alınabilir.
    {
        abstract public void X();
        public abstract int  Y { get; set; }
    }

    class Calisma : Ornek
    {
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void X()
        {
            Console.WriteLine("Override = Ezilmiş Sınıf , Virtual = Asıl gerçek olan");
        }
    }
}


            
