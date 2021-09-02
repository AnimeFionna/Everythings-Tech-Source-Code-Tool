namespace EtOptimizationProgram
{
	// Token: 0x02000009 RID: 9
	public partial class optionsBox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00002331 File Offset: 0x00000531
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00009ED0 File Offset: 0x000080D0
		private void InitializeComponent()
		{
			this.panelText = new global::System.Windows.Forms.Panel();
			this.labelPrompt = new global::System.Windows.Forms.Label();
			this.panelOptionsMenu = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.label6 = new global::System.Windows.Forms.Label();
			this.panelGeneral = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBoxDisplayWarningMessages = new global::System.Windows.Forms.CheckBox();
			this.checkBoxAutoCheckForUpdates = new global::System.Windows.Forms.CheckBox();
			this.panelText.SuspendLayout();
			this.panelOptionsMenu.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelGeneral.SuspendLayout();
			base.SuspendLayout();
			this.panelText.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.panelText.Controls.Add(this.labelPrompt);
			this.panelText.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelText.Location = new global::System.Drawing.Point(2, 2);
			this.panelText.Name = "panelText";
			this.panelText.Size = new global::System.Drawing.Size(380, 48);
			this.panelText.TabIndex = 7;
			this.panelText.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelText_MouseDown);
			this.labelPrompt.AutoSize = true;
			this.labelPrompt.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelPrompt.ForeColor = global::System.Drawing.Color.White;
			this.labelPrompt.Location = new global::System.Drawing.Point(8, 9);
			this.labelPrompt.Name = "labelPrompt";
			this.labelPrompt.Size = new global::System.Drawing.Size(86, 30);
			this.labelPrompt.TabIndex = 3;
			this.labelPrompt.Text = "Options";
			this.labelPrompt.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPrompt.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPrompt_MouseDown);
			this.panelOptionsMenu.BackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.panelOptionsMenu.Controls.Add(this.panel2);
			this.panelOptionsMenu.Controls.Add(this.panelGeneral);
			this.panelOptionsMenu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelOptionsMenu.Location = new global::System.Drawing.Point(2, 50);
			this.panelOptionsMenu.Name = "panelOptionsMenu";
			this.panelOptionsMenu.Size = new global::System.Drawing.Size(380, 398);
			this.panelOptionsMenu.TabIndex = 57;
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.panel2.Controls.Add(this.btnOk);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new global::System.Drawing.Point(0, 337);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(380, 61);
			this.panel2.TabIndex = 60;
			this.btnOk.BackColor = global::System.Drawing.Color.FromArgb(52, 53, 54);
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 190, 255);
			this.btnOk.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 180, 255);
			this.btnOk.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnOk.ForeColor = global::System.Drawing.Color.White;
			this.btnOk.Location = new global::System.Drawing.Point(297, 11);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(75, 41);
			this.btnOk.TabIndex = 56;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(3, 41);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(124, 13);
			this.label6.TabIndex = 55;
			this.label6.Text = "EverythingTech © 2021";
			this.panelGeneral.BackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.panelGeneral.Controls.Add(this.label1);
			this.panelGeneral.Controls.Add(this.checkBoxDisplayWarningMessages);
			this.panelGeneral.Controls.Add(this.checkBoxAutoCheckForUpdates);
			this.panelGeneral.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelGeneral.ForeColor = global::System.Drawing.Color.White;
			this.panelGeneral.Location = new global::System.Drawing.Point(0, 0);
			this.panelGeneral.Name = "panelGeneral";
			this.panelGeneral.Size = new global::System.Drawing.Size(380, 340);
			this.panelGeneral.TabIndex = 58;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(2, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(383, 15);
			this.label1.TabIndex = 35;
			this.label1.Text = "- General -----------------------------------------------------------------";
			this.checkBoxDisplayWarningMessages.AutoSize = true;
			this.checkBoxDisplayWarningMessages.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxDisplayWarningMessages.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxDisplayWarningMessages.Location = new global::System.Drawing.Point(13, 56);
			this.checkBoxDisplayWarningMessages.Name = "checkBoxDisplayWarningMessages";
			this.checkBoxDisplayWarningMessages.Size = new global::System.Drawing.Size(161, 19);
			this.checkBoxDisplayWarningMessages.TabIndex = 34;
			this.checkBoxDisplayWarningMessages.Text = "Display warning messages";
			this.checkBoxDisplayWarningMessages.UseVisualStyleBackColor = true;
			this.checkBoxDisplayWarningMessages.CheckedChanged += new global::System.EventHandler(this.checkBoxDisplayWarningMessages_CheckedChanged);
			this.checkBoxAutoCheckForUpdates.AutoSize = true;
			this.checkBoxAutoCheckForUpdates.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxAutoCheckForUpdates.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxAutoCheckForUpdates.Location = new global::System.Drawing.Point(13, 31);
			this.checkBoxAutoCheckForUpdates.Name = "checkBoxAutoCheckForUpdates";
			this.checkBoxAutoCheckForUpdates.Size = new global::System.Drawing.Size(283, 19);
			this.checkBoxAutoCheckForUpdates.TabIndex = 32;
			this.checkBoxAutoCheckForUpdates.Text = "Automatically check for updates (recommended)";
			this.checkBoxAutoCheckForUpdates.UseVisualStyleBackColor = true;
			this.checkBoxAutoCheckForUpdates.CheckedChanged += new global::System.EventHandler(this.checkBoxAutoCheckForUpdates_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 26);
			base.ClientSize = new global::System.Drawing.Size(384, 450);
			base.Controls.Add(this.panelOptionsMenu);
			base.Controls.Add(this.panelText);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new global::System.Drawing.Size(384, 450);
			this.MinimumSize = new global::System.Drawing.Size(384, 450);
			base.Name = "optionsBox";
			base.Opacity = 0.97;
			base.Padding = new global::System.Windows.Forms.Padding(2);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "optionsBox";
			base.Load += new global::System.EventHandler(this.optionsBox_Load);
			base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.optionsBox_Paint);
			this.panelText.ResumeLayout(false);
			this.panelText.PerformLayout();
			this.panelOptionsMenu.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelGeneral.ResumeLayout(false);
			this.panelGeneral.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000055 RID: 85
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Panel panelText;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label labelPrompt;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Panel panelOptionsMenu;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Panel panelGeneral;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.CheckBox checkBoxDisplayWarningMessages;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.CheckBox checkBoxAutoCheckForUpdates;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400005E RID: 94
		public global::System.Windows.Forms.Button btnOk;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label6;
	}
}
