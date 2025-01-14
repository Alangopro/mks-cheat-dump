using System;
using System.Windows.Forms;

namespace BSP_Launcher
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000039C9 File Offset: 0x00001BC9
		[global::System.STAThread]
		private static void Main()
		{
			global::System.Windows.Forms.Application.EnableVisualStyles();
			global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			global::System.Windows.Forms.Application.Run(new global::BSP_Launcher.Form1());
		}
	}
}
