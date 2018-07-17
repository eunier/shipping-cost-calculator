using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DistanceGetter
    {
        FrmCalculator frmCalculator;

        public DistanceGetter(FrmCalculator frmCalculator)
        {
            this.frmCalculator = frmCalculator;
        }

        public double GetDrivingDistanceInMiles(string origin, string destination)
        {
            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origin + "&destinations=" + destination +
              "&mode=driving&sensor=false&language=en-EN&units=imperial";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);


            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                try
                {
                    XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
                    return Convert.ToDouble(distance[0].ChildNodes[1].InnerText.Replace(" mi", ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, check the address imput to see if is correct .", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    frmCalculator.clear();
                    frmCalculator.ResetTextBoxesText();
                }
            }

            return 0;
        }
    }
}
