using System;
using HarmonyLib;
using Il2CppBSP.Scripts.Scenes.BaseEditorScene;

// Token: 0x02000015 RID: 21
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Scenes.BaseEditorScene.EditorSceneContext), "OnUndoButton")]
internal class jG
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002E10 File Offset: 0x00001010
	[global::HarmonyLib.HarmonyPrefix]
	public static bool Prefix()
	{
		global::Il2CppBSP.Scripts.Scenes.BaseEditorScene.EditorSceneContext.Current().GetCurrentState().DoUndo();
		return false;
	}
}
