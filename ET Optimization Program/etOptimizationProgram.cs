using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Win32;

namespace EtOptimizationProgram
{
	// Token: 0x02000006 RID: 6
	public partial class etOptimizationProgram : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002116 File Offset: 0x00000316
		public etOptimizationProgram()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27
		[DllImport("user32.dll", SetLastError = true)]
		private static extern void ReleaseCapture();

		// Token: 0x0600001C RID: 28
		[DllImport("user32.dll", SetLastError = true)]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x0600001D RID: 29
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

		// Token: 0x0600001E RID: 30
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x0600001F RID: 31 RVA: 0x0000212B File Offset: 0x0000032B
		private void etOptimizationProgram_MouseDown(object sender, MouseEventArgs e)
		{
			etOptimizationProgram.ReleaseCapture();
			etOptimizationProgram.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000212B File Offset: 0x0000032B
		private void panelMaxMinClose_MouseDown(object sender, MouseEventArgs e)
		{
			etOptimizationProgram.ReleaseCapture();
			etOptimizationProgram.SendMessage(base.Handle, 274, 61458, 0);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004BF8 File Offset: 0x00002DF8
		private void etOptimizationProgram_Load(object sender, EventArgs e)
		{
			XmlFile.xmlCreate();
			try
			{
				if (Process.GetProcessesByName(AppDomain.CurrentDomain.FriendlyName).Count<Process>() > 1)
				{
					MessageBox.Show("Only one process running is allowed.", "", "ET Optimization Program", MessageBoxButtons.OK);
					Environment.Exit(0);
				}
				if (XmlFile.xmlRead("CheckForUpdates") == "True")
				{
					int num = 0;
					try
					{
						num = 1;
						string text = Environment.CurrentDirectory + "\\ET Optimization Program.zip";
						XDocument xdocument = XDocument.Load("https://everythingtechtutorials.com/ETUpdate/ETOptUpdate.xml");
						WebClient webClient = new WebClient();
						ServicePointManager.Expect100Continue = true;
						ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
						if (xdocument.Root.Element("ProgramVersion").Value != "1.1.0")
						{
							if (MessageBox.Show("Update is available!", "Would you like to download it?", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
							{
								num = 2;
								string value = xdocument.Root.Element("ProgramDownload").Value;
								webClient.DownloadFile(value, text);
							}
							if (File.Exists(text))
							{
								MessageBox.Show("Update successfully downloaded!", "", "ET Optimization Program", MessageBoxButtons.OK);
							}
						}
					}
					catch (WebException error)
					{
						if (num == 1)
						{
							ApplicationCrash.ExLogging.ETOptLog(error, 1021);
							MessageBox.Show("Update check failed.", "Program will continue as usual.", "ET Optimization Program", MessageBoxButtons.OK);
						}
						if (num == 2)
						{
							ApplicationCrash.ExLogging.ETOptLog(error, 1011);
							MessageBox.Show("Download failed.", "Program will continue as usual.", "ET Optimization Program", MessageBoxButtons.OK);
						}
					}
					catch (Exception error2)
					{
						ApplicationCrash.ExLogging.ETOptLog(error2, 1022);
						MessageBox.Show("Network connection unavailable.", "Program will continue as usual.", "ET Optimization Program", MessageBoxButtons.OK);
					}
				}
				if (Environment.OSVersion.Version.Major >= 10)
				{
					MessageBox.Show("Windows version is out-of-date.", "Program may not function as intended.", "ET Optimization Program", MessageBoxButtons.OK);
				}
				try
				{
					if (XmlFile.xmlRead("FirstTime") == "True" && XmlFile.xmlRead("DisclaimerAccepted") == "False")
					{
						disclaimerMessageBox disclaimerMessageBox = new disclaimerMessageBox();
						disclaimerMessageBox.ShowDialog();
					}
				}
				catch (Exception error3)
				{
					ApplicationCrash.ExLogging.ETOptLog(error3, 1004);
					MessageBox.Show("Xml file reading failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
					Environment.Exit(0);
				}
				Process[] processesByName = Process.GetProcessesByName(AppDomain.CurrentDomain.FriendlyName);
				foreach (Process process in processesByName)
				{
					IntPtr mainWindowHandle = process.MainWindowHandle;
					Control.FromHandle(mainWindowHandle);
					if (mainWindowHandle != IntPtr.Zero)
					{
						etOptimizationProgram.SetWindowPos(mainWindowHandle, 0, 0, 0, 0, 0, 69);
					}
				}
				this.hideSubMenu();
				this.hideMainPanel();
			}
			catch (Exception error4)
			{
				ApplicationCrash.ExLogging.ETOptLog(error4, 1000);
				MessageBox.Show("Program start-up error.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002148 File Offset: 0x00000348
		private void hideSubMenu()
		{
			this.panelOptimizeSubMenu.Visible = false;
			this.panelCleanSubMenu.Visible = false;
			this.panelEmpty.Visible = false;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000216E File Offset: 0x0000036E
		private void showSubMenu(Panel subMenu)
		{
			if (!subMenu.Visible)
			{
				this.hideSubMenu();
				subMenu.Visible = true;
				return;
			}
			subMenu.Visible = false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000218D File Offset: 0x0000038D
		private void hideMainPanel()
		{
			this.panelMainForm.Visible = false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000219B File Offset: 0x0000039B
		private void showMainPanel(Panel Main)
		{
			if (!Main.Visible)
			{
				this.hideMainPanel();
				Main.Visible = true;
				return;
			}
			Main.Visible = false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021BA File Offset: 0x000003BA
		private void btnRegistry_Click(object sender, EventArgs e)
		{
			this.showSubMenu(this.panelOptimizeSubMenu);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004F14 File Offset: 0x00003114
		private void btnLowLatency_Click(object sender, EventArgs e)
		{
			this.hideSubMenu();
			try
			{
				if (XmlFile.xmlRead("DisplayWarning") == "False")
				{
					this.warningMessage = false;
					this.taskGranted = true;
				}
				if (XmlFile.xmlRead("DisplayWarning") == "True")
				{
					this.warningMessage = true;
				}
				if (this.warningMessage)
				{
					if (MessageBox.Show("Are you sure you want to continue?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						this.taskGranted = true;
					}
					else
					{
						MessageBox.Show("Optimizations not applied.", "", "ET Optimization Program", MessageBoxButtons.OK);
					}
				}
				if (this.taskGranted)
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
					registryKey.SetValue("Win32PrioritySeparation", "38", RegistryValueKind.DWord);
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\");
					RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
					RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
					Process process = new Process
					{
						StartInfo = 
						{
							FileName = "powershell"
						}
					};
					Process process2 = new Process
					{
						StartInfo = 
						{
							FileName = "bcdedit"
						}
					};
					using (registryKey2)
					{
						registryKey2.SetValue("DisablePagingExecutive", "1", RegistryValueKind.DWord);
						registryKey2.SetValue("LargeSystemCache", "1", RegistryValueKind.DWord);
						registryKey2.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
						registryKey2.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
						registryKey2.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
					}
					using (registryKey3)
					{
						registryKey3.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
						registryKey3.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
						registryKey3.SetValue("EnableBoottrace", "0", RegistryValueKind.DWord);
					}
					using (registryKey4)
					{
						registryKey4.SetValue("SystemResponsiveness", "32", RegistryValueKind.DWord);
						registryKey4.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
					}
					RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling");
					registryKey8.SetValue("PowerThrottlingOff", "1", RegistryValueKind.DWord);
					RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power");
					registryKey9.SetValue("HibernateEnabled", "0", RegistryValueKind.DWord);
					RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power");
					registryKey10.SetValue("HiberbootEnabled", "0", RegistryValueKind.DWord);
					RegistryKey registryKey11 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching");
					registryKey11.SetValue("SearchOrderConfig", "3", RegistryValueKind.DWord);
					RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Software\\Policies\\Microsoft\\Windows\\Device Metadata");
					registryKey12.SetValue("PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
					RegistryKey registryKey13 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
					registryKey13.SetValue("MaintenanceDisabled", "1", RegistryValueKind.DWord);
					RegistryKey registryKey14 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
					registryKey14.SetValue("AllowTelemetry", "0", RegistryValueKind.DWord);
					RegistryKey registryKey15 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat");
					registryKey15.SetValue("AITEnable", "0", RegistryValueKind.DWord);
					using (process)
					{
						process.StartInfo.CreateNoWindow = true;
						process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process.StartInfo.Arguments = "Get-EventLog -LogName * | ForEach { Clear-EventLog $_.Log }; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb *.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb.chk'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Tmp.edb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\*.log'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.sdb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.log'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.chk'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.xml'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.csv'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.cmtx'; Add-MpPreference -ExclusionPath $env:windir'\\apppatch\\sysmain.sdb'; Add-MpPreference -ExclusionPath $env:windir'\\EventLog\\Data\\lastalive?.dat'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.pol'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.tmp'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.log'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.dat'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.chk'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\MetaConfig.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\winevt\\Logs\\*.evtx'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCStatusHistory.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCEngineCache.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCResourceStateCache.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\ConfigurationStatus'; Add-MpPreference -ExclusionPath $env:userprofile'\\AppData\\Local\\ETOptProgram\\ETOptProgram.xml'";
						process.Start();
					}
					using (process2)
					{
						process2.StartInfo.CreateNoWindow = true;
						process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process2.StartInfo.Arguments = " /set useplatformtick true";
						process2.Start();
						process2.StartInfo.Arguments = " /set disabledynamictick yes";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue linearaddress57";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue increaseuserva";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue firstmegabytepolicy";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue avoidlowmemory";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue nolowmem";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue allowedinmemorysettings";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue x2apicpolicy";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue configaccesspolicy";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue MSI Default";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue usephysicaldestination";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue usefirmwarepcisettings";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue useplatformclock";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue vsmlaunchtype";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue vm";
						process2.Start();
					}
				}
				XmlFile.xmlWrite("LowLatencyChecked", "True");
				this.taskGranted = false;
				MessageBox.Show("Optimizations successfully applied!", "", "ET Optimization Program", MessageBoxButtons.OK);
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1010);
				MessageBox.Show("Low Latency not applied.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005518 File Offset: 0x00003718
		private void btnHighPerformance_Click(object sender, EventArgs e)
		{
			this.hideSubMenu();
			try
			{
				if (XmlFile.xmlRead("DisplayWarning") == "False")
				{
					this.warningMessage = false;
					this.taskGranted = true;
				}
				if (XmlFile.xmlRead("DisplayWarning") == "True")
				{
					this.warningMessage = true;
				}
				if (this.warningMessage)
				{
					if (MessageBox.Show("Are you sure you want to continue?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						this.taskGranted = true;
					}
					else
					{
						MessageBox.Show("Optimizations not applied.", "", "ET Optimization Program", MessageBoxButtons.OK);
					}
				}
				if (this.taskGranted)
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
					registryKey.SetValue("Win32PrioritySeparation", -49263, RegistryValueKind.DWord);
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\");
					RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
					RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
					Process process = new Process
					{
						StartInfo = 
						{
							FileName = "powershell"
						}
					};
					Process process2 = new Process
					{
						StartInfo = 
						{
							FileName = "bcdedit"
						}
					};
					using (registryKey2)
					{
						registryKey2.SetValue("DisablePagingExecutive", "1", RegistryValueKind.DWord);
						registryKey2.SetValue("LargeSystemCache", "1", RegistryValueKind.DWord);
						registryKey2.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
						registryKey2.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
						registryKey2.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
					}
					using (registryKey3)
					{
						registryKey3.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
						registryKey3.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
						registryKey3.SetValue("EnableBoottrace", "0", RegistryValueKind.DWord);
					}
					using (registryKey4)
					{
						registryKey4.SetValue("SystemResponsiveness", "32", RegistryValueKind.DWord);
						registryKey4.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
					}
					RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling");
					registryKey8.SetValue("PowerThrottlingOff", "1", RegistryValueKind.DWord);
					RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power");
					registryKey9.SetValue("HibernateEnabled", "0", RegistryValueKind.DWord);
					RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power");
					registryKey10.SetValue("HiberbootEnabled", "0", RegistryValueKind.DWord);
					RegistryKey registryKey11 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching");
					registryKey11.SetValue("SearchOrderConfig", "3", RegistryValueKind.DWord);
					RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Software\\Policies\\Microsoft\\Windows\\Device Metadata");
					registryKey12.SetValue("PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
					RegistryKey registryKey13 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
					registryKey13.SetValue("MaintenanceDisabled", "1", RegistryValueKind.DWord);
					RegistryKey registryKey14 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
					registryKey14.SetValue("AllowTelemetry", "0", RegistryValueKind.DWord);
					RegistryKey registryKey15 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat");
					registryKey15.SetValue("AITEnable", "0", RegistryValueKind.DWord);
					using (process)
					{
						process.StartInfo.CreateNoWindow = true;
						process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process.StartInfo.Arguments = "Get-EventLog -LogName * | ForEach { Clear-EventLog $_.Log }; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb *.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb.chk'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Tmp.edb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\*.log'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.sdb'; Add-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.log'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.chk'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.xml'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.csv'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.cmtx'; Add-MpPreference -ExclusionPath $env:windir'\\apppatch\\sysmain.sdb'; Add-MpPreference -ExclusionPath $env:windir'\\EventLog\\Data\\lastalive?.dat'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.pol'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.tmp'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.log'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.dat'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.chk'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\MetaConfig.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\winevt\\Logs\\*.evtx'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCStatusHistory.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCEngineCache.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCResourceStateCache.mof'; Add-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\ConfigurationStatus'; Add-MpPreference -ExclusionPath $env:userprofile'\\AppData\\Local\\ETOptProgram\\ETOptProgram.xml'";
						process.Start();
					}
					using (process2)
					{
						process2.StartInfo.CreateNoWindow = true;
						process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process2.StartInfo.Arguments = " /set useplatformtick true";
						process2.Start();
						process2.StartInfo.Arguments = " /set disabledynamictick yes";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue linearaddress57";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue increaseuserva";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue firstmegabytepolicy";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue avoidlowmemory";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue nolowmem";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue allowedinmemorysettings";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue x2apicpolicy";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue configaccesspolicy";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue MSI Default";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue usephysicaldestination";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue usefirmwarepcisettings";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue useplatformclock";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue vsmlaunchtype";
						process2.Start();
						process2.StartInfo.Arguments = " /deletevalue vm";
						process2.Start();
					}
				}
				XmlFile.xmlWrite("HighPerformanceChecked", "True");
				this.taskGranted = false;
				MessageBox.Show("Optimizations successfully applied!", "", "ET Optimization Program", MessageBoxButtons.OK);
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1010);
				MessageBox.Show("High Performance not applied.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021C8 File Offset: 0x000003C8
		private void btnClean_Click(object sender, EventArgs e)
		{
			this.showSubMenu(this.panelCleanSubMenu);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005B18 File Offset: 0x00003D18
		private void btnCleanTemp_Click(object sender, EventArgs e)
		{
			this.hideSubMenu();
			try
			{
				Process process = new Process
				{
					StartInfo = 
					{
						FileName = "cmd"
					}
				};
				using (process)
				{
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.Arguments = "/c del /s /q C:\\Windows\\temp";
					process.Start();
					process.StartInfo.Arguments = "/c del /s /q C:\\Users\\%username%\\AppData\\Local\\Temp";
					process.Start();
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1011);
				MessageBox.Show("Temp cleaning failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
			MessageBox.Show("Temp files cleaned!", "", "ET Optimization Program", MessageBoxButtons.OK);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005BF0 File Offset: 0x00003DF0
		private void btnCleanPrefetch_Click(object sender, EventArgs e)
		{
			this.hideSubMenu();
			try
			{
				Process process = new Process
				{
					StartInfo = 
					{
						FileName = "cmd"
					}
				};
				using (process)
				{
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.Arguments = "/c del /s /q C:\\Windows\\Prefetch";
					process.Start();
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1011);
				MessageBox.Show("Prefetch cleaning failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
			MessageBox.Show("Prefetch files cleaned!", "", "ET Optimization Program", MessageBoxButtons.OK);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005CB0 File Offset: 0x00003EB0
		private void btnClearEventLogs_Click(object sender, EventArgs e)
		{
			this.hideSubMenu();
			try
			{
				Process process = new Process
				{
					StartInfo = 
					{
						FileName = "powershell"
					}
				};
				using (process)
				{
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.Arguments = "Get-EventLog -LogName * | ForEach { Clear - EventLog $_.Log }";
					process.Start();
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1011);
				MessageBox.Show("Event Log clearing failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
			MessageBox.Show("Event Logs cleared!", "", "ET Optimization Program", MessageBoxButtons.OK);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021D6 File Offset: 0x000003D6
		private void btnManual_Click(object sender, EventArgs e)
		{
			if (!this.panelMainForm.Visible)
			{
				this.openMainMax(new MainForm());
				this.showMainPanel(this.panelMainForm);
				this.hideSubMenu();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005D74 File Offset: 0x00003F74
		private void btnRevert_Click(object sender, EventArgs e)
		{
			try
			{
				if (XmlFile.xmlRead("DisplayWarning") == "False")
				{
					this.warningMessage = false;
					this.taskGranted = true;
				}
				else
				{
					this.warningMessage = true;
				}
				if (this.warningMessage)
				{
					if (MessageBox.Show("Are you sure you want to revert?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						this.taskGranted = true;
					}
					else
					{
						this.taskGranted = false;
						MessageBox.Show("Optimizations were not reverted.", "", "ET Optimization Program", MessageBoxButtons.OK);
					}
				}
				if (this.taskGranted)
				{
					if (XmlFile.xmlRead("LowLatencyChecked") == "False" && XmlFile.xmlRead("HighPerformanceChecked") == "False" && XmlFile.xmlRead("Check1Checked") == "False" && XmlFile.xmlRead("Check2Checked") == "False" && XmlFile.xmlRead("Check3Checked") == "False" && XmlFile.xmlRead("Check4Checked") == "False" && XmlFile.xmlRead("Check5Checked") == "False" && XmlFile.xmlRead("Check6Checked") == "False" && XmlFile.xmlRead("Check7Checked") == "False" && XmlFile.xmlRead("Check8Checked") == "False" && XmlFile.xmlRead("Check9Checked") == "False" && XmlFile.xmlRead("Check10Checked") == "False" && XmlFile.xmlRead("Check11Checked") == "False" && XmlFile.xmlRead("Check12Checked") == "False" && XmlFile.xmlRead("Check13Checked") == "False" && XmlFile.xmlRead("Check14Checked") == "False" && XmlFile.xmlRead("Check15Checked") == "False" && XmlFile.xmlRead("Check16Checked") == "False" && XmlFile.xmlRead("Check17Checked") == "False" && XmlFile.xmlRead("Check18Checked") == "False" && XmlFile.xmlRead("Check19Checked") == "False" && XmlFile.xmlRead("Check20Checked") == "False" && XmlFile.xmlRead("Check21Checked") == "False" && XmlFile.xmlRead("Check22Checked") == "False")
					{
						MessageBox.Show("Please use a tweak :3", "", "ET Optimization Program", MessageBoxButtons.OK);
					}
					if (XmlFile.xmlRead("LowLatencyChecked") == "True")
					{
						RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey.SetValue("Win32PrioritySeparation", "2", RegistryValueKind.DWord);
						RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management");
						RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
						Process process = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						Process process2 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						using (registryKey2)
						{
							registryKey2.SetValue("DisablePagingExecutive", "0", RegistryValueKind.DWord);
							registryKey2.SetValue("LargeSystemCache", "0", RegistryValueKind.DWord);
							registryKey2.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
							registryKey2.SetValue("FeatureSettingsOverride", "0", RegistryValueKind.DWord);
							registryKey2.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
						}
						using (registryKey3)
						{
							registryKey3.SetValue("SystemResponsiveness", "20", RegistryValueKind.DWord);
							registryKey3.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
						}
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", false);
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling", false);
						RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching");
						registryKey6.SetValue("SearchOrderConfig", "1", RegistryValueKind.DWord);
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Software\\Policies\\Microsoft\\Windows\\Device Metadata", false);
						RegistryKey registryKey7 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
						registryKey7.SetValue("MaintenanceDisabled", "0", RegistryValueKind.DWord);
						RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
						registryKey8.SetValue("AllowTelemetry", "1", RegistryValueKind.DWord);
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", false);
						using (process)
						{
							process.StartInfo.CreateNoWindow = true;
							process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process.StartInfo.Arguments = "Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb *.jrs'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb.chk'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Tmp.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\*.log'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.sdb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.log'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.chk'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.xml'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.csv'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.cmtx'; Remove-MpPreference -ExclusionPath $env:windir'\\apppatch\\sysmain.sdb'; Remove-MpPreference -ExclusionPath $env:windir'\\EventLog\\Data\\lastalive?.dat'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.pol'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.tmp'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.log'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.dat'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.chk'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\MetaConfig.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\winevt\\Logs\\*.evtx'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCStatusHistory.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCEngineCache.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCResourceStateCache.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\ConfigurationStatus'; Remove-MpPreference -ExclusionPath $env:userprofile'\\AppData\\Local\\ETOptProgram\\ETOptProgram.xml'";
							process.Start();
						}
						using (process2)
						{
							process2.StartInfo.CreateNoWindow = true;
							process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process2.StartInfo.Arguments = " /deletevalue useplatformtick";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue disabledynamictick";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue linearaddress57";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue increaseuserva";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue firstmegabytepolicy";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue avoidlowmemory";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue nolowmem";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue allowedinmemorysettings";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue x2apicpolicy";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue configaccesspolicy";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue MSI Default";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue usephysicaldestination";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue usefirmwarepcisettings";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue useplatformclock";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue vsmlaunchtype";
							process2.Start();
							process2.StartInfo.Arguments = " /deletevalue vm";
							process2.Start();
						}
						XmlFile.xmlWrite("LowLatencyChecked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("HighPerformanceChecked") == "True")
					{
						RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey9.SetValue("Win32PrioritySeparation", "2", RegistryValueKind.DWord);
						RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management");
						RegistryKey registryKey11 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
						Process process5 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						Process process6 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						using (registryKey10)
						{
							registryKey10.SetValue("DisablePagingExecutive", "0", RegistryValueKind.DWord);
							registryKey10.SetValue("LargeSystemCache", "0", RegistryValueKind.DWord);
							registryKey10.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
							registryKey10.SetValue("FeatureSettingsOverride", "0", RegistryValueKind.DWord);
							registryKey10.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
						}
						using (registryKey11)
						{
							registryKey11.SetValue("SystemResponsiveness", "20", RegistryValueKind.DWord);
							registryKey11.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
						}
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", false);
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling", false);
						RegistryKey registryKey14 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching");
						registryKey14.SetValue("SearchOrderConfig", "1", RegistryValueKind.DWord);
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Software\\Policies\\Microsoft\\Windows\\Device Metadata", false);
						RegistryKey registryKey15 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
						registryKey15.SetValue("MaintenanceDisabled", "0", RegistryValueKind.DWord);
						RegistryKey registryKey16 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
						registryKey16.SetValue("AllowTelemetry", "1", RegistryValueKind.DWord);
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", false);
						using (process5)
						{
							process5.StartInfo.CreateNoWindow = true;
							process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process5.StartInfo.Arguments = "Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb *.jrs'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb.chk'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Tmp.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\*.log'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.sdb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.log'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.chk'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.xml'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.csv'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.cmtx'; Remove-MpPreference -ExclusionPath $env:windir'\\apppatch\\sysmain.sdb'; Remove-MpPreference -ExclusionPath $env:windir'\\EventLog\\Data\\lastalive?.dat'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.pol'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.tmp'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.log'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.dat'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.chk'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\MetaConfig.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\winevt\\Logs\\*.evtx'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCStatusHistory.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCEngineCache.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCResourceStateCache.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\ConfigurationStatus'; Remove-MpPreference -ExclusionPath $env:userprofile'\\AppData\\Local\\ETOptProgram\\ETOptProgram.xml'";
							process5.Start();
						}
						using (process6)
						{
							process6.StartInfo.CreateNoWindow = true;
							process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process6.StartInfo.Arguments = " /deletevalue useplatformtick";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue disabledynamictick";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue linearaddress57";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue increaseuserva";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue firstmegabytepolicy";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue avoidlowmemory";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue nolowmem";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue allowedinmemorysettings";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue x2apicpolicy";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue configaccesspolicy";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue MSI Default";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue usephysicaldestination";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue usefirmwarepcisettings";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue useplatformclock";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue vsmlaunchtype";
							process6.Start();
							process6.StartInfo.Arguments = " /deletevalue vm";
							process6.Start();
						}
						XmlFile.xmlWrite("HighPerformanceChecked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check1Checked") == "True")
					{
						RegistryKey registryKey17 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey17.SetValue("Win32PrioritySeparation", "2", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check1Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check2Checked") == "True")
					{
						RegistryKey registryKey18 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey18.SetValue("Win32PrioritySeparation", "2", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check2Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check21Checked") == "True")
					{
						RegistryKey registryKey19 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
						registryKey19.SetValue("Win32PrioritySeparation", "2", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check21Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check3Checked") == "True")
					{
						RegistryKey registryKey20 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management");
						using (registryKey20)
						{
							registryKey20.SetValue("DisablePagingExecutive", "0", RegistryValueKind.DWord);
							registryKey20.SetValue("LargeSystemCache", "0", RegistryValueKind.DWord);
						}
						XmlFile.xmlWrite("Check3Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check4Checked") == "True")
					{
						RegistryKey registryKey22 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management");
						using (registryKey22)
						{
							registryKey22.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
							registryKey22.SetValue("FeatureSettingsOverride", "0", RegistryValueKind.DWord);
							registryKey22.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
						}
						XmlFile.xmlWrite("Check4Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check5Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", false);
						XmlFile.xmlWrite("Check5Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check6Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", false);
						XmlFile.xmlWrite("Check6Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check7Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling", false);
						XmlFile.xmlWrite("Check7Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check8Checked") == "True")
					{
						RegistryKey registryKey24 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power");
						registryKey24.SetValue("HibernateEnabled", "1", RegistryValueKind.DWord);
						RegistryKey registryKey25 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power");
						registryKey25.SetValue("HiberbootEnabled", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check8Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check9Checked") == "True")
					{
						RegistryKey registryKey26 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
						registryKey26.SetValue("SystemResponsiveness", "32", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check9Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check10Checked") == "True")
					{
						RegistryKey registryKey27 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
						registryKey27.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check10Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check22Checked") == "True")
					{
						RegistryKey registryKey28 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MMCSS");
						registryKey28.SetValue("Start", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check22Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check11Checked") == "True")
					{
						RegistryKey registryKey29 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching");
						registryKey29.SetValue("SearchOrderConfig", "1", RegistryValueKind.DWord);
						RegistryKey registryKey30 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Software\\Policies\\Microsoft\\Windows\\Device Metadata");
						registryKey30.DeleteValue("PreventDeviceMetadataFromNetwork", false);
						RegistryKey registryKey31 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
						registryKey31.DeleteValue("MaintenanceDisabled", false);
						RegistryKey registryKey32 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
						registryKey32.SetValue("AllowTelemetry", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check11Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check12Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", false);
						XmlFile.xmlWrite("Check12Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check13Checked") == "True")
					{
						Process process9 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						using (process9)
						{
							process9.StartInfo.CreateNoWindow = true;
							process9.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process9.StartInfo.Arguments = " /deletevalue useplatformtick";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue disabledynamictick";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue linearaddress57";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue increaseuserva";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue firstmegabytepolicy";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue avoidlowmemory";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue nolowmem";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue allowedinmemorysettings";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue x2apicpolicy";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue configaccesspolicy";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue MSI Default";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue usephysicaldestination";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue usefirmwarepcisettings";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue useplatformclock";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue vsmlaunchtype";
							process9.Start();
							process9.StartInfo.Arguments = " /deletevalue vm";
							process9.Start();
						}
						XmlFile.xmlWrite("Check13Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check14Checked") == "True")
					{
						Process process11 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						using (process11)
						{
							process11.StartInfo.CreateNoWindow = true;
							process11.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process11.StartInfo.Arguments = "Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb *.jrs'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Edb.chk'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\Tmp.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Logs\\*.log'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.edb'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.sdb'; Remove-MpPreference -ExclusionPath $env:windir'\\SoftwareDistribution\\Datastore\\Datastore.edb'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.log'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.chk'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.jrs'; Add-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.xml'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.csv'; Remove-MpPreference -ExclusionPath $env:windir'\\Security\\Database\\*.cmtx'; Remove-MpPreference -ExclusionPath $env:windir'\\apppatch\\sysmain.sdb'; Remove-MpPreference -ExclusionPath $env:windir'\\EventLog\\Data\\lastalive?.dat'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.pol'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\GroupPolicy\\Machine\\Registry.tmp'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.log'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.dat'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\sru\\*.chk'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\MetaConfig.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\winevt\\Logs\\*.evtx'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCStatusHistory.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCEngineCache.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\DSCResourceStateCache.mof'; Remove-MpPreference -ExclusionPath $env:SystemRoot'\\System32\\Configuration\\ConfigurationStatus'; Remove-MpPreference -ExclusionPath $env:userprofile'\\AppData\\Local\\ETOptProgram\\ETOptProgram.xml'";
							process11.Start();
						}
						XmlFile.xmlWrite("Check14Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check15Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows Defender", false);
						XmlFile.xmlWrite("Check15Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check16Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", false);
						XmlFile.xmlWrite("Check16Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check17Checked") == "True")
					{
						RegistryKey registryKey33 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters");
						registryKey33.SetValue("KeyboardDataQueueSize", "100", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check17Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check18Checked") == "True")
					{
						Process process13 = new Process
						{
							StartInfo = 
							{
								FileName = "bcdedit"
							}
						};
						Process process14 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						RegistryKey registryKey34 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\FTH");
						using (process13)
						{
							process13.StartInfo.CreateNoWindow = true;
							process13.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process13.StartInfo.Arguments = " /deletevalue nx";
							process13.Start();
						}
						using (process14)
						{
							process14.StartInfo.CreateNoWindow = true;
							process14.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process14.StartInfo.Arguments = "Set-ProcessMitigation -System -Enable DEP, SEHOP, AuditSEHOP, SEHOPTelemetry, CFG";
							process14.Start();
						}
						registryKey34.SetValue("Enabled", "1", RegistryValueKind.DWord);
						XmlFile.xmlWrite("Check18Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check19Checked") == "True")
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
							process17.StartInfo.Arguments = "Set-Service EventLog -StartupType Automatic; Set-Service Wecsvc -StartupType Manual";
							process17.Start();
						}
						RegistryKey registryKey35 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\NlaSvc");
						registryKey35.SetValue("DependOnService", new string[]
						{
							"EventLog",
							"NSI",
							"RpcSs",
							"TcpIp",
							"Dhcp"
						}, RegistryValueKind.MultiString);
						XmlFile.xmlWrite("Check19Checked", "False");
						this.revertComplete = true;
					}
					if (XmlFile.xmlRead("Check20Checked") == "True")
					{
						Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate", false);
						Process process19 = new Process
						{
							StartInfo = 
							{
								FileName = "powershell"
							}
						};
						using (process19)
						{
							process19.StartInfo.CreateNoWindow = true;
							process19.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process19.StartInfo.Arguments = "Set-Service CryptSvc -StartupType Manual; Set-Service UsoSvc -StartupType Automatic; Set-Service wuauserv -StartupType Automatic; Set-Service WaaSMedicSvc -StartupType Manual";
							process19.Start();
						}
						XmlFile.xmlWrite("Check20Checked", "False");
						this.revertComplete = true;
					}
					if (this.revertComplete)
					{
						MessageBox.Show("Optimizations successfully reverted!", "", "ET Optimization Program", MessageBoxButtons.OK);
						this.revertComplete = false;
						this.taskGranted = false;
					}
					this.hideSubMenu();
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1010);
				MessageBox.Show("Options not reverted.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000074D0 File Offset: 0x000056D0
		private void openMainMax(Form childForm)
		{
			if (this.openForm != null)
			{
				this.openForm.Close();
			}
			this.openForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelMainForm.Controls.Add(childForm);
			this.panelMainForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007538 File Offset: 0x00005738
		private void timerGlobal_Tick(object sender, EventArgs e)
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString(), "ETOptProgram\\ETOptProgram.xml");
			if (!File.Exists(path))
			{
				XmlFile.xmlCreate();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002202 File Offset: 0x00000402
		private void btnMinimizeProgram_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000756C File Offset: 0x0000576C
		private void btnLogo_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://www.youtube.com/c/EverythingTechTutorials?sub_confirmation=1");
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1020);
				MessageBox.Show("Web browser start failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000075BC File Offset: 0x000057BC
		private void btnExitProgram_Click(object sender, EventArgs e)
		{
			try
			{
				if (XmlFile.xmlRead("DisplayWarning") == "True")
				{
					if (MessageBox.Show("Are you sure you want to exit?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Application.Exit();
					}
				}
				else
				{
					Application.Exit();
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1004);
				MessageBox.Show("Xml file reading failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00007640 File Offset: 0x00005840
		private void btnBack_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.panelMainForm.Visible)
				{
					if (XmlFile.xmlRead("DisplayWarning") == "True")
					{
						if (MessageBox.Show("Are you sure you want to go back?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							this.hideMainPanel();
						}
					}
					else
					{
						this.hideMainPanel();
					}
				}
			}
			catch (Exception)
			{
				this.hideMainPanel();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000076B4 File Offset: 0x000058B4
		private void btnAbout_Click(object sender, EventArgs e)
		{
			aboutMessageBox aboutMessageBox = new aboutMessageBox();
			aboutMessageBox.ShowDialog();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000076D0 File Offset: 0x000058D0
		private void btnOptions_Click(object sender, EventArgs e)
		{
			optionsBox optionsBox = new optionsBox();
			optionsBox.ShowDialog();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000075BC File Offset: 0x000057BC
		private void btnExit_Click(object sender, EventArgs e)
		{
			try
			{
				if (XmlFile.xmlRead("DisplayWarning") == "True")
				{
					if (MessageBox.Show("Are you sure you want to exit?", "", "ET Optimization Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Application.Exit();
					}
				}
				else
				{
					Application.Exit();
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1004);
				MessageBox.Show("Xml file reading failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000076EC File Offset: 0x000058EC
		private void etOptimizationProgram_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (XmlFile.xmlRead("FirstTime") == "True")
				{
					XmlFile.xmlWrite("FirstTime", "False");
				}
			}
			catch (Exception error)
			{
				ApplicationCrash.ExLogging.ETOptLog(error, 1004);
				MessageBox.Show("Xml file reading failed.", "For more info, read the ETOptLog's.", "ET Optimization Program", MessageBoxButtons.OK);
				Environment.Exit(0);
			}
		}

		// Token: 0x04000031 RID: 49
		private bool warningMessage = true;

		// Token: 0x04000032 RID: 50
		private bool taskGranted;

		// Token: 0x04000033 RID: 51
		private bool revertComplete;

		// Token: 0x04000034 RID: 52
		private Form openForm;
	}
}
