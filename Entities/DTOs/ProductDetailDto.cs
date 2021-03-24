using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto //=>> Generate type'Dto' => Generate new type yaparak oluşturduk Core\Entities altında bir imza interface 
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }

        public string  CategoryName { get; set; }

        public  short UnitsInStock { get; set; }
    }
}
