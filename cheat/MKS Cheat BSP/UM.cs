using System;
using HarmonyLib;
using Il2CppBSP.Scripts.Scenes.ArenaEditorScene;

// Token: 0x02000008 RID: 8
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Scenes.ArenaEditorScene.ArenaEditorSceneContext), "DoSaveProcess")]
internal class UM
{
	// Token: 0x0600000B RID: 11 RVA: 0x00002744 File Offset: 0x00000944
	[global::HarmonyLib.HarmonyPrefix]
	public static bool Prefix()
	{
		global::Il2CppBSP.Scripts.Scenes.ArenaEditorScene.ArenaEditorSceneContext.Current().ContinueSaving(true);
		return false;
	}
}
