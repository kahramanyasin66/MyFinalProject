using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; 

        public CategoryManager(ICategoryDal categoryDal) //Bağımlılığı Constractor Enjektion ile yapıyorum 
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll(); //_categoryDal'daki tüm nesneleri bana ver  
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId == categoryId);
            // git veri tabanına c takma isim vererek bütün tabloyu gez benim verdiğim categoryId'deki kolonu bana getir  
        }
    }
}
