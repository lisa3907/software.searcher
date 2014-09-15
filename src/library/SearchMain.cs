using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

using Microsoft.Win32;

namespace SoftwareSearch.Library
{
    //=============================================================================================
    //
    //=============================================================================================
    /// <summary></summary>
    public partial class SearchMain : System.Windows.Forms.UserControl
    {
        //=========================================================================================
        //
        //=========================================================================================
        /// <summary></summary>
        public SearchMain()
        {
            this.InitializeComponent();

            this.m_licenseManager = new LicenseManager();
        }

        //=========================================================================================
        //
        //=========================================================================================
        private const string REGISTRY_KEY = @"software\Microsoft\Windows\CurrentVersion\Uninstall";

        //=========================================================================================
        //
        //=========================================================================================
        private LicenseManager m_licenseManager = null;

        //=========================================================================================
        //
        //=========================================================================================
        /// <summary></summary>
        /// <param name="filepath"></param>
        private void Save(string filepath)
        {
            XmlDocument xmldocument = new XmlDocument();
            xmldocument.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" ?><Results></Results>");

            foreach (ListViewItem item in this.lvSoftwareList.Items)
            {
                XmlElement element = this.CreateLicenseXmlElement(xmldocument, item);
                xmldocument.DocumentElement.AppendChild(element);
            }
            xmldocument.Save(filepath);
        }

        /// <summary></summary>
        /// <param name="xmldocument"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private XmlElement CreateLicenseXmlElement(XmlDocument xmldocument, ListViewItem item)
        {
            XmlElement element = xmldocument.CreateElement("License");

            XmlAttribute nameattribute = xmldocument.CreateAttribute("name");
            nameattribute.Value = item.SubItems[0].Text;
            element.Attributes.Append(nameattribute);

            XmlAttribute existattribute = xmldocument.CreateAttribute("exist");
            existattribute.Value = item.SubItems[2].Text;
            element.Attributes.Append(existattribute);

            return element;
        }

        //=========================================================================================
        //
        //=========================================================================================
        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            //01) 레지스트리 키를 검색합니다.
            RegistryKey uninstallKey = Registry.LocalMachine.OpenSubKey(REGISTRY_KEY);

            if (uninstallKey == null)
                return;

            //02) 모든 하위 키 이름이 포함된 문자열의 배열을 검색합니다.
            string[] subkeyNames = uninstallKey.GetSubKeyNames();

            List<string> softwareNames = new List<string>();

            foreach (string key in subkeyNames)
            {
                RegistryKey subkey = uninstallKey.OpenSubKey(key);

                if (subkey == null)
                    continue;

                //03) 소프트웨어 명칭을 가져옵니다.
                string displayName = subkey.GetValue("DisplayName", "").ToString();

                if (String.IsNullOrEmpty(displayName))
                    continue;

                softwareNames.Add(displayName);
            }

            softwareNames.Sort();

            foreach (string displayName in softwareNames)
            {
                string existname = this.m_licenseManager.Contains(displayName) ? "True" : "False";

                ListViewItem item = new ListViewItem(new string[] { displayName, "", existname });
                this.lvSoftwareList.Items.Add(item);
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = String.Format("{0}({1})", Environment.MachineName, DateTime.Now.ToShortDateString());
                dialog.Filter   = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return;

                this.Save(dialog.FileName);
            }
        }
    }
}