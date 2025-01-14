using System;
using System.Runtime.CompilerServices;
using Il2CppBSP.Scripts.Components.Mining.MiningBot;
using UnityEngine;

namespace MKS.Helpers
{
	// Token: 0x0200002F RID: 47
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public class leK
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public static global::Il2CppBSP.Scripts.Components.Mining.MiningBot.MiningBot Cej()
		{
			global::Il2CppBSP.Scripts.Components.Mining.MiningBot.MiningBot miningBot;
			try
			{
				miningBot = global::UnityEngine.GameObject.Find("scene_layout_prefab/mining_bots").transform.GetChild(0).GetComponent<global::Il2CppBSP.Scripts.Components.Mining.MiningBot.MiningBot>();
			}
			catch
			{
				miningBot = null;
			}
			return miningBot;
		}
	}
}
