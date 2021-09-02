using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x0200000B RID: 11
	public partial class yesandnoMessageBox : Form
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00002388 File Offset: 0x00000588
		public yesandnoMessageBox()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002060 File Offset: 0x00000260
		private void yesandnoMessageBox_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002396 File Offset: 0x00000596
		private void labelPrompt_MouseDown(object sender, MouseEventArgs e)
		{
			yesandnoMessageBox.ReleaseCapture();
			yesandnoMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000025DC File Offset: 0x000007DC
		private void yesandnoMessageBox_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(0, 180, 255), Color.FromArgb(0, 30, 70), 90f))
			{
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		// Token: 0x06000063 RID: 99
		[DllImport("user32.DLL")]
		private static extern void ReleaseCapture();

		// Token: 0x06000064 RID: 100
		[DllImport("user32.DLL")]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000023B3 File Offset: 0x000005B3
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000023C0 File Offset: 0x000005C0
		public string Message
		{
			get
			{
				return this.labelPrompt.Text;
			}
			set
			{
				this.labelPrompt.Text = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000023CE File Offset: 0x000005CE
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000023DB File Offset: 0x000005DB
		public string Info
		{
			get
			{
				return this.labelInfo.Text;
			}
			set
			{
				this.labelInfo.Text = value;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002069 File Offset: 0x00000269
		private void btnYes_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002069 File Offset: 0x00000269
		private void btnNo_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002396 File Offset: 0x00000596
		private void panelText_MouseDown(object sender, MouseEventArgs e)
		{
			yesandnoMessageBox.ReleaseCapture();
			yesandnoMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}
	}
}
