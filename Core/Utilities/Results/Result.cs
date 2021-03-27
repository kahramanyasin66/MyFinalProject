using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

        public Result(bool success, string message):this(success) // this ile yazdığımız alttaki cons. çalışsın diye 
        {
            Message = message;
            /*Success = success; Bunu burdan aldık artık */

        }
        public Result(bool success) // Bunu adam message'a gerek yok true,false yeterli derse diye yaptık yukarıyı çalıştırmaz bunu çalıştrırı direk
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
