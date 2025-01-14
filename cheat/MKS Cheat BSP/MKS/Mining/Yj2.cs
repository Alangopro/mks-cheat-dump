using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppBSP.Scripts.Components.BlockStars.Behaviors.Movement;
using Il2CppBSP.Scripts.Components.Mining.MiningBot;
using Il2CppNebula.Core.UI;
using Il2CppNebula.Core.UI.Popups;
using MelonLoader;
using MKS.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace MKS.Mining
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class Yj2
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00009254 File Offset: 0x00007454
		public static void PinDynamites()
		{
			global::UnityEngine.Vector3 vector;
			vector..ctor(20f, 0f, -750f);
			global::UnityEngine.Vector3 vector2;
			vector2..ctor(223.623f, 0f, -750f);
			try
			{
				global::MKS.Mining.Yj2.djN = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_mining/gadgets_menu/gadgets_menu_container/mining_tools_container/mining_list/ScrollView/Browser Panel");
				global::UnityEngine.Transform transform = global::MKS.Mining.Yj2.djN.transform;
				int childCount = transform.childCount;
				new global::System.Collections.Generic.List<global::UnityEngine.Transform>(childCount);
				for (int i = 0; i < childCount; i++)
				{
					global::UnityEngine.Transform child = transform.GetChild(i);
					if (child.localPosition == vector)
					{
						child.name = "Small Dynamite";
					}
					global::UnityEngine.Transform child2 = transform.GetChild(i);
					if (child2.localPosition == vector2)
					{
						child2.name = "Large Dynamite";
					}
				}
				transform.Find("Small Dynamite").parent = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud").transform;
				transform.Find("Large Dynamite").parent = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud").transform;
				global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_mining/gadgets_menu/gadgets_menu_container/close_button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
			}
			catch (global::System.NullReferenceException)
			{
				global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("Pinning Dynamites", "In order to pin dynamites, you have to open your inventory/backpack first!", "no way", true, null, null, null);
				global::MelonLoader.MelonLogger.Error("In order to pin dynamites, you have to open your inventory/backpack first!");
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000093AC File Offset: 0x000075AC
		public static void OnlinePosition(bool active)
		{
			try
			{
				global::UnityEngine.GameObject.Find("MainRobot").GetComponent<global::Il2CppBSP.Scripts.Components.BlockStars.Behaviors.Movement.BlockStarOnlinePositionBehavior>().Active = active;
			}
			catch (global::System.NullReferenceException)
			{
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000093E4 File Offset: 0x000075E4
		public static void IsStorageFull()
		{
			try
			{
				string value = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_mining/side_control_container/mining_curency_container/currency_display/currency_text").GetComponent<global::Il2CppNebula.Core.UI.TextUI>().GetValue();
				if (value != null)
				{
					int length = value.Length;
					if (length != 6)
					{
						if (length != 7)
						{
							goto IL_025E;
						}
						switch (value[1])
						{
						case '0':
							if (!(value == "10 / 10") && !(value == "20 / 20") && !(value == "30 / 30") && !(value == "40 / 40") && !(value == "50 / 50"))
							{
								goto IL_025E;
							}
							break;
						case '1':
						case '6':
							goto IL_025E;
						case '2':
							if (!(value == "72 / 75"))
							{
								goto IL_025E;
							}
							break;
						case '3':
							if (!(value == "73 / 75"))
							{
								goto IL_025E;
							}
							break;
						case '4':
							if (!(value == "74 / 75"))
							{
								goto IL_025E;
							}
							break;
						case '5':
							if (!(value == "75 / 75"))
							{
								goto IL_025E;
							}
							break;
						case '7':
							if (!(value == "17 / 20") && !(value == "27 / 30") && !(value == "37 / 40") && !(value == "47 / 50"))
							{
								goto IL_025E;
							}
							break;
						case '8':
							if (!(value == "18 / 20") && !(value == "28 / 30") && !(value == "38 / 40"))
							{
								if (!(value == "48 / 50"))
								{
									goto IL_025E;
								}
							}
							break;
						case '9':
							if (!(value == "19 / 20") && !(value == "29 / 30") && !(value == "39 / 40"))
							{
								if (!(value == "49 / 50"))
								{
									goto IL_025E;
								}
							}
							break;
						default:
							goto IL_025E;
						}
					}
					else
					{
						switch (value[0])
						{
						case '7':
							if (!(value == "7 / 10"))
							{
								goto IL_025E;
							}
							break;
						case '8':
							if (!(value == "8 / 10"))
							{
								goto IL_025E;
							}
							break;
						case '9':
							if (!(value == "9 / 10"))
							{
								goto IL_025E;
							}
							break;
						default:
							goto IL_025E;
						}
					}
					if (global::MKS.Mining.Yj2.zjf == 0)
					{
						global::MelonLoader.MelonCoroutines.Start(new global::MKS.Mining.Yj2.<StartExtraction>d__5(0));
						global::MKS.Mining.Yj2.zjf = 1;
					}
				}
				IL_025E:;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000023B3 File Offset: 0x000005B3
		public static global::System.Collections.IEnumerator StartExtraction()
		{
			return new global::MKS.Mining.Yj2.<StartExtraction>d__5(0);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009670 File Offset: 0x00007870
		public static void StopExtraction()
		{
			if (!(global::MKS.Helpers.HjL.AeB() == "MiningScene"))
			{
				return;
			}
			global::MKS.Mining.Yj2.Fjo = global::UnityEngine.GameObject.Find("scene_layout_prefab/mining_bots");
			if (!((global::UnityEngine.Object)global::MKS.Mining.Yj2.Fjo == null))
			{
				global::MKS.Mining.Yj2.Sj3 = global::MKS.Mining.Yj2.Fjo.transform;
				if ((!((global::UnityEngine.Object)global::MKS.Mining.Yj2.Sj3 == null) || global::MKS.Mining.Yj2.Sj3.GetChildCount() == 0) && global::MKS.Mining.Yj2.Sj3.GetChildCount() > 0)
				{
					global::MKS.Mining.Yj2.Xjd = global::MKS.Mining.Yj2.Sj3.GetChild(0);
					if (global::MKS.Mining.Yj2.Xjd.GetComponent<global::Il2CppBSP.Scripts.Components.Mining.MiningBot.MiningBot>().IsExtracting())
					{
						global::MKS.Mining.Yj2.Fjo.transform.GetChild(0).GetComponent<global::Il2CppBSP.Scripts.Components.Mining.MiningBot.MiningBot>().StopExtraction();
						global::MKS.Mining.Yj2.zjf = 0;
					}
				}
				return;
			}
		}

		// Token: 0x04000160 RID: 352
		private static int zjf;

		// Token: 0x04000161 RID: 353
		private static global::UnityEngine.GameObject djN;

		// Token: 0x04000162 RID: 354
		private static global::UnityEngine.GameObject Fjo;

		// Token: 0x04000163 RID: 355
		private static global::UnityEngine.Transform Sj3;

		// Token: 0x04000164 RID: 356
		private static global::UnityEngine.Transform Xjd;
	}
}
