using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BSP_Launcher.Properties
{
	// Token: 0x02000007 RID: 7
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000039E0 File Offset: 0x00001BE0
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000039E8 File Offset: 0x00001BE8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::BSP_Launcher.Properties.Resources.resourceMan == null)
				{
					global::BSP_Launcher.Properties.Resources.resourceMan = new global::System.Resources.ResourceManager("BSP_Launcher.Properties.Resources", typeof(global::BSP_Launcher.Properties.Resources).Assembly);
				}
				return global::BSP_Launcher.Properties.Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003A14 File Offset: 0x00001C14
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00003A1B File Offset: 0x00001C1B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::BSP_Launcher.Properties.Resources.resourceCulture;
			}
			set
			{
				global::BSP_Launcher.Properties.Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003A23 File Offset: 0x00001C23
		internal static global::System.Drawing.Bitmap banane_sex
		{
			get
			{
				return (global::System.Drawing.Bitmap)global::BSP_Launcher.Properties.Resources.ResourceManager.GetObject("banane-sex", global::BSP_Launcher.Properties.Resources.resourceCulture);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003A3E File Offset: 0x00001C3E
		internal static global::System.Drawing.Bitmap logo
		{
			get
			{
				return (global::System.Drawing.Bitmap)global::BSP_Launcher.Properties.Resources.ResourceManager.GetObject("logo", global::BSP_Launcher.Properties.Resources.resourceCulture);
			}
		}

		// Token: 0x04000026 RID: 38
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000027 RID: 39
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
