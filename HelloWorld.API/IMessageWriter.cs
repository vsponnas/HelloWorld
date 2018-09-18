using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{

    /// <summary>
    /// IMessageWriter
    /// </summary>
    public interface IMessageWriter
    {
        /// <summary>
        /// WriteMessage
        /// </summary>
        /// <param name="message"></param>
        void WriteMessage(string message);
        
    }
}
