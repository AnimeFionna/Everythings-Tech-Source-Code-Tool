using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x0200000D RID: 13
	internal static class Program
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00002575 File Offset: 0x00000775
		[STAThread]
		private static void Main()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				Program.SetProcessDPIAware();
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new etOptimizationProgram());
		}

		// Token: 0x0600008C RID: 140
		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
