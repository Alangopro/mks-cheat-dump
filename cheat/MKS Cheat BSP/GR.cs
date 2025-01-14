using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using MelonLoader;
using MKS;
using UnityEngine.Networking;

// Token: 0x02000010 RID: 16
[global::System.Runtime.CompilerServices.NullableContext(1)]
[global::System.Runtime.CompilerServices.Nullable(0)]
[global::HarmonyLib.HarmonyPatch(typeof(global::UnityEngine.Networking.UnityWebRequest), "Get")]
public static class GR
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002D38 File Offset: 0x00000F38
	[global::HarmonyLib.HarmonyPrefix]
	public static void Prefix(ref string uri)
	{
		if (global::MKS.Xd.mjl)
		{
			global::MelonLoader.MelonLogger.Msg(uri);
		}
		if (uri.Contains("/addressables/") && uri.Contains(".bytes"))
		{
			global::GR.VD = uri;
		}
		if (uri.Contains("/buildergame/") && uri.Contains("/blob/level/") && uri.Contains(".arena"))
		{
			global::GR.VD = uri;
		}
	}

	// Token: 0x04000015 RID: 21
	public static string VD;
}
