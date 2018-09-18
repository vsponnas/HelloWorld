using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.API;

namespace HelloWorldDemo
{
    /// <summary>
    /// HelloWorld
    /// </summary>
    class HelloWorld
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main()
        {
            //Write message to console
            ConsoleMessageWriter _consoleMessageWriter = new ConsoleMessageWriter();
            _consoleMessageWriter.WriteMessage("Hello World!");

            //Ready any key
            Console.ReadKey();
        }
    }
}
