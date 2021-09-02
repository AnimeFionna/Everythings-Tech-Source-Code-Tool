using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x02000009 RID: 9
	public partial class optionsBox : Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000022AA File Offset: 0x000004AA
		public optionsBox()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004C RID: 76
		[DllImport("user32.DLL", SetLastError = true)]
		private static extern void ReleaseCapture();

		// Token: 0x0600004D RID: 77
		[DllImport("user32.DLL", SetLastError = true)]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x0600004E RID: 78 RVA: 0x000022B8 File Offset: 0x000004B8
		private void panelText_MouseDown(object sender, MouseEventArgs e)
		{
			optionsBox.ReleaseCapture();
			optionsBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000022B8 File Offset: 0x000004B8
		private void labelPrompt_MouseDown(object sender, MouseEventArgs e)
		{
			optionsBox.ReleaseCapture();
			optionsBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000025DC File Offset: 0x000007DC
		private void optionsBox_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(0, 180, 255), Color.FromArgb(0, 30, 70), 90f))
			{
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00009E24 File Offset: 0x00008024
		private void optionsBox_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Normal;
				if (XmlFile.xmlRead("CheckForUpdates") == "True")
				{
					this.checkBoxAutoCheckForUpdates.Checked = true;
				}
				else
				{
					this.checkBoxAutoCheckForUpdates.Checked = false;
				}
				if (XmlFile.xmlRead("DisplayWarning") == "True")
				{
					this.checkBoxDisplayWarningMessages.Checked = true;
				}
				else
				{
					this.checkBoxDisplayWarningMessages.Checked = false;
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1004);
				MessageBox.Show("Xml file reading failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000022D5 File Offset: 0x000004D5
		private void checkBoxAutoCheckForUpdates_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxAutoCheckForUpdates.Checked)
			{
				XmlFile.xmlWrite("CheckForUpdates", "True");
				return;
			}
			XmlFile.xmlWrite("CheckForUpdates", "False");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002303 File Offset: 0x00000503
		private void checkBoxDisplayWarningMessages_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxDisplayWarningMessages.Checked)
			{
				XmlFile.xmlWrite("DisplayWarning", "True");
				return;
			}
			XmlFile.xmlWrite("DisplayWarning", "False");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002069 File Offset: 0x00000269
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
