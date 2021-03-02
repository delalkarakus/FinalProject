using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
//Result DataResultı inherit ediyor.Yeni DataResult bir Resultdır. Yani resullttaki yapıları içeriyotr.
//IDataResul ise interface yapıyor. yani DataResult aynı zamanda IDataResultın kodlarını kullanabiliyor.
//DataResultın base'i Result, Resultın This yapmıştık.
