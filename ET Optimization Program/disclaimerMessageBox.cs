using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EtOptimizationProgram
{
	// Token: 0x02000005 RID: 5
	public partial class disclaimerMessageBox : Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020B5 File Offset: 0x000002B5
		public disclaimerMessageBox()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003B64 File Offset: 0x00001D64
		private void disclaimerMessageBox_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Normal;
				string text = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner", "").ToString();
				int num = 0;
				foreach (char c in text)
				{
					num++;
				}
				if (num >= 20)
				{
					this.labelPrompt.Text = "Welcome new user!";
				}
				if (num <= 20)
				{
					if (text.Contains("@"))
					{
						this.labelPrompt.Text = "Welcome new user!";
					}
					if (!text.Contains("@"))
					{
						this.labelPrompt.Text = "Welcome " + text + "!";
					}
				}
			}
			catch (Exception)
			{
				this.labelPrompt.Text = "Welcome new user!";
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x06000012 RID: 18
		[DllImport("user32.DLL")]
		private static extern void ReleaseCapture();

		// Token: 0x06000013 RID: 19
		[DllImport("user32.DLL")]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x06000014 RID: 20 RVA: 0x000020C3 File Offset: 0x000002C3
		private void panelText_MouseDown(object sender, MouseEventArgs e)
		{
			disclaimerMessageBox.ReleaseCapture();
			disclaimerMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020C3 File Offset: 0x000002C3
		private void labelPrompt_MouseDown(object sender, MouseEventArgs e)
		{
			disclaimerMessageBox.ReleaseCapture();
			disclaimerMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025DC File Offset: 0x000007DC
		private void disclaimerMessageBox_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(0, 180, 255), Color.FromArgb(0, 30, 70), 90f))
			{
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020E0 File Offset: 0x000002E0
		private void btnOk_Click(object sender, EventArgs e)
		{
			XmlFile.xmlWrite("DisclaimerAccepted", "True");
			base.Close();
		}
	}
}
