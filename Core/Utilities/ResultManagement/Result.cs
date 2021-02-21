using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManagement
{
    public class Result : IResult
    {
        public Result(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
