using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppBSP.Scripts.Components.WorldItems.Behaviors.Mining.Chests;
using Il2CppBSP.Scripts.Scenes.Mining;
using Il2CppBSP.Scripts.UI.Tooltips.WorldItems;
using MelonLoader;
using UnityEngine;

namespace MKS.Mining
{
	// Token: 0x02000027 RID: 39
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public class fjp
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00009088 File Offset: 0x00007288
		public static global::System.Collections.Generic.List<global::UnityEngine.Transform> Chests()
		{
			global::UnityEngine.Transform transform = global::UnityEngine.GameObject.Find("WorldItemsContainer").transform;
			int childCount = transform.childCount;
			global::System.Collections.Generic.List<global::UnityEngine.Transform> list = new global::System.Collections.Generic.List<global::UnityEngine.Transform>(childCount);
			for (int i = 0; i < childCount; i++)
			{
				global::UnityEngine.Transform child = transform.GetChild(i);
				if ((child.name == "Mining Chest" || child.name == "Mining Big Chest") && child.childCount != 0)
				{
					list.Add(child);
				}
			}
			list.Sort((global::UnityEngine.Transform left, global::UnityEngine.Transform right) => right.position.y.CompareTo(left.position.y));
			return list;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002390 File Offset: 0x00000590
		public static int ChestCount()
		{
			return global::MKS.Mining.fjp.Chests().Count;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009128 File Offset: 0x00007328
		public static string ChestState(int index)
		{
			return global::MKS.Mining.fjp.Chests()[index].GetComponent<global::Il2CppBSP.Scripts.Components.WorldItems.Behaviors.Mining.Chests.WorldItemChestBehavior>().State.ToString();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000239C File Offset: 0x0000059C
		public static global::Il2CppBSP.Scripts.UI.Tooltips.WorldItems.ClaimChestTooltip ChestClaimer(int index)
		{
			return global::MKS.Mining.fjp.Chests()[index].GetComponent<global::Il2CppBSP.Scripts.Components.WorldItems.Behaviors.Mining.Chests.WorldItemChestBehavior>().tooltip;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000915C File Offset: 0x0000735C
		public static void Mine(int index)
		{
			try
			{
				global::Il2CppBSP.Scripts.Scenes.Mining.MiningSceneContext component = global::UnityEngine.GameObject.Find("Scripts").GetComponent<global::Il2CppBSP.Scripts.Scenes.Mining.MiningSceneContext>();
				global::System.Collections.Generic.List<global::UnityEngine.Transform> list = global::MKS.Mining.fjp.Chests();
				if (index <= global::MKS.Mining.fjp.ChestCount())
				{
					int num = (int)list[index].localPosition.y / 16;
					if (list[index].name.Contains("Big"))
					{
						num++;
					}
					component.StartMining((int)list[index].localPosition.x / 16, num, (int)list[index].localPosition.z / 16, 1);
				}
			}
			catch (global::System.Exception ex)
			{
				global::MelonLoader.MelonLogger.Warning(ex);
			}
		}
	}
}
