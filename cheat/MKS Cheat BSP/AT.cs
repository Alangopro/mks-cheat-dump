using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2Cpp;
using Il2CppBSP.Scripts.Components.Arenas.Renderers;
using MelonLoader;
using MKS;

// Token: 0x0200000D RID: 13
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Components.Arenas.Renderers.Arena), "Load", new global::System.Type[]
{
	typeof(global::Il2Cpp.CKCGOBBEAKK),
	typeof(bool),
	typeof(bool)
})]
internal class AT
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002BAC File Offset: 0x00000DAC
	[global::HarmonyLib.HarmonyPostfix]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public static void Postfix(ref global::Il2Cpp.CKCGOBBEAKK valueObject)
	{
		try
		{
			global::MKS.Xd.YjJ = valueObject;
		}
		catch (global::System.Exception ex)
		{
			global::MelonLoader.MelonLogger.BigError("WORLD SAVE ERROR", ex.Message);
		}
	}
}
