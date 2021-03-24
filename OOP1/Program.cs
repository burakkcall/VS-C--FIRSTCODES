using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1 productA = new Product1();
            productA.Id = 1;
            productA.CategoryId = 2;    // 2 numara mobilyaya karşılık geliyor
            productA.ProductName = "Masa";
            productA.UnitPrice = 500;
            productA.UnitsInStock = 3;                              

            Product1 productB = new Product1 {Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice=35, UnitsInStock=5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(productA);



                 
        }
    }
}
