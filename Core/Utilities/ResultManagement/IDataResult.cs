using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManagement
{
    public interface IDataResult<T>:IResult
    {
        public T Data { get; set; }
    }
}
