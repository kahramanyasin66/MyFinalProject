using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }  // Sen Message ve true false döndüreceksin "IResult" onun yanında birde Data döndürmelisin void değilsin      
         
    }
}
