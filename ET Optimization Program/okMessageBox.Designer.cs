namespace EtOptimizationProgram
{
	// Token: 0x02000008 RID: 8
	public partial class okMessageBox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000228B File Offset: 0x0000048B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000098CC File Offset: 0x00007ACC
		private void InitializeComponent()
		{
			this.panelText = new global::System.Windows.Forms.Panel();
			this.labelPrompt = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.labelInfo = new global::System.Windows.Forms.Label();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.panelText.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panelText.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.panelText.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelText.Controls.Add(this.labelPrompt);
			this.panelText.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelText.Location = new global::System.Drawing.Point(2, 2);
			this.panelText.Name = "panelText";
			this.panelText.Size = new global::System.Drawing.Size(380, 48);
			this.panelText.TabIndex = 4;
			this.panelText.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelText_MouseDown);
			this.labelPrompt.AutoSize = true;
			this.labelPrompt.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPrompt.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelPrompt.ForeColor = global::System.Drawing.Color.White;
			this.labelPrompt.Location = new global::System.Drawing.Point(12, 9);
			this.labelPrompt.Name = "labelPrompt";
			this.labelPrompt.Size = new global::System.Drawing.Size(103, 30);
			this.labelPrompt.TabIndex = 2;
			this.labelPrompt.Text = "Canceled.";
			this.labelPrompt.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPrompt_MouseDown);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.panel1.Controls.Add(this.labelInfo);
			this.panel1.Controls.Add(this.btnOk);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(2, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(380, 159);
			this.panel1.TabIndex = 5;
			this.labelInfo.AutoSize = true;
			this.labelInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.labelInfo.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelInfo.ForeColor = global::System.Drawing.Color.White;
			this.labelInfo.Location = new global::System.Drawing.Point(13, 8);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new global::System.Drawing.Size(40, 21);
			this.labelInfo.TabIndex = 3;
			this.labelInfo.Text = "Info.";
			this.btnOk.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 190, 255);
			this.btnOk.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 180, 255);
			this.btnOk.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnOk.ForeColor = global::System.Drawing.Color.White;
			this.btnOk.Location = new global::System.Drawing.Point(295, 108);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(75, 41);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 26);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(384, 211);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panelText);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(384, 211);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(384, 211);
			base.Name = "okMessageBox";
			base.Opacity = 0.97;
			base.Padding = new global::System.Windows.Forms.Padding(2);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.okMessageBox_Load);
			base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.okMessageBox_Paint);
			this.panelText.ResumeLayout(false);
			this.panelText.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400004F RID: 79
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Panel panelText;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label labelPrompt;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label labelInfo;
	}
}
