using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP33.LogServices
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Service enabled");
        }
    }
}
