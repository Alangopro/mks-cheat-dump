using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppSfs2X;
using MelonLoader;
using MKS;

// Token: 0x02000012 RID: 18
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppSfs2X.SmartFox), "Connect", new global::System.Type[] { typeof(string) })]
internal class qY
{
	// Token: 0x0600001E RID: 30 RVA: 0x00002DD4 File Offset: 0x00000FD4
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::HarmonyLib.HarmonyPrefix]
	public static void Postfix(ref string host)
	{
		if (global::MKS.Xd.mjl)
		{
			global::MelonLoader.MelonLogger.Warning(host);
		}
	}
}
