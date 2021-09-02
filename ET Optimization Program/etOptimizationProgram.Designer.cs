namespace EtOptimizationProgram
{
	// Token: 0x02000006 RID: 6
	public partial class etOptimizationProgram : global::System.Windows.Forms.Form
	{
		// Token: 0x06000039 RID: 57 RVA: 0x0000220B File Offset: 0x0000040B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000775C File Offset: 0x0000595C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::EtOptimizationProgram.etOptimizationProgram));
			this.panelSideMenu = new global::System.Windows.Forms.Panel();
			this.btnAbout = new global::System.Windows.Forms.Button();
			this.btnRevert = new global::System.Windows.Forms.Button();
			this.btnDonate = new global::System.Windows.Forms.Button();
			this.panelEmpty = new global::System.Windows.Forms.Panel();
			this.btnManual = new global::System.Windows.Forms.Button();
			this.panelCleanSubMenu = new global::System.Windows.Forms.Panel();
			this.btnClearEventLogs = new global::System.Windows.Forms.Button();
			this.btnCleanPrefetch = new global::System.Windows.Forms.Button();
			this.btnCleanTemp = new global::System.Windows.Forms.Button();
			this.btnClean = new global::System.Windows.Forms.Button();
			this.panelOptimizeSubMenu = new global::System.Windows.Forms.Panel();
			this.btnHighPerformance = new global::System.Windows.Forms.Button();
			this.btnLowLatency = new global::System.Windows.Forms.Button();
			this.btnRegistry = new global::System.Windows.Forms.Button();
			this.panelLogo = new global::System.Windows.Forms.Panel();
			this.btnLogo = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.panelMainForm = new global::System.Windows.Forms.Panel();
			this.panelMain = new global::System.Windows.Forms.Panel();
			this.panelMaxMinClose = new global::System.Windows.Forms.Panel();
			this.btnBack = new global::System.Windows.Forms.Button();
			this.btnMinimizeProgram = new global::System.Windows.Forms.Button();
			this.btnExitProgram = new global::System.Windows.Forms.Button();
			this.timerXmlWrite = new global::System.Windows.Forms.Timer(this.components);
			this.panelSideMenu.SuspendLayout();
			this.panelCleanSubMenu.SuspendLayout();
			this.panelOptimizeSubMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelMaxMinClose.SuspendLayout();
			base.SuspendLayout();
			this.panelSideMenu.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.panelSideMenu.Controls.Add(this.btnAbout);
			this.panelSideMenu.Controls.Add(this.btnRevert);
			this.panelSideMenu.Controls.Add(this.btnDonate);
			this.panelSideMenu.Controls.Add(this.panelEmpty);
			this.panelSideMenu.Controls.Add(this.btnManual);
			this.panelSideMenu.Controls.Add(this.panelCleanSubMenu);
			this.panelSideMenu.Controls.Add(this.btnClean);
			this.panelSideMenu.Controls.Add(this.panelOptimizeSubMenu);
			this.panelSideMenu.Controls.Add(this.btnRegistry);
			this.panelSideMenu.Controls.Add(this.panelLogo);
			this.panelSideMenu.Controls.Add(this.btnExit);
			this.panelSideMenu.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelSideMenu.Location = new global::System.Drawing.Point(3, 3);
			this.panelSideMenu.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new global::System.Drawing.Size(200, 594);
			this.panelSideMenu.TabIndex = 0;
			this.btnAbout.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnAbout.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnAbout.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnAbout.FlatAppearance.BorderSize = 0;
			this.btnAbout.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnAbout.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnAbout.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAbout.ForeColor = global::System.Drawing.Color.White;
			this.btnAbout.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAbout.Location = new global::System.Drawing.Point(0, 418);
			this.btnAbout.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnAbout.Size = new global::System.Drawing.Size(200, 39);
			this.btnAbout.TabIndex = 15;
			this.btnAbout.Text = "About";
			this.btnAbout.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAbout.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.Click += new global::System.EventHandler(this.btnAbout_Click);
			this.btnRevert.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnRevert.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnRevert.FlatAppearance.BorderSize = 0;
			this.btnRevert.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnRevert.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnRevert.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnRevert.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnRevert.ForeColor = global::System.Drawing.Color.White;
			this.btnRevert.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRevert.Location = new global::System.Drawing.Point(0, 379);
			this.btnRevert.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRevert.Name = "btnRevert";
			this.btnRevert.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnRevert.Size = new global::System.Drawing.Size(200, 39);
			this.btnRevert.TabIndex = 14;
			this.btnRevert.Text = "Revert Changes (Beta)";
			this.btnRevert.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRevert.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRevert.UseVisualStyleBackColor = false;
			this.btnRevert.Click += new global::System.EventHandler(this.btnRevert_Click);
			this.btnDonate.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnDonate.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.btnDonate.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnDonate.FlatAppearance.BorderSize = 0;
			this.btnDonate.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnDonate.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnDonate.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnDonate.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDonate.ForeColor = global::System.Drawing.Color.White;
			this.btnDonate.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDonate.Location = new global::System.Drawing.Point(0, 515);
			this.btnDonate.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDonate.Name = "btnDonate";
			this.btnDonate.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnDonate.Size = new global::System.Drawing.Size(200, 39);
			this.btnDonate.TabIndex = 12;
			this.btnDonate.Text = "Options";
			this.btnDonate.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDonate.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDonate.UseVisualStyleBackColor = false;
			this.btnDonate.Click += new global::System.EventHandler(this.btnOptions_Click);
			this.panelEmpty.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.panelEmpty.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panelEmpty.ForeColor = global::System.Drawing.Color.White;
			this.panelEmpty.Location = new global::System.Drawing.Point(0, 459);
			this.panelEmpty.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelEmpty.Name = "panelEmpty";
			this.panelEmpty.Size = new global::System.Drawing.Size(200, 54);
			this.panelEmpty.TabIndex = 7;
			this.btnManual.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnManual.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnManual.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnManual.FlatAppearance.BorderSize = 0;
			this.btnManual.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnManual.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnManual.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnManual.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnManual.ForeColor = global::System.Drawing.Color.White;
			this.btnManual.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManual.Location = new global::System.Drawing.Point(0, 340);
			this.btnManual.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnManual.Name = "btnManual";
			this.btnManual.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnManual.Size = new global::System.Drawing.Size(200, 39);
			this.btnManual.TabIndex = 10;
			this.btnManual.Text = "Manual (Advanced)";
			this.btnManual.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManual.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnManual.UseVisualStyleBackColor = false;
			this.btnManual.Click += new global::System.EventHandler(this.btnManual_Click);
			this.panelCleanSubMenu.BackColor = global::System.Drawing.Color.Transparent;
			this.panelCleanSubMenu.Controls.Add(this.btnClearEventLogs);
			this.panelCleanSubMenu.Controls.Add(this.btnCleanPrefetch);
			this.panelCleanSubMenu.Controls.Add(this.btnCleanTemp);
			this.panelCleanSubMenu.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelCleanSubMenu.Location = new global::System.Drawing.Point(0, 238);
			this.panelCleanSubMenu.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelCleanSubMenu.Name = "panelCleanSubMenu";
			this.panelCleanSubMenu.Size = new global::System.Drawing.Size(200, 102);
			this.panelCleanSubMenu.TabIndex = 4;
			this.btnClearEventLogs.BackColor = global::System.Drawing.Color.FromArgb(0, 50, 100);
			this.btnClearEventLogs.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnClearEventLogs.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnClearEventLogs.FlatAppearance.BorderSize = 0;
			this.btnClearEventLogs.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 70, 120);
			this.btnClearEventLogs.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 60, 110);
			this.btnClearEventLogs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnClearEventLogs.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnClearEventLogs.ForeColor = global::System.Drawing.Color.White;
			this.btnClearEventLogs.Location = new global::System.Drawing.Point(0, 66);
			this.btnClearEventLogs.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClearEventLogs.Name = "btnClearEventLogs";
			this.btnClearEventLogs.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnClearEventLogs.Size = new global::System.Drawing.Size(200, 36);
			this.btnClearEventLogs.TabIndex = 2;
			this.btnClearEventLogs.Text = "Clear Event Logs";
			this.btnClearEventLogs.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClearEventLogs.UseVisualStyleBackColor = false;
			this.btnClearEventLogs.Click += new global::System.EventHandler(this.btnClearEventLogs_Click);
			this.btnCleanPrefetch.BackColor = global::System.Drawing.Color.FromArgb(0, 70, 130);
			this.btnCleanPrefetch.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnCleanPrefetch.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnCleanPrefetch.FlatAppearance.BorderSize = 0;
			this.btnCleanPrefetch.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 90, 150);
			this.btnCleanPrefetch.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 80, 140);
			this.btnCleanPrefetch.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCleanPrefetch.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCleanPrefetch.ForeColor = global::System.Drawing.Color.White;
			this.btnCleanPrefetch.Location = new global::System.Drawing.Point(0, 33);
			this.btnCleanPrefetch.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCleanPrefetch.Name = "btnCleanPrefetch";
			this.btnCleanPrefetch.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnCleanPrefetch.Size = new global::System.Drawing.Size(200, 33);
			this.btnCleanPrefetch.TabIndex = 1;
			this.btnCleanPrefetch.Text = "Clean Prefetch";
			this.btnCleanPrefetch.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCleanPrefetch.UseVisualStyleBackColor = false;
			this.btnCleanPrefetch.Click += new global::System.EventHandler(this.btnCleanPrefetch_Click);
			this.btnCleanTemp.BackColor = global::System.Drawing.Color.FromArgb(0, 90, 160);
			this.btnCleanTemp.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnCleanTemp.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnCleanTemp.FlatAppearance.BorderSize = 0;
			this.btnCleanTemp.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 110, 180);
			this.btnCleanTemp.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 100, 170);
			this.btnCleanTemp.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCleanTemp.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCleanTemp.ForeColor = global::System.Drawing.Color.White;
			this.btnCleanTemp.Location = new global::System.Drawing.Point(0, 0);
			this.btnCleanTemp.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCleanTemp.Name = "btnCleanTemp";
			this.btnCleanTemp.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnCleanTemp.Size = new global::System.Drawing.Size(200, 33);
			this.btnCleanTemp.TabIndex = 0;
			this.btnCleanTemp.Text = "Clean Temp";
			this.btnCleanTemp.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCleanTemp.UseVisualStyleBackColor = false;
			this.btnCleanTemp.Click += new global::System.EventHandler(this.btnCleanTemp_Click);
			this.btnClean.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnClean.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnClean.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnClean.FlatAppearance.BorderSize = 0;
			this.btnClean.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnClean.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnClean.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnClean.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnClean.ForeColor = global::System.Drawing.Color.White;
			this.btnClean.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClean.Location = new global::System.Drawing.Point(0, 199);
			this.btnClean.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClean.Name = "btnClean";
			this.btnClean.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnClean.Size = new global::System.Drawing.Size(200, 39);
			this.btnClean.TabIndex = 3;
			this.btnClean.Text = "Clean Cache";
			this.btnClean.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClean.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClean.UseVisualStyleBackColor = false;
			this.btnClean.Click += new global::System.EventHandler(this.btnClean_Click);
			this.panelOptimizeSubMenu.BackColor = global::System.Drawing.Color.Transparent;
			this.panelOptimizeSubMenu.Controls.Add(this.btnHighPerformance);
			this.panelOptimizeSubMenu.Controls.Add(this.btnLowLatency);
			this.panelOptimizeSubMenu.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelOptimizeSubMenu.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panelOptimizeSubMenu.Location = new global::System.Drawing.Point(0, 131);
			this.panelOptimizeSubMenu.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelOptimizeSubMenu.Name = "panelOptimizeSubMenu";
			this.panelOptimizeSubMenu.Size = new global::System.Drawing.Size(200, 68);
			this.panelOptimizeSubMenu.TabIndex = 2;
			this.btnHighPerformance.BackColor = global::System.Drawing.Color.FromArgb(0, 130, 205);
			this.btnHighPerformance.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnHighPerformance.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnHighPerformance.FlatAppearance.BorderSize = 0;
			this.btnHighPerformance.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 150, 215);
			this.btnHighPerformance.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 140, 210);
			this.btnHighPerformance.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnHighPerformance.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnHighPerformance.ForeColor = global::System.Drawing.Color.White;
			this.btnHighPerformance.Location = new global::System.Drawing.Point(0, 33);
			this.btnHighPerformance.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHighPerformance.Name = "btnHighPerformance";
			this.btnHighPerformance.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnHighPerformance.Size = new global::System.Drawing.Size(200, 35);
			this.btnHighPerformance.TabIndex = 1;
			this.btnHighPerformance.Text = "High Performance";
			this.btnHighPerformance.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHighPerformance.UseVisualStyleBackColor = false;
			this.btnHighPerformance.Click += new global::System.EventHandler(this.btnHighPerformance_Click);
			this.btnLowLatency.BackColor = global::System.Drawing.Color.FromArgb(0, 150, 220);
			this.btnLowLatency.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnLowLatency.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnLowLatency.FlatAppearance.BorderSize = 0;
			this.btnLowLatency.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 170, 230);
			this.btnLowLatency.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 160, 225);
			this.btnLowLatency.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnLowLatency.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLowLatency.ForeColor = global::System.Drawing.Color.White;
			this.btnLowLatency.Location = new global::System.Drawing.Point(0, 0);
			this.btnLowLatency.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLowLatency.Name = "btnLowLatency";
			this.btnLowLatency.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnLowLatency.Size = new global::System.Drawing.Size(200, 33);
			this.btnLowLatency.TabIndex = 0;
			this.btnLowLatency.Text = "Low Latency (Recommended)";
			this.btnLowLatency.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLowLatency.UseVisualStyleBackColor = false;
			this.btnLowLatency.Click += new global::System.EventHandler(this.btnLowLatency_Click);
			this.btnRegistry.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnRegistry.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnRegistry.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnRegistry.FlatAppearance.BorderSize = 0;
			this.btnRegistry.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnRegistry.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnRegistry.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistry.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnRegistry.ForeColor = global::System.Drawing.Color.White;
			this.btnRegistry.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegistry.Location = new global::System.Drawing.Point(0, 92);
			this.btnRegistry.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegistry.Name = "btnRegistry";
			this.btnRegistry.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnRegistry.Size = new global::System.Drawing.Size(200, 39);
			this.btnRegistry.TabIndex = 1;
			this.btnRegistry.Text = "Optimize Registry";
			this.btnRegistry.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegistry.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRegistry.UseVisualStyleBackColor = false;
			this.btnRegistry.Click += new global::System.EventHandler(this.btnRegistry_Click);
			this.panelLogo.BackColor = global::System.Drawing.Color.Black;
			this.panelLogo.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panelLogo.Controls.Add(this.btnLogo);
			this.panelLogo.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panelLogo.ForeColor = global::System.Drawing.Color.White;
			this.panelLogo.Location = new global::System.Drawing.Point(0, 0);
			this.panelLogo.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new global::System.Drawing.Size(200, 92);
			this.panelLogo.TabIndex = 0;
			this.btnLogo.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnLogo.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnLogo.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnLogo.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnLogo.FlatAppearance.BorderSize = 0;
			this.btnLogo.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(46, 47, 48);
			this.btnLogo.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			this.btnLogo.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnLogo.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnLogo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnLogo.Image");
			this.btnLogo.Location = new global::System.Drawing.Point(0, 0);
			this.btnLogo.Name = "btnLogo";
			this.btnLogo.Size = new global::System.Drawing.Size(200, 92);
			this.btnLogo.TabIndex = 0;
			this.btnLogo.UseVisualStyleBackColor = false;
			this.btnLogo.Click += new global::System.EventHandler(this.btnLogo_Click);
			this.btnExit.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.btnExit.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.btnExit.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(208, 0, 0);
			this.btnExit.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.btnExit.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnExit.ForeColor = global::System.Drawing.Color.White;
			this.btnExit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new global::System.Drawing.Point(0, 554);
			this.btnExit.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnExit.Size = new global::System.Drawing.Size(200, 40);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Exit";
			this.btnExit.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.panelMainForm.AutoScroll = true;
			this.panelMainForm.BackColor = global::System.Drawing.Color.Transparent;
			this.panelMainForm.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelMainForm.Location = new global::System.Drawing.Point(0, 30);
			this.panelMainForm.Name = "panelMainForm";
			this.panelMainForm.Size = new global::System.Drawing.Size(695, 564);
			this.panelMainForm.TabIndex = 1;
			this.panelMain.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.panelMain.Controls.Add(this.panelMaxMinClose);
			this.panelMain.Controls.Add(this.panelMainForm);
			this.panelMain.Location = new global::System.Drawing.Point(202, 3);
			this.panelMain.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new global::System.Drawing.Size(695, 594);
			this.panelMain.TabIndex = 2;
			this.panelMaxMinClose.BackColor = global::System.Drawing.Color.FromArgb(0, 180, 255);
			this.panelMaxMinClose.Controls.Add(this.btnBack);
			this.panelMaxMinClose.Controls.Add(this.btnMinimizeProgram);
			this.panelMaxMinClose.Controls.Add(this.btnExitProgram);
			this.panelMaxMinClose.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelMaxMinClose.Location = new global::System.Drawing.Point(0, 0);
			this.panelMaxMinClose.Name = "panelMaxMinClose";
			this.panelMaxMinClose.Size = new global::System.Drawing.Size(695, 30);
			this.panelMaxMinClose.TabIndex = 3;
			this.panelMaxMinClose.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelMaxMinClose_MouseDown);
			this.btnBack.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnBack.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 200, 255);
			this.btnBack.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 190, 255);
			this.btnBack.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnBack.ForeColor = global::System.Drawing.Color.White;
			this.btnBack.Location = new global::System.Drawing.Point(0, 0);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new global::System.Drawing.Size(78, 30);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new global::System.EventHandler(this.btnBack_Click);
			this.btnMinimizeProgram.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMinimizeProgram.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimizeProgram.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnMinimizeProgram.FlatAppearance.BorderSize = 0;
			this.btnMinimizeProgram.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 200, 255);
			this.btnMinimizeProgram.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 190, 255);
			this.btnMinimizeProgram.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizeProgram.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimizeProgram.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimizeProgram.Location = new global::System.Drawing.Point(645, 0);
			this.btnMinimizeProgram.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnMinimizeProgram.Name = "btnMinimizeProgram";
			this.btnMinimizeProgram.Padding = new global::System.Windows.Forms.Padding(0, 6, 0, 0);
			this.btnMinimizeProgram.Size = new global::System.Drawing.Size(25, 30);
			this.btnMinimizeProgram.TabIndex = 3;
			this.btnMinimizeProgram.Text = "-";
			this.btnMinimizeProgram.UseVisualStyleBackColor = false;
			this.btnMinimizeProgram.Click += new global::System.EventHandler(this.btnMinimizeProgram_Click);
			this.btnExitProgram.BackColor = global::System.Drawing.Color.Transparent;
			this.btnExitProgram.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnExitProgram.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnExitProgram.FlatAppearance.BorderSize = 0;
			this.btnExitProgram.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(208, 0, 0);
			this.btnExitProgram.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.btnExitProgram.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnExitProgram.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnExitProgram.ForeColor = global::System.Drawing.Color.White;
			this.btnExitProgram.Location = new global::System.Drawing.Point(670, 0);
			this.btnExitProgram.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnExitProgram.Name = "btnExitProgram";
			this.btnExitProgram.Size = new global::System.Drawing.Size(25, 30);
			this.btnExitProgram.TabIndex = 5;
			this.btnExitProgram.Text = "X";
			this.btnExitProgram.UseVisualStyleBackColor = false;
			this.btnExitProgram.Click += new global::System.EventHandler(this.btnExitProgram_Click);
			this.timerXmlWrite.Enabled = true;
			this.timerXmlWrite.Interval = 1000;
			this.timerXmlWrite.Tick += new global::System.EventHandler(this.timerGlobal_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 30);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(900, 600);
			base.ControlBox = false;
			base.Controls.Add(this.panelMain);
			base.Controls.Add(this.panelSideMenu);
			this.DoubleBuffered = true;
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximumSize = new global::System.Drawing.Size(900, 600);
			this.MinimumSize = new global::System.Drawing.Size(900, 600);
			base.Name = "etOptimizationProgram";
			base.Opacity = 0.97;
			base.Padding = new global::System.Windows.Forms.Padding(3);
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ET Optimization Program";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.etOptimizationProgram_FormClosing);
			base.Load += new global::System.EventHandler(this.etOptimizationProgram_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.etOptimizationProgram_MouseDown);
			this.panelSideMenu.ResumeLayout(false);
			this.panelCleanSubMenu.ResumeLayout(false);
			this.panelOptimizeSubMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.panelMaxMinClose.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000035 RID: 53
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Panel panelSideMenu;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Panel panelOptimizeSubMenu;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button btnHighPerformance;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button btnLowLatency;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button btnRegistry;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Panel panelEmpty;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Panel panelCleanSubMenu;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button btnClearEventLogs;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Button btnCleanPrefetch;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Button btnCleanTemp;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Button btnClean;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Panel panelLogo;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Panel panelMainForm;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Panel panelMain;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Panel panelMaxMinClose;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button btnExitProgram;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button btnMinimizeProgram;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Button btnBack;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Button btnLogo;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button btnManual;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button btnDonate;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Timer timerXmlWrite;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button btnAbout;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Button btnRevert;
	}
}
