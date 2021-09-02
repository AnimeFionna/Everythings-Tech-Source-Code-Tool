using System;
using System.IO;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x02000003 RID: 3
	internal class ApplicationCrash
	{
		// Token: 0x02000004 RID: 4
		public static class ExLogging
		{
			// Token: 0x0600000E RID: 14 RVA: 0x000038C8 File Offset: 0x00001AC8
			public static void ETOptLog(Exception error, int errNum)
			{
				string text = Path.Combine(Environment.CurrentDirectory.ToString(), "ETOptLogs");
				string path = Path.Combine(text, DateTime.Today.ToString("dd-MM-yy") + "ETOptLog.txt");
				string newLine = Environment.NewLine;
				if (errNum == 1000)
				{
					ApplicationCrash.ExLogging.errorDesc = "Program start-up error.";
					ApplicationCrash.ExLogging.errorSol = "Send your XML file to the creator along with the error message.";
				}
				if (errNum == 1001)
				{
					ApplicationCrash.ExLogging.errorDesc = "Xml file creation failed.";
					ApplicationCrash.ExLogging.errorSol = "Temporarily disable your antivirus, it may be removing the file(s).";
				}
				if (errNum == 1002)
				{
					ApplicationCrash.ExLogging.errorDesc = "Xml file patching failed.";
					ApplicationCrash.ExLogging.errorSol = "Issue should be fixed on next program launch.";
				}
				if (errNum == 1003)
				{
					ApplicationCrash.ExLogging.errorDesc = "Xml file writing failed.";
					ApplicationCrash.ExLogging.errorSol = "Temporarily disable your antivirus, it may be removing the file(s).";
				}
				if (errNum == 1004)
				{
					ApplicationCrash.ExLogging.errorDesc = "Xml file reading failed.";
					ApplicationCrash.ExLogging.errorSol = "Temporarily disable your antivirus, it may be removing the file(s).";
				}
				if (errNum == 1010)
				{
					ApplicationCrash.ExLogging.errorDesc = "Regsitry key failed to write/access denied.";
					ApplicationCrash.ExLogging.errorSol = "Temporarily disable your antivirus or give program admin rights. Your Windows version may also be out of date.";
				}
				if (errNum == 1011)
				{
					ApplicationCrash.ExLogging.errorDesc = "File access/removal issue.";
					ApplicationCrash.ExLogging.errorSol = "Temporarily disable your antivirus, it may be removing the file(s) before the program can.";
				}
				if (errNum == 1020)
				{
					ApplicationCrash.ExLogging.errorDesc = "Web browser failed to start/doesn't exist, make sure to select a default browser.";
					ApplicationCrash.ExLogging.errorSol = "Install a web browser or set a default via the Settings app.";
				}
				if (errNum == 1021)
				{
					ApplicationCrash.ExLogging.errorDesc = "Update check failed.";
					ApplicationCrash.ExLogging.errorSol = "May be due to a disabled service or a issue with Windows.";
				}
				if (errNum == 1022)
				{
					ApplicationCrash.ExLogging.errorDesc = "No internet connection.";
					ApplicationCrash.ExLogging.errorSol = "Please connect to the internet.";
				}
				try
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					if (!File.Exists(path))
					{
						File.Create(path).Dispose();
					}
					using (StreamWriter streamWriter = File.AppendText(path))
					{
						streamWriter.WriteLine("------------------- Crash Log creation " + DateTime.Now.ToString() + " -------------------");
						streamWriter.WriteLine(string.Concat(new string[]
						{
							newLine,
							"Exception Type: ",
							error.GetType().ToString(),
							newLine,
							newLine,
							"Error Cause: ",
							error.Message.ToString(),
							newLine,
							newLine,
							"Error Description: ",
							ApplicationCrash.ExLogging.errorDesc,
							newLine,
							newLine,
							"Error Solution: ",
							ApplicationCrash.ExLogging.errorSol,
							newLine
						}));
						streamWriter.WriteLine("------------------------------------- End -------------------------------------");
						streamWriter.Flush();
						streamWriter.Close();
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Crash log write error, closing now.", "", "ET Optimization Program", MessageBoxButtons.OK);
					Environment.Exit(0);
				}
			}

			// Token: 0x0400001A RID: 26
			private static string errorDesc;

			// Token: 0x0400001B RID: 27
			private static string errorSol;
		}
	}
}
