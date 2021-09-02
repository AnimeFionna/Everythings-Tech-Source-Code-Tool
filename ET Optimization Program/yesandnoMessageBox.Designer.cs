namespace EtOptimizationProgram
{
	// Token: 0x0200000B RID: 11
	public partial class yesandnoMessageBox : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000023E9 File Offset: 0x000005E9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		private void InitializeComponent()
		{
			this.btnNo = new global::System.Windows.Forms.Button();
			this.btnYes = new global::System.Windows.Forms.Button();
			this.labelPrompt = new global::System.Windows.Forms.Label();
			this.panelText = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.labelInfo = new global::System.Windows.Forms.Label();
			this.panelText.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnNo.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.btnNo.DialogResult = global::System.Windows.Forms.DialogResult.No;
			this.btnNo.FlatAppearance.BorderSize = 0;
			this.btnNo.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(208, 0, 0);
			this.btnNo.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.btnNo.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnNo.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnNo.ForeColor = global::System.Drawing.Color.White;
			this.btnNo.Location = new global::System.Drawing.Point(296, 109);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new global::System.Drawing.Size(75, 41);
			this.btnNo.TabIndex = 0;
			this.btnNo.Text = "No";
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Click += new global::System.EventHandler(this.btnNo_Click);
			this.btnYes.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.btnYes.DialogResult = global::System.Windows.Forms.DialogResult.Yes;
			this.btnYes.FlatAppearance.BorderSize = 0;
			this.btnYes.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 208, 0);
			this.btnYes.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.btnYes.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnYes.ForeColor = global::System.Drawing.Color.White;
			this.btnYes.Location = new global::System.Drawing.Point(215, 109);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new global::System.Drawing.Size(75, 41);
			this.btnYes.TabIndex = 1;
			this.btnYes.Text = "Yes";
			this.btnYes.UseVisualStyleBackColor = false;
			this.btnYes.Click += new global::System.EventHandler(this.btnYes_Click);
			this.labelPrompt.AutoSize = true;
			this.labelPrompt.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelPrompt.ForeColor = global::System.Drawing.Color.White;
			this.labelPrompt.Location = new global::System.Drawing.Point(14, 9);
			this.labelPrompt.Name = "labelPrompt";
			this.labelPrompt.Size = new global::System.Drawing.Size(342, 30);
			this.labelPrompt.TabIndex = 2;
			this.labelPrompt.Text = "Are you sure you want to continue?";
			this.labelPrompt.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPrompt.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPrompt_MouseDown);
			this.panelText.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.panelText.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelText.Controls.Add(this.labelPrompt);
			this.panelText.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelText.Location = new global::System.Drawing.Point(2, 2);
			this.panelText.Name = "panelText";
			this.panelText.Size = new global::System.Drawing.Size(380, 48);
			this.panelText.TabIndex = 3;
			this.panelText.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelText_MouseDown);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.panel1.Controls.Add(this.labelInfo);
			this.panel1.Controls.Add(this.btnNo);
			this.panel1.Controls.Add(this.btnYes);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(2, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(380, 159);
			this.panel1.TabIndex = 4;
			this.labelInfo.AutoSize = true;
			this.labelInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.labelInfo.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelInfo.ForeColor = global::System.Drawing.Color.White;
			this.labelInfo.Location = new global::System.Drawing.Point(13, 8);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new global::System.Drawing.Size(40, 21);
			this.labelInfo.TabIndex = 5;
			this.labelInfo.Text = "Info.";
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
			base.Name = "yesandnoMessageBox";
			base.Opacity = 0.97;
			base.Padding = new global::System.Windows.Forms.Padding(2);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ET Optimization Team";
			base.Load += new global::System.EventHandler(this.yesandnoMessageBox_Load);
			base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.yesandnoMessageBox_Paint);
			this.panelText.ResumeLayout(false);
			this.panelText.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000062 RID: 98
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Button btnYes;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label labelPrompt;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Panel panelText;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000067 RID: 103
		public global::System.Windows.Forms.Button btnNo;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label labelInfo;
	}
}
