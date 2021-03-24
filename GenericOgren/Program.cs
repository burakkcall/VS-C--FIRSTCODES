using System;

namespace GenericOgren
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass < Ornek, Mesela > m1 = new MyClass<Ornek, Mesela>();    //// geneldeTyazilir isimli verdiğim parametre "Ornek" tipine bürünecektir. Ne verirsen ona bürünür.

        }
    }

    class MyClass<geneldeTyazilir, X>      
    {
        geneldeTyazilir t;
    }
    class Ornek
    {

    }
}
