using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
// birinci yapıda mesaj gönderiyor ve Result-base true olarak success yapıyor ve message yazılıyır.
//ikinci yapıda mesaj yazılmıyor sadece true olduğunu gösteriyor.
