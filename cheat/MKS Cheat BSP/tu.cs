using System;
using HarmonyLib;
using Il2CppBSP.Scripts.Scenes.BaseEditorScene;

// Token: 0x02000014 RID: 20
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Scenes.BaseEditorScene.EditorSceneContext), "IsAllowedToSave")]
internal class tu
{
	// Token: 0x06000022 RID: 34 RVA: 0x000022F0 File Offset: 0x000004F0
	[global::HarmonyLib.HarmonyPrefix]
	public static bool Prefix()
	{
		return true;
	}
}
