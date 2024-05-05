using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileLogger<T> : FileStream, ILogger<T>
    {
        public FileLogger(string path) : base(path, FileMode.Append) { } 

        public IDisposable? BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            byte[] messageByteArray = new UTF8Encoding(true).GetBytes(state.ToString() + "\n");
            Write(messageByteArray, 0, messageByteArray.Length);
            Flush();
        }
    }
}
