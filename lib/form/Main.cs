using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

// This is the Threshold Computing Zip File program
// This was written as a simple experiment and code is available without charge
// The code is also heavily commmented for clarity
namespace ThresholdBackup
{
    public partial class WinZipSharp : Form
    {
        public WinZipSharp()
        {
            InitializeComponent();

            // SplashScreenStart();

            // Creates the save file structure
            WriteConfiguration createStructure = new WriteConfiguration();
            createStructure.CreateStructure();

            // Check if this is the first time running
            if (Properties.Settings.Default.FirstRun == true)
            {
                MessageBox.Show("Welcome to the backup utility!" + System.Environment.NewLine +
                    "Please see help for more information", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.source = null;
                Properties.Settings.Default.destination = null;
                Properties.Settings.Default.Save();

            }

            // Sets text boxes to previously used source and destinations
            if (Properties.Settings.Default.source != null)
            {
                sourceTextBox.Text = Properties.Settings.Default.source;
            }

            if (Properties.Settings.Default.destination != null)
            {
                destinationTextBox.Text = Properties.Settings.Default.destination;
            }
            //**********************************************************//
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (true)
            {
                aboutZip displayVersionInfo = new aboutZip();
                displayVersionInfo.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceDirectory = new FolderBrowserDialog();
            sourceDirectory.Description = "Select a source folder";
           
            if (sourceDirectory.ShowDialog() == DialogResult.OK)
                sourceTextBox.Text = sourceDirectory.SelectedPath; 
            string Source = sourceDirectory.SelectedPath;
            Properties.Settings.Default.source = Source;
            Properties.Settings.Default.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.destination != null && Properties.Settings.Default.source != null)
            {
                backupConfirm confirmBackup = new backupConfirm();
                confirmBackup.Tag = this;
                confirmBackup.Show(this);
                Hide();
            }
            else if (Properties.Settings.Default.destination == @"c:\example\destination" || 
                Properties.Settings.Default.source == @"c:\example\source")
            {
                MessageBox.Show("This is not a valid directory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Please specify a source and destination directory", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog destinationDirectory = new FolderBrowserDialog();
            destinationDirectory.Description = "Select a destination folder";

            if (destinationDirectory.ShowDialog() == DialogResult.OK)
                destinationTextBox.Text = destinationDirectory.SelectedPath;            
            string d1 = destinationDirectory.SelectedPath;
            string d2 = "\\";
            string Destination = d1 + d2;
            Properties.Settings.Default.destination = Destination;
            Properties.Settings.Default.Save();
        }

        private void WinZipSharp_Load(object sender, EventArgs e)
        {

        }

        private void SplashScreenStart()
        {
            try
            {
                splashLogo splashStart = new splashLogo();
                Thread startScreen = new Thread(splashStart.Show);

                startScreen.Start();
                splashStart.Show();
                Thread.Sleep(1000);
                splashStart.Close();
                startScreen.Abort();
            }

            catch (Exception e3)
            {
                LogToFile splashError = new LogToFile();
                splashError.ThresholdLogger("Splash screen could not load: ", e3.Message);
                MessageBox.Show("Something went wrong, \nPlease see log for more information \n" + e3.Message);
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.source != null && Properties.Settings.Default.destination != null)
                {
                    string source = Properties.Settings.Default.source;
                    string destination = Properties.Settings.Default.destination;
                    WriteConfiguration saveData = new WriteConfiguration();
                    saveData.writeToFile(source, destination);
                }
                MessageBox.Show("Configuration saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            catch (Exception e1)
            {
                LogToFile saveError = new LogToFile();
                saveError.ThresholdLogger("Could not save configuration", e1.Message);
                MessageBox.Show("Something went wrong, \nPlease see log for more information \n");
            }
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFolder openLog = new OpenFolder();
                openLog.OpenLocation("log/");
            }

            catch (Exception e2)
            {
                LogToFile viewErrorLog = new LogToFile();
                viewErrorLog.ThresholdLogger("Could not open file location: ", e2.Message);
            }
        }

        private void loadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteConfiguration loadSettings = new WriteConfiguration();
            string source = loadSettings.ReadFromFile().Item1;
            string destination = loadSettings.ReadFromFile().Item2;


            // TODO: feed these variables to the settings files
            MessageBox.Show("Source: " + source + "\nDestination: " + destination);
            Properties.Settings.Default.source = source;
            Properties.Settings.Default.destination = destination;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            try
            {
                sourceTextBox.Text = source;
                destinationTextBox.Text = destination;
            }
            catch (Exception e4)
            {
                LogToFile loadSettingsErr = new LogToFile();
                loadSettingsErr.ThresholdLogger("Could not load your settings: ", e4.Message);
            }
        }

        private void rollTheDiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomGenerator.FancyRandom thisRandom = new RandomGenerator.FancyRandom();
            int data = thisRandom.MyGenerator(3, 20);
            MessageBox.Show("Your dice roll equals: " + data);

        }
    }
}
