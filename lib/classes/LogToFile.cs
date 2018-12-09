using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThresholdBackup
{
    public class LogToFile
    {
        public void ThresholdLogger(string mType, string logMessage)
        {
            /* Creating the listener*/
            DefaultTraceListener defaultListener;
            defaultListener = new DefaultTraceListener();
            Trace.Listeners.Add(defaultListener);
            /*----------------------*/

            /*Adding a way to keep the time on the log*/
            DateTime localTime = DateTime.Now;
            
            // Try loop to write data to log
            try
            {
                Trace.WriteLine(localTime + " - " + mType + " - " + logMessage);
            }
            catch (FormatException e1)
            {
                Trace.WriteLine(localTime + " - " + e1.Message);
            }
            catch (DivideByZeroException e2)
            {
                Trace.WriteLine(localTime + " - " + e2.Message);
            }
        }
    }
}
