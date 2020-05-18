using System;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Log log = new Log();
            log.LogMessage("This is log message : -" + DateTime.Now.ToString());


        }

      
    }
}
