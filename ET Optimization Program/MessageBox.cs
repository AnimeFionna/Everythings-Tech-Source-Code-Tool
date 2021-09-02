using System;
using System.Windows.Forms;

namespace EtOptimizationProgram
{
	// Token: 0x02000007 RID: 7
	public static class MessageBox
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0000983C File Offset: 0x00007A3C
		public static DialogResult Show(string message, string info, string caption, MessageBoxButtons button)
		{
			DialogResult result = DialogResult.None;
			if (button != MessageBoxButtons.OK)
			{
				if (button != MessageBoxButtons.YesNo)
				{
					return result;
				}
				using (yesandnoMessageBox yesandnoMessageBox = new yesandnoMessageBox())
				{
					yesandnoMessageBox.Text = caption;
					yesandnoMessageBox.Info = info;
					yesandnoMessageBox.Message = message;
					return yesandnoMessageBox.ShowDialog();
				}
			}
			using (okMessageBox okMessageBox = new okMessageBox())
			{
				okMessageBox.Text = caption;
				okMessageBox.Info = info;
				okMessageBox.Message = message;
				result = okMessageBox.ShowDialog();
			}
			return result;
		}
	}
}
