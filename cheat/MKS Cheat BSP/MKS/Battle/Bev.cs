using System;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppBSP.Scripts.Components.Weapons;

namespace MKS.Battle
{
	// Token: 0x02000033 RID: 51
	[global::HarmonyLib.HarmonyPatch(typeof(global::Il2CppBSP.Scripts.Components.Weapons.Weapon), "ShowFireEffect")]
	public class Bev
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000AC44 File Offset: 0x00008E44
		[global::HarmonyLib.HarmonyPostfix]
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public static void Patch(ref global::Il2CppBSP.Scripts.Components.Weapons.Weapon __instance)
		{
			if (global::MKS.Xd.qjk)
			{
				__instance.Active = true;
				__instance.WeaponData.RemainingFireTime = 0;
				__instance.WeaponData.RemainingReloadTime = 0;
				__instance.WeaponData.FireRate = 0;
			}
		}
	}
}
