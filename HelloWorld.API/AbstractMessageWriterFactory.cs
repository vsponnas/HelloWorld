using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    /// <summary>
    /// AbstractMessageWriterFactory
    /// </summary>
    public abstract class AbstractMessageWriterFactory
    {
       public abstract IMessageWriter GetWritter(WritterType Writter);
    }

    /// <summary>
    /// WritterType
    /// </summary>
    public enum WritterType
    {
        Console,
        Mobile,
        WindowService
    }
}
