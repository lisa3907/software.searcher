using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SoftwareSearch.Library
{
    //=============================================================================================
    //
    //=============================================================================================
    /// <summary></summary>
    public class LicenseManager
    {
        //=========================================================================================
        //
        //=========================================================================================
        /// <summary></summary>
        public LicenseManager()
        {
            this.Initialize();
        }

        //=========================================================================================
        //
        //=========================================================================================
        private List<string> m_list = new List<string>();

        //=========================================================================================
        //
        //=========================================================================================
        /// <summary></summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(string item)
        {
            return this.m_list.Contains(item);
        }

        //=========================================================================================
        //
        //=========================================================================================
        /// <summary></summary>
        private void Initialize()
        {
            string licenselistPath = Path.Combine(Application.StartupPath, "LicenseList.xml");

            if (File.Exists(licenselistPath) == false)
                return;

            string licenselistContent = String.Empty;

            using (StreamReader reader = new StreamReader(licenselistPath, Encoding.UTF8))
            {
                licenselistContent = reader.ReadToEnd();
            }

            XmlDocument xmldocument = new XmlDocument();
            xmldocument.LoadXml(licenselistContent);

            XmlNodeList nodelist = xmldocument.GetElementsByTagName("license");

            foreach (XmlNode node in nodelist)
            {
                if (this.m_list.Contains(node.InnerText))
                    continue;

                this.m_list.Add(node.InnerText);
            }
        }
    }
}