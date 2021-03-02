using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç, void bir şey döndürmez.
    //get- okumak için, set- yazmak için 
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
