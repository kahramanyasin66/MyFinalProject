using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }
        public SuccessDataResult(T data):base(data,true) // bura sadece data isteyen message istemeyen için 
        {

        }
        public SuccessDataResult(string message):base (default,true,message) // bura sadece message isteyen kullanıcı için 
        {

        }
        public SuccessDataResult():base (default,true) // bura sadece bool değer isteyen için true 
        {

        }
    }
}
