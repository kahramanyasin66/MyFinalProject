using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        // Bütün methodların dışında tanımladığımız için bu class için global bir değişken oluyor bu yüzden bunlara _ altçizgi koyuyoruz .Net projelerinde kullanılan bir isimlendirme standartı naming convension....
        public InMemoryProductDal()//Constructor bellekte ref aldığı zaman çalışacak blok direk class ismi kullanılır
        {
            //Oracle, SwlServer,Postgres, MongoDb gibi veritabanlarından geldiğini düşünüyoruz buranın
            _products = new List<Product> {
            new Product {CategoryId=1, ProductId=1,  ProductName="IPhone7", UnitInStok=1, UnitPrice=500},
            new Product {CategoryId=1, ProductId=2,  ProductName="IPhone8", UnitInStok=2, UnitPrice=600},
            new Product {CategoryId=1, ProductId=3,  ProductName="IPhone10", UnitInStok=2, UnitPrice=700},
            new Product {CategoryId=1, ProductId=4,  ProductName="IPhone11", UnitInStok=5, UnitPrice=800},
            new Product {CategoryId=1, ProductId=5,  ProductName="IPhone12", UnitInStok=4, UnitPrice=900}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);//tekbir eleman bulmaya yarar SOD

             
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul demek 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitInStok = product.UnitInStok;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;


        }
    }
}
