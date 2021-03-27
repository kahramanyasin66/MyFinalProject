using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
        {
            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }
            public ErrorDataResult(T data) : base(default, false) // bura sadece data isteyen message istemeyen için 
            {

            }
            public ErrorDataResult(string message) : base(default, false, message) // bura sadece message isteyen kullanıcı için 
            {

            }
            public ErrorDataResult() : base(default, false) // bura sadece bool değer isteyen için true yada false
            {

            }
       }
}
