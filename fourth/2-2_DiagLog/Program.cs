using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2_2_DiagLog
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog MyLog = new EventLog("X", "Richter", "Demo");
            Trace.AutoFlush = true;
            EventLogTraceListener MyListener = new EventLogTraceListener(MyLog);
            Trace.Write("This is a test");
        }
    }
}
