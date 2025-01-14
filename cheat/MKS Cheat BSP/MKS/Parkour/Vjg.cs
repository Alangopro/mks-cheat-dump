using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppCodeStage.AntiCheat.Detectors;
using MKS.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace MKS.Parkour
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class Vjg
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000895C File Offset: 0x00006B5C
		public static void NavigateParkour(string action)
		{
			if (action == "continue" && global::MKS.Parkour.Vjg.TjR <= 3)
			{
				global::MKS.Parkour.Vjg.kjw = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/final_screen/full_container/container_center/continue_button");
				if (!((global::UnityEngine.Object)global::MKS.Parkour.Vjg.kjw == null))
				{
					global::UnityEngine.UI.Button component = global::MKS.Parkour.Vjg.kjw.gameObject.GetComponent<global::UnityEngine.UI.Button>();
					if (!((global::UnityEngine.Object)global::MKS.Parkour.Vjg.kjw == null) && !((global::UnityEngine.Object)component == null))
					{
						global::MKS.Helpers.WeI.je5 = true;
						component.onClick.Invoke();
						global::MKS.Helpers.WeI.je5 = true;
						return;
					}
				}
			}
			else
			{
				if (!(action == "retry"))
				{
					return;
				}
				global::MKS.Parkour.Vjg.Cju = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/game_reward_screen/Container/container_navigation/button_retry");
				if (!((global::UnityEngine.Object)global::MKS.Parkour.Vjg.Cju == null))
				{
					global::UnityEngine.UI.Button component2 = global::MKS.Parkour.Vjg.Cju.gameObject.GetComponent<global::UnityEngine.UI.Button>();
					if (!((global::UnityEngine.Object)global::MKS.Parkour.Vjg.Cju == null) && !((global::UnityEngine.Object)component2 == null))
					{
						global::MKS.Helpers.WeI.je5 = true;
						component2.onClick.Invoke();
						global::MKS.Helpers.WeI.je5 = true;
						global::MKS.Parkour.Vjg.TjR++;
						global::MKS.Parkour.Vjg.cjn = 0;
					}
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008A80 File Offset: 0x00006C80
		public static void SwitchParkour(string name)
		{
			if ((global::MKS.Parkour.Vjg.TjR >= 3 && (global::UnityEngine.Object)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/final_screen/full_container/container_center/continue_button") != null) || global::MKS.Parkour.Vjg.cjn > 800 || global::MKS.Parkour.Vjg.jjY)
			{
				if (name == "parkour_1" && global::MKS.Parkour.Vjg.TjD == 0)
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_1").transform.Find("background").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
					global::MKS.Parkour.Vjg.TjR = 0;
					global::MKS.Parkour.Vjg.TjD = 1;
					global::MKS.Parkour.Vjg.cjn = 0;
					global::MKS.Parkour.Vjg.jjY = false;
					return;
				}
				if (name == "parkour_2" && global::MKS.Parkour.Vjg.TjD == 1)
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_2").transform.Find("background").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
					global::MKS.Parkour.Vjg.TjR = 0;
					global::MKS.Parkour.Vjg.TjD = 2;
					global::MKS.Parkour.Vjg.cjn = 0;
					global::MKS.Parkour.Vjg.jjY = false;
					return;
				}
				if (name == "parkour_3" && global::MKS.Parkour.Vjg.TjD == 2)
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_3").transform.Find("background").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
					global::MKS.Parkour.Vjg.TjR = 0;
					global::MKS.Parkour.Vjg.TjD = 3;
					global::MKS.Parkour.Vjg.cjn = 0;
					global::MKS.Parkour.Vjg.jjY = false;
					return;
				}
				if (name == "parkour_4" && global::MKS.Parkour.Vjg.TjD == 3)
				{
					global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Front/parkour_4").transform.Find("background").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
					global::MKS.Parkour.Vjg.TjR = 0;
					global::MKS.Parkour.Vjg.TjD = 0;
					global::MKS.Parkour.Vjg.cjn = 0;
					global::MKS.Parkour.Vjg.jjY = false;
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008C18 File Offset: 0x00006E18
		public static async void TeleportToMeta()
		{
			if (global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_SPECIALS_PARKOUR_END"))
			{
				try
				{
					global::Il2CppCodeStage.AntiCheat.Detectors.TimeCheatingDetector.StopDetection();
					global::Il2CppCodeStage.AntiCheat.Detectors.TimeCheatingDetector.Dispose();
					global::Il2CppCodeStage.AntiCheat.Detectors.WallHackDetector.StopDetection();
					global::Il2CppCodeStage.AntiCheat.Detectors.WallHackDetector.Dispose();
					global::Il2CppCodeStage.AntiCheat.Detectors.OCD.Destroy();
					global::Il2CppCodeStage.AntiCheat.Detectors.SHD.Destroy();
					global::Il2CppCodeStage.AntiCheat.Detectors.ID.Destroy();
					goto IL_0050;
				}
				catch (global::System.Exception)
				{
					goto IL_0050;
				}
				goto IL_0045;
				IL_0050:
				try
				{
					global::MKS.Parkour.Vjg.hj7 = global::MKS.Xd.mj4;
					global::MKS.Parkour.Vjg.JjZ = int.Parse(global::MKS.Parkour.Vjg.hj7);
					global::MKS.Parkour.Vjg.wjG++;
					if (global::MKS.Parkour.Vjg.wjG > global::MKS.Parkour.Vjg.JjZ * 10)
					{
						if (global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_SPECIALS_PARKOUR_END"))
						{
							global::MKS.Parkour.Vjg.sjO = global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_SPECIALS_PARKOUR_END");
							global::MKS.Parkour.Vjg.JjV = new global::UnityEngine.Vector3(global::MKS.Parkour.Vjg.sjO.transform.position.x, global::MKS.Parkour.Vjg.sjO.transform.position.y + 16f, global::MKS.Parkour.Vjg.sjO.transform.position.z);
							global::MKS.Helpers.WeI.TeleportMe(global::MKS.Parkour.Vjg.JjV, 20);
							while (!global::MKS.Xd.iKb)
							{
								global::System.Runtime.CompilerServices.TaskAwaiter taskAwaiter = global::System.Threading.Tasks.Task.Delay(100).GetAwaiter();
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
						global::MKS.Parkour.Vjg.wjG = 0;
					}
				}
				catch (global::System.Exception)
				{
					global::MKS.Parkour.Vjg.wjG = 0;
				}
				return;
			}
			IL_0045:
			global::MKS.Parkour.Vjg.wjG = 0;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008C48 File Offset: 0x00006E48
		public static void Action()
		{
			global::MKS.Parkour.Vjg.cjn++;
			global::MKS.Parkour.Vjg.NavigateParkour("continue");
			global::MKS.Parkour.Vjg.NavigateParkour("retry");
			global::MKS.Parkour.Vjg.SwitchParkour("parkour_1");
			global::MKS.Parkour.Vjg.SwitchParkour("parkour_2");
			global::MKS.Parkour.Vjg.SwitchParkour("parkour_3");
			global::MKS.Parkour.Vjg.SwitchParkour("parkour_4");
		}

		// Token: 0x0400014B RID: 331
		public static int Qjy;

		// Token: 0x0400014C RID: 332
		public static int TjR;

		// Token: 0x0400014D RID: 333
		public static int TjD;

		// Token: 0x0400014E RID: 334
		public static int cjn;

		// Token: 0x0400014F RID: 335
		public static bool jjY;

		// Token: 0x04000150 RID: 336
		private static global::UnityEngine.GameObject kjw;

		// Token: 0x04000151 RID: 337
		private static global::UnityEngine.GameObject Cju;

		// Token: 0x04000152 RID: 338
		private static int wjG;

		// Token: 0x04000153 RID: 339
		private static global::UnityEngine.GameObject sjO;

		// Token: 0x04000154 RID: 340
		private static bool tj0;

		// Token: 0x04000155 RID: 341
		private static string hj7;

		// Token: 0x04000156 RID: 342
		private static int JjZ;

		// Token: 0x04000157 RID: 343
		private static global::UnityEngine.GameObject JjE;

		// Token: 0x04000158 RID: 344
		private static global::UnityEngine.Vector3 JjV;
	}
}
