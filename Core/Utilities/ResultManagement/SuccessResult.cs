﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManagement
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(message,true)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
