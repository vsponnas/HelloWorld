using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    /// <summary>
    /// MessageWritterFactory 
    /// </summary>
    public class MessageWritterFactory : AbstractMessageWriterFactory
    {
        /// <summary>
        /// IMessageWriter 
        /// </summary>
        /// <param name="Writter"></param>
        /// <returns></returns>
        public override IMessageWriter GetWritter(WritterType Writter)
        {
            if (Writter == WritterType.Console)
                return new ConsoleMessageWriter();
            else if (Writter == WritterType.Mobile)
                return new MobileMessageWriter();
            //list go on based on implemetation
            return new NullMessageWritter();
        }
    }
}
