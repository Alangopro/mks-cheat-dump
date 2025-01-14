using System;
using System.Runtime.CompilerServices;
using DiscordRPC;

namespace MKS.Discord
{
	// Token: 0x02000032 RID: 50
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public class aeX
	{
		// Token: 0x060000AB RID: 171 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public static void initializediscord(string stejt)
		{
			try
			{
				global::MKS.Discord.aeX.geH = new global::DiscordRPC.DiscordRpcClient("1171004136205066280");
				global::MKS.Discord.aeX.geH.Initialize();
				global::MKS.Discord.aeX.geH.SetPresence(new global::DiscordRPC.RichPresence
				{
					Details = "MKS-Cheat | @ Cracked by KangarooLeaks",
					State = stejt,
					Timestamps = global::MKS.Discord.aeX.Ve9,
					Assets = new global::DiscordRPC.Assets
					{
						LargeImageKey = "http://mksteam.ovh/hwids/app1.png"
					},
					Buttons = new global::DiscordRPC.Button[]
					{
						new global::DiscordRPC.Button
						{
							Label = "Download",
							Url = "https://firenox.ct8.pl/clowns"
						},
						new global::DiscordRPC.Button
						{
							Label = "Discord",
							Url = "https://discord.gg/Demk9JpfMc"
						}
					}
				});
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000AB6C File Offset: 0x00008D6C
		public static void SetPresence(string scene)
		{
			try
			{
				global::MKS.Discord.aeX.geH.SetPresence(new global::DiscordRPC.RichPresence
				{
					Details = "MKS-Cheat | @ cracked by kangarooleaks",
					State = "Scene: " + scene,
					Timestamps = global::MKS.Discord.aeX.Ve9,
					Assets = new global::DiscordRPC.Assets
					{
						LargeImageKey = "http://mksteam.ovh/hwids/app1.png"
					},
					Buttons = new global::DiscordRPC.Button[]
					{
						new global::DiscordRPC.Button
						{
							Label = "Download",
							Url = "https://firenox.ct8.pl/clowns"
						},
						new global::DiscordRPC.Button
						{
							Label = "Discord",
							Url = "https://discord.gg/Demk9JpfMc"
						}
					}
				});
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x04000191 RID: 401
		public static global::DiscordRPC.DiscordRpcClient geH;

		// Token: 0x04000192 RID: 402
		private static global::DiscordRPC.Timestamps Ve9 = global::DiscordRPC.Timestamps.Now;
	}
}
