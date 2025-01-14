using System;
using System.Collections;
using System.Runtime.CompilerServices;
using MelonLoader;
using UnityEngine;

namespace MKS.Helpers
{
	// Token: 0x02000030 RID: 48
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class WeI
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00009D24 File Offset: 0x00007F24
		public static void TeleportMe(global::UnityEngine.Vector3 pos, int minechest = 20)
		{
			if (global::MKS.Xd.iKb)
			{
				global::MKS.Xd.iKb = false;
				try
				{
					global::MelonLoader.MelonCoroutines.Start(global::MKS.Helpers.WeI.Tweenteleport(pos.x, pos.y, pos.z, minechest));
				}
				catch (global::System.Exception)
				{
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009D74 File Offset: 0x00007F74
		public static void TeleportMe(float x, float y, float z, int minechest = 20)
		{
			if (global::MKS.Xd.iKb)
			{
				global::MKS.Xd.iKb = false;
				try
				{
					global::MelonLoader.MelonCoroutines.Start(global::MKS.Helpers.WeI.Tweenteleport(x, y, z, minechest));
				}
				catch (global::System.Exception)
				{
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000023C3 File Offset: 0x000005C3
		private static global::System.Collections.IEnumerator Tweenteleport(float x, float y, float z, int minechest)
		{
			global::MKS.Helpers.WeI.<Tweenteleport>d__14 <Tweenteleport>d__ = new global::MKS.Helpers.WeI.<Tweenteleport>d__14(0);
			<Tweenteleport>d__.x = x;
			<Tweenteleport>d__.y = y;
			<Tweenteleport>d__.z = z;
			<Tweenteleport>d__.minechest = minechest;
			return <Tweenteleport>d__;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009DB4 File Offset: 0x00007FB4
		public static void MoveMeY(float y)
		{
			try
			{
				global::MKS.Helpers.HjL.Pjz().transform.position += new global::UnityEngine.Vector3(0f, y, 0f);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009E04 File Offset: 0x00008004
		public static void MoveMeX(float x)
		{
			try
			{
				global::MKS.Helpers.HjL.Pjz().transform.position += new global::UnityEngine.Vector3(x, 0f, 0f);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009E54 File Offset: 0x00008054
		public static void MoveMeZ(float z)
		{
			try
			{
				global::MKS.Helpers.HjL.Pjz().transform.position += new global::UnityEngine.Vector3(0f, 0f, z);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x04000170 RID: 368
		public static bool je5 = false;

		// Token: 0x04000171 RID: 369
		private static global::System.Random oem = new global::System.Random();

		// Token: 0x04000172 RID: 370
		private static global::UnityEngine.GameObject xei = new global::UnityEngine.GameObject();

		// Token: 0x04000173 RID: 371
		private static global::UnityEngine.GameObject Qet = new global::UnityEngine.GameObject();

		// Token: 0x04000174 RID: 372
		private static global::UnityEngine.GameObject QeU = new global::UnityEngine.GameObject();

		// Token: 0x04000175 RID: 373
		private static global::UnityEngine.GameObject OeA = new global::UnityEngine.GameObject();

		// Token: 0x04000176 RID: 374
		private static global::UnityEngine.GameObject Wek = new global::UnityEngine.GameObject();

		// Token: 0x04000177 RID: 375
		private static global::UnityEngine.GameObject he4 = new global::UnityEngine.GameObject();

		// Token: 0x04000178 RID: 376
		private static global::UnityEngine.GameObject HeM = new global::UnityEngine.GameObject();

		// Token: 0x04000179 RID: 377
		private static global::UnityEngine.GameObject weh = new global::UnityEngine.GameObject();

		// Token: 0x0400017A RID: 378
		private static global::UnityEngine.GameObject aeJ = new global::UnityEngine.GameObject();

		// Token: 0x0400017B RID: 379
		private static global::UnityEngine.GameObject WeT = new global::UnityEngine.GameObject();
	}
}
