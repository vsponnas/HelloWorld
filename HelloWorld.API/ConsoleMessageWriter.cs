using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    /// <summary>
    /// ConsoleMessageWriter
    /// </summary>
    public class ConsoleMessageWriter : IMessageWriter
    {
        /// <summary>
        /// WriteMessage
        /// </summary>
        /// <param name="message"></param>
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
