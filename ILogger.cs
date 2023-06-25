using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface ILogger
    {
        void LogInfo(string message);
        void LogError(string errorMessage);
    }

    class FileLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("This is the Information");
        }
        public void LogError(string errorMessage)
        {
            Console.WriteLine("This is the Error");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("This is the The Database");
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine("This is the Error in the Database.");
        }
    }
}
