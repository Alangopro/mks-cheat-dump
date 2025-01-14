using System;
using System.Runtime.CompilerServices;
using Il2CppBSP.Scripts.Components.Managers.Drops;
using Il2CppBSP.Scripts.Scenes;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using MKS.Helpers;
using UnityEngine;

namespace MKS.Lobby
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public class Pjq
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00009984 File Offset: 0x00007B84
		public static void CrystalsBypassed()
		{
			if (global::MKS.Xd.iKb)
			{
				string text = "NULL";
				global::MKS.Lobby.Pjq.gj1 = global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().DropsManager.GetDrops();
				global::UnityEngine.Vector3 position;
				position..ctor(0f, 0f, 0f);
				foreach (global::Il2CppSystem.Collections.Generic.KeyValuePair<string, global::Il2CppBSP.Scripts.Components.Managers.Drops.DropBase> keyValuePair in global::MKS.Lobby.Pjq.gj1)
				{
					if (!global::MKS.Xd.KWP.Contains(keyValuePair.key.Split('_', global::System.StringSplitOptions.None)[0]))
					{
						position = keyValuePair.Value.transform.position;
						text = keyValuePair.key;
					}
				}
				if (text != "NULL" && position != new global::UnityEngine.Vector3(0f, 0f, 0f))
				{
					global::MKS.Lobby.Pjq.Vjc = text;
					global::MKS.Lobby.Pjq.yjQ = true;
					global::MKS.Helpers.WeI.TeleportMe(position, 20);
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009A68 File Offset: 0x00007C68
		public static void CrystalsCustomized(int id)
		{
			try
			{
				global::MKS.Lobby.Pjq.Hjb = false;
				global::MKS.Lobby.Pjq.Wja = id;
				global::MKS.Lobby.Pjq.gj1 = global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().DropsManager.GetDrops();
				global::UnityEngine.Vector3 position;
				position..ctor(0f, 0f, 0f);
				foreach (global::Il2CppSystem.Collections.Generic.KeyValuePair<string, global::Il2CppBSP.Scripts.Components.Managers.Drops.DropBase> keyValuePair in global::MKS.Lobby.Pjq.gj1)
				{
					if (keyValuePair.Key.StartsWith(global::MKS.Lobby.Pjq.Wja.ToString() + "_"))
					{
						global::MKS.Lobby.Pjq.Hjb = true;
						position = keyValuePair.Value.transform.position;
					}
				}
				if (position != new global::UnityEngine.Vector3(0f, 0f, 0f))
				{
					global::MKS.Lobby.Pjq.Vjc = global::MKS.Lobby.Pjq.Wja.ToString();
					global::MKS.Lobby.Pjq.yjQ = true;
					global::MKS.Helpers.WeI.TeleportMe(position, 20);
				}
				if (!global::MKS.Lobby.Pjq.Hjb)
				{
					global::MelonLoader.MelonLogger.Warning("Crystal not found!");
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0400016A RID: 362
		public static string Vjc = "0";

		// Token: 0x0400016B RID: 363
		public static bool yjQ = false;

		// Token: 0x0400016C RID: 364
		public static global::Il2CppSystem.Collections.Generic.Dictionary<string, global::Il2CppBSP.Scripts.Components.Managers.Drops.DropBase> gj1;

		// Token: 0x0400016D RID: 365
		public static int Wja;

		// Token: 0x0400016E RID: 366
		public static bool Hjb = false;
	}
}
