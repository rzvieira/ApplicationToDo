using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Results
{
    public class CommonResult
    {
        public string[] Errors { get; set; }
        public bool Success { get; set; }
    }

    public class CommonResult<TResult> : CommonResult
    {
        public TResult Result { get; set; }
    }
}

