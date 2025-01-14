using System;
using System.Runtime.CompilerServices;
using Il2CppBSP.Scripts.Components.BlockStars.Renderers;
using Il2CppBSP.Scripts.Scenes;
using UnityEngine;
using UnityEngine.UI;

namespace MKS.Helpers
{
	// Token: 0x0200002E RID: 46
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class HjL
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002309 File Offset: 0x00000509
		public static global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar Pjz()
		{
			return global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().BlockStar;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00009B8C File Offset: 0x00007D8C
		public static string AeB()
		{
			string text;
			try
			{
				text = global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().SceneName;
			}
			catch (global::System.NullReferenceException)
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00009BC4 File Offset: 0x00007DC4
		public static void Accepter()
		{
			try
			{
				if (global::MKS.Helpers.HjL.AeB() == "MiningScene")
				{
					global::MKS.Helpers.HjL.Der = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_mining/floating_voxel_editor_component");
					if (!global::MKS.Helpers.HjL.Der.activeSelf)
					{
						try
						{
							global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Large Dynamite/main_button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
							goto IL_006E;
						}
						catch (global::System.NullReferenceException)
						{
							goto IL_006E;
						}
					}
					global::MKS.Helpers.HjL.Der.transform.Find("button_container/accept_button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
				}
				IL_006E:
				if (global::MKS.Helpers.HjL.AeB() == "LobbyScene")
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_nexus/floating_voxel_editor_component/button_container/accept_button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
				}
				if (global::MKS.Helpers.HjL.AeB() == "ParkourScene")
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_parkour/floating_voxel_editor_component/button_container/accept_button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
				}
				if (global::MKS.Helpers.HjL.AeB() == "ChatScene")
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Hud/Layer - Hud - Viewport/hud_chat/floating_voxel_editor_component/button_container/accept_button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0400016F RID: 367
		private static global::UnityEngine.GameObject Der;
	}
}
