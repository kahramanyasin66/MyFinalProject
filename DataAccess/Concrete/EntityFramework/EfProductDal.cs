using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) //using içinde yazdığın nesneler using bitince anında garbage collector tarafından yok edilir  IDisposable pattern implementation of C# 
            {
                var addedEntity = context.Entry(entity); //git verikaynağından benim bu gönderdiğim product'a bir tane nesne ile eşleştir.
                addedEntity.State = EntityState.Added; // o nesne eklenecek bir nesnedir diyoruz 
                context.SaveChanges(); // şimidide o nesneyi ekle dedik      
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();  
            }
        }     

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
                // tek bir kayıt istenince getirikecek olan filter kaydını getirir 
            }
        }
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
                // filtre null mı? evetse tümünü getir :"değilse" context.Set<Product>():Where(filter).ToList() demek  
            }
        }
        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
