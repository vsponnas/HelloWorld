using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    /// <summary>
    /// NullMessageWritter
    /// </summary>
    public class NullMessageWritter : IMessageWriter//Null object Design
    {
        /// <summary>
        /// WriteMessage 
        /// </summary>
        /// <param name="message"></param>
        public void WriteMessage(string message)
        {
           //do nothing
        }
    }
}
