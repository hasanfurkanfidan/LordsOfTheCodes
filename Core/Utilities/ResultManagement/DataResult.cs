using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManagement
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(string message, bool isSuccess, T data) : base(message, isSuccess)
        {
            Data = data;
        }
        public DataResult(bool isSuccess,T data):base(isSuccess)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
