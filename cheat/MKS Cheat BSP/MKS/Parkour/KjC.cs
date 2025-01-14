using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MKS.Parkour
{
	// Token: 0x02000026 RID: 38
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class KjC
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00008ECC File Offset: 0x000070CC
		public static void Pin(string name)
		{
			global::MKS.Parkour.KjC.xjs = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/choice_overlay_view(Clone)/vertical_button_layout/button_layout_row_1/choice_button_3");
			if (!global::MKS.Parkour.KjC.xjs.activeSelf)
			{
				global::MKS.Parkour.KjC.xjs = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/choice_overlay_view(Clone)/vertical_button_layout/button_layout_row_1/choice_button_2");
			}
			global::MKS.Parkour.KjC.xjs.name = name;
			global::MKS.Parkour.KjC.tj8 = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front");
			global::MKS.Parkour.KjC.xjs.transform.parent = global::MKS.Parkour.KjC.tj8.transform;
			if (name == "parkour_1")
			{
				global::MKS.Parkour.KjC.xjs.SetActive(false);
			}
			if (name == "parkour_2")
			{
				global::MKS.Parkour.KjC.xjs.SetActive(false);
			}
			if (name == "parkour_3")
			{
				global::MKS.Parkour.KjC.xjs.SetActive(false);
			}
			if (name == "parkour_4")
			{
				global::MKS.Parkour.KjC.xjs.SetActive(false);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008F98 File Offset: 0x00007198
		public static void Destroy(string name)
		{
			if (name == "parkour_1" || (global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_1") != null)
			{
				global::UnityEngine.Object.Destroy((global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_1"));
			}
			if (name == "parkour_2" || (global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_2") != null)
			{
				global::UnityEngine.Object.Destroy((global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_2"));
			}
			if (name == "parkour_3" || (global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_3") != null)
			{
				global::UnityEngine.Object.Destroy((global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_3"));
			}
			if (name == "parkour_4" || (global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_4") != null)
			{
				global::UnityEngine.Object.Destroy((global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_4"));
			}
		}

		// Token: 0x0400015C RID: 348
		private static global::UnityEngine.GameObject xjs;

		// Token: 0x0400015D RID: 349
		private static global::UnityEngine.GameObject tj8;
	}
}
