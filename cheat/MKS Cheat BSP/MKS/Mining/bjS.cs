using System;
using System.Collections.Generic;
using MelonLoader;
using MKS.Helpers;
using UnityEngine;

namespace MKS.Mining
{
	// Token: 0x0200002B RID: 43
	public class bjS
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00009800 File Offset: 0x00007A00
		public static void TeleportToChest(int index)
		{
			try
			{
				if (index <= global::MKS.Mining.fjp.ChestCount())
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
					float x = list[index].position.x;
					float num = list[index].position.y + 16f;
					float z = list[index].position.z;
					if (list[index].name.Contains("Big"))
					{
						num += 18f;
					}
					global::MKS.Helpers.WeI.TeleportMe(x, num, z, index);
				}
			}
			catch (global::System.IndexOutOfRangeException ex)
			{
				global::MelonLoader.MelonLogger.Warning(ex);
			}
			catch (global::System.NullReferenceException ex2)
			{
				global::MelonLoader.MelonLogger.Warning(ex2);
			}
		}
	}
}
