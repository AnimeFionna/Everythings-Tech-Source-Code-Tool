namespace EtOptimizationProgram
{
	// Token: 0x0200000C RID: 12
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002556 File Offset: 0x00000756
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000DA20 File Offset: 0x0000BC20
		private void InitializeComponent()
		{
			this.btnApplyChanges = new global::System.Windows.Forms.Button();
			this.panelApplyChanges = new global::System.Windows.Forms.Panel();
			this.panelMemoryManagementOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxLargeSystemCache = new global::System.Windows.Forms.CheckBox();
			this.checkBoxSpectreMeltdown = new global::System.Windows.Forms.CheckBox();
			this.panelMemoryManagement = new global::System.Windows.Forms.Panel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.btnMemoryManagement = new global::System.Windows.Forms.Button();
			this.panelDataQueueSize = new global::System.Windows.Forms.Panel();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.label27 = new global::System.Windows.Forms.Label();
			this.btnDataQueueSize = new global::System.Windows.Forms.Button();
			this.panelCleanCacheOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxTempPrefetch = new global::System.Windows.Forms.CheckBox();
			this.checkBoxClearDisableEventLogs = new global::System.Windows.Forms.CheckBox();
			this.panelCleanCache = new global::System.Windows.Forms.Panel();
			this.label31 = new global::System.Windows.Forms.Label();
			this.label32 = new global::System.Windows.Forms.Label();
			this.label33 = new global::System.Windows.Forms.Label();
			this.btnClearCache = new global::System.Windows.Forms.Button();
			this.flowPanelMain = new global::System.Windows.Forms.FlowLayoutPanel();
			this.panelDataQueueSizeOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxMouseDataQueueSize = new global::System.Windows.Forms.CheckBox();
			this.checkBoxKeyboardDataQueueSize = new global::System.Windows.Forms.CheckBox();
			this.panelPlatformTick = new global::System.Windows.Forms.Panel();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label21 = new global::System.Windows.Forms.Label();
			this.btnPlatformTick = new global::System.Windows.Forms.Button();
			this.panelPlatformTickOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxPlatformTick = new global::System.Windows.Forms.CheckBox();
			this.checkBoxResetOtherBCDEdit = new global::System.Windows.Forms.CheckBox();
			this.panelPowerOptions = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.btnPowerOptions = new global::System.Windows.Forms.Button();
			this.panelPowerOptionsOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxPowerThrottling = new global::System.Windows.Forms.CheckBox();
			this.checkBoxHibernation = new global::System.Windows.Forms.CheckBox();
			this.panelPrefetchLogging = new global::System.Windows.Forms.Panel();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.btnPrefetchLogging = new global::System.Windows.Forms.Button();
			this.panelPrefetchLoggingOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxPrefetchSuperfetch = new global::System.Windows.Forms.CheckBox();
			this.checkBoxBootTracing = new global::System.Windows.Forms.CheckBox();
			this.panelProcessMitigation = new global::System.Windows.Forms.Panel();
			this.label28 = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.label30 = new global::System.Windows.Forms.Label();
			this.btnProcessMitigation = new global::System.Windows.Forms.Button();
			this.panelProcessMitigationOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxProcessMitigationEnabled = new global::System.Windows.Forms.CheckBox();
			this.checkBoxProcessMitigationDisabled = new global::System.Windows.Forms.CheckBox();
			this.panelSystemProfile = new global::System.Windows.Forms.Panel();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.btnSystemProfile = new global::System.Windows.Forms.Button();
			this.panelSystemProfileOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxDisableMMCSS = new global::System.Windows.Forms.CheckBox();
			this.checkBoxSystemResponsiveness = new global::System.Windows.Forms.CheckBox();
			this.checkBoxNetworkThrottlingIndex = new global::System.Windows.Forms.CheckBox();
			this.panelSystemTelemetry = new global::System.Windows.Forms.Panel();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.btnSystemTelemetry = new global::System.Windows.Forms.Button();
			this.panelSystemTelemetryOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxSystemTelemetry = new global::System.Windows.Forms.CheckBox();
			this.checkBoxAppTelemetry = new global::System.Windows.Forms.CheckBox();
			this.panelWin32Priority = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnWin32Priority = new global::System.Windows.Forms.Button();
			this.panelWin32PriorityOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxWin3f91 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxWin2 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxWin26 = new global::System.Windows.Forms.CheckBox();
			this.panelWinDefender = new global::System.Windows.Forms.Panel();
			this.label22 = new global::System.Windows.Forms.Label();
			this.label23 = new global::System.Windows.Forms.Label();
			this.label24 = new global::System.Windows.Forms.Label();
			this.btnWinDefender = new global::System.Windows.Forms.Button();
			this.panelWinDefenderOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxWinDefenderExclusions = new global::System.Windows.Forms.CheckBox();
			this.checkBoxDisableWinDefender = new global::System.Windows.Forms.CheckBox();
			this.panelWindowsUpdate = new global::System.Windows.Forms.Panel();
			this.label37 = new global::System.Windows.Forms.Label();
			this.label38 = new global::System.Windows.Forms.Label();
			this.label39 = new global::System.Windows.Forms.Label();
			this.btnWindowsUpdate = new global::System.Windows.Forms.Button();
			this.panelWindowsUpdateOptions = new global::System.Windows.Forms.Panel();
			this.checkBoxWinUpdateEnabled = new global::System.Windows.Forms.CheckBox();
			this.checkBoxWinUpdateDisabled = new global::System.Windows.Forms.CheckBox();
			this.panelApplyChanges.SuspendLayout();
			this.panelMemoryManagementOptions.SuspendLayout();
			this.panelMemoryManagement.SuspendLayout();
			this.panelDataQueueSize.SuspendLayout();
			this.panelCleanCacheOptions.SuspendLayout();
			this.panelCleanCache.SuspendLayout();
			this.flowPanelMain.SuspendLayout();
			this.panelDataQueueSizeOptions.SuspendLayout();
			this.panelPlatformTick.SuspendLayout();
			this.panelPlatformTickOptions.SuspendLayout();
			this.panelPowerOptions.SuspendLayout();
			this.panelPowerOptionsOptions.SuspendLayout();
			this.panelPrefetchLogging.SuspendLayout();
			this.panelPrefetchLoggingOptions.SuspendLayout();
			this.panelProcessMitigation.SuspendLayout();
			this.panelProcessMitigationOptions.SuspendLayout();
			this.panelSystemProfile.SuspendLayout();
			this.panelSystemProfileOptions.SuspendLayout();
			this.panelSystemTelemetry.SuspendLayout();
			this.panelSystemTelemetryOptions.SuspendLayout();
			this.panelWin32Priority.SuspendLayout();
			this.panelWin32PriorityOptions.SuspendLayout();
			this.panelWinDefender.SuspendLayout();
			this.panelWinDefenderOptions.SuspendLayout();
			this.panelWindowsUpdate.SuspendLayout();
			this.panelWindowsUpdateOptions.SuspendLayout();
			base.SuspendLayout();
			this.btnApplyChanges.BackColor = global::System.Drawing.Color.Transparent;
			this.btnApplyChanges.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnApplyChanges.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnApplyChanges.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnApplyChanges.FlatAppearance.BorderSize = 0;
			this.btnApplyChanges.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(0, 208, 0);
			this.btnApplyChanges.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.btnApplyChanges.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnApplyChanges.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnApplyChanges.ForeColor = global::System.Drawing.Color.White;
			this.btnApplyChanges.Location = new global::System.Drawing.Point(0, 0);
			this.btnApplyChanges.Name = "btnApplyChanges";
			this.btnApplyChanges.Size = new global::System.Drawing.Size(695, 64);
			this.btnApplyChanges.TabIndex = 28;
			this.btnApplyChanges.Text = "Apply Changes";
			this.btnApplyChanges.UseVisualStyleBackColor = false;
			this.btnApplyChanges.Click += new global::System.EventHandler(this.btnApplyChanges_Click);
			this.panelApplyChanges.BackColor = global::System.Drawing.Color.Transparent;
			this.panelApplyChanges.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelApplyChanges.Controls.Add(this.btnApplyChanges);
			this.panelApplyChanges.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelApplyChanges.Location = new global::System.Drawing.Point(0, 501);
			this.panelApplyChanges.Name = "panelApplyChanges";
			this.panelApplyChanges.Size = new global::System.Drawing.Size(695, 64);
			this.panelApplyChanges.TabIndex = 29;
			this.panelMemoryManagementOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelMemoryManagementOptions.Controls.Add(this.checkBoxLargeSystemCache);
			this.panelMemoryManagementOptions.Controls.Add(this.checkBoxSpectreMeltdown);
			this.panelMemoryManagementOptions.Location = new global::System.Drawing.Point(0, 320);
			this.panelMemoryManagementOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelMemoryManagementOptions.Name = "panelMemoryManagementOptions";
			this.panelMemoryManagementOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelMemoryManagementOptions.TabIndex = 206;
			this.panelMemoryManagementOptions.Visible = false;
			this.checkBoxLargeSystemCache.AutoSize = true;
			this.checkBoxLargeSystemCache.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxLargeSystemCache.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxLargeSystemCache.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxLargeSystemCache.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxLargeSystemCache.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxLargeSystemCache.Name = "checkBoxLargeSystemCache";
			this.checkBoxLargeSystemCache.Size = new global::System.Drawing.Size(348, 19);
			this.checkBoxLargeSystemCache.TabIndex = 62;
			this.checkBoxLargeSystemCache.Text = "Enable LargeSystemCache (changes PageFile write frequency)";
			this.checkBoxLargeSystemCache.UseVisualStyleBackColor = false;
			this.checkBoxSpectreMeltdown.AutoSize = true;
			this.checkBoxSpectreMeltdown.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxSpectreMeltdown.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxSpectreMeltdown.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxSpectreMeltdown.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxSpectreMeltdown.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxSpectreMeltdown.Name = "checkBoxSpectreMeltdown";
			this.checkBoxSpectreMeltdown.Size = new global::System.Drawing.Size(240, 19);
			this.checkBoxSpectreMeltdown.TabIndex = 64;
			this.checkBoxSpectreMeltdown.Text = "Disable Spectre && Meltdown (less secure)";
			this.checkBoxSpectreMeltdown.UseVisualStyleBackColor = false;
			this.panelMemoryManagement.BackColor = global::System.Drawing.Color.Transparent;
			this.panelMemoryManagement.Controls.Add(this.label4);
			this.panelMemoryManagement.Controls.Add(this.label5);
			this.panelMemoryManagement.Controls.Add(this.label6);
			this.panelMemoryManagement.Controls.Add(this.btnMemoryManagement);
			this.panelMemoryManagement.Location = new global::System.Drawing.Point(0, 256);
			this.panelMemoryManagement.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelMemoryManagement.Name = "panelMemoryManagement";
			this.panelMemoryManagement.Size = new global::System.Drawing.Size(678, 64);
			this.panelMemoryManagement.TabIndex = 205;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(196, 34);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(303, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "patches, PageFile behavior, and system logging options.";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(196, 14);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(429, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Specifies the Session Memory Management settings. This affects certain security";
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(27, 22);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(138, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Memory Management";
			this.btnMemoryManagement.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMemoryManagement.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnMemoryManagement.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnMemoryManagement.FlatAppearance.BorderSize = 0;
			this.btnMemoryManagement.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnMemoryManagement.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnMemoryManagement.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMemoryManagement.Location = new global::System.Drawing.Point(0, 0);
			this.btnMemoryManagement.Name = "btnMemoryManagement";
			this.btnMemoryManagement.Size = new global::System.Drawing.Size(30, 64);
			this.btnMemoryManagement.TabIndex = 0;
			this.btnMemoryManagement.Text = ">";
			this.btnMemoryManagement.UseVisualStyleBackColor = false;
			this.btnMemoryManagement.Click += new global::System.EventHandler(this.btnMemoryManagement_Click);
			this.panelDataQueueSize.BackColor = global::System.Drawing.Color.Transparent;
			this.panelDataQueueSize.Controls.Add(this.label25);
			this.panelDataQueueSize.Controls.Add(this.label26);
			this.panelDataQueueSize.Controls.Add(this.label27);
			this.panelDataQueueSize.Controls.Add(this.btnDataQueueSize);
			this.panelDataQueueSize.Location = new global::System.Drawing.Point(0, 128);
			this.panelDataQueueSize.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelDataQueueSize.Name = "panelDataQueueSize";
			this.panelDataQueueSize.Size = new global::System.Drawing.Size(678, 64);
			this.panelDataQueueSize.TabIndex = 182;
			this.label25.AutoSize = true;
			this.label25.BackColor = global::System.Drawing.Color.Transparent;
			this.label25.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label25.Location = new global::System.Drawing.Point(196, 34);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(342, 15);
			this.label25.TabIndex = 3;
			this.label25.Text = "in a positive way, but if the value is too low, glitches may occur.";
			this.label26.AutoSize = true;
			this.label26.BackColor = global::System.Drawing.Color.Transparent;
			this.label26.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label26.Location = new global::System.Drawing.Point(196, 14);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(434, 15);
			this.label26.TabIndex = 2;
			this.label26.Text = "Specifies the DataQueueSize for the keyboard and mouse. This may affect latency";
			this.label27.AutoSize = true;
			this.label27.BackColor = global::System.Drawing.Color.Transparent;
			this.label27.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label27.Location = new global::System.Drawing.Point(27, 22);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(96, 17);
			this.label27.TabIndex = 1;
			this.label27.Text = "DataQueueSize";
			this.btnDataQueueSize.BackColor = global::System.Drawing.Color.Transparent;
			this.btnDataQueueSize.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnDataQueueSize.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnDataQueueSize.FlatAppearance.BorderSize = 0;
			this.btnDataQueueSize.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnDataQueueSize.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnDataQueueSize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnDataQueueSize.Location = new global::System.Drawing.Point(0, 0);
			this.btnDataQueueSize.Name = "btnDataQueueSize";
			this.btnDataQueueSize.Size = new global::System.Drawing.Size(30, 64);
			this.btnDataQueueSize.TabIndex = 0;
			this.btnDataQueueSize.Text = ">";
			this.btnDataQueueSize.UseVisualStyleBackColor = false;
			this.btnDataQueueSize.Click += new global::System.EventHandler(this.btnDataQueueSize_Click);
			this.panelCleanCacheOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelCleanCacheOptions.Controls.Add(this.checkBoxTempPrefetch);
			this.panelCleanCacheOptions.Controls.Add(this.checkBoxClearDisableEventLogs);
			this.panelCleanCacheOptions.Location = new global::System.Drawing.Point(0, 64);
			this.panelCleanCacheOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelCleanCacheOptions.Name = "panelCleanCacheOptions";
			this.panelCleanCacheOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelCleanCacheOptions.TabIndex = 181;
			this.panelCleanCacheOptions.Visible = false;
			this.checkBoxTempPrefetch.AutoSize = true;
			this.checkBoxTempPrefetch.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxTempPrefetch.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxTempPrefetch.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxTempPrefetch.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxTempPrefetch.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxTempPrefetch.Name = "checkBoxTempPrefetch";
			this.checkBoxTempPrefetch.Size = new global::System.Drawing.Size(307, 19);
			this.checkBoxTempPrefetch.TabIndex = 62;
			this.checkBoxTempPrefetch.Text = "Clean Temp && Prefetch (may increase responsiveness)";
			this.checkBoxTempPrefetch.UseVisualStyleBackColor = false;
			this.checkBoxClearDisableEventLogs.AutoSize = true;
			this.checkBoxClearDisableEventLogs.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxClearDisableEventLogs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxClearDisableEventLogs.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxClearDisableEventLogs.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxClearDisableEventLogs.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxClearDisableEventLogs.Name = "checkBoxClearDisableEventLogs";
			this.checkBoxClearDisableEventLogs.Size = new global::System.Drawing.Size(291, 19);
			this.checkBoxClearDisableEventLogs.TabIndex = 64;
			this.checkBoxClearDisableEventLogs.Text = "Clear && Disable Event Logs (should reduce latency)";
			this.checkBoxClearDisableEventLogs.UseVisualStyleBackColor = false;
			this.panelCleanCache.BackColor = global::System.Drawing.Color.Transparent;
			this.panelCleanCache.Controls.Add(this.label31);
			this.panelCleanCache.Controls.Add(this.label32);
			this.panelCleanCache.Controls.Add(this.label33);
			this.panelCleanCache.Controls.Add(this.btnClearCache);
			this.panelCleanCache.Location = new global::System.Drawing.Point(0, 0);
			this.panelCleanCache.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelCleanCache.Name = "panelCleanCache";
			this.panelCleanCache.Size = new global::System.Drawing.Size(678, 64);
			this.panelCleanCache.TabIndex = 180;
			this.label31.AutoSize = true;
			this.label31.BackColor = global::System.Drawing.Color.Transparent;
			this.label31.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label31.Location = new global::System.Drawing.Point(196, 34);
			this.label31.Name = "label31";
			this.label31.Size = new global::System.Drawing.Size(395, 15);
			this.label31.TabIndex = 3;
			this.label31.Text = "your system. This affects the Temp folder, Prefetch folder, and Event Logs.";
			this.label32.AutoSize = true;
			this.label32.BackColor = global::System.Drawing.Color.Transparent;
			this.label32.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label32.Location = new global::System.Drawing.Point(196, 14);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(416, 15);
			this.label32.TabIndex = 2;
			this.label32.Text = "Specifies whether you will clean the potential heaps of cached data sittting on";
			this.label33.AutoSize = true;
			this.label33.BackColor = global::System.Drawing.Color.Transparent;
			this.label33.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label33.Location = new global::System.Drawing.Point(27, 22);
			this.label33.Name = "label33";
			this.label33.Size = new global::System.Drawing.Size(77, 17);
			this.label33.TabIndex = 1;
			this.label33.Text = "Clear Cache";
			this.btnClearCache.BackColor = global::System.Drawing.Color.Transparent;
			this.btnClearCache.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnClearCache.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnClearCache.FlatAppearance.BorderSize = 0;
			this.btnClearCache.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnClearCache.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnClearCache.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnClearCache.Location = new global::System.Drawing.Point(0, 0);
			this.btnClearCache.Name = "btnClearCache";
			this.btnClearCache.Size = new global::System.Drawing.Size(30, 64);
			this.btnClearCache.TabIndex = 0;
			this.btnClearCache.Text = ">";
			this.btnClearCache.UseVisualStyleBackColor = false;
			this.btnClearCache.Click += new global::System.EventHandler(this.btnClearCache_Click);
			this.flowPanelMain.AutoScroll = true;
			this.flowPanelMain.BackColor = global::System.Drawing.Color.Transparent;
			this.flowPanelMain.Controls.Add(this.panelCleanCache);
			this.flowPanelMain.Controls.Add(this.panelCleanCacheOptions);
			this.flowPanelMain.Controls.Add(this.panelDataQueueSize);
			this.flowPanelMain.Controls.Add(this.panelDataQueueSizeOptions);
			this.flowPanelMain.Controls.Add(this.panelMemoryManagement);
			this.flowPanelMain.Controls.Add(this.panelMemoryManagementOptions);
			this.flowPanelMain.Controls.Add(this.panelPlatformTick);
			this.flowPanelMain.Controls.Add(this.panelPlatformTickOptions);
			this.flowPanelMain.Controls.Add(this.panelPowerOptions);
			this.flowPanelMain.Controls.Add(this.panelPowerOptionsOptions);
			this.flowPanelMain.Controls.Add(this.panelPrefetchLogging);
			this.flowPanelMain.Controls.Add(this.panelPrefetchLoggingOptions);
			this.flowPanelMain.Controls.Add(this.panelProcessMitigation);
			this.flowPanelMain.Controls.Add(this.panelProcessMitigationOptions);
			this.flowPanelMain.Controls.Add(this.panelSystemProfile);
			this.flowPanelMain.Controls.Add(this.panelSystemProfileOptions);
			this.flowPanelMain.Controls.Add(this.panelSystemTelemetry);
			this.flowPanelMain.Controls.Add(this.panelSystemTelemetryOptions);
			this.flowPanelMain.Controls.Add(this.panelWin32Priority);
			this.flowPanelMain.Controls.Add(this.panelWin32PriorityOptions);
			this.flowPanelMain.Controls.Add(this.panelWinDefender);
			this.flowPanelMain.Controls.Add(this.panelWinDefenderOptions);
			this.flowPanelMain.Controls.Add(this.panelWindowsUpdate);
			this.flowPanelMain.Controls.Add(this.panelWindowsUpdateOptions);
			this.flowPanelMain.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowPanelMain.Location = new global::System.Drawing.Point(0, 0);
			this.flowPanelMain.Margin = new global::System.Windows.Forms.Padding(0);
			this.flowPanelMain.Name = "flowPanelMain";
			this.flowPanelMain.Size = new global::System.Drawing.Size(695, 501);
			this.flowPanelMain.TabIndex = 30;
			this.flowPanelMain.WrapContents = false;
			this.panelDataQueueSizeOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelDataQueueSizeOptions.Controls.Add(this.checkBoxMouseDataQueueSize);
			this.panelDataQueueSizeOptions.Controls.Add(this.checkBoxKeyboardDataQueueSize);
			this.panelDataQueueSizeOptions.Location = new global::System.Drawing.Point(0, 192);
			this.panelDataQueueSizeOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelDataQueueSizeOptions.Name = "panelDataQueueSizeOptions";
			this.panelDataQueueSizeOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelDataQueueSizeOptions.TabIndex = 183;
			this.panelDataQueueSizeOptions.Visible = false;
			this.checkBoxMouseDataQueueSize.AutoSize = true;
			this.checkBoxMouseDataQueueSize.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxMouseDataQueueSize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxMouseDataQueueSize.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxMouseDataQueueSize.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxMouseDataQueueSize.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxMouseDataQueueSize.Name = "checkBoxMouseDataQueueSize";
			this.checkBoxMouseDataQueueSize.Size = new global::System.Drawing.Size(330, 19);
			this.checkBoxMouseDataQueueSize.TabIndex = 62;
			this.checkBoxMouseDataQueueSize.Text = "MouseDataQueueSize (20 dec; Breaks trackpads/PS2 mice)";
			this.checkBoxMouseDataQueueSize.UseVisualStyleBackColor = false;
			this.checkBoxKeyboardDataQueueSize.AutoSize = true;
			this.checkBoxKeyboardDataQueueSize.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxKeyboardDataQueueSize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxKeyboardDataQueueSize.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxKeyboardDataQueueSize.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxKeyboardDataQueueSize.Location = new global::System.Drawing.Point(8, 37);
			this.checkBoxKeyboardDataQueueSize.Name = "checkBoxKeyboardDataQueueSize";
			this.checkBoxKeyboardDataQueueSize.Size = new global::System.Drawing.Size(355, 19);
			this.checkBoxKeyboardDataQueueSize.TabIndex = 64;
			this.checkBoxKeyboardDataQueueSize.Text = "KeyboardDataQueueSize (50 dec, Breaks laptop/PS2 keyboards)";
			this.checkBoxKeyboardDataQueueSize.UseVisualStyleBackColor = false;
			this.panelPlatformTick.BackColor = global::System.Drawing.Color.Transparent;
			this.panelPlatformTick.Controls.Add(this.label19);
			this.panelPlatformTick.Controls.Add(this.label20);
			this.panelPlatformTick.Controls.Add(this.label21);
			this.panelPlatformTick.Controls.Add(this.btnPlatformTick);
			this.panelPlatformTick.Location = new global::System.Drawing.Point(0, 384);
			this.panelPlatformTick.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelPlatformTick.Name = "panelPlatformTick";
			this.panelPlatformTick.Size = new global::System.Drawing.Size(678, 64);
			this.panelPlatformTick.TabIndex = 211;
			this.label19.AutoSize = true;
			this.label19.BackColor = global::System.Drawing.Color.Transparent;
			this.label19.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.Location = new global::System.Drawing.Point(196, 34);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(394, 15);
			this.label19.TabIndex = 3;
			this.label19.Text = "This will change the system timer, which is connected to timer resolution.";
			this.label20.AutoSize = true;
			this.label20.BackColor = global::System.Drawing.Color.Transparent;
			this.label20.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label20.Location = new global::System.Drawing.Point(196, 14);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(389, 15);
			this.label20.TabIndex = 2;
			this.label20.Text = "Specifies the whether the system timer is platform tick or platform clock.";
			this.label21.AutoSize = true;
			this.label21.BackColor = global::System.Drawing.Color.Transparent;
			this.label21.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label21.Location = new global::System.Drawing.Point(27, 22);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(141, 17);
			this.label21.TabIndex = 1;
			this.label21.Text = "Platform Tick (BCDEdit)";
			this.btnPlatformTick.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPlatformTick.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnPlatformTick.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnPlatformTick.FlatAppearance.BorderSize = 0;
			this.btnPlatformTick.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnPlatformTick.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnPlatformTick.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnPlatformTick.Location = new global::System.Drawing.Point(0, 0);
			this.btnPlatformTick.Name = "btnPlatformTick";
			this.btnPlatformTick.Size = new global::System.Drawing.Size(30, 64);
			this.btnPlatformTick.TabIndex = 0;
			this.btnPlatformTick.Text = ">";
			this.btnPlatformTick.UseVisualStyleBackColor = false;
			this.btnPlatformTick.Click += new global::System.EventHandler(this.btnPlatformTick_Click);
			this.panelPlatformTickOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelPlatformTickOptions.Controls.Add(this.checkBoxPlatformTick);
			this.panelPlatformTickOptions.Controls.Add(this.checkBoxResetOtherBCDEdit);
			this.panelPlatformTickOptions.Location = new global::System.Drawing.Point(0, 448);
			this.panelPlatformTickOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelPlatformTickOptions.Name = "panelPlatformTickOptions";
			this.panelPlatformTickOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelPlatformTickOptions.TabIndex = 212;
			this.panelPlatformTickOptions.Visible = false;
			this.checkBoxPlatformTick.AutoSize = true;
			this.checkBoxPlatformTick.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxPlatformTick.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxPlatformTick.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxPlatformTick.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxPlatformTick.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxPlatformTick.Name = "checkBoxPlatformTick";
			this.checkBoxPlatformTick.Size = new global::System.Drawing.Size(345, 19);
			this.checkBoxPlatformTick.TabIndex = 62;
			this.checkBoxPlatformTick.Text = "UsePlatformTick && DisableDynamicTick (may reduce latency)";
			this.checkBoxPlatformTick.UseVisualStyleBackColor = false;
			this.checkBoxPlatformTick.CheckedChanged += new global::System.EventHandler(this.checkBoxPlatformTick_CheckedChanged);
			this.checkBoxResetOtherBCDEdit.AutoSize = true;
			this.checkBoxResetOtherBCDEdit.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxResetOtherBCDEdit.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxResetOtherBCDEdit.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxResetOtherBCDEdit.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxResetOtherBCDEdit.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxResetOtherBCDEdit.Name = "checkBoxResetOtherBCDEdit";
			this.checkBoxResetOtherBCDEdit.Size = new global::System.Drawing.Size(275, 19);
			this.checkBoxResetOtherBCDEdit.TabIndex = 64;
			this.checkBoxResetOtherBCDEdit.Text = "Reset all other BCDEdit options (recommended)";
			this.checkBoxResetOtherBCDEdit.UseVisualStyleBackColor = false;
			this.checkBoxResetOtherBCDEdit.CheckedChanged += new global::System.EventHandler(this.checkBoxResetOtherBCDEdit_CheckedChanged);
			this.panelPowerOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.panelPowerOptions.Controls.Add(this.label10);
			this.panelPowerOptions.Controls.Add(this.label11);
			this.panelPowerOptions.Controls.Add(this.label12);
			this.panelPowerOptions.Controls.Add(this.btnPowerOptions);
			this.panelPowerOptions.Location = new global::System.Drawing.Point(0, 512);
			this.panelPowerOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelPowerOptions.Name = "panelPowerOptions";
			this.panelPowerOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelPowerOptions.TabIndex = 213;
			this.label10.AutoSize = true;
			this.label10.BackColor = global::System.Drawing.Color.Transparent;
			this.label10.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(196, 34);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(326, 15);
			this.label10.TabIndex = 3;
			this.label10.Text = "affect certain sleep settings, power settings, and hibernation.";
			this.label11.AutoSize = true;
			this.label11.BackColor = global::System.Drawing.Color.Transparent;
			this.label11.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(196, 14);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(424, 15);
			this.label11.TabIndex = 2;
			this.label11.Text = "Specifies certain power options set by the operating system by default. This can";
			this.label12.AutoSize = true;
			this.label12.BackColor = global::System.Drawing.Color.Transparent;
			this.label12.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.Location = new global::System.Drawing.Point(27, 22);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(94, 17);
			this.label12.TabIndex = 1;
			this.label12.Text = "Power Options";
			this.btnPowerOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPowerOptions.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnPowerOptions.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnPowerOptions.FlatAppearance.BorderSize = 0;
			this.btnPowerOptions.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnPowerOptions.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnPowerOptions.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnPowerOptions.Location = new global::System.Drawing.Point(0, 0);
			this.btnPowerOptions.Name = "btnPowerOptions";
			this.btnPowerOptions.Size = new global::System.Drawing.Size(30, 64);
			this.btnPowerOptions.TabIndex = 0;
			this.btnPowerOptions.Text = ">";
			this.btnPowerOptions.UseVisualStyleBackColor = false;
			this.btnPowerOptions.Click += new global::System.EventHandler(this.btnPowerOptions_Click);
			this.panelPowerOptionsOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelPowerOptionsOptions.Controls.Add(this.checkBoxPowerThrottling);
			this.panelPowerOptionsOptions.Controls.Add(this.checkBoxHibernation);
			this.panelPowerOptionsOptions.Location = new global::System.Drawing.Point(0, 576);
			this.panelPowerOptionsOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelPowerOptionsOptions.Name = "panelPowerOptionsOptions";
			this.panelPowerOptionsOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelPowerOptionsOptions.TabIndex = 214;
			this.panelPowerOptionsOptions.Visible = false;
			this.checkBoxPowerThrottling.AutoSize = true;
			this.checkBoxPowerThrottling.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxPowerThrottling.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxPowerThrottling.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxPowerThrottling.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxPowerThrottling.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxPowerThrottling.Name = "checkBoxPowerThrottling";
			this.checkBoxPowerThrottling.Size = new global::System.Drawing.Size(279, 19);
			this.checkBoxPowerThrottling.TabIndex = 62;
			this.checkBoxPowerThrottling.Text = "Disable Power Throttling (will affect power draw)";
			this.checkBoxPowerThrottling.UseVisualStyleBackColor = false;
			this.checkBoxHibernation.AutoSize = true;
			this.checkBoxHibernation.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxHibernation.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxHibernation.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxHibernation.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxHibernation.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxHibernation.Name = "checkBoxHibernation";
			this.checkBoxHibernation.Size = new global::System.Drawing.Size(234, 19);
			this.checkBoxHibernation.TabIndex = 64;
			this.checkBoxHibernation.Text = "Disable Hibernation (mainly for laptops)";
			this.checkBoxHibernation.UseVisualStyleBackColor = false;
			this.panelPrefetchLogging.BackColor = global::System.Drawing.Color.Transparent;
			this.panelPrefetchLogging.Controls.Add(this.label7);
			this.panelPrefetchLogging.Controls.Add(this.label8);
			this.panelPrefetchLogging.Controls.Add(this.label9);
			this.panelPrefetchLogging.Controls.Add(this.btnPrefetchLogging);
			this.panelPrefetchLogging.Location = new global::System.Drawing.Point(0, 640);
			this.panelPrefetchLogging.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelPrefetchLogging.Name = "panelPrefetchLogging";
			this.panelPrefetchLogging.Size = new global::System.Drawing.Size(678, 64);
			this.panelPrefetchLogging.TabIndex = 225;
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(196, 34);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(448, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "This will affect how Prefetch/Superfetch works and whether they are enabled or not.";
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(196, 14);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(440, 15);
			this.label8.TabIndex = 2;
			this.label8.Text = "Specifies the settings used for Prefetch, Superfetch (or Sysmain), and Boot Tracing.";
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(27, 22);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(121, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Prefetch && Logging";
			this.btnPrefetchLogging.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPrefetchLogging.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnPrefetchLogging.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnPrefetchLogging.FlatAppearance.BorderSize = 0;
			this.btnPrefetchLogging.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnPrefetchLogging.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnPrefetchLogging.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnPrefetchLogging.Location = new global::System.Drawing.Point(0, 0);
			this.btnPrefetchLogging.Name = "btnPrefetchLogging";
			this.btnPrefetchLogging.Size = new global::System.Drawing.Size(30, 64);
			this.btnPrefetchLogging.TabIndex = 0;
			this.btnPrefetchLogging.Text = ">";
			this.btnPrefetchLogging.UseVisualStyleBackColor = false;
			this.btnPrefetchLogging.Click += new global::System.EventHandler(this.btnPrefetchLogging_Click);
			this.panelPrefetchLoggingOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelPrefetchLoggingOptions.Controls.Add(this.checkBoxPrefetchSuperfetch);
			this.panelPrefetchLoggingOptions.Controls.Add(this.checkBoxBootTracing);
			this.panelPrefetchLoggingOptions.Location = new global::System.Drawing.Point(0, 704);
			this.panelPrefetchLoggingOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelPrefetchLoggingOptions.Name = "panelPrefetchLoggingOptions";
			this.panelPrefetchLoggingOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelPrefetchLoggingOptions.TabIndex = 226;
			this.panelPrefetchLoggingOptions.Visible = false;
			this.checkBoxPrefetchSuperfetch.AutoSize = true;
			this.checkBoxPrefetchSuperfetch.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxPrefetchSuperfetch.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxPrefetchSuperfetch.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxPrefetchSuperfetch.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxPrefetchSuperfetch.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxPrefetchSuperfetch.Name = "checkBoxPrefetchSuperfetch";
			this.checkBoxPrefetchSuperfetch.Size = new global::System.Drawing.Size(308, 19);
			this.checkBoxPrefetchSuperfetch.TabIndex = 62;
			this.checkBoxPrefetchSuperfetch.Text = "Disable Prefetch/Superfetch (reduces disk/CPU usage)";
			this.checkBoxPrefetchSuperfetch.UseVisualStyleBackColor = false;
			this.checkBoxBootTracing.AutoSize = true;
			this.checkBoxBootTracing.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxBootTracing.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxBootTracing.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxBootTracing.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxBootTracing.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxBootTracing.Name = "checkBoxBootTracing";
			this.checkBoxBootTracing.Size = new global::System.Drawing.Size(363, 19);
			this.checkBoxBootTracing.TabIndex = 64;
			this.checkBoxBootTracing.Text = "Disable Boot Tracing (reduces startup times, may reduce latency)";
			this.checkBoxBootTracing.UseVisualStyleBackColor = false;
			this.panelProcessMitigation.BackColor = global::System.Drawing.Color.Transparent;
			this.panelProcessMitigation.Controls.Add(this.label28);
			this.panelProcessMitigation.Controls.Add(this.label29);
			this.panelProcessMitigation.Controls.Add(this.label30);
			this.panelProcessMitigation.Controls.Add(this.btnProcessMitigation);
			this.panelProcessMitigation.Location = new global::System.Drawing.Point(0, 768);
			this.panelProcessMitigation.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelProcessMitigation.Name = "panelProcessMitigation";
			this.panelProcessMitigation.Size = new global::System.Drawing.Size(678, 64);
			this.panelProcessMitigation.TabIndex = 227;
			this.label28.AutoSize = true;
			this.label28.BackColor = global::System.Drawing.Color.Transparent;
			this.label28.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label28.Location = new global::System.Drawing.Point(196, 35);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(423, 15);
			this.label28.TabIndex = 3;
			this.label28.Text = "effect DEP, ASLR, SEHOP, and FTH mitigations depending on what you choose.";
			this.label29.AutoSize = true;
			this.label29.BackColor = global::System.Drawing.Color.Transparent;
			this.label29.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label29.Location = new global::System.Drawing.Point(196, 15);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(378, 15);
			this.label29.TabIndex = 2;
			this.label29.Text = "Specifies whether process mitigations are enabled or disabled. This will";
			this.label30.AutoSize = true;
			this.label30.BackColor = global::System.Drawing.Color.Transparent;
			this.label30.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label30.Location = new global::System.Drawing.Point(27, 22);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(116, 17);
			this.label30.TabIndex = 1;
			this.label30.Text = "Process Mitigation";
			this.btnProcessMitigation.BackColor = global::System.Drawing.Color.Transparent;
			this.btnProcessMitigation.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnProcessMitigation.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnProcessMitigation.FlatAppearance.BorderSize = 0;
			this.btnProcessMitigation.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnProcessMitigation.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnProcessMitigation.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnProcessMitigation.Location = new global::System.Drawing.Point(0, 0);
			this.btnProcessMitigation.Name = "btnProcessMitigation";
			this.btnProcessMitigation.Size = new global::System.Drawing.Size(30, 64);
			this.btnProcessMitigation.TabIndex = 0;
			this.btnProcessMitigation.Text = ">";
			this.btnProcessMitigation.UseVisualStyleBackColor = false;
			this.btnProcessMitigation.Click += new global::System.EventHandler(this.btnProcessMitigation_Click);
			this.panelProcessMitigationOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelProcessMitigationOptions.Controls.Add(this.checkBoxProcessMitigationEnabled);
			this.panelProcessMitigationOptions.Controls.Add(this.checkBoxProcessMitigationDisabled);
			this.panelProcessMitigationOptions.Location = new global::System.Drawing.Point(0, 832);
			this.panelProcessMitigationOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelProcessMitigationOptions.Name = "panelProcessMitigationOptions";
			this.panelProcessMitigationOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelProcessMitigationOptions.TabIndex = 228;
			this.panelProcessMitigationOptions.Visible = false;
			this.checkBoxProcessMitigationEnabled.AutoSize = true;
			this.checkBoxProcessMitigationEnabled.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxProcessMitigationEnabled.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxProcessMitigationEnabled.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxProcessMitigationEnabled.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxProcessMitigationEnabled.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxProcessMitigationEnabled.Name = "checkBoxProcessMitigationEnabled";
			this.checkBoxProcessMitigationEnabled.Size = new global::System.Drawing.Size(402, 19);
			this.checkBoxProcessMitigationEnabled.TabIndex = 62;
			this.checkBoxProcessMitigationEnabled.Text = "All Process Mitigations Enabled (will increase security; increases latency)";
			this.checkBoxProcessMitigationEnabled.UseVisualStyleBackColor = false;
			this.checkBoxProcessMitigationEnabled.CheckedChanged += new global::System.EventHandler(this.checkBoxProcessMitigationEnabled_CheckedChanged);
			this.checkBoxProcessMitigationDisabled.AutoSize = true;
			this.checkBoxProcessMitigationDisabled.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxProcessMitigationDisabled.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxProcessMitigationDisabled.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxProcessMitigationDisabled.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxProcessMitigationDisabled.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxProcessMitigationDisabled.Name = "checkBoxProcessMitigationDisabled";
			this.checkBoxProcessMitigationDisabled.Size = new global::System.Drawing.Size(391, 19);
			this.checkBoxProcessMitigationDisabled.TabIndex = 64;
			this.checkBoxProcessMitigationDisabled.Text = "All Process Mitigations Disabled (will reduce latency; reduces security)";
			this.checkBoxProcessMitigationDisabled.UseVisualStyleBackColor = false;
			this.checkBoxProcessMitigationDisabled.CheckedChanged += new global::System.EventHandler(this.checkBoxProcessMitigationDisabled_CheckedChanged);
			this.panelSystemProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.panelSystemProfile.Controls.Add(this.label13);
			this.panelSystemProfile.Controls.Add(this.label14);
			this.panelSystemProfile.Controls.Add(this.label15);
			this.panelSystemProfile.Controls.Add(this.btnSystemProfile);
			this.panelSystemProfile.Location = new global::System.Drawing.Point(0, 896);
			this.panelSystemProfile.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelSystemProfile.Name = "panelSystemProfile";
			this.panelSystemProfile.Size = new global::System.Drawing.Size(678, 64);
			this.panelSystemProfile.TabIndex = 229;
			this.label13.AutoSize = true;
			this.label13.BackColor = global::System.Drawing.Color.Transparent;
			this.label13.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.Location = new global::System.Drawing.Point(196, 35);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(429, 15);
			this.label13.TabIndex = 3;
			this.label13.Text = "This will affect MMCSS behavior, system responsiveness, and network throttling.";
			this.label14.AutoSize = true;
			this.label14.BackColor = global::System.Drawing.Color.Transparent;
			this.label14.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.Location = new global::System.Drawing.Point(196, 15);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(442, 15);
			this.label14.TabIndex = 2;
			this.label14.Text = "Specifies the settings for multimedia applications such as games or a web browser.";
			this.label15.AutoSize = true;
			this.label15.BackColor = global::System.Drawing.Color.Transparent;
			this.label15.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.Location = new global::System.Drawing.Point(27, 22);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(140, 17);
			this.label15.TabIndex = 1;
			this.label15.Text = "System Profile Options";
			this.btnSystemProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSystemProfile.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnSystemProfile.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnSystemProfile.FlatAppearance.BorderSize = 0;
			this.btnSystemProfile.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnSystemProfile.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnSystemProfile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSystemProfile.Location = new global::System.Drawing.Point(0, 0);
			this.btnSystemProfile.Name = "btnSystemProfile";
			this.btnSystemProfile.Size = new global::System.Drawing.Size(30, 64);
			this.btnSystemProfile.TabIndex = 0;
			this.btnSystemProfile.Text = ">";
			this.btnSystemProfile.UseVisualStyleBackColor = false;
			this.btnSystemProfile.Click += new global::System.EventHandler(this.btnSystemProfile_Click);
			this.panelSystemProfileOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelSystemProfileOptions.Controls.Add(this.checkBoxDisableMMCSS);
			this.panelSystemProfileOptions.Controls.Add(this.checkBoxSystemResponsiveness);
			this.panelSystemProfileOptions.Controls.Add(this.checkBoxNetworkThrottlingIndex);
			this.panelSystemProfileOptions.Location = new global::System.Drawing.Point(0, 960);
			this.panelSystemProfileOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelSystemProfileOptions.Name = "panelSystemProfileOptions";
			this.panelSystemProfileOptions.Size = new global::System.Drawing.Size(678, 96);
			this.panelSystemProfileOptions.TabIndex = 230;
			this.panelSystemProfileOptions.Visible = false;
			this.checkBoxDisableMMCSS.AutoSize = true;
			this.checkBoxDisableMMCSS.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxDisableMMCSS.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxDisableMMCSS.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxDisableMMCSS.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxDisableMMCSS.Location = new global::System.Drawing.Point(8, 70);
			this.checkBoxDisableMMCSS.Name = "checkBoxDisableMMCSS";
			this.checkBoxDisableMMCSS.Size = new global::System.Drawing.Size(310, 19);
			this.checkBoxDisableMMCSS.TabIndex = 65;
			this.checkBoxDisableMMCSS.Text = "Disable MMCSS (recommended for better rate of DPC)";
			this.checkBoxDisableMMCSS.UseVisualStyleBackColor = false;
			this.checkBoxSystemResponsiveness.AutoSize = true;
			this.checkBoxSystemResponsiveness.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxSystemResponsiveness.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxSystemResponsiveness.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxSystemResponsiveness.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxSystemResponsiveness.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxSystemResponsiveness.Name = "checkBoxSystemResponsiveness";
			this.checkBoxSystemResponsiveness.Size = new global::System.Drawing.Size(254, 19);
			this.checkBoxSystemResponsiveness.TabIndex = 62;
			this.checkBoxSystemResponsiveness.Text = "SystemResponsiveness (20; reduces latency)";
			this.checkBoxSystemResponsiveness.UseVisualStyleBackColor = false;
			this.checkBoxNetworkThrottlingIndex.AutoSize = true;
			this.checkBoxNetworkThrottlingIndex.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxNetworkThrottlingIndex.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxNetworkThrottlingIndex.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxNetworkThrottlingIndex.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxNetworkThrottlingIndex.Location = new global::System.Drawing.Point(8, 39);
			this.checkBoxNetworkThrottlingIndex.Name = "checkBoxNetworkThrottlingIndex";
			this.checkBoxNetworkThrottlingIndex.Size = new global::System.Drawing.Size(258, 19);
			this.checkBoxNetworkThrottlingIndex.TabIndex = 64;
			this.checkBoxNetworkThrottlingIndex.Text = "NetworkThrottlingIndex (10; reduces hit-reg)";
			this.checkBoxNetworkThrottlingIndex.UseVisualStyleBackColor = false;
			this.panelSystemTelemetry.BackColor = global::System.Drawing.Color.Transparent;
			this.panelSystemTelemetry.Controls.Add(this.label16);
			this.panelSystemTelemetry.Controls.Add(this.label17);
			this.panelSystemTelemetry.Controls.Add(this.label18);
			this.panelSystemTelemetry.Controls.Add(this.btnSystemTelemetry);
			this.panelSystemTelemetry.Location = new global::System.Drawing.Point(0, 1056);
			this.panelSystemTelemetry.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelSystemTelemetry.Name = "panelSystemTelemetry";
			this.panelSystemTelemetry.Size = new global::System.Drawing.Size(678, 64);
			this.panelSystemTelemetry.TabIndex = 231;
			this.label16.AutoSize = true;
			this.label16.BackColor = global::System.Drawing.Color.Transparent;
			this.label16.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.Location = new global::System.Drawing.Point(196, 35);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(430, 15);
			this.label16.TabIndex = 3;
			this.label16.Text = "This affects system-wide telemetry and specifies whether its enabled or disabled.";
			this.label17.AutoSize = true;
			this.label17.BackColor = global::System.Drawing.Color.Transparent;
			this.label17.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.Location = new global::System.Drawing.Point(196, 15);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(430, 15);
			this.label17.TabIndex = 2;
			this.label17.Text = "Specifies the types of telemetry used to collect user and system data for analysis.";
			this.label18.AutoSize = true;
			this.label18.BackColor = global::System.Drawing.Color.Transparent;
			this.label18.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.Location = new global::System.Drawing.Point(27, 22);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(109, 17);
			this.label18.TabIndex = 1;
			this.label18.Text = "System Telemetry";
			this.btnSystemTelemetry.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSystemTelemetry.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnSystemTelemetry.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnSystemTelemetry.FlatAppearance.BorderSize = 0;
			this.btnSystemTelemetry.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnSystemTelemetry.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnSystemTelemetry.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSystemTelemetry.Location = new global::System.Drawing.Point(0, 0);
			this.btnSystemTelemetry.Name = "btnSystemTelemetry";
			this.btnSystemTelemetry.Size = new global::System.Drawing.Size(30, 64);
			this.btnSystemTelemetry.TabIndex = 0;
			this.btnSystemTelemetry.Text = ">";
			this.btnSystemTelemetry.UseVisualStyleBackColor = false;
			this.btnSystemTelemetry.Click += new global::System.EventHandler(this.btnSystemTelemetry_Click);
			this.panelSystemTelemetryOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelSystemTelemetryOptions.Controls.Add(this.checkBoxSystemTelemetry);
			this.panelSystemTelemetryOptions.Controls.Add(this.checkBoxAppTelemetry);
			this.panelSystemTelemetryOptions.Location = new global::System.Drawing.Point(0, 1120);
			this.panelSystemTelemetryOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelSystemTelemetryOptions.Name = "panelSystemTelemetryOptions";
			this.panelSystemTelemetryOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelSystemTelemetryOptions.TabIndex = 232;
			this.panelSystemTelemetryOptions.Visible = false;
			this.checkBoxSystemTelemetry.AutoSize = true;
			this.checkBoxSystemTelemetry.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxSystemTelemetry.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxSystemTelemetry.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxSystemTelemetry.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxSystemTelemetry.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxSystemTelemetry.Name = "checkBoxSystemTelemetry";
			this.checkBoxSystemTelemetry.Size = new global::System.Drawing.Size(409, 19);
			this.checkBoxSystemTelemetry.TabIndex = 62;
			this.checkBoxSystemTelemetry.Text = "Disable system telemetry/auto driver updates (reduces background tasks)";
			this.checkBoxSystemTelemetry.UseVisualStyleBackColor = false;
			this.checkBoxAppTelemetry.AutoSize = true;
			this.checkBoxAppTelemetry.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxAppTelemetry.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxAppTelemetry.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxAppTelemetry.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxAppTelemetry.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxAppTelemetry.Name = "checkBoxAppTelemetry";
			this.checkBoxAppTelemetry.Size = new global::System.Drawing.Size(256, 19);
			this.checkBoxAppTelemetry.TabIndex = 64;
			this.checkBoxAppTelemetry.Text = "Disable application telemetry (more privacy)";
			this.checkBoxAppTelemetry.UseVisualStyleBackColor = false;
			this.panelWin32Priority.BackColor = global::System.Drawing.Color.Transparent;
			this.panelWin32Priority.Controls.Add(this.label3);
			this.panelWin32Priority.Controls.Add(this.label2);
			this.panelWin32Priority.Controls.Add(this.label1);
			this.panelWin32Priority.Controls.Add(this.btnWin32Priority);
			this.panelWin32Priority.Location = new global::System.Drawing.Point(0, 1184);
			this.panelWin32Priority.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelWin32Priority.Name = "panelWin32Priority";
			this.panelWin32Priority.Size = new global::System.Drawing.Size(678, 64);
			this.panelWin32Priority.TabIndex = 233;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(196, 35);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(444, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "affects the relative priority of the threads of foreground and background processes.";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(196, 15);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(421, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Specifies the strategy used for optimizing processor time on this system. It also";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(148, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Win32PrioritySeparation";
			this.btnWin32Priority.BackColor = global::System.Drawing.Color.Transparent;
			this.btnWin32Priority.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnWin32Priority.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnWin32Priority.FlatAppearance.BorderSize = 0;
			this.btnWin32Priority.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnWin32Priority.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnWin32Priority.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnWin32Priority.ForeColor = global::System.Drawing.Color.White;
			this.btnWin32Priority.Location = new global::System.Drawing.Point(0, 0);
			this.btnWin32Priority.Name = "btnWin32Priority";
			this.btnWin32Priority.Size = new global::System.Drawing.Size(30, 64);
			this.btnWin32Priority.TabIndex = 0;
			this.btnWin32Priority.Text = ">";
			this.btnWin32Priority.UseVisualStyleBackColor = false;
			this.btnWin32Priority.Click += new global::System.EventHandler(this.btnWin32Priority_Click);
			this.panelWin32PriorityOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelWin32PriorityOptions.Controls.Add(this.checkBoxWin3f91);
			this.panelWin32PriorityOptions.Controls.Add(this.checkBoxWin2);
			this.panelWin32PriorityOptions.Controls.Add(this.checkBoxWin26);
			this.panelWin32PriorityOptions.Location = new global::System.Drawing.Point(0, 1248);
			this.panelWin32PriorityOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelWin32PriorityOptions.Name = "panelWin32PriorityOptions";
			this.panelWin32PriorityOptions.Size = new global::System.Drawing.Size(678, 96);
			this.panelWin32PriorityOptions.TabIndex = 234;
			this.panelWin32PriorityOptions.Visible = false;
			this.checkBoxWin3f91.AutoSize = true;
			this.checkBoxWin3f91.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxWin3f91.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWin3f91.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxWin3f91.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxWin3f91.Location = new global::System.Drawing.Point(8, 70);
			this.checkBoxWin3f91.Name = "checkBoxWin3f91";
			this.checkBoxWin3f91.Size = new global::System.Drawing.Size(359, 19);
			this.checkBoxWin3f91.TabIndex = 65;
			this.checkBoxWin3f91.Text = "ffff3f91 (Unknown; added by popular demand, may be the best)";
			this.checkBoxWin3f91.UseVisualStyleBackColor = false;
			this.checkBoxWin3f91.CheckedChanged += new global::System.EventHandler(this.checkBoxWin3f91_CheckedChanged);
			this.checkBoxWin2.AutoSize = true;
			this.checkBoxWin2.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxWin2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWin2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxWin2.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxWin2.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxWin2.Name = "checkBoxWin2";
			this.checkBoxWin2.Size = new global::System.Drawing.Size(245, 19);
			this.checkBoxWin2.TabIndex = 62;
			this.checkBoxWin2.Text = "2 (Default; gives more FPS, higher latency)";
			this.checkBoxWin2.UseVisualStyleBackColor = false;
			this.checkBoxWin2.CheckedChanged += new global::System.EventHandler(this.checkBoxWin2_CheckedChanged);
			this.checkBoxWin26.AutoSize = true;
			this.checkBoxWin26.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxWin26.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWin26.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxWin26.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxWin26.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxWin26.Name = "checkBoxWin26";
			this.checkBoxWin26.Size = new global::System.Drawing.Size(254, 19);
			this.checkBoxWin26.TabIndex = 64;
			this.checkBoxWin26.Text = "26 (Optimized; gives lower latency, less FPS)";
			this.checkBoxWin26.UseVisualStyleBackColor = false;
			this.checkBoxWin26.CheckedChanged += new global::System.EventHandler(this.checkBoxWin26_CheckedChanged);
			this.panelWinDefender.BackColor = global::System.Drawing.Color.Transparent;
			this.panelWinDefender.Controls.Add(this.label22);
			this.panelWinDefender.Controls.Add(this.label23);
			this.panelWinDefender.Controls.Add(this.label24);
			this.panelWinDefender.Controls.Add(this.btnWinDefender);
			this.panelWinDefender.Location = new global::System.Drawing.Point(0, 1344);
			this.panelWinDefender.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelWinDefender.Name = "panelWinDefender";
			this.panelWinDefender.Size = new global::System.Drawing.Size(678, 64);
			this.panelWinDefender.TabIndex = 235;
			this.label22.AutoSize = true;
			this.label22.BackColor = global::System.Drawing.Color.Transparent;
			this.label22.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label22.Location = new global::System.Drawing.Point(196, 35);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(392, 15);
			this.label22.TabIndex = 3;
			this.label22.Text = "This will affect Windows Defender, but is customizable to the users liking.";
			this.label23.AutoSize = true;
			this.label23.BackColor = global::System.Drawing.Color.Transparent;
			this.label23.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label23.Location = new global::System.Drawing.Point(196, 15);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(393, 15);
			this.label23.TabIndex = 2;
			this.label23.Text = "Specifies Windows Defender settings and whether its disabled or enabled.";
			this.label24.AutoSize = true;
			this.label24.BackColor = global::System.Drawing.Color.Transparent;
			this.label24.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label24.Location = new global::System.Drawing.Point(27, 22);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(119, 17);
			this.label24.TabIndex = 1;
			this.label24.Text = "Windows Defender";
			this.btnWinDefender.BackColor = global::System.Drawing.Color.Transparent;
			this.btnWinDefender.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnWinDefender.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnWinDefender.FlatAppearance.BorderSize = 0;
			this.btnWinDefender.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnWinDefender.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnWinDefender.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnWinDefender.Location = new global::System.Drawing.Point(0, 0);
			this.btnWinDefender.Name = "btnWinDefender";
			this.btnWinDefender.Size = new global::System.Drawing.Size(30, 64);
			this.btnWinDefender.TabIndex = 0;
			this.btnWinDefender.Text = ">";
			this.btnWinDefender.UseVisualStyleBackColor = false;
			this.btnWinDefender.Click += new global::System.EventHandler(this.btnWinDefender_Click);
			this.panelWinDefenderOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelWinDefenderOptions.Controls.Add(this.checkBoxWinDefenderExclusions);
			this.panelWinDefenderOptions.Controls.Add(this.checkBoxDisableWinDefender);
			this.panelWinDefenderOptions.Location = new global::System.Drawing.Point(0, 1408);
			this.panelWinDefenderOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelWinDefenderOptions.Name = "panelWinDefenderOptions";
			this.panelWinDefenderOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelWinDefenderOptions.TabIndex = 236;
			this.panelWinDefenderOptions.Visible = false;
			this.checkBoxWinDefenderExclusions.AutoSize = true;
			this.checkBoxWinDefenderExclusions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxWinDefenderExclusions.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWinDefenderExclusions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxWinDefenderExclusions.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxWinDefenderExclusions.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxWinDefenderExclusions.Name = "checkBoxWinDefenderExclusions";
			this.checkBoxWinDefenderExclusions.Size = new global::System.Drawing.Size(446, 19);
			this.checkBoxWinDefenderExclusions.TabIndex = 62;
			this.checkBoxWinDefenderExclusions.Text = "Windows Defender Exclusions (may reduce latency; Windows Defender enabled)";
			this.checkBoxWinDefenderExclusions.UseVisualStyleBackColor = false;
			this.checkBoxWinDefenderExclusions.CheckedChanged += new global::System.EventHandler(this.checkBoxWinDefenderExclusions_CheckedChanged);
			this.checkBoxDisableWinDefender.AutoSize = true;
			this.checkBoxDisableWinDefender.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxDisableWinDefender.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxDisableWinDefender.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxDisableWinDefender.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxDisableWinDefender.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxDisableWinDefender.Name = "checkBoxDisableWinDefender";
			this.checkBoxDisableWinDefender.Size = new global::System.Drawing.Size(253, 19);
			this.checkBoxDisableWinDefender.TabIndex = 64;
			this.checkBoxDisableWinDefender.Text = "Disable Windows Defender (recommended)";
			this.checkBoxDisableWinDefender.UseVisualStyleBackColor = false;
			this.checkBoxDisableWinDefender.CheckedChanged += new global::System.EventHandler(this.checkBoxDisableWinDefender_CheckedChanged);
			this.panelWindowsUpdate.BackColor = global::System.Drawing.Color.Transparent;
			this.panelWindowsUpdate.Controls.Add(this.label37);
			this.panelWindowsUpdate.Controls.Add(this.label38);
			this.panelWindowsUpdate.Controls.Add(this.label39);
			this.panelWindowsUpdate.Controls.Add(this.btnWindowsUpdate);
			this.panelWindowsUpdate.Location = new global::System.Drawing.Point(0, 1472);
			this.panelWindowsUpdate.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelWindowsUpdate.Name = "panelWindowsUpdate";
			this.panelWindowsUpdate.Size = new global::System.Drawing.Size(678, 64);
			this.panelWindowsUpdate.TabIndex = 237;
			this.label37.AutoSize = true;
			this.label37.BackColor = global::System.Drawing.Color.Transparent;
			this.label37.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label37.Location = new global::System.Drawing.Point(196, 35);
			this.label37.Name = "label37";
			this.label37.Size = new global::System.Drawing.Size(402, 15);
			this.label37.TabIndex = 3;
			this.label37.Text = "This will disable/enabled Windows Update depending on what you choose.";
			this.label38.AutoSize = true;
			this.label38.BackColor = global::System.Drawing.Color.Transparent;
			this.label38.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label38.Location = new global::System.Drawing.Point(196, 15);
			this.label38.Name = "label38";
			this.label38.Size = new global::System.Drawing.Size(448, 15);
			this.label38.TabIndex = 2;
			this.label38.Text = "Specifies whether Windows Update is enabled or disabled, which may specify limits.";
			this.label39.AutoSize = true;
			this.label39.BackColor = global::System.Drawing.Color.Transparent;
			this.label39.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label39.Location = new global::System.Drawing.Point(27, 22);
			this.label39.Name = "label39";
			this.label39.Size = new global::System.Drawing.Size(108, 17);
			this.label39.TabIndex = 1;
			this.label39.Text = "Windows Update";
			this.btnWindowsUpdate.BackColor = global::System.Drawing.Color.Transparent;
			this.btnWindowsUpdate.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnWindowsUpdate.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 255, 255, 255);
			this.btnWindowsUpdate.FlatAppearance.BorderSize = 0;
			this.btnWindowsUpdate.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnWindowsUpdate.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnWindowsUpdate.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnWindowsUpdate.Location = new global::System.Drawing.Point(0, 0);
			this.btnWindowsUpdate.Name = "btnWindowsUpdate";
			this.btnWindowsUpdate.Size = new global::System.Drawing.Size(30, 64);
			this.btnWindowsUpdate.TabIndex = 0;
			this.btnWindowsUpdate.Text = ">";
			this.btnWindowsUpdate.UseVisualStyleBackColor = false;
			this.btnWindowsUpdate.Click += new global::System.EventHandler(this.btnWindowsUpdate_Click);
			this.panelWindowsUpdateOptions.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.panelWindowsUpdateOptions.Controls.Add(this.checkBoxWinUpdateEnabled);
			this.panelWindowsUpdateOptions.Controls.Add(this.checkBoxWinUpdateDisabled);
			this.panelWindowsUpdateOptions.Location = new global::System.Drawing.Point(0, 1536);
			this.panelWindowsUpdateOptions.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelWindowsUpdateOptions.Name = "panelWindowsUpdateOptions";
			this.panelWindowsUpdateOptions.Size = new global::System.Drawing.Size(678, 64);
			this.panelWindowsUpdateOptions.TabIndex = 238;
			this.panelWindowsUpdateOptions.Visible = false;
			this.checkBoxWinUpdateEnabled.AutoSize = true;
			this.checkBoxWinUpdateEnabled.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxWinUpdateEnabled.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWinUpdateEnabled.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxWinUpdateEnabled.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxWinUpdateEnabled.Location = new global::System.Drawing.Point(8, 7);
			this.checkBoxWinUpdateEnabled.Name = "checkBoxWinUpdateEnabled";
			this.checkBoxWinUpdateEnabled.Size = new global::System.Drawing.Size(398, 19);
			this.checkBoxWinUpdateEnabled.TabIndex = 62;
			this.checkBoxWinUpdateEnabled.Text = "Enabled (All; all updates are allowed, including recommended updates)";
			this.checkBoxWinUpdateEnabled.UseVisualStyleBackColor = false;
			this.checkBoxWinUpdateEnabled.CheckedChanged += new global::System.EventHandler(this.checkBoxWinUpdateEnabled_CheckedChanged);
			this.checkBoxWinUpdateDisabled.AutoSize = true;
			this.checkBoxWinUpdateDisabled.BackColor = global::System.Drawing.Color.FromArgb(56, 57, 58);
			this.checkBoxWinUpdateDisabled.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWinUpdateDisabled.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxWinUpdateDisabled.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxWinUpdateDisabled.Location = new global::System.Drawing.Point(8, 38);
			this.checkBoxWinUpdateDisabled.Name = "checkBoxWinUpdateDisabled";
			this.checkBoxWinUpdateDisabled.Size = new global::System.Drawing.Size(355, 19);
			this.checkBoxWinUpdateDisabled.TabIndex = 64;
			this.checkBoxWinUpdateDisabled.Text = "Disabled (None; stops updates entirely, may not work on 20H2)";
			this.checkBoxWinUpdateDisabled.UseVisualStyleBackColor = false;
			this.checkBoxWinUpdateDisabled.CheckedChanged += new global::System.EventHandler(this.checkBoxWinUpdateDisabled_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 41, 42);
			base.ClientSize = new global::System.Drawing.Size(695, 565);
			base.ControlBox = false;
			base.Controls.Add(this.panelApplyChanges);
			base.Controls.Add(this.flowPanelMain);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new global::System.Drawing.Size(695, 565);
			this.MinimumSize = new global::System.Drawing.Size(695, 565);
			base.Name = "MainForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.panelApplyChanges.ResumeLayout(false);
			this.panelMemoryManagementOptions.ResumeLayout(false);
			this.panelMemoryManagementOptions.PerformLayout();
			this.panelMemoryManagement.ResumeLayout(false);
			this.panelMemoryManagement.PerformLayout();
			this.panelDataQueueSize.ResumeLayout(false);
			this.panelDataQueueSize.PerformLayout();
			this.panelCleanCacheOptions.ResumeLayout(false);
			this.panelCleanCacheOptions.PerformLayout();
			this.panelCleanCache.ResumeLayout(false);
			this.panelCleanCache.PerformLayout();
			this.flowPanelMain.ResumeLayout(false);
			this.panelDataQueueSizeOptions.ResumeLayout(false);
			this.panelDataQueueSizeOptions.PerformLayout();
			this.panelPlatformTick.ResumeLayout(false);
			this.panelPlatformTick.PerformLayout();
			this.panelPlatformTickOptions.ResumeLayout(false);
			this.panelPlatformTickOptions.PerformLayout();
			this.panelPowerOptions.ResumeLayout(false);
			this.panelPowerOptions.PerformLayout();
			this.panelPowerOptionsOptions.ResumeLayout(false);
			this.panelPowerOptionsOptions.PerformLayout();
			this.panelPrefetchLogging.ResumeLayout(false);
			this.panelPrefetchLogging.PerformLayout();
			this.panelPrefetchLoggingOptions.ResumeLayout(false);
			this.panelPrefetchLoggingOptions.PerformLayout();
			this.panelProcessMitigation.ResumeLayout(false);
			this.panelProcessMitigation.PerformLayout();
			this.panelProcessMitigationOptions.ResumeLayout(false);
			this.panelProcessMitigationOptions.PerformLayout();
			this.panelSystemProfile.ResumeLayout(false);
			this.panelSystemProfile.PerformLayout();
			this.panelSystemProfileOptions.ResumeLayout(false);
			this.panelSystemProfileOptions.PerformLayout();
			this.panelSystemTelemetry.ResumeLayout(false);
			this.panelSystemTelemetry.PerformLayout();
			this.panelSystemTelemetryOptions.ResumeLayout(false);
			this.panelSystemTelemetryOptions.PerformLayout();
			this.panelWin32Priority.ResumeLayout(false);
			this.panelWin32Priority.PerformLayout();
			this.panelWin32PriorityOptions.ResumeLayout(false);
			this.panelWin32PriorityOptions.PerformLayout();
			this.panelWinDefender.ResumeLayout(false);
			this.panelWinDefender.PerformLayout();
			this.panelWinDefenderOptions.ResumeLayout(false);
			this.panelWinDefenderOptions.PerformLayout();
			this.panelWindowsUpdate.ResumeLayout(false);
			this.panelWindowsUpdate.PerformLayout();
			this.panelWindowsUpdateOptions.ResumeLayout(false);
			this.panelWindowsUpdateOptions.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400006C RID: 108
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Button btnApplyChanges;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Panel panelApplyChanges;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Panel panelMemoryManagementOptions;

		// Token: 0x04000070 RID: 112
		public global::System.Windows.Forms.CheckBox checkBoxLargeSystemCache;

		// Token: 0x04000071 RID: 113
		public global::System.Windows.Forms.CheckBox checkBoxSpectreMeltdown;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Panel panelMemoryManagement;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Button btnMemoryManagement;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Panel panelDataQueueSize;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Button btnDataQueueSize;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Panel panelCleanCacheOptions;

		// Token: 0x0400007D RID: 125
		public global::System.Windows.Forms.CheckBox checkBoxTempPrefetch;

		// Token: 0x0400007E RID: 126
		public global::System.Windows.Forms.CheckBox checkBoxClearDisableEventLogs;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Panel panelCleanCache;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Button btnClearCache;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.FlowLayoutPanel flowPanelMain;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Panel panelDataQueueSizeOptions;

		// Token: 0x04000086 RID: 134
		public global::System.Windows.Forms.CheckBox checkBoxMouseDataQueueSize;

		// Token: 0x04000087 RID: 135
		public global::System.Windows.Forms.CheckBox checkBoxKeyboardDataQueueSize;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Panel panelPowerOptions;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Button btnPowerOptions;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Panel panelPowerOptionsOptions;

		// Token: 0x0400008E RID: 142
		public global::System.Windows.Forms.CheckBox checkBoxPowerThrottling;

		// Token: 0x0400008F RID: 143
		public global::System.Windows.Forms.CheckBox checkBoxHibernation;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Panel panelPlatformTick;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Button btnPlatformTick;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Panel panelPlatformTickOptions;

		// Token: 0x04000096 RID: 150
		public global::System.Windows.Forms.CheckBox checkBoxPlatformTick;

		// Token: 0x04000097 RID: 151
		public global::System.Windows.Forms.CheckBox checkBoxResetOtherBCDEdit;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Panel panelPrefetchLogging;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Button btnPrefetchLogging;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Panel panelPrefetchLoggingOptions;

		// Token: 0x0400009E RID: 158
		public global::System.Windows.Forms.CheckBox checkBoxPrefetchSuperfetch;

		// Token: 0x0400009F RID: 159
		public global::System.Windows.Forms.CheckBox checkBoxBootTracing;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Panel panelProcessMitigation;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Label label28;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Label label29;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label label30;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Button btnProcessMitigation;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Panel panelProcessMitigationOptions;

		// Token: 0x040000A6 RID: 166
		public global::System.Windows.Forms.CheckBox checkBoxProcessMitigationEnabled;

		// Token: 0x040000A7 RID: 167
		public global::System.Windows.Forms.CheckBox checkBoxProcessMitigationDisabled;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Panel panelSystemProfile;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Button btnSystemProfile;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Panel panelSystemProfileOptions;

		// Token: 0x040000AE RID: 174
		public global::System.Windows.Forms.CheckBox checkBoxDisableMMCSS;

		// Token: 0x040000AF RID: 175
		public global::System.Windows.Forms.CheckBox checkBoxSystemResponsiveness;

		// Token: 0x040000B0 RID: 176
		public global::System.Windows.Forms.CheckBox checkBoxNetworkThrottlingIndex;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Panel panelSystemTelemetry;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Button btnSystemTelemetry;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Panel panelSystemTelemetryOptions;

		// Token: 0x040000B7 RID: 183
		public global::System.Windows.Forms.CheckBox checkBoxSystemTelemetry;

		// Token: 0x040000B8 RID: 184
		public global::System.Windows.Forms.CheckBox checkBoxAppTelemetry;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Panel panelWin32Priority;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Button btnWin32Priority;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Panel panelWin32PriorityOptions;

		// Token: 0x040000BF RID: 191
		public global::System.Windows.Forms.CheckBox checkBoxWin3f91;

		// Token: 0x040000C0 RID: 192
		public global::System.Windows.Forms.CheckBox checkBoxWin2;

		// Token: 0x040000C1 RID: 193
		public global::System.Windows.Forms.CheckBox checkBoxWin26;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Panel panelWinDefender;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label label22;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Label label23;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Label label24;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Button btnWinDefender;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Panel panelWinDefenderOptions;

		// Token: 0x040000C8 RID: 200
		public global::System.Windows.Forms.CheckBox checkBoxWinDefenderExclusions;

		// Token: 0x040000C9 RID: 201
		public global::System.Windows.Forms.CheckBox checkBoxDisableWinDefender;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Panel panelWindowsUpdate;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label38;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Label label39;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Button btnWindowsUpdate;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Panel panelWindowsUpdateOptions;

		// Token: 0x040000D0 RID: 208
		public global::System.Windows.Forms.CheckBox checkBoxWinUpdateEnabled;

		// Token: 0x040000D1 RID: 209
		public global::System.Windows.Forms.CheckBox checkBoxWinUpdateDisabled;
	}
}
