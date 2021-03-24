using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product1 product) // sen bana product1 isminde bi dizin göndereceksin ben onu product isminde tutacam gibi
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product1 product)    // VOİD : Emir kipinde git ve ekle diyor veya git ve şunu yap
        {
            Console.WriteLine(product.ProductName + "güncellendi.");

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); 
        }

    }
}
