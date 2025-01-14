using System;
using HarmonyLib;
using Il2CppNebula.Core.Service;
using MKS;

// Token: 0x02000016 RID: 22
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppNebula.Core.Service.Membership), "IsMember")]
internal class UO
{
	// Token: 0x06000026 RID: 38 RVA: 0x00002E30 File Offset: 0x00001030
	[global::HarmonyLib.HarmonyPrefix]
	public static bool Prefix(ref bool __result)
	{
		if (global::MKS.Xd.Ojv)
		{
			__result = true;
			return false;
		}
		return true;
	}
}
