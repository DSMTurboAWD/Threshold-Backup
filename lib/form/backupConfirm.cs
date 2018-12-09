using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ThresholdBackup
{
    public partial class backupConfirm : Form
    {
        public backupConfirm()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.source;
            label2.Text = Properties.Settings.Default.destination;
        }

        private void RenderText6(PaintEventArgs e)
        {
            TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.EndEllipsis;
            TextRenderer.DrawText(e.Graphics, "This is some text that will be clipped at the end.", this.Font,
                new Rectangle(10, 10, 100, 50), SystemColors.ControlText, flags);
        }

        private void beginBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables for the backup process

                long timeTicks = DateTime.Now.Ticks;
                string zipName = "bak" + timeTicks + ".zip";
                string sourceDir = Properties.Settings.Default.source;
                string destDir = Properties.Settings.Default.destination;
                string backupSuccessMsg = "Backup " + zipName + " was created successfully at " + destDir + ".";

                Thread thread = new Thread(t =>
                {
                    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                    {
                        zip.AddDirectory(sourceDir);
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(sourceDir);
                        zip.SaveProgress += Zip_SaveProgress;
                        zip.SaveProgress += Zip_NumberProgress;
                        zip.Save(destDir + "\\" + zipName);

                        // Attempting to log the file name to the Log Service
                        //ThresholdServiceMonitor sendToLog = new ThresholdServiceMonitor();
                        //sendToLog.ThresholdWriteLog(backupSuccessMsg);

                        // Attempt to write to the log file in the program directory
                        LogToFile updateLogData = new LogToFile();
                        updateLogData.ThresholdLogger("Success", backupSuccessMsg);

                    }
                })
                { IsBackground = true };
                thread.Start();
            }
            catch (IOException err)
            {
                MessageBox.Show("Something went wrong" + System.Environment.NewLine
                    + "IOException source: {0}", err.Source);
            }
        }

        private void cancelClose_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var form1 = (WinZipSharp)Tag;
                form1.Show();
                Close();
            }
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = e.EntriesSaved + 1;
                    progressBar.Update();
                    
                }));
                if (progressBar.Value == progressBar.Maximum)
                {
                    MessageBox.Show("Done!", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Zip_NumberProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressText.Invoke(new MethodInvoker(delegate
                {
                    progressText.Text = ((int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer)).ToString();
                    //progressText.Maximum = 100;
                    //progressText.Value = 
                    progressText.Update();
                }));
            }
        }

        private void backupConfirm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
