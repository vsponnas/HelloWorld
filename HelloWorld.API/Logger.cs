using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    /// <summary>
    /// Logger 
    /// </summary>
    public class Logger : ILogger
    {
        public AbstractMessageWriterFactory _writerFactory;

        /// <summary>
        /// Logger
        /// </summary>
        /// <param name="WriterFactory"></param>
        public Logger(AbstractMessageWriterFactory WriterFactory)
        {
            if (WriterFactory != null)
                throw new Exception("writer factory cannot not be null");
            this._writerFactory = WriterFactory;
        }

        /// <summary>
        /// LogMessage
        /// </summary>
        /// <param name="message"></param>
        public void LogMessage(string message)
        {
            var writter = this._writerFactory.GetWritter(WritterType.Console);//Can be replaced having config setting inside app.config
            writter.WriteMessage(message);
        }
    }
}
