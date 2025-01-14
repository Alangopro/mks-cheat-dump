using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;

namespace MKS_Cheat_BSP
{
	// Token: 0x0200001B RID: 27
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public static class MN
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003160 File Offset: 0x00001360
		public static string EncryptText(string input, string key)
		{
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(input);
			byte[] bytes2 = global::System.Text.Encoding.UTF8.GetBytes(key);
			byte[] array = new byte[bytes.Length];
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = bytes[i] ^ bytes2[i % bytes2.Length];
			}
			return global::System.Convert.ToBase64String(array);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000031C4 File Offset: 0x000013C4
		public static string DecryptText(string encryptedText, string key)
		{
			byte[] array = global::System.Convert.FromBase64String(encryptedText);
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(key);
			byte[] array2 = new byte[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = array[i] ^ bytes[i % bytes.Length];
			}
			return global::System.Text.Encoding.UTF8.GetString(array2);
		}

		// Token: 0x0400001C RID: 28
		public static global::System.Net.Http.HttpClient Fo = new global::System.Net.Http.HttpClient();
	}
}
