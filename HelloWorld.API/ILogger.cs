using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    /// <summary>
    /// ILogger
    /// </summary>
    public interface ILogger
    {

        /// <summary>
        /// LogMessage
        /// </summary>
        /// <param name="message"></param>
        void LogMessage(string message);
    }
}
