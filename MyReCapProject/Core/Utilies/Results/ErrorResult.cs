using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilies.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {

        }
        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}
