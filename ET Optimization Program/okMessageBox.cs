using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x02000008 RID: 8
	public partial class okMessageBox : Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0000222A File Offset: 0x0000042A
		public okMessageBox()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002060 File Offset: 0x00000260
		private void okMessageBox_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000025DC File Offset: 0x000007DC
		private void okMessageBox_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(0, 180, 255), Color.FromArgb(0, 30, 70), 90f))
			{
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		// Token: 0x06000040 RID: 64
		[DllImport("user32.DLL")]
		private static extern void ReleaseCapture();

		// Token: 0x06000041 RID: 65
		[DllImport("user32.DLL")]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002245 File Offset: 0x00000445
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002253 File Offset: 0x00000453
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002260 File Offset: 0x00000460
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

		// Token: 0x06000046 RID: 70 RVA: 0x0000226E File Offset: 0x0000046E
		private void panelText_MouseDown(object sender, MouseEventArgs e)
		{
			okMessageBox.ReleaseCapture();
			okMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000226E File Offset: 0x0000046E
		private void labelPrompt_MouseDown(object sender, MouseEventArgs e)
		{
			okMessageBox.ReleaseCapture();
			okMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002069 File Offset: 0x00000269
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
