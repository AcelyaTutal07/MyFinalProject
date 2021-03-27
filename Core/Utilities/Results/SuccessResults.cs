using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResults: Result
    {
        public SuccessResults(string message) : base(true,message)
        {

        }

        public SuccessResults():base(true)
        {

        }
    }
}
