using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
     /* property ve contex nesnelerini yani product ,customer, northwindcontext gibi nesneleri buradan fixle*/
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //using içinde yazdığın nesneler using bitince anında garbage collector tarafından yok edilir  IDisposable pattern implementation of C# 
            {
                var addedEntity = context.Entry(entity); //git verikaynağından benim bu gönderdiğim product'a bir tane nesne ile eşleştir.
                addedEntity.State = EntityState.Added; // o nesne eklenecek bir nesnedir diyoruz 
                context.SaveChanges(); // şimidide o nesneyi ekle dedik      
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
                // tek bir kayıt istenince getirilecek olan filter kaydını getirir 
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
                // filtre null mı? evetse tümünü getir :"değilse" context.Set<Product>():Where(filter).ToList() demek  
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        /* EfProductDal'dan aldık burayı
         * SingleOrDefault ve Expression using or default yaparak ekleyince düzeliyor unutabilirsin         
         */
    }
}
