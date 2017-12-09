using System;
using System.Diagnostics;

namespace _2_1_DiagLog
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!EventLog.SourceExists("Demo"))
            {
                EventLog.CreateEventSource("Demo", "MyNewLog");
            }
            EventLog logDemo = new EventLog
            {
                Source = "MySource",
            };
            logDemo.WriteEntry("Hello world");

            Console.WriteLine("yeah");
        }
    }
}
