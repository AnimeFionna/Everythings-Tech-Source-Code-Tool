using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EtOptimizationProgram
{
	// Token: 0x0200000C RID: 12
	public partial class MainForm : Form
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002408 File Offset: 0x00000608
		public MainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000025DC File Offset: 0x000007DC
		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(0, 180, 255), Color.FromArgb(0, 30, 70), 90f))
			{
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B474 File Offset: 0x00009674
		private void btnClearCache_Click(object sender, EventArgs e)
		{
			if (this.panelCleanCacheOptions.Visible)
			{
				this.btnClearCache.Text = ">";
				this.panelCleanCacheOptions.Visible = false;
				return;
			}
			this.btnClearCache.Text = "v";
			this.panelCleanCacheOptions.Visible = true;
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000B5FC File Offset: 0x000097FC
		private void btnDataQueueSize_Click(object sender, EventArgs e)
		{
			if (this.panelDataQueueSizeOptions.Visible)
			{
				this.btnDataQueueSize.Text = ">";
				this.panelDataQueueSizeOptions.Visible = false;
				return;
			}
			this.btnDataQueueSize.Text = "v";
			this.panelDataQueueSizeOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000B784 File Offset: 0x00009984
		private void btnMemoryManagement_Click(object sender, EventArgs e)
		{
			if (this.panelMemoryManagementOptions.Visible)
			{
				this.btnMemoryManagement.Text = ">";
				this.panelMemoryManagementOptions.Visible = false;
				return;
			}
			this.btnMemoryManagement.Text = "v";
			this.panelMemoryManagementOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B90C File Offset: 0x00009B0C
		private void btnPlatformTick_Click(object sender, EventArgs e)
		{
			if (this.panelPlatformTickOptions.Visible)
			{
				this.btnPlatformTick.Text = ">";
				this.panelPlatformTickOptions.Visible = false;
				return;
			}
			this.btnPlatformTick.Text = "v";
			this.panelPlatformTickOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000BA94 File Offset: 0x00009C94
		private void btnPowerOptions_Click(object sender, EventArgs e)
		{
			if (this.panelPowerOptionsOptions.Visible)
			{
				this.btnPowerOptions.Text = ">";
				this.panelPowerOptionsOptions.Visible = false;
				return;
			}
			this.btnPowerOptions.Text = "v";
			this.panelPowerOptionsOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000BC1C File Offset: 0x00009E1C
		private void btnPrefetchLogging_Click(object sender, EventArgs e)
		{
			if (this.panelPrefetchLoggingOptions.Visible)
			{
				this.btnPrefetchLogging.Text = ">";
				this.panelPrefetchLoggingOptions.Visible = false;
				return;
			}
			this.btnPrefetchLogging.Text = "v";
			this.panelPrefetchLoggingOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		private void btnProcessMitigation_Click(object sender, EventArgs e)
		{
			if (this.panelProcessMitigationOptions.Visible)
			{
				this.btnProcessMitigation.Text = ">";
				this.panelProcessMitigationOptions.Visible = false;
				return;
			}
			this.btnProcessMitigation.Text = "v";
			this.panelProcessMitigationOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000BF2C File Offset: 0x0000A12C
		private void btnSystemProfile_Click(object sender, EventArgs e)
		{
			if (this.panelSystemProfileOptions.Visible)
			{
				this.btnSystemProfile.Text = ">";
				this.panelSystemProfileOptions.Visible = false;
				return;
			}
			this.btnSystemProfile.Text = "v";
			this.panelSystemProfileOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		private void btnSystemTelemetry_Click(object sender, EventArgs e)
		{
			if (this.panelSystemTelemetryOptions.Visible)
			{
				this.btnSystemTelemetry.Text = ">";
				this.panelSystemTelemetryOptions.Visible = false;
				return;
			}
			this.btnSystemTelemetry.Text = "v";
			this.panelSystemTelemetryOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C23C File Offset: 0x0000A43C
		private void btnWin32Priority_Click(object sender, EventArgs e)
		{
			if (this.panelWin32PriorityOptions.Visible)
			{
				this.btnWin32Priority.Text = ">";
				this.panelWin32PriorityOptions.Visible = false;
				return;
			}
			this.btnWin32Priority.Text = "v";
			this.panelWin32PriorityOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
		private void btnWinDefender_Click(object sender, EventArgs e)
		{
			if (this.panelWinDefenderOptions.Visible)
			{
				this.btnWinDefender.Text = ">";
				this.panelWinDefenderOptions.Visible = false;
				return;
			}
			this.btnWinDefender.Text = "v";
			this.panelWinDefenderOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWindowsUpdateOptions.Visible = false;
			this.btnWindowsUpdate.Text = ">";
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000C54C File Offset: 0x0000A74C
		private void btnWindowsUpdate_Click(object sender, EventArgs e)
		{
			if (this.panelWindowsUpdateOptions.Visible)
			{
				this.btnWindowsUpdate.Text = ">";
				this.panelWindowsUpdateOptions.Visible = false;
				return;
			}
			this.btnWindowsUpdate.Text = "v";
			this.panelWindowsUpdateOptions.Visible = true;
			this.panelCleanCacheOptions.Visible = false;
			this.btnClearCache.Text = ">";
			this.panelDataQueueSizeOptions.Visible = false;
			this.btnDataQueueSize.Text = ">";
			this.panelMemoryManagementOptions.Visible = false;
			this.btnMemoryManagement.Text = ">";
			this.panelPlatformTickOptions.Visible = false;
			this.btnPlatformTick.Text = ">";
			this.panelPowerOptionsOptions.Visible = false;
			this.btnPowerOptions.Text = ">";
			this.panelPrefetchLoggingOptions.Visible = false;
			this.btnPrefetchLogging.Text = ">";
			this.panelProcessMitigationOptions.Visible = false;
			this.btnProcessMitigation.Text = ">";
			this.panelSystemProfileOptions.Visible = false;
			this.btnSystemProfile.Text = ">";
			this.panelSystemTelemetryOptions.Visible = false;
			this.btnSystemTelemetry.Text = ">";
			this.panelWin32PriorityOptions.Visible = false;
			this.btnWin32Priority.Text = ">";
			this.panelWinDefenderOptions.Visible = false;
			this.btnWinDefender.Text = ">";
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002416 File Offset: 0x00000616
		private void checkBoxPlatformTick_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxPlatformTick.Checked && this.checkBoxResetOtherBCDEdit.Checked)
			{
				this.checkBoxResetOtherBCDEdit.Checked = false;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000243E File Offset: 0x0000063E
		private void checkBoxResetOtherBCDEdit_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxResetOtherBCDEdit.Checked && this.checkBoxPlatformTick.Checked)
			{
				this.checkBoxPlatformTick.Checked = false;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		private void checkBoxWin2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxWin2.Checked && this.checkBoxWin26.Checked)
			{
				this.checkBoxWin26.Checked = false;
			}
			if (this.checkBoxWin2.Checked && this.checkBoxWin3f91.Checked)
			{
				this.checkBoxWin3f91.Checked = false;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000C730 File Offset: 0x0000A930
		private void checkBoxWin26_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxWin26.Checked && this.checkBoxWin2.Checked)
			{
				this.checkBoxWin2.Checked = false;
			}
			if (this.checkBoxWin26.Checked && this.checkBoxWin3f91.Checked)
			{
				this.checkBoxWin3f91.Checked = false;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000C78C File Offset: 0x0000A98C
		private void checkBoxWin3f91_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxWin3f91.Checked && this.checkBoxWin26.Checked)
			{
				this.checkBoxWin26.Checked = false;
			}
			if (this.checkBoxWin3f91.Checked && this.checkBoxWin2.Checked)
			{
				this.checkBoxWin2.Checked = false;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002466 File Offset: 0x00000666
		private void checkBoxProcessMitigationEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxProcessMitigationEnabled.Checked && this.checkBoxProcessMitigationDisabled.Checked)
			{
				this.checkBoxProcessMitigationDisabled.Checked = false;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000248E File Offset: 0x0000068E
		private void checkBoxProcessMitigationDisabled_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxProcessMitigationDisabled.Checked && this.checkBoxProcessMitigationEnabled.Checked)
			{
				this.checkBoxProcessMitigationEnabled.Checked = false;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000024B6 File Offset: 0x000006B6
		private void checkBoxWinDefenderExclusions_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxWinDefenderExclusions.Checked && this.checkBoxDisableWinDefender.Checked)
			{
				this.checkBoxDisableWinDefender.Checked = false;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000024DE File Offset: 0x000006DE
		private void checkBoxDisableWinDefender_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxDisableWinDefender.Checked && this.checkBoxWinDefenderExclusions.Checked)
			{
				this.checkBoxWinDefenderExclusions.Checked = false;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002506 File Offset: 0x00000706
		private void checkBoxWinUpdateEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxWinUpdateEnabled.Checked && this.checkBoxWinUpdateDisabled.Checked)
			{
				this.checkBoxWinUpdateDisabled.Checked = false;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000252E File Offset: 0x0000072E
		private void checkBoxWinUpdateDisabled_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxWinUpdateDisabled.Checked && this.checkBoxWinUpdateEnabled.Checked)
			{
				this.checkBoxWinUpdateEnabled.Checked = false;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		private void btnApplyChanges_Click(object sender, EventArgs e)
		{
			try
			{
				if (XmlFile.xmlRead("DisplayWarning") == "True")
				{
					this.warningMessage = true;
				}
				else
				{
					this.warningMessage = false;
					this.taskGranted = true;
				}
				if (this.warningMessage)
				{
					if (MessageBox.Show("Are you sure you want to continue?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						this.taskGranted = true;
					}
					else
					{
						this.taskGranted = false;
						MessageBox.Show("Optimizations not applied.", "", "ET Optimization Program", MessageBoxButtons.OK);
					}
				}
				if (this.taskGranted)
				{
					if (!this.checkBoxWin2.Checked && !this.checkBoxWin26.Checked && !this.checkBoxWin3f91.Checked && !this.checkBoxLargeSystemCache.Checked && !this.checkBoxSpectreMeltdown.Checked && !this.checkBoxPrefetchSuperfetch.Checked && !this.checkBoxBootTracing.Checked && !this.checkBoxPowerThrottling.Checked && !this.checkBoxHibernation.Checked && !this.checkBoxSystemResponsiveness.Checked && !this.checkBoxNetworkThrottlingIndex.Checked && !this.checkBoxDisableMMCSS.Checked && !this.checkBoxSystemTelemetry.Checked && !this.checkBoxAppTelemetry.Checked && !this.checkBoxPlatformTick.Checked && !this.checkBoxResetOtherBCDEdit.Checked && !this.checkBoxWinDefenderExclusions.Checked && !this.checkBoxDisableWinDefender.Checked && !this.checkBoxMouseDataQueueSize.Checked && !this.checkBoxKeyboardDataQueueSize.Checked && !this.checkBoxProcessMitigationEnabled.Checked && !this.checkBoxProcessMitigationDisabled.Checked && !this.checkBoxTempPrefetch.Checked && !this.checkBoxClearDisableEventLogs.Checked && !this.checkBoxWinUpdateEnabled.Checked && !this.checkBoxWinUpdateDisabled.Checked)
					{
						MessageBox.Show("Please select a option.", "", "ET Optimization Program", MessageBoxButtons.OK);
					}
					if (this.checkBoxWin2.Checked)
					{
						RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey.SetValue("Win32PrioritySeparation", "2", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check1Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxWin26.Checked)
					{
						RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey2.SetValue("Win32PrioritySeparation", "38", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check2Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxWin3f91.Checked)
					{
						RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey3.SetValue("Win32PrioritySeparation", -49263, RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check21Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxLargeSystemCache.Checked)
					{
						RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
						using (registryKey4)
						{
							registryKey4.SetValue("DisablePagingExecutive", "1", RegistryValueKind.DWord);
							registryKey4.SetValue("LargeSystemCache", "1", RegistryValueKind.DWord);
						}
						XmlFile.xmlWrite("Check3Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxSpectreMeltdown.Checked)
					{
						RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
						using (registryKey6)
						{
							registryKey6.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
							registryKey6.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
							registryKey6.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
						}
						XmlFile.xmlWrite("Check4Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxPrefetchSuperfetch.Checked)
					{
						RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
						using (registryKey8)
						{
							registryKey8.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
							registryKey8.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
						}
						XmlFile.xmlWrite("Check5Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxBootTracing.Checked)
					{
						RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
						registryKey10.SetValue("EnableBoottrace", "0", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check6Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxPowerThrottling.Checked)
					{
						RegistryKey registryKey11 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling");
						registryKey11.SetValue("PowerThrottlingOff", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check7Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxHibernation.Checked)
					{
						RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power");
						registryKey12.SetValue("HibernateEnabled", "0", RegistryValueKind.DWord);
						RegistryKey registryKey13 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power");
						registryKey13.SetValue("HiberbootEnabled", "0", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check8Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxSystemResponsiveness.Checked)
					{
						RegistryKey registryKey14 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
						registryKey14.SetValue("SystemResponsiveness", "32", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check9Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxNetworkThrottlingIndex.Checked)
					{
						RegistryKey registryKey15 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
						registryKey15.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check10Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxDisableMMCSS.Checked)
					{
						RegistryKey registryKey16 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MMCSS");
						registryKey16.SetValue("Start", "4", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check22Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxSystemTelemetry.Checked)
					{
						RegistryKey registryKey17 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching");
						registryKey17.SetValue("SearchOrderConfig", "0", RegistryValueKind.DWord);
						RegistryKey registryKey18 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
						registryKey18.SetValue("AllowTelemetry", "0", RegistryValueKind.DWord);
						RegistryKey registryKey19 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Software\\Policies\\Microsoft\\Windows\\Device Metadata");
						registryKey19.SetValue("PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
						RegistryKey registryKey20 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
						registryKey20.SetValue("MaintenanceDisabled", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check11Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxAppTelemetry.Checked)
					{
						RegistryKey registryKey21 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat");
						registryKey21.SetValue("AITEnable", "0", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check12Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxPlatformTick.Checked)
					{
						Process process = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						using (process)
						{
							process.StartInfo.CreateNoWindow = true;
							process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process.StartInfo.Arguments = " /set useplatformtick true";
							process.StartInfo.Arguments = " /set disabledynamictick yes";
							process.Start();
						}
						XmlFile.xmlWrite("Check13Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxResetOtherBCDEdit.Checked)
					{
						Process process3 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						using (process3)
						{
							process3.StartInfo.CreateNoWindow = true;
							process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process3.StartInfo.Arguments = " /deletevalue linearaddress57";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue increaseuserva";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue firstmegabytepolicy";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue avoidlowmemory";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue nolowmem";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue allowedinmemorysettings";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue x2apicpolicy";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue configaccesspolicy";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue MSI Default";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue usephysicaldestination";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue usefirmwarepcisettings";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue useplatformclock";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue useplatformtick";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue disabledynamictick";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue vsmlaunchtype";
							process3.Start();
							process3.StartInfo.Arguments = " /deletevalue vm";
							process3.Start();
						}
						XmlFile.xmlWrite("Check13Checked", "False");
						this.optComplete = true;
					}
					if (this.checkBoxWinDefenderExclusions.Checked)
					{
						Process process5 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						using (process5)
						{
							process5.StartInfo.CreateNoWindow = true;
							process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process5.StartInfo.Arguments = "Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb *.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb.chk'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Tmp.edb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\*.log'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.sdb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.log'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.chk'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.xml'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.csv'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.cmtx'; Add-MpPreference -ExclusionPath $env:windir'\\apppatch\\sysmain.sdb'; Add-MpPreference -ExclusionPath $env:windir'\\EventLog\\Data\\lastalive?.dat'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.pol'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.tmp'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.log'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.dat'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.chk'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\MetaConfig.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\winevt\\Logs\\*.evtx'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCStatusHistory.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCEngineCache.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCResourceStateCache.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\ConfigurationStatus'; Add-MpPreference -ExclusionPath $env:userprofile'\\AppData\\Local\\ETOptProgram\\ETOptProgram.xml'";
							process5.Start();
						}
						XmlFile.xmlWrite("Check14Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxDisableWinDefender.Checked)
					{
						RegistryKey registryKey22 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
						RegistryKey registryKey23 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
						using (registryKey22)
						{
							registryKey22.SetValue("DisableAntiSpyware", "1", RegistryValueKind.DWord);
							registryKey22.SetValue("DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
							registryKey22.SetValue("ServiceKeepAlive", "0", RegistryValueKind.DWord);
						}
						using (registryKey23)
						{
							registryKey23.SetValue("DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
							registryKey23.SetValue("DisableIOAVProtection", "1", RegistryValueKind.DWord);
							registryKey23.SetValue("DisableOnAccessProtection", "1", RegistryValueKind.DWord);
							registryKey23.SetValue("DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
						}
						RegistryKey registryKey26 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Reporting");
						registryKey26.SetValue("DisableEnhancedNotifications", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check15Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxMouseDataQueueSize.Checked)
					{
						RegistryKey registryKey27 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters");
						registryKey27.SetValue("MouseDataQueueSize", "20", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check16Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxKeyboardDataQueueSize.Checked)
					{
						RegistryKey registryKey28 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters");
						registryKey28.SetValue("KeyboardDataQueueSize", "50", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check17Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxProcessMitigationEnabled.Checked)
					{
						Process process7 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						Process process8 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						RegistryKey registryKey29 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\FTH");
						using (process7)
						{
							process7.StartInfo.CreateNoWindow = true;
							process7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process7.StartInfo.Arguments = " /deletevalue nx";
							process7.Start();
						}
						using (process8)
						{
							process8.StartInfo.CreateNoWindow = true;
							process8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process8.StartInfo.Arguments = "Set-ProcessMitigation -System -Enable DEP, SEHOP, AuditSEHOP, SEHOPTelemetry, CFG";
							process8.Start();
						}
						registryKey29.SetValue("Enabled", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check18Checked", "False");
						this.optComplete = true;
					}
					if (this.checkBoxProcessMitigationDisabled.Checked)
					{
						Process process11 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						Process process12 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						RegistryKey registryKey30 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\FTH");
						using (process11)
						{
							process11.StartInfo.CreateNoWindow = true;
							process11.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process11.StartInfo.Arguments = " /set {current} nx AlwaysOff";
							process11.Start();
						}
						using (process12)
						{
							process12.StartInfo.CreateNoWindow = true;
							process12.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process12.StartInfo.Arguments = "Set-ProcessMitigation -System -Disable DEP, SEHOP, AuditSEHOP, SEHOPTelemetry, CFG; Remove-Item -Path \"HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\*\" -Recurse -ErrorAction SilentlyContinue";
							process12.Start();
						}
						registryKey30.SetValue("Enabled", "0", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check18Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxTempPrefetch.Checked)
					{
						Process process15 = new Process
						{
							StartInfo = 
							{
								FileName = "cmd"
							}
						};
						using (process15)
						{
							process15.StartInfo.CreateNoWindow = true;
							process15.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process15.StartInfo.Arguments = "/c del /s /q C:\\Windows\\temp";
							process15.Start();
							process15.StartInfo.Arguments = "/c del /s /q C:\\Users\\%username%\\AppData\\Local\\Temp";
							process15.Start();
							process15.StartInfo.Arguments = "/c del /s /q C:\\Windows\\Prefetch";
							process15.Start();
						}
						this.optComplete = true;
					}
					if (this.checkBoxClearDisableEventLogs.Checked)
					{
						Process process17 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						using (process17)
						{
							process17.StartInfo.CreateNoWindow = true;
							process17.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process17.StartInfo.Arguments = "Get-EventLog -LogName * | ForEach { Clear - EventLog $_.Log }; Set-Service EventLog -StartupType Disabled; Set-Service Wecsvc -StartupType Disabled";
							process17.Start();
						}
						RegistryKey registryKey31 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\NlaSvc");
						registryKey31.SetValue("DependOnService", new string[]
						{
							"NSI",
							"RpcSs",
							"TcpIp",
							"Dhcp"
						}, RegistryValueKind.MultiString);
						XmlFile.xmlWrite("Check19Checked", "True");
						this.optComplete = true;
					}
					if (this.checkBoxWinUpdateEnabled.Checked)
					{
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate", false);
						XmlFile.xmlWrite("Check20Checked", "False");
						this.optComplete = true;
					}
					if (this.checkBoxWinUpdateDisabled.Checked)
					{
						RegistryKey registryKey32 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate");
						Process process19 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						using (registryKey32)
						{
							registryKey32.SetValue("UpdateServiceUrlAlternate", "http://stopwindowsfromscrewingwithourchanges.com/", RegistryValueKind.String);
							registryKey32.SetValue("WUServer", "http://stopwindows.com/", RegistryValueKind.String);
							registryKey32.SetValue("WUStatusServer", "http://stopwindows.com/", RegistryValueKind.String);
							registryKey32.SetValue("UseWUServer", "1", RegistryValueKind.DWord);
							registryKey32.SetValue("DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
						}
						using (process19)
						{
							process19.StartInfo.CreateNoWindow = true;
							process19.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process19.StartInfo.Arguments = "Set-Service CryptSvc -StartupType Disabled; Set-Service UsoSvc -StartupType Disabled; Set-Service wuauserv -StartupType Disabled; Set-Service WaaSMedicSvc -StartupType Disabled";
							process19.Start();
						}
						XmlFile.xmlWrite("Check20Checked", "True");
						this.optComplete = true;
					}
					if (this.optComplete)
					{
						MessageBox.Show("Option(s) successfully applied!", "", "ET Optimization Program", MessageBoxButtons.OK);
						this.optComplete = false;
						this.taskGranted = false;
					}
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1010);
				MessageBox.Show("Options not applied.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
		}

		// Token: 0x04000069 RID: 105
		private bool optComplete;

		// Token: 0x0400006A RID: 106
		private bool taskGranted;

		// Token: 0x0400006B RID: 107
		private bool warningMessage;
	}
}
