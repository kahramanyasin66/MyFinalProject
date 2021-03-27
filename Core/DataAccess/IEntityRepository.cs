using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess 
{
    // generic constraint : generik kısıt
    // class : referans tip olmasını istiyoruz demek 
    // IEntity : IEntity olabilir "veri tabanı nesnesi" veya onu implemente eden başka bir nesne olabilir 
    // IEntityRepository implemente eden sınıf type olarak IEntity de verebilmekte buda istemediğimiz bir olay ve onuda new() yazarak kırıyoruz Nasıl kırıyoruz IEntity bir inteface'dir ve newlenemez :D  

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//GetAll=hepsini getir demek linq ile filtrelemeyi sağlar
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
     
    }
}
