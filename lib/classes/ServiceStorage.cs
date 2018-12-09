using System.Diagnostics;
using System.ServiceProcess;

namespace ThresholdBackup
{
    public partial class ThresholdServiceMonitor : ServiceBase
    {
        public void ThresholdBackupService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("ThreshLog"))
            {
                EventLog.CreateEventSource("ThresholdBak", "ThreshLog");
            }
            eventLog1.Source = "ThresholdBak";
            eventLog1.Log = "ThreshLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Service Started");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Service Halted");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue");
        }

        public void ThresholdWriteLog(string thresholdLogData)
        {
            eventLog1.WriteEntry(thresholdLogData);
        }
    }
}
