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

            //ProductTest();
            //CategoryTest();
            ProductTest2();
        }

        private static void ProductTest2()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
                var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
               
                Console.WriteLine(result.Message);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40, 150).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        
    }
}
