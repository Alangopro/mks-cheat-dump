using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BSP_Launcher
{
	// Token: 0x02000002 RID: 2
	public static class encryption
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static async global::System.Threading.Tasks.Task<string> EncryptPassword(string name, string pass, string url)
		{
			global::System.Net.Http.HttpResponseMessage httpResponseMessage = await global::BSP_Launcher.encryption.httpClient.GetAsync("http://" + url + "/ip");
			string text = pass;
			string text2 = text + await httpResponseMessage.Content.ReadAsStringAsync() + name;
			text = null;
			return global::BSP_Launcher.encryption.EncryptText(name + pass, text2);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A4 File Offset: 0x000002A4
		private static string EncryptText(string input, string key)
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

		// Token: 0x06000003 RID: 3 RVA: 0x000020F8 File Offset: 0x000002F8
		private static string DecryptText(string encryptedText, string key)
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

		// Token: 0x04000001 RID: 1
		public static global::System.Net.Http.HttpClient httpClient = new global::System.Net.Http.HttpClient();
	}
}
