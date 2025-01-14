using System;
using System.Runtime.CompilerServices;
using Il2CppSfs2X.Core;
using Il2CppSfs2X.Entities.Data;
using Il2CppSystem;
using MKS;

namespace MKS_Cheat_BSP
{
	// Token: 0x0200001C RID: 28
	public static class H3
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003240 File Offset: 0x00001440
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public static void OnExtensionResponse(global::Il2CppSfs2X.Core.BaseEvent evt)
		{
			if (global::MKS.Xd.mjl)
			{
				global::Il2CppSystem.Object @object = evt.Params["params"];
				global::Il2CppSfs2X.Entities.Data.SFSObject sfsobject = @object as global::Il2CppSfs2X.Entities.Data.SFSObject;
				if (sfsobject != null)
				{
					global::System.Console.WriteLine("Intercepted Response: " + sfsobject.GetDump());
					return;
				}
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(31, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Response params type mismatch: ");
				defaultInterpolatedStringHandler.AppendFormatted<global::System.Type>(@object.GetType());
				global::System.Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
	}
}
