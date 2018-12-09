using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThresholdBackup.lib.classes
{
    class ReadXML
    {
        public Tuple<string, string> ParseXMLFile (string file)
        {
            string mySource = "";
            string myDestination = "";

            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            XmlNode node = doc.DocumentElement.SelectSingleNode("/fileAttribute");
            mySource = node.Attributes["Source"]?.InnerText;
            myDestination = node.Attributes["Destination"]?.InnerText;

            return Tuple.Create(mySource, myDestination);
        }
    }
}
