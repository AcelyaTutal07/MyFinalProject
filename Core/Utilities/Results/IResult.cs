using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // temel voidler için başlangıç
   public  interface IResult
    {
        bool Success { get;  } // yaptığımmız işlemi başarılı true / başarısız false
        string Message { get; } 
    }
}
