using System;
using HarmonyLib;
using Il2CppBSP.Scripts.UI.ItemSelector;
using MelonLoader;
using MKS;
using UnityEngine;

// Token: 0x0200000C RID: 12
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.UI.ItemSelector.ItemSelector), "GetCurrentColor")]
internal class UJ
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002B08 File Offset: 0x00000D08
	[global::HarmonyLib.HarmonyPostfix]
	public static void Postfix(ref int __result)
	{
		if (global::MKS.Xd.lWa)
		{
			try
			{
				global::UnityEngine.Color color;
				color..ctor((float)global::System.Convert.ToInt32(global::MKS.Xd.KWc), (float)global::System.Convert.ToInt32(global::MKS.Xd.eWQ), (float)global::System.Convert.ToInt32(global::MKS.Xd.RW1), 0f);
				__result = ((int)color.a << 24) | ((int)color.r << 16) | ((int)color.g << 8) | (int)color.b;
			}
			catch (global::System.Exception ex)
			{
				string text = "Invalid RGB Code!: ";
				global::System.Exception ex2 = ex;
				global::MelonLoader.MelonLogger.Error(text + ((ex2 != null) ? ex2.ToString() : null));
			}
		}
	}
}
