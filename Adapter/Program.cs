using Microsoft.Extensions.Logging;
using System;
//using Microsoft.Extensions.Logging;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new FileLogger<Program>("Log.txt");
            logger.LogDebug("This is a new log message");

        }
    }
}