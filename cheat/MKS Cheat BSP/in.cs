using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppSfs2X;
using MelonLoader;
using MKS;

// Token: 0x02000011 RID: 17
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppSfs2X.SmartFox), "Connect", new global::System.Type[]
{
	typeof(string),
	typeof(int)
})]
internal class @in
{
	// Token: 0x0600001C RID: 28 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[global::HarmonyLib.HarmonyPrefix]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public static void Postfix(ref string host, ref int port)
	{
		if (global::MKS.Xd.mjl)
		{
			global::MelonLoader.MelonLogger.Warning(host + ":" + port.ToString());
		}
	}
}
