using System;
using System.IO;

namespace ConsoleApp1
{
    public class Log
    {
        static string dir = @"C:\Users\mibisen\source\repos\logdemo";
        static string fileName = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000) + ".txt";
        static string file = Path.Combine(dir, fileName);

        public void LogMessage(string logMessage)
        {
            using (StreamWriter w = File.AppendText(file))
            {
                w.Write("Log Entry : ");
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine("-------------------------------");
                w.WriteLine($"Message - > :{logMessage}");
            }
        }

        //public void DumpLog(StreamReader r)
        //{
        //    string line;
        //    while ((line = r.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}
    }
}
