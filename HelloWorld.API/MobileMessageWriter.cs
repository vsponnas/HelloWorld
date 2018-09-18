using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HelloWorld.API
{
    /// <summary>
    /// MobileMessageWriter
    /// </summary>
    public class MobileMessageWriter : IMessageWriter
    {

        /// <summary>
        /// WriteMessage
        /// </summary>
        /// <param name="message"></param>
        public void WriteMessage(string message)
        {
            //TODO - This can be extended to write output in application/Json format for mobile applications

            //HttpContext.Current.Response.ContentType = "application/Json";
            //HttpContext.Current.Response.Write(message);
        }
    }
}
