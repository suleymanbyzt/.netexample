using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product()
            {
                ID = 2,
                CategoryId = 3,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 20
            };
            
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            // return değer dönderme
            int toplamasonucu = productManager.Topla(2, 5);

            Console.WriteLine(toplamasonucu*2);
            

        }
    }
}