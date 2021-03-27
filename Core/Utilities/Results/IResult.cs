using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult  // void methodalar için burası 
    {
        bool Success { get; }
        string Message { get; }

    }
}
