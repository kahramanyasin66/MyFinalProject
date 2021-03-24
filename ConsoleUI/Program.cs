using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* ProductManager productManager = new ProductManager(new EfProductDal());
             foreach (var product in productManager.GetAll())
             {
                 Console.WriteLine(product.ProductName);
             }*/

            /* ProductManager productManager = new ProductManager(new EfProductDal());
             foreach (var product in productManager.GetAllByCategoryId(2))
             {
                 Console.WriteLine(product.ProductName);
             }*/

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,150))
            {
                Console.WriteLine(product.ProductId);
            }
        }
    }
}
