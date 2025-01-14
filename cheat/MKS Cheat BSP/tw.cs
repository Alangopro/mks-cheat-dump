using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2Cpp;
using Il2CppBSP.Scripts.Scenes.BaseEditorScene;

// Token: 0x02000013 RID: 19
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Scenes.BaseEditorScene.EditorSceneContext), "SelectTool")]
internal class tw
{
	// Token: 0x06000020 RID: 32 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::HarmonyLib.HarmonyPrefix]
	public static bool Prefix([global::HarmonyLib.HarmonyArgument(0)] global::Il2Cpp.MEJDGPHMFGD o)
	{
		global::Il2CppBSP.Scripts.Scenes.BaseEditorScene.EditorSceneContext.Current().GetCurrentState().ChangeToolBy(o);
		return false;
	}
}
