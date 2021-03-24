using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Bunu işaretleyerek amaçladığımız şey IEntity  bu adamın referansını tutsun yani Category'nin 
    // ve bilirizki böylelikle Category bir veritabanı nesnesidir 

    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName  { get; set; }

    }
}
