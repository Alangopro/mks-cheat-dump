using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;

// Token: 0x02000005 RID: 5
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppSystem.IO.Directory), "GetDirectories", new global::System.Type[] { typeof(string) })]
public static class EA
{
	// Token: 0x06000007 RID: 7 RVA: 0x000026F4 File Offset: 0x000008F4
	[global::HarmonyLib.HarmonyPrefix]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public static bool Prefix(ref global::Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray __result)
	{
		__result = new global::Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(0L);
		return false;
	}
}
