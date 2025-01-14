using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppNebula.Core.Managers.Localization;
using MKS;

// Token: 0x02000007 RID: 7
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppNebula.Core.Managers.Localization.LocalizationManager), "LoadLanguage")]
public static class O4
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002728 File Offset: 0x00000928
	[global::HarmonyLib.HarmonyPrefix]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public static bool Prefix(ref string language)
	{
		if (global::MKS.Xd.CWl)
		{
			language = "en_us";
		}
		return true;
	}
}
