using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000035 RID: 53
internal class EeE
{
	// Token: 0x060000B1 RID: 177 RVA: 0x0000AC94 File Offset: 0x00008E94
	static EeE()
	{
		try
		{
			global::System.Security.Cryptography.RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x000023EF File Offset: 0x000005EF
	internal EeE()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000022E8 File Offset: 0x000004E8
	private void method_0()
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0000AD3C File Offset: 0x00008F3C
	internal static byte[] smethod_0(byte[] byte_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_0.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_0.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)byte_0.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array2[i] = byte_0[i];
		}
		byte[] array3 = array2;
		int num4 = byte_0.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((global::System.IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)((num3 >> (8 - j) * 8) & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)(((int)array2[(int)(num11 + (num12 + 3U))] << 24) | ((int)array2[(int)(num11 + (num12 + 2U))] << 16) | ((int)array2[(int)(num11 + (num12 + 1U))] << 8) | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			global::EeE.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			global::EeE.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			global::EeE.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			global::EeE.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			global::EeE.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			global::EeE.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			global::EeE.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			global::EeE.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			global::EeE.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			global::EeE.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			global::EeE.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			global::EeE.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			global::EeE.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			global::EeE.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			global::EeE.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			global::EeE.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			global::EeE.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			global::EeE.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			global::EeE.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			global::EeE.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			global::EeE.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			global::EeE.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			global::EeE.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			global::EeE.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			global::EeE.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			global::EeE.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			global::EeE.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			global::EeE.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			global::EeE.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			global::EeE.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			global::EeE.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			global::EeE.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			global::EeE.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			global::EeE.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			global::EeE.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			global::EeE.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			global::EeE.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			global::EeE.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			global::EeE.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			global::EeE.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			global::EeE.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			global::EeE.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			global::EeE.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			global::EeE.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			global::EeE.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			global::EeE.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			global::EeE.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			global::EeE.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			global::EeE.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			global::EeE.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			global::EeE.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			global::EeE.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			global::EeE.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			global::EeE.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			global::EeE.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			global::EeE.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			global::EeE.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			global::EeE.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			global::EeE.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			global::EeE.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			global::EeE.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			global::EeE.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			global::EeE.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			global::EeE.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		global::System.Array.Copy(global::System.BitConverter.GetBytes(num6), 0, array4, 0, 4);
		global::System.Array.Copy(global::System.BitConverter.GetBytes(num7), 0, array4, 4, 4);
		global::System.Array.Copy(global::System.BitConverter.GetBytes(num8), 0, array4, 8, 4);
		global::System.Array.Copy(global::System.BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000023F7 File Offset: 0x000005F7
	private static void smethod_1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + global::EeE.smethod_5(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[(int)uint_4] + global::EeE.YeV[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002420 File Offset: 0x00000620
	private static void smethod_2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + global::EeE.smethod_5(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[(int)uint_4] + global::EeE.YeV[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002449 File Offset: 0x00000649
	private static void smethod_3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + global::EeE.smethod_5(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[(int)uint_4] + global::EeE.YeV[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000246F File Offset: 0x0000066F
	private static void smethod_4(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + global::EeE.smethod_5(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[(int)uint_4] + global::EeE.YeV[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002496 File Offset: 0x00000696
	private static uint smethod_5(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> (int)(32 - ushort_0)) | (uint_0 << (int)ushort_0);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000024A8 File Offset: 0x000006A8
	internal static byte[] smethod_6(byte[] byte_0)
	{
		if (!global::EeE.smethod_8())
		{
			return new global::System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return global::EeE.smethod_0(byte_0);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000B39C File Offset: 0x0000959C
	private static void smethod_7()
	{
		try
		{
			global::System.Security.Cryptography.RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x060000BC RID: 188 RVA: 0x000024C3 File Offset: 0x000006C3
	internal static bool smethod_8()
	{
		if (!global::EeE.meC)
		{
			global::EeE.smethod_10();
			global::EeE.meC = true;
		}
		return global::EeE.Kes;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x000024DC File Offset: 0x000006DC
	internal byte[] obdSwoMrd()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000BE RID: 190 RVA: 0x000024F7 File Offset: 0x000006F7
	internal byte[] method_1()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002512 File Offset: 0x00000712
	internal byte[] method_2()
	{
		int length = "{11111-22222-50001-00001}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000252D File Offset: 0x0000072D
	internal byte[] method_3()
	{
		int length = "{11111-22222-50001-00002}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002548 File Offset: 0x00000748
	private static int smethod_9()
	{
		return 5;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0000B3C4 File Offset: 0x000095C4
	internal static void smethod_10()
	{
		try
		{
			new global::System.Security.Cryptography.MD5CryptoServiceProvider();
		}
		catch
		{
			global::EeE.Kes = true;
			return;
		}
		try
		{
			global::EeE.Kes = global::System.Security.Cryptography.CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000B410 File Offset: 0x00009610
	internal static global::System.Security.Cryptography.SymmetricAlgorithm smethod_11()
	{
		global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = null;
		if (global::EeE.smethod_8())
		{
			symmetricAlgorithm = new global::System.Security.Cryptography.AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				symmetricAlgorithm = new global::System.Security.Cryptography.RijndaelManaged();
			}
			catch
			{
				symmetricAlgorithm = new global::System.Security.Cryptography.AesCryptoServiceProvider();
			}
		}
		return symmetricAlgorithm;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0000254B File Offset: 0x0000074B
	private byte[] method_4()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002566 File Offset: 0x00000766
	private byte[] method_5()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000B454 File Offset: 0x00009654
	internal static void smethod_12(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm_0, global::System.IO.Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 > 0U)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			global::EeE.smethod_13(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002581 File Offset: 0x00000781
	internal static void smethod_13(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000B490 File Offset: 0x00009690
	internal static uint smethod_14(uint uint_0, int int_0, long long_0, global::System.IO.BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			binaryReader_0.BaseStream.Position = long_0 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_0 && uint_0 < num2 + num)
			{
				return num3 + uint_0 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0000258F File Offset: 0x0000078F
	private static global::System.IO.Stream smethod_15()
	{
		return new global::System.IO.MemoryStream();
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000B4EC File Offset: 0x000096EC
	private static byte[] smethod_16(string string_0)
	{
		byte[] array;
		using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(string_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000B54C File Offset: 0x0000974C
	internal static object smethod_17(global::System.Reflection.Assembly assembly_0)
	{
		try
		{
			if (global::System.IO.File.Exists(((global::System.Reflection.Assembly)assembly_0).Location))
			{
				return ((global::System.Reflection.Assembly)assembly_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (global::System.IO.File.Exists(((global::System.Reflection.Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((global::System.Reflection.Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (global::System.IO.File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0])
				.ToString()))
			{
				return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002596 File Offset: 0x00000796
	private static byte[] smethod_18(global::System.IO.Stream stream_0)
	{
		return ((global::System.IO.MemoryStream)stream_0).ToArray();
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000025A3 File Offset: 0x000007A3
	internal byte[] method_6()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000CE RID: 206 RVA: 0x000025BE File Offset: 0x000007BE
	internal byte[] method_7()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000B65C File Offset: 0x0000985C
	private static void smethod_19(global::System.IO.Stream stream_0)
	{
		using (global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(stream_0))
		{
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 148;
			array2[0] = 99;
			array2[0] = 98;
			array2[0] = 112;
			array2[1] = 185;
			array2[1] = 86;
			array2[1] = 191;
			array2[1] = 59;
			array2[1] = 159;
			array2[2] = 115;
			array2[2] = 168;
			array2[2] = 76;
			array2[2] = 222;
			array2[3] = 90;
			array2[3] = 109;
			array2[3] = 86;
			array2[3] = 175;
			array2[4] = 153;
			array2[4] = 118;
			array2[4] = 227;
			array2[5] = 91;
			array2[5] = 166;
			array2[5] = 126;
			array2[5] = 19;
			array2[5] = 203;
			array2[5] = 125;
			array2[6] = 114;
			array2[6] = 13;
			array2[6] = 34;
			array2[6] = 121;
			array2[6] = 137;
			array2[6] = 187;
			array2[7] = 121;
			array2[7] = 99;
			array2[7] = 97;
			array2[7] = 116;
			array2[7] = 206;
			array2[8] = 116;
			array2[8] = 33;
			array2[8] = 251;
			array2[9] = 134;
			array2[9] = 111;
			array2[9] = 162;
			array2[9] = 135;
			array2[9] = 40;
			array2[10] = 100;
			array2[10] = 238;
			array2[10] = 17;
			array2[11] = 118;
			array2[11] = 109;
			array2[11] = 145;
			array2[11] = 92;
			array2[11] = 90;
			array2[11] = 20;
			array2[12] = 92;
			array2[12] = 77;
			array2[12] = 119;
			array2[13] = 124;
			array2[13] = 117;
			array2[13] = 139;
			array2[13] = 22;
			array2[14] = 56;
			array2[14] = 91;
			array2[14] = 169;
			array2[14] = 73;
			array2[15] = 138;
			array2[15] = 187;
			array2[15] = 163;
			array2[15] = 130;
			array2[15] = 218;
			array2[16] = 146;
			array2[16] = 78;
			array2[16] = 151;
			array2[16] = 168;
			array2[16] = 191;
			array2[17] = 112;
			array2[17] = 84;
			array2[17] = 79;
			array2[17] = 146;
			array2[17] = 66;
			array2[18] = 146;
			array2[18] = 165;
			array2[18] = 133;
			array2[18] = 122;
			array2[19] = 199;
			array2[19] = 124;
			array2[19] = 140;
			array2[19] = 171;
			array2[20] = 148;
			array2[20] = 114;
			array2[20] = 39;
			array2[20] = 128;
			array2[20] = 119;
			array2[21] = 95;
			array2[21] = 129;
			array2[21] = 88;
			array2[21] = 86;
			array2[21] = 99;
			array2[21] = 52;
			array2[22] = 78;
			array2[22] = 104;
			array2[22] = 133;
			array2[22] = 143;
			array2[22] = 97;
			array2[22] = 42;
			array2[23] = 117;
			array2[23] = 128;
			array2[23] = 224;
			array2[24] = 89;
			array2[24] = 88;
			array2[24] = 54;
			array2[24] = 103;
			array2[24] = 41;
			array2[25] = 161;
			array2[25] = 159;
			array2[25] = 16;
			array2[26] = 219;
			array2[26] = 150;
			array2[26] = 150;
			array2[26] = 128;
			array2[26] = 116;
			array2[26] = 153;
			array2[27] = 96;
			array2[27] = 85;
			array2[27] = 60;
			array2[27] = 65;
			array2[28] = 92;
			array2[28] = 139;
			array2[28] = 151;
			array2[28] = 186;
			array2[29] = 219;
			array2[29] = 134;
			array2[29] = 41;
			array2[30] = 130;
			array2[30] = 154;
			array2[30] = 105;
			array2[30] = 82;
			array2[31] = 84;
			array2[31] = 65;
			array2[31] = 108;
			array2[31] = 75;
			array2[31] = 5;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 85;
			array4[0] = 92;
			array4[0] = 112;
			array4[0] = 54;
			array4[1] = 155;
			array4[1] = 92;
			array4[1] = 104;
			array4[1] = 95;
			array4[1] = 148;
			array4[1] = 212;
			array4[2] = 162;
			array4[2] = 103;
			array4[2] = 130;
			array4[2] = 156;
			array4[2] = 164;
			array4[2] = 163;
			array4[3] = 91;
			array4[3] = 81;
			array4[3] = 27;
			array4[4] = 172;
			array4[4] = 77;
			array4[4] = 168;
			array4[5] = 87;
			array4[5] = 141;
			array4[5] = 105;
			array4[6] = 100;
			array4[6] = 134;
			array4[6] = 175;
			array4[6] = 164;
			array4[6] = 247;
			array4[7] = 144;
			array4[7] = 72;
			array4[7] = 164;
			array4[7] = 45;
			array4[8] = 206;
			array4[8] = 137;
			array4[8] = 36;
			array4[9] = 108;
			array4[9] = 155;
			array4[9] = 91;
			array4[9] = 138;
			array4[9] = 241;
			array4[10] = 166;
			array4[10] = 130;
			array4[10] = 195;
			array4[11] = 49;
			array4[11] = 140;
			array4[11] = 90;
			array4[11] = 96;
			array4[11] = 164;
			array4[11] = 38;
			array4[12] = 100;
			array4[12] = 161;
			array4[12] = 118;
			array4[12] = 156;
			array4[12] = 221;
			array4[13] = 131;
			array4[13] = 31;
			array4[13] = 66;
			array4[13] = 128;
			array4[13] = 107;
			array4[14] = 104;
			array4[14] = 25;
			array4[14] = 116;
			array4[14] = 171;
			array4[14] = 185;
			array4[15] = 34;
			array4[15] = 103;
			array4[15] = 69;
			array4[15] = 168;
			array4[15] = 114;
			array4[15] = 184;
			byte[] array5 = array4;
			if (global::EeE.re2.EntryPoint == null)
			{
				global::EeE.Veq = 80;
			}
			global::EeE.Peo = new global::EeE(array3, array5).method_8(array);
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000C23C File Offset: 0x0000A43C
	internal static string smethod_20(int int_0)
	{
		if (global::EeE.Peo.Length == 0)
		{
			global::EeE.Hed = new global::System.Collections.Generic.List<string>();
			global::EeE.UeS = new global::System.Collections.Generic.List<int>();
			global::EeE.smethod_19(typeof(global::EeE).GetTypeInfo().Assembly.GetManifestResourceStream("\u009f7x5m\u008d\u0087\u00939i\u0095\u009d9\u0094\u0091fiw.n\u009cw\u0099\u008b\u0089\u0088\u0092\u009fvtxwphqt\u008f"));
		}
		if (global::EeE.Veq < 75)
		{
			if (global::EeE.re2 != new global::System.Diagnostics.StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new global::System.Exception();
			}
			global::EeE.Veq++;
		}
		object obj = global::EeE.ge3;
		lock (obj)
		{
			int num = global::System.BitConverter.ToInt32(global::EeE.Peo, int_0);
			if (num >= global::EeE.UeS.Count || global::EeE.UeS[num] != int_0)
			{
				try
				{
					byte[] array = new byte[num];
					global::System.Array.Copy(global::EeE.Peo, int_0 + 4, array, 0, num);
					string @string = global::System.Text.Encoding.Unicode.GetString(array, 0, array.Length);
					global::EeE.Hed.Add(@string);
					global::EeE.UeS.Add(int_0);
					global::System.Array.Copy(global::System.BitConverter.GetBytes(global::EeE.Hed.Count - 1), 0, global::EeE.Peo, int_0, 4);
					return @string;
				}
				catch
				{
					goto IL_0137;
				}
			}
			return global::EeE.Hed[num];
		}
		IL_0137:
		return "";
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000025D9 File Offset: 0x000007D9
	private EeE(byte[] byte_0, byte[] byte_1)
	{
		this.mec = byte_0;
		this.weQ = byte_1;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
	private byte[] method_8(byte[] byte_0)
	{
		if (byte_0.Length == 0)
		{
			return new byte[0];
		}
		int num = byte_0.Length % 4;
		int num2 = byte_0.Length / 4;
		byte[] array = new byte[byte_0.Length];
		int num3 = this.mec.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)(((int)this.mec[(int)(num7 + 3U)] << 24) | ((int)this.mec[(int)(num7 + 2U)] << 16) | ((int)this.mec[(int)(num7 + 1U)] << 8) | (int)this.mec[(int)num7]);
			if (i == num2 - 1 && num > 0)
			{
				uint num9 = 0U;
				uint num10 = 255U;
				int num11 = 0;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num9 <<= 8;
					}
					num9 |= (uint)byte_0[byte_0.Length - (1 + j)];
				}
				num4 += num8;
				num4 += this.method_9(num4);
				uint num12 = num4 ^ num9;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num6 + k] = (byte)((num12 & num10) >> num11);
				}
			}
			else
			{
				num7 = (uint)num6;
				uint num9 = (uint)(((int)byte_0[(int)(num7 + 3U)] << 24) | ((int)byte_0[(int)(num7 + 2U)] << 16) | ((int)byte_0[(int)(num7 + 1U)] << 8) | (int)byte_0[(int)num7]);
				num4 += num8;
				num4 += this.method_9(num4);
				uint num13 = num4 ^ num9;
				array[num6] = (byte)(num13 & 255U);
				array[num6 + 1] = (byte)((num13 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num13 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num13 & 4278190080U) >> 24);
			}
		}
		return array;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000C570 File Offset: 0x0000A770
	private uint method_9(uint uint_0)
	{
		uint num = uint_0 ^ (uint_0 << 3);
		num += 3302414041U;
		num ^= num << 11;
		num += 2323220752U;
		num ^= num >> 27;
		num += 1568112929U;
		return 319228767U - num;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
	internal static string smethod_21(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = global::System.Convert.FromBase64String(string_0);
		return global::System.Text.Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000025EF File Offset: 0x000007EF
	private static byte[] smethod_22(byte[] byte_0)
	{
		return new global::EeE(new byte[]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		}, new byte[]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		}).method_8(byte_0);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
	private byte[] method_10()
	{
		return null;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
	private byte[] method_11()
	{
		return null;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002620 File Offset: 0x00000820
	internal static bool smethod_23()
	{
		return null == null;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002626 File Offset: 0x00000826
	internal static object smethod_24()
	{
		return null;
	}

	// Token: 0x04000193 RID: 403
	private static global::System.Collections.Generic.Dictionary<int, int> fe8 = null;

	// Token: 0x04000194 RID: 404
	private static global::System.Security.Cryptography.RSACryptoServiceProvider DeN = null;

	// Token: 0x04000195 RID: 405
	private static global::System.Collections.Generic.List<int> UeS = null;

	// Token: 0x04000196 RID: 406
	private static int Veq = 0;

	// Token: 0x04000197 RID: 407
	private byte[] weQ;

	// Token: 0x04000198 RID: 408
	private static global::System.Collections.Generic.List<string> Hed = null;

	// Token: 0x04000199 RID: 409
	private static bool Kes = false;

	// Token: 0x0400019A RID: 410
	private byte[] mec;

	// Token: 0x0400019B RID: 411
	private static global::System.Reflection.Assembly re2 = typeof(global::EeE).Assembly;

	// Token: 0x0400019C RID: 412
	private static bool meC = false;

	// Token: 0x0400019D RID: 413
	private static object Tep = new object();

	// Token: 0x0400019E RID: 414
	private static uint[] YeV = new uint[]
	{
		3614090360U, 3905402710U, 606105819U, 3250441966U, 4118548399U, 1200080426U, 2821735955U, 4249261313U, 1770035416U, 2336552879U,
		4294925233U, 2304563134U, 1804603682U, 4254626195U, 2792965006U, 1236535329U, 4129170786U, 3225465664U, 643717713U, 3921069994U,
		3593408605U, 38016083U, 3634488961U, 3889429448U, 568446438U, 3275163606U, 4107603335U, 1163531501U, 2850285829U, 4243563512U,
		1735328473U, 2368359562U, 4294588738U, 2272392833U, 1839030562U, 4259657740U, 2763975236U, 1272893353U, 4139469664U, 3200236656U,
		681279174U, 3936430074U, 3572445317U, 76029189U, 3654602809U, 3873151461U, 530742520U, 3299628645U, 4096336452U, 1126891415U,
		2878612391U, 4237533241U, 1700485571U, 2399980690U, 4293915773U, 2240044497U, 1873313359U, 4264355552U, 2734768916U, 1309151649U,
		4149444226U, 3174756917U, 718787259U, 3951481745U
	};

	// Token: 0x0400019F RID: 415
	private static byte[] Peo = new byte[0];

	// Token: 0x040001A0 RID: 416
	private static byte[] bef = new byte[0];

	// Token: 0x040001A1 RID: 417
	private static object ge3 = new object();

	// Token: 0x02000036 RID: 54
	internal class He1
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00002629 File Offset: 0x00000829
		public He1(global::System.IO.Stream stream_0)
		{
			this.Aea = new global::System.IO.BinaryReader(stream_0);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000263D File Offset: 0x0000083D
		internal global::System.IO.Stream method_0()
		{
			return this.Aea.BaseStream;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000264A File Offset: 0x0000084A
		internal byte[] method_1(int int_0)
		{
			return this.Aea.ReadBytes(int_0);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002658 File Offset: 0x00000858
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.Aea.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002668 File Offset: 0x00000868
		internal int method_3()
		{
			return this.Aea.ReadInt32();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002675 File Offset: 0x00000875
		internal void method_4()
		{
			this.Aea.Close();
		}

		// Token: 0x040001A2 RID: 418
		private global::System.IO.BinaryReader Aea;
	}

	// Token: 0x02000037 RID: 55
	// (Invoke) Token: 0x060000E1 RID: 225
	private delegate void Leb(object o);

	// Token: 0x02000038 RID: 56
	internal class PeL
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes(string_0);
			byte[] array = new byte[]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array2 = global::EeE.smethod_6(global::System.Text.Encoding.Unicode.GetBytes(string_1));
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::EeE.smethod_11();
			symmetricAlgorithm.Key = array;
			symmetricAlgorithm.IV = array2;
			global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return global::System.Convert.ToBase64String(memoryStream.ToArray());
		}
	}
}
