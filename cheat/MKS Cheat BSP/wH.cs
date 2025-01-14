using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppSfs2X;
using Il2CppSfs2X.Requests;
using MelonLoader;
using MKS;

// Token: 0x0200000F RID: 15
[global::System.Runtime.CompilerServices.NullableContext(1)]
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppSfs2X.SmartFox), "Send")]
[global::System.Runtime.CompilerServices.Nullable(0)]
public static class wH
{
	// Token: 0x0600001A RID: 26 RVA: 0x00002C28 File Offset: 0x00000E28
	[global::HarmonyLib.HarmonyPostfix]
	public static void dx(ref global::Il2CppSfs2X.Requests.IRequest request, ref global::Il2CppSfs2X.SmartFox __instance)
	{
		if (global::wH.KP != __instance)
		{
			global::wH.KP = __instance;
		}
		if (request.Message.Content.ToJson().Contains("{\"c\":\"ure\""))
		{
			global::wH.Nx = request;
		}
		if (request.Message.Content.ToJson().Contains("{\"c\":\"mlb\""))
		{
			global::wH.ag = request;
		}
		if (request.Message.Content.ToJson().Contains("{\"c\":\"mle\""))
		{
			global::wH.hy = request;
			if (global::MKS.Xd.GWR)
			{
				__instance.Send(global::wH.ag);
			}
		}
		if (request.Message.Content.ToJson().Contains("{\"c\":\"sch2\""))
		{
			global::wH.L9 = request;
			global::wH.cv = __instance;
		}
		if (request.Message.Content.ToJson().Contains("{\"c\":\"ucps\",\"r\":-1,\"p\":{\"n\":\"BattleScene\"}}"))
		{
			global::wH.J6 = request;
			global::wH.Yl = __instance;
		}
		if (global::MKS.Xd.mjl)
		{
			global::MelonLoader.MelonLogger.Msg(request.Message.Content.ToJson());
		}
	}

	// Token: 0x0400000D RID: 13
	public static global::Il2CppSfs2X.Requests.IRequest L9;

	// Token: 0x0400000E RID: 14
	public static global::Il2CppSfs2X.SmartFox cv;

	// Token: 0x0400000F RID: 15
	public static global::Il2CppSfs2X.Requests.IRequest Nx;

	// Token: 0x04000010 RID: 16
	public static global::Il2CppSfs2X.SmartFox KP;

	// Token: 0x04000011 RID: 17
	public static global::Il2CppSfs2X.Requests.IRequest J6;

	// Token: 0x04000012 RID: 18
	public static global::Il2CppSfs2X.SmartFox Yl;

	// Token: 0x04000013 RID: 19
	public static global::Il2CppSfs2X.Requests.IRequest ag;

	// Token: 0x04000014 RID: 20
	public static global::Il2CppSfs2X.Requests.IRequest hy;
}
