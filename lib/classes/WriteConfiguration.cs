using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThresholdBackup
{
    public class WriteConfiguration
    {
        public void CreateStructure()
        {
            string path = "resource/";
            Directory.CreateDirectory(path);
        }

        public void writeToFile(string sourceDirectory, string destinationDirectory)
        {
            try
            {
                // TODO: Need to separate the create from the write functions here

                string path = "resource/";
                string file = "resource/backup.txt";
                
                TextWriter tw = new StreamWriter(file);

                // write lines of text to the file
                tw.WriteLine(sourceDirectory);
                tw.WriteLine(destinationDirectory);

                // close the stream     
                tw.Close();
                
            }

            catch (Exception e)
            {
                LogToFile writeSettingsToFile = new LogToFile();
                writeSettingsToFile.ThresholdLogger("Process failed", e.Message);
            }
        }

        public Tuple<string, string> ReadFromFile()
        {
            // create reader & open file
            TextReader tr = new StreamReader("resource/backup.txt");

            // read lines of text
            string sourceDirectory = tr.ReadLine();
            string destinationDirectory = tr.ReadLine();

            // close the stream
            tr.Close();
            return Tuple.Create(sourceDirectory, destinationDirectory);
        }
    }
}
