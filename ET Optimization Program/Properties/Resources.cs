using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EtOptimizationProgram.Properties
{
	// Token: 0x0200000E RID: 14
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000020AD File Offset: 0x000002AD
		internal Resources()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00012D48 File Offset: 0x00010F48
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("EtOptimizationProgram.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000025A4 File Offset: 0x000007A4
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000025AB File Offset: 0x000007AB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00012D84 File Offset: 0x00010F84
		internal static Icon EP_Logo
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("EP_Logo", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x040000D2 RID: 210
		private static ResourceManager resourceMan;

		// Token: 0x040000D3 RID: 211
		private static CultureInfo resourceCulture;
	}
}
