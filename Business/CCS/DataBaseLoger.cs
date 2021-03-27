using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class DataBaseLoger
    {
        public class DataBaseLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Veritabanına Loglandı");
            }
        }
    }
}
