using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace ThresholdBackup.lib.service
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
            Thread log = new Thread(new ThreadStart(this.ThresholdWriteLog));
            log.Start();
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
