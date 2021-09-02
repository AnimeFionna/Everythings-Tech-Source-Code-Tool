using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace EtOptimizationProgram
{
	// Token: 0x0200000A RID: 10
	public class XmlFile
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000A798 File Offset: 0x00008998
		public static void xmlCreate()
		{
			try
			{
				if (!Directory.Exists(XmlFile.root))
				{
					Directory.CreateDirectory(XmlFile.root);
				}
				if (!File.Exists(XmlFile.path))
				{
					XDocument xdocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new object[]
					{
						new XElement("Data", new object[]
						{
							new XElement("FirstTime", "True"),
							new XElement("DisclaimerAccepted", "False"),
							new XElement("CheckForUpdates", "True"),
							new XElement("DisplayWarning", "True"),
							new XElement("LowLatencyChecked", "False"),
							new XElement("HighPerformanceChecked", "False"),
							new XElement("Check1Checked", "False"),
							new XElement("Check2Checked", "False"),
							new XElement("Check3Checked", "False"),
							new XElement("Check4Checked", "False"),
							new XElement("Check5Checked", "False"),
							new XElement("Check6Checked", "False"),
							new XElement("Check7Checked", "False"),
							new XElement("Check8Checked", "False"),
							new XElement("Check9Checked", "False"),
							new XElement("Check10Checked", "False"),
							new XElement("Check11Checked", "False"),
							new XElement("Check12Checked", "False"),
							new XElement("Check13Checked", "False"),
							new XElement("Check14Checked", "False"),
							new XElement("Check15Checked", "False"),
							new XElement("Check16Checked", "False"),
							new XElement("Check17Checked", "False"),
							new XElement("Check18Checked", "False"),
							new XElement("Check19Checked", "False"),
							new XElement("Check20Checked", "False"),
							new XElement("Check21Checked", "False"),
							new XElement("Check22Checked", "False")
						})
					});
					xdocument.Save(XmlFile.path);
				}
				else
				{
					XmlFile.xmlPatch("FirstTime", "True");
					XmlFile.xmlPatch("DisclaimerAccepted", "False");
					XmlFile.xmlPatch("CheckForUpdates", "True");
					XmlFile.xmlPatch("DisplayWarning", "True");
					XmlFile.xmlPatch("LowLatencyChecked", "False");
					XmlFile.xmlPatch("HighPerformanceChecked", "False");
					XmlFile.xmlPatch("Check1Checked", "False");
					XmlFile.xmlPatch("Check2Checked", "False");
					XmlFile.xmlPatch("Check3Checked", "False");
					XmlFile.xmlPatch("Check4Checked", "False");
					XmlFile.xmlPatch("Check5Checked", "False");
					XmlFile.xmlPatch("Check6Checked", "False");
					XmlFile.xmlPatch("Check7Checked", "False");
					XmlFile.xmlPatch("Check8Checked", "False");
					XmlFile.xmlPatch("Check9Checked", "False");
					XmlFile.xmlPatch("Check10Checked", "False");
					XmlFile.xmlPatch("Check11Checked", "False");
					XmlFile.xmlPatch("Check12Checked", "False");
					XmlFile.xmlPatch("Check13Checked", "False");
					XmlFile.xmlPatch("Check14Checked", "False");
					XmlFile.xmlPatch("Check15Checked", "False");
					XmlFile.xmlPatch("Check16Checked", "False");
					XmlFile.xmlPatch("Check17Checked", "False");
					XmlFile.xmlPatch("Check18Checked", "False");
					XmlFile.xmlPatch("Check19Checked", "False");
					XmlFile.xmlPatch("Check20Checked", "False");
					XmlFile.xmlPatch("Check21Checked", "False");
					XmlFile.xmlPatch("Check22Checked", "False");
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1001);
				MessageBox.Show("XML creation failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000AC98 File Offset: 0x00008E98
		public static void xmlPatch(string xmlElement, string xmlValue)
		{
			try
			{
				XDocument xdocument = XDocument.Load(XmlFile.path);
				if (xdocument.Root.Element(xmlElement) == null)
				{
					xdocument.Root.Add(new XElement(xmlElement, xmlValue));
					xdocument.Save(XmlFile.path);
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1002);
				MessageBox.Show("XML patching failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				if (File.Exists(XmlFile.path))
				{
					File.Delete(XmlFile.path);
				}
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000AD3C File Offset: 0x00008F3C
		public static void xmlWrite(string getElement, string GetValue)
		{
			try
			{
				XDocument xdocument = XDocument.Load(XmlFile.path);
				xdocument.XPathSelectElement("//Data/" + getElement).Value = GetValue;
				xdocument.Save(XmlFile.path);
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1003);
				MessageBox.Show("XML writing failed, closing now.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		public static string xmlRead(string getElement)
		{
			XDocument xdocument = XDocument.Load(XmlFile.path);
			return xdocument.Root.Element(getElement).Value;
		}

		// Token: 0x04000060 RID: 96
		public static string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString(), "ETOptProgram");

		// Token: 0x04000061 RID: 97
		public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString(), "ETOptProgram\\ETOptProgram.xml");
	}
}
