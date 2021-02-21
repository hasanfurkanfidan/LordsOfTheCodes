using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManagement
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(message,false,data)
        {

        }
        public ErrorDataResult(T data):base(false,data)
        {

        }
    }
}
