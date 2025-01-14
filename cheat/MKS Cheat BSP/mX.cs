using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2Cpp;
using Il2CppBSP.Scripts.Components.BlockStars.Renderers;
using MelonLoader;
using MKS;

// Token: 0x0200000E RID: 14
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar), "Load", new global::System.Type[]
{
	typeof(global::Il2Cpp.PJPAFJBIDAL),
	typeof(bool)
})]
internal class mX
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002BE8 File Offset: 0x00000DE8
	[global::HarmonyLib.HarmonyPrefix]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public static void Postfix(ref global::Il2Cpp.PJPAFJBIDAL valueObject, ref bool canLoadWeapon)
	{
		try
		{
			canLoadWeapon = true;
			global::MKS.Xd.ljT = valueObject;
		}
		catch (global::System.Exception ex)
		{
			global::MelonLoader.MelonLogger.BigError("BLOCKSTAR SAVE ERROR", ex.Message);
		}
	}
}
