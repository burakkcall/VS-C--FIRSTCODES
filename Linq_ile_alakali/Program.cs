using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_ile_alakali
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
             {
                 new Category{CategoryId = 1, CategoryName= "Bilgisayar"},
                 new Category{CategoryId = 1, CategoryName= "Telefon"}
             };

            List<Product> products = new List<Product>
            {
                new Product{ProductId= 1, CategoryId =1, ProductName="Acer laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=5},
                new Product{ProductId= 2, CategoryId =1, ProductName="HP laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=6},
                new Product{ProductId= 3, CategoryId =2, ProductName="Apple telefon", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
                new Product{ProductId= 4, CategoryId =2, ProductName="Xiaomi telefon", QuantityPerUnit="4 GB Ram", UnitPrice=9000, UnitsInStock=3},

            };



            //LinqTest(products);

            //GetProducts(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTEST(products);

            //AscDscWHEREtest(products);

            //KomutlarlaFiltreleme(products);
        }

        private static void KomutlarlaFiltreleme(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 8000
                         orderby p.UnitPrice
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDscWHEREtest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            // Descending -- Düşen yani çoktan aza sıralar.                // Fiyata göre sıralayarak gösterir.   // Z den A ya ters alfabetik sırayla getir. Yani DÜŞEN-DESC
            foreach (var IcindetopGecenUrun in result)
            {
                Console.WriteLine(IcindetopGecenUrun.ProductName);
            }
        }

        private static void FindAllTEST(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));  // İsminde 'top' geçeni gösterir
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 2);  // Bu kriterde ürünü bulur bize.
            Console.WriteLine(result);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer laptop");  // Varmı Yok mu diye sorgular ( true-false döndürür)
            Console.WriteLine(result);
        }

        private static void LinqTest(List<Product> products)
        {
            Console.WriteLine("Algoritmik ile yapım -------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 8000 && product.UnitsInStock > 0)
                {
                    Console.WriteLine(product.ProductName);

                }
            }

            Console.WriteLine("Linq ile ---------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3); // p = product'a verdiğimiz isim

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }   // + ya basınca açabilirsin.

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();

            foreach (var p in products)
            {
                if (p.UnitPrice>5000 && p.UnitsInStock > 0)
                {
                    filteredProduct.Add(p);
                }
            }

            return filteredProduct;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {

            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();   // Bu satırdaki Where foreach ı sağlıyor. 
                    // Array oldugu için kızıyor; .Tolist LİSTEYE ÇEVİRİR ve düzeltir.
        }






    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
