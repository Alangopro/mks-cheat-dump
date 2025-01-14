using System;
using HarmonyLib;
using Il2CppNebula.Core.Mangrove.Event;

// Token: 0x02000006 RID: 6
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppNebula.Core.Mangrove.Event.MangroveBaseEvent), "Send")]
internal class ak
{
	// Token: 0x06000008 RID: 8 RVA: 0x000022ED File Offset: 0x000004ED
	[global::HarmonyLib.HarmonyPrefix]
	public static bool Prefix()
	{
		return false;
	}
}
