using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ThresholdBackup
{
    class OpenFolder
    {
        public void OpenLocation(string folderPath)
        {

            string absolutePath = Path.GetFullPath(folderPath);
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = absolutePath,
                    FileName = "explorer.exe"
                };
            Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist", absolutePath));
            }
        }
    }
}
