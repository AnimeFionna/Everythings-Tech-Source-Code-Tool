using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x02000002 RID: 2
	public partial class aboutMessageBox : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		public aboutMessageBox()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002060 File Offset: 0x00000260
		private void aboutMessageBox_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000025DC File Offset: 0x000007DC
		private void aboutMessageBox_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(0, 180, 255), Color.FromArgb(0, 30, 70), 90f))
			{
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		// Token: 0x06000006 RID: 6
		[DllImport("user32.DLL")]
		private static extern void ReleaseCapture();

		// Token: 0x06000007 RID: 7
		[DllImport("user32.DLL")]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x06000008 RID: 8 RVA: 0x00002069 File Offset: 0x00000269
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002071 File Offset: 0x00000271
		private void labelPrompt_MouseDown(object sender, MouseEventArgs e)
		{
			aboutMessageBox.ReleaseCapture();
			aboutMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002071 File Offset: 0x00000271
		private void panelText_MouseDown(object sender, MouseEventArgs e)
		{
			aboutMessageBox.ReleaseCapture();
			aboutMessageBox.SendMessage(base.Handle, 274, 61458, 0);
		}
	}
}
