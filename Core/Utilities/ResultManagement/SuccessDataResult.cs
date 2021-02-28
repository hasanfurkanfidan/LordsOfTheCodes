using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManagement
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(message, true, data)
        {

        }
        public SuccessDataResult(T data) : base(true, data)
        {

        }

        public SuccessDataResult(string message) : base(message, true,default)
        {

        }

    }
}
