using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using HarmonyLib;
using Il2Cpp;
using Il2CppBSP.Scripts.Components.BlockStars.Behaviors.Movement;
using Il2CppBSP.Scripts.Components.BlockStars.Renderers;
using Il2CppBSP.Scripts.Components.Environment;
using Il2CppBSP.Scripts.Components.Managers.Drops;
using Il2CppBSP.Scripts.Components.WorldItems.Behaviors.Gate.Implementations.Key;
using Il2CppBSP.Scripts.Scenes;
using Il2CppBSP.Scripts.Scenes.ArenaEditorScene;
using Il2CppBSP.Scripts.UI.Tooltips.Pets;
using Il2CppBSP.Scripts.UI.Tooltips.SocialItems;
using Il2CppBSP.Scripts.UI.Tooltips.WorldItems;
using Il2CppCinemachine;
using Il2CppCodeStage.AntiCheat.Detectors;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppNebula.Core.UI;
using Il2CppNebula.Core.UI.Popups;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using MelonLoader;
using MKS.Discord;
using MKS.Helpers;
using MKS.Lobby;
using MKS.Mining;
using MKS.Parkour;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MKS
{
	// Token: 0x0200001D RID: 29
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public class Xd : global::MelonLoader.MelonMod
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000032BC File Offset: 0x000014BC
		public override void OnApplicationStart()
		{
			try
			{
				global::System.Console.Clear();
				global::MelonLoader.MelonLogger.Warning("Setting things up...");
				global::MelonLoader.MelonUtils.SetConsoleTitle("MKS Cheats - SETTING UP");
				global::MelonLoader.MelonLogger.Warning("Loaded!");
				global::System.Console.Clear();
				global::MelonLoader.MelonUtils.SetConsoleTitle("BlockStarPlanet - MKS Cheat - V 2.2.4 ");
				global::MelonLoader.MelonLogger.Warning("Welcome to MKS cheats!");
				global::MelonLoader.MelonLogger.Warning("Made by: maicja");
				global::MelonLoader.MelonLogger.Warning("Have fun!");
				global::MelonLoader.MelonLogger.Warning(" ");
				this.HBk = (float)(global::UnityEngine.Screen.height / 50);
				this.HBk = (float)global::UnityEngine.Screen.height - this.HBk;
				this.SB4 = (float)global::UnityEngine.Screen.width;
				global::MelonLoader.MelonLogger.Warning("Press F1 to hide/show menu :P");
				global::MelonLoader.MelonLogger.Warning("\r\nMods saved by config system: \r\nAllow Weapons\r\nWatermark\r\nDiscordRPC\r\nFOV\r\nVSync\r\nFog\r\n\r\nConfigs are saved on changing scenes!");
				if (!global::System.IO.Directory.Exists("c:\\majagejtlejzabijsie"))
				{
					global::MKS.Xd.mjl = false;
				}
				else
				{
					global::MKS.Xd.mjl = true;
					global::MelonLoader.MelonLogger.Warning("DEV MODE ENABLED!");
				}
				this.NBh = "Press F1 to hide GUI | MKS-Cheat 2.2.4      Your license ID:  @CRACKED_BY_KANGAROO_LEAKS";
				global::System.IO.File.ReadAllText("c:\\maicjadir\\MKSBSP\\mks.acc");
				this.jz = new global::HarmonyLib.Harmony("9");
				this.jz.PatchAll();
				global::MelonLoader.MelonLogger.Warning("Loaded Harmony Patches!");
				this.sBU = "Jezeli to czytasz, to jestes cwelem i pedalem";
			}
			catch (global::System.Exception ex)
			{
				if (global::MKS.Xd.mjl)
				{
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003488 File Offset: 0x00001688
		private void EmergencyInjector()
		{
			try
			{
			}
			finally
			{
			}
			try
			{
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000034EC File Offset: 0x000016EC
		private static string CalculateMD5(string filename)
		{
			string text;
			using (global::System.Security.Cryptography.MD5 md = global::System.Security.Cryptography.MD5.Create())
			{
				using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(filename))
				{
					text = global::System.BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return text;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003564 File Offset: 0x00001764
		public override void OnGUI()
		{
			try
			{
				this.HBk = (float)(global::UnityEngine.Screen.height / 50);
				this.HBk = (float)global::UnityEngine.Screen.height - this.HBk;
				this.SB4 = (float)global::UnityEngine.Screen.width;
				if (this.YBJ)
				{
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, this.HBk, this.SB4, 20f), this.NBh);
				}
				if (this.VKQ)
				{
					this.kKa = global::UnityEngine.GUI.Window(0, this.kKa, new global::System.Action<int>(this.DoMyWindow), "MKS-Shit");
					if (global::MKS.Xd.IBT)
					{
						this.qBl.x = this.kKa.x + global::MKS.Xd.QB7;
						this.qBl.y = this.kKa.y;
						this.qBl = global::UnityEngine.GUI.Window(1, this.qBl, new global::System.Action<int>(this.DoMyWindow), "World");
						global::MKS.Xd.QB7 += this.qBl.width;
					}
					if (global::MKS.Xd.YBX)
					{
						this.fBg.x = this.kKa.x + global::MKS.Xd.QB7;
						this.fBg.y = this.kKa.y;
						this.fBg = global::UnityEngine.GUI.Window(2, this.fBg, new global::System.Action<int>(this.DoMyWindow), "Parkour");
						global::MKS.Xd.QB7 += this.fBg.width;
					}
					if (global::MKS.Xd.NB6)
					{
						this.ABy.x = this.kKa.x + global::MKS.Xd.QB7;
						this.ABy.y = this.kKa.y;
						this.ABy = global::UnityEngine.GUI.Window(3, this.ABy, new global::System.Action<int>(this.DoMyWindow), "Mining");
						global::MKS.Xd.QB7 += this.ABy.width;
					}
					if (global::MKS.Xd.KB9)
					{
						this.KBR.x = this.kKa.x + global::MKS.Xd.QB7;
						this.KBR.y = this.kKa.y;
						this.KBR = global::UnityEngine.GUI.Window(4, this.KBR, new global::System.Action<int>(this.DoMyWindow), "Battle");
						global::MKS.Xd.QB7 += this.KBR.width;
					}
					if (global::MKS.Xd.JBx)
					{
						this.WBD.x = this.kKa.x + global::MKS.Xd.QB7;
						this.WBD.y = this.kKa.y;
						this.WBD.width = 360f;
						this.WBD = global::UnityEngine.GUI.Window(5, this.WBD, new global::System.Action<int>(this.DoMyWindow), "Misc");
						global::MKS.Xd.QB7 += this.WBD.width;
					}
					if (global::MKS.Xd.JBv)
					{
						this.aBn.x = this.kKa.x + global::MKS.Xd.QB7;
						this.aBn.y = this.kKa.y;
						this.aBn = global::UnityEngine.GUI.Window(6, this.aBn, new global::System.Action<int>(this.DoMyWindow), "Players");
						this.JBu.x = this.kKa.x + this.aBn.width + global::MKS.Xd.QB7;
						this.JBu.y = this.kKa.y;
						this.JBu = global::UnityEngine.GUI.Window(9, this.JBu, new global::System.Action<int>(this.DoMyWindow), "Teleport");
						global::MKS.Xd.QB7 += 490f;
					}
					if (global::MKS.Xd.qBP)
					{
						this.XBY.x = this.kKa.x + global::MKS.Xd.QB7;
						this.XBY.y = this.kKa.y;
						this.XBY = global::UnityEngine.GUI.Window(7, this.XBY, new global::System.Action<int>(this.DoMyWindow), "Render");
						global::MKS.Xd.QB7 += this.XBY.width;
					}
					if (global::MKS.Xd.rBH)
					{
						this.iBw.x = this.kKa.x + global::MKS.Xd.QB7;
						this.iBw.y = this.kKa.y;
						this.iBw = global::UnityEngine.GUI.Window(8, this.iBw, new global::System.Action<int>(this.DoMyWindow), "Movement");
						global::MKS.Xd.QB7 += this.iBw.width;
					}
					global::MKS.Xd.QB7 = 90f;
				}
				this.YBO = (float)global::UnityEngine.Screen.height;
				this.jB0 = (float)global::UnityEngine.Screen.width;
				if (this.CBE)
				{
					global::MKS.Xd.JKW = global::B0.I8.name;
					float num = this.jB0 / 2f;
					float num2 = this.YBO / 2f;
					global::B0.DrawLine(new global::UnityEngine.Vector2(num, num2 - 10f), new global::UnityEngine.Vector2(num, num2 + 10f), global::UnityEngine.Color.green, 3f);
					global::B0.DrawLine(new global::UnityEngine.Vector2(num - 10f, num2), new global::UnityEngine.Vector2(num + 10f, num2), global::UnityEngine.Color.green, 3f);
				}
				if (this.PKL || this.qa || this.lQ)
				{
					global::MKS.Xd.JKW = global::B0.I8.name;
					foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
					{
						if (!blockStar.IsMe())
						{
							this.aWi = blockStar.transform.position;
							this.GWm = this.aWi;
							this.GWm.y = this.aWi.y + 24f;
							this.aWt = global::UnityEngine.Camera.main.WorldToScreenPoint(this.GWm);
							if (this.aWt.z > 16f)
							{
								this.gW5 = this.aWi;
								this.HWU = global::UnityEngine.Camera.main.WorldToScreenPoint(this.gW5);
								this.gW5.y = this.gW5.y + 24f;
								this.UWA = global::UnityEngine.Camera.main.WorldToScreenPoint(this.gW5);
								if (this.lQ)
								{
									global::B0.DrawLine(new global::UnityEngine.Vector2((float)(global::UnityEngine.Screen.width / 2), this.YBO / 2f), new global::UnityEngine.Vector2(this.aWt.x, this.YBO - this.aWt.y), global::UnityEngine.Color.green, 2f);
								}
								if (this.PKL)
								{
									this.gB1 = this.UWA.y - this.HWU.y;
									this.ABa = 2f;
									this.bBb = this.gB1 / this.ABa;
									this.HWU.y = this.YBO - this.HWU.y;
									global::B0.DrawBox(this.HWU.x - this.bBb / 2f, this.HWU.y - this.gB1, this.bBb, this.gB1, global::UnityEngine.Color.red, 2f);
								}
								if (this.qa)
								{
									global::B0.DrawString(new global::UnityEngine.Vector2(this.aWt.x, this.YBO - this.aWt.y), "<size=16><b>" + blockStar.GameModeData.Name + "</b></size>", global::UnityEngine.Color.white, true);
								}
							}
						}
					}
				}
				if (global::MKS.Xd.djH)
				{
					global::MKS.Xd.JKW = global::B0.I8.name;
					foreach (global::Il2CppBSP.Scripts.Components.WorldItems.Behaviors.Gate.Implementations.Key.WorldItemGateKeyBehavior worldItemGateKeyBehavior in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppBSP.Scripts.Components.WorldItems.Behaviors.Gate.Implementations.Key.WorldItemGateKeyBehavior>())
					{
						this.VBf = worldItemGateKeyBehavior.gameObject.transform.position;
						this.PBN = global::UnityEngine.Camera.main.WorldToScreenPoint(this.VBf);
						if (this.PBN.z > 16f)
						{
							this.lBo = global::UnityEngine.Camera.main.WorldToScreenPoint(this.VBf);
							this.VBf.y = this.VBf.y + 16f;
							this.jB3 = global::UnityEngine.Camera.main.WorldToScreenPoint(this.VBf);
							global::B0.DrawString(new global::UnityEngine.Vector2(this.PBN.x, this.YBO - this.PBN.y - 9f), worldItemGateKeyBehavior.gameObject.name, global::UnityEngine.Color.red, true);
							this.tBd = this.jB3.y - this.lBo.y;
							this.dBS = this.tBd;
							this.lBo.y = this.YBO - this.lBo.y;
							global::B0.DrawBox(this.lBo.x - this.dBS / 2f, this.lBo.y - this.tBd, this.dBS, this.tBd, global::UnityEngine.Color.green, 2f);
						}
					}
				}
				if (global::MKS.Xd.fj9)
				{
					global::MKS.Xd.JKW = global::B0.I8.name;
					if (global::MKS.Helpers.HjL.AeB() == "MiningScene")
					{
						for (int i = 0; i < global::MKS.Mining.fjp.ChestCount(); i++)
						{
							this.JBV = global::MKS.Mining.fjp.Chests()[i].gameObject.transform.position;
							this.NBC = global::UnityEngine.Camera.main.WorldToScreenPoint(this.JBV);
							if (this.NBC.z > 16f)
							{
								this.XBs = global::UnityEngine.Camera.main.WorldToScreenPoint(this.JBV);
								this.JBV.y = this.JBV.y + 16f;
								this.fB8 = global::UnityEngine.Camera.main.WorldToScreenPoint(this.JBV);
								this.mBp = this.fB8.y - this.XBs.y;
								this.NB2 = this.mBp * 1.2f;
								this.XBs.y = this.YBO - this.XBs.y;
								global::B0.DrawBox(this.XBs.x - this.NB2 / 2f, this.XBs.y - this.mBp, this.NB2, this.mBp, global::UnityEngine.Color.yellow, 12f);
							}
						}
					}
				}
				if (this.gBL)
				{
					global::MKS.Xd.JKW = global::B0.I8.name;
					global::MKS.Lobby.Pjq.gj1 = global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().DropsManager.GetDrops();
					foreach (global::Il2CppSystem.Collections.Generic.KeyValuePair<string, global::Il2CppBSP.Scripts.Components.Managers.Drops.DropBase> keyValuePair in global::MKS.Lobby.Pjq.gj1)
					{
						global::MKS.Xd.ABZ = global::UnityEngine.Camera.main.WorldToScreenPoint(keyValuePair.value.transform.position);
						if (global::MKS.Xd.ABZ.z > 0f)
						{
							this.rWr.x = keyValuePair.value.transform.position.x;
							this.rWr.z = keyValuePair.value.transform.position.z;
							this.rWr.y = keyValuePair.value.transform.position.y - 15f;
							this.bWe.x = keyValuePair.value.transform.position.x;
							this.bWe.z = keyValuePair.value.transform.position.z;
							this.bWe.y = keyValuePair.value.transform.position.y + 4f;
							float num3 = 1f;
							float num4 = this.bWe.y - this.rWr.y;
							float num5 = num4 / num3;
							global::B0.DrawString(new global::UnityEngine.Vector2(global::MKS.Xd.ABZ.x, (float)global::UnityEngine.Screen.height - global::MKS.Xd.ABZ.y - 12f), keyValuePair.key.Split('_', global::System.StringSplitOptions.None)[0], global::UnityEngine.Color.magenta, true);
							global::B0.DrawBox(global::MKS.Xd.ABZ.x - num5 / 2f, (float)global::UnityEngine.Screen.height - global::MKS.Xd.ABZ.y - 8f, num5, num4, global::UnityEngine.Color.magenta, 3f);
						}
					}
				}
				if (global::MKS.Xd.QjB && this.VKQ)
				{
					global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(100f, 300f, 500f, 60f), "Tutorial how to conf. autoprk on my discord.\r\n YOU NEED TO BIND 4 PARKOURS BC OF BSP PROTECTION!");
				}
			}
			catch (global::System.Exception)
			{
				if (global::MKS.Xd.fj9 || global::MKS.Xd.djH || this.gBL || this.PKL || this.lQ || this.CBE)
				{
					global::B0.I8 = new global::UnityEngine.Texture2D(1, 1);
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002309 File Offset: 0x00000509
		public static global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar gS()
		{
			return global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().BlockStar;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004300 File Offset: 0x00002500
		private void DoMyWindow(int windowID)
		{
			try
			{
				if (windowID == 0)
				{
					global::MKS.Xd.IBT = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 80f, 20f), global::MKS.Xd.IBT, "World");
					global::MKS.Xd.YBX = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 40f, 80f, 20f), global::MKS.Xd.YBX, "Parkour");
					global::MKS.Xd.NB6 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 60f, 80f, 20f), global::MKS.Xd.NB6, "Mining");
					global::MKS.Xd.KB9 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 80f, 80f, 20f), global::MKS.Xd.KB9, "Battle");
					global::MKS.Xd.rBH = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 100f, 80f, 20f), global::MKS.Xd.rBH, "Movement");
					global::MKS.Xd.JBv = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 120f, 80f, 20f), global::MKS.Xd.JBv, "Teleport");
					global::MKS.Xd.JBx = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 140f, 80f, 20f), global::MKS.Xd.JBx, "Misc");
					global::MKS.Xd.qBP = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 160f, 80f, 20f), global::MKS.Xd.qBP, "Render");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 180f, 110f, 20f), "FPS: " + this.Ic);
					global::UnityEngine.GUI.DragWindow(new global::UnityEngine.Rect(0f, 0f, 10000f, 10000f));
				}
				if (windowID == 1)
				{
					global::MKS.Xd.OKz = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 80f, 20f), global::MKS.Xd.OKz, "Crystals");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 40f, 25f, 20f), "ID:");
					this.CW6 = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(30f, 40f, 55f, 20f), this.CW6);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 60f, 80f, 20f), "Collect"))
					{
						try
						{
							global::MKS.Lobby.Pjq.CrystalsCustomized(int.Parse(this.CW6));
						}
						catch (global::System.Exception ex)
						{
							global::MelonLoader.MelonLogger.Warning(ex);
						}
					}
					global::MKS.Xd.d1 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 80f, 80f, 20f), global::MKS.Xd.d1, "Collect");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 100f, 80f, 20f), "Blacklist:");
					global::MKS.Xd.KWP = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(5f, 120f, 80f, 20f), global::MKS.Xd.KWP);
					this.fji = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 140f, 80f, 20f), this.fji, "Blink");
					global::MKS.Xd.MWO = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 160f, 80f, 20f), global::MKS.Xd.MWO, "NoClip");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 180f, 80f, 20f), "Speedhack"))
					{
						global::UnityEngine.Time.timeScale = ((global::UnityEngine.Time.timeScale > 1f) ? 1f : 5f);
					}
				}
				if (windowID == 2)
				{
					this.Hjr = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 100f, 20f), this.Hjr, "Hotkeys");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 40f, 100f, 20f), "Clear"))
					{
						global::MKS.Parkour.KjC.Destroy("parkour_1");
						global::MKS.Parkour.KjC.Destroy("parkour_2");
						global::MKS.Parkour.KjC.Destroy("parkour_3");
						global::MKS.Parkour.KjC.Destroy("parkour_4");
					}
					global::MKS.Xd.QjB = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 60f, 100f, 20f), global::MKS.Xd.QjB, "Auto Parkour");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 80f, 100f, 20f), "AutoMeta delay:");
					global::MKS.Xd.mj4 = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(5f, 100f, 100f, 20f), global::MKS.Xd.mj4);
					this.RjW = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 120f, 100f, 20f), this.RjW, "Auto Meta");
				}
				if (windowID == 3)
				{
					this.ojK = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 100f, 20f), this.ojK, "Hotkeys");
					this.Fjt = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 40f, 100f, 20f), this.Fjt, "Auto Extract");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 60f, 100f, 20f), "Pin Dynamites"))
					{
						global::MKS.Mining.Yj2.PinDynamites();
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 80f, 100f, 20f), "Extract"))
					{
						global::MelonLoader.MelonCoroutines.Start(global::MKS.Mining.Yj2.StartExtraction());
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 100f, 100f, 20f), "HELP"))
					{
						global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("Mining Hotkeys", "1,2,3,4,5,6,7,8 on keyboard - chest TP\r\nQ, E on keyboard - laser shop and crystals extract\r\nR, F on keyboard - Fly up and down", "Ok!?", true, null, null, null);
					}
					global::MKS.Xd.GWR = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 120f, 100f, 20f), global::MKS.Xd.GWR, "NoMineCancel");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 140f, 100f, 20f), "MineAll"))
					{
						global::MelonLoader.MelonCoroutines.Start(this.mineall());
					}
				}
				if (windowID == 4)
				{
					global::MKS.Xd.qjk = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 120f, 20f), global::MKS.Xd.qjk, "Allow Weapons");
					global::MKS.Xd.Uje = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 40f, 120f, 20f), global::MKS.Xd.Uje, "ANTI-AFK");
					this.nWB = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 60f, 120f, 20f), this.nWB, "Rapid Fire (X)");
					this.zrS = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 80f, 120f, 20f), this.zrS, "TP To Each");
					this.CBE = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 100f, 120f, 20f), this.CBE, "Custom Crosshair");
					if (global::MKS.Xd.mjl && global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 120f, 120f, 20f), "sex mode"))
					{
						global::wH.Yl.Send(global::wH.J6);
					}
				}
				if (windowID == 5)
				{
					this.YBJ = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 110f, 20f), this.YBJ, "Watermark");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 40f, 120f, 20f), "Discord RPC:");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 60f, 110f, 20f), this.frU))
					{
						if (!this.brR)
						{
							this.frU = "WAIT!";
							global::MKS.Discord.aeX.initializediscord(global::MKS.Xd.SKR);
							this.brR = true;
							this.frU = "Turn off";
						}
						else
						{
							this.frU = "WAIT!";
							global::MKS.Discord.aeX.geH.Deinitialize();
							global::MKS.Discord.aeX.geH.Dispose();
							this.brR = false;
							this.frU = "Turn on";
						}
					}
					global::UnityEngine.GUIStyle guistyle = new global::UnityEngine.GUIStyle(global::UnityEngine.GUI.skin.button);
					if (global::UnityEngine.QualitySettings.vSyncCount == 1)
					{
						guistyle.normal.textColor = global::UnityEngine.Color.green;
					}
					else
					{
						guistyle.normal.textColor = global::UnityEngine.Color.red;
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 80f, 110f, 20f), "VSync", guistyle))
					{
						try
						{
							if (global::UnityEngine.QualitySettings.vSyncCount == 1)
							{
								global::UnityEngine.QualitySettings.vSyncCount = 0;
							}
							else
							{
								global::UnityEngine.QualitySettings.vSyncCount = 1;
							}
						}
						catch (global::System.Exception ex2)
						{
							global::MelonLoader.MelonLogger.Error(ex2);
						}
					}
					this.VBB = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 100f, 110f, 20f), this.VBB, "Custom FOV");
					this.eBF = global::UnityEngine.GUI.HorizontalSlider(new global::UnityEngine.Rect(5f, 120f, 90f, 20f), this.eBF, 1f, 150f);
					string text = this.eBF.ToString();
					if (text.Contains(","))
					{
						global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(100f, 120f, 40f, 20f), text.Split(',', global::System.StringSplitOptions.None)[0]);
					}
					else
					{
						global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(100f, 120f, 40f, 20f), text);
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 140f, 110f, 20f), "Billboard"))
					{
						try
						{
							global::MelonLoader.MelonLogger.Msg("HOW TO USE CHANGE BILLBOARD: \r\n put png/jpg file called 'image.png' in c:/maicjadir/MKSBSP/image.png\r\nThen just click buthon and billboard in nexus should change.\r\nDoesn't work? ASK IN DISCORD SERVER!");
							global::UnityEngine.Texture2D texture2D = new global::UnityEngine.Texture2D(1100, 1100);
							global::UnityEngine.ImageConversion.LoadImage(texture2D, global::System.IO.File.ReadAllBytes("C:\\maicjadir\\MKSBSP\\image.png"), false);
							global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/Billboard Plane 6x6/world_item_content_billboard_08_prefab(Clone)/world_item_content_billboard_08_fbx(Clone)/content").GetComponent<global::UnityEngine.MeshRenderer>().material.mainTexture = texture2D;
						}
						catch (global::System.Exception ex3)
						{
							global::MelonLoader.MelonLogger.Error(ex3);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 160f, 110f, 20f), "Texture Pack"))
					{
						try
						{
							global::UnityEngine.Texture2D texture2D2 = new global::UnityEngine.Texture2D(1100, 1100);
							global::UnityEngine.ImageConversion.LoadImage(texture2D2, global::System.IO.File.ReadAllBytes("C:\\maicjadir\\MKSBSP\\image.png"), false);
							foreach (global::UnityEngine.GameObject gameObject in global::UnityEngine.Object.FindObjectsOfType<global::UnityEngine.GameObject>())
							{
								try
								{
									gameObject.GetComponent<global::UnityEngine.MeshRenderer>().material.mainTexture = texture2D2;
								}
								catch (global::System.Exception)
								{
								}
								try
								{
									gameObject.GetComponent<global::UnityEngine.UI.RawImage>().texture = texture2D2;
									gameObject.GetComponent<global::UnityEngine.UI.RawImage>().material.mainTexture = texture2D2;
								}
								catch (global::System.Exception)
								{
								}
								try
								{
									gameObject.GetComponent<global::UnityEngine.UI.Image>().material.mainTexture = texture2D2;
								}
								catch (global::System.Exception)
								{
								}
								try
								{
									gameObject.GetComponent<global::Il2CppNebula.Core.UI.NebulaImage>().material.mainTexture = texture2D2;
								}
								catch (global::System.Exception)
								{
								}
								try
								{
									gameObject.GetComponent<global::Il2CppNebula.Core.UI.ImageUI>().Image.material.mainTexture = texture2D2;
								}
								catch (global::System.Exception)
								{
								}
							}
						}
						catch (global::System.Exception)
						{
						}
					}
					global::MKS.Xd.CWl = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 180f, 110f, 20f), global::MKS.Xd.CWl, "Force English");
					global::MKS.Xd.KWc = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(125f, 20f, 36.6f, 20f), global::MKS.Xd.KWc);
					global::MKS.Xd.eWQ = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(161.6f, 20f, 36.6f, 20f), global::MKS.Xd.eWQ);
					global::MKS.Xd.RW1 = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(198.2f, 20f, 36.6f, 20f), global::MKS.Xd.RW1);
					global::MKS.Xd.lWa = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(125f, 40f, 110f, 20f), global::MKS.Xd.lWa, "RGB Colors");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(125f, 60f, 55f, 20f), "Down"))
					{
						int num = int.Parse(global::MKS.Xd.KWc);
						int num2 = int.Parse(global::MKS.Xd.RW1);
						num -= 7;
						num2 -= 7;
						global::MKS.Xd.KWc = num.ToString();
						global::MKS.Xd.RW1 = num2.ToString();
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(180f, 60f, 55f, 20f), "Left"))
					{
						int num3 = int.Parse(global::MKS.Xd.eWQ);
						global::MKS.Xd.eWQ = (num3 + 7).ToString();
					}
					this.dr2 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(125f, 80f, 110f, 20f), this.dr2, "Auto Claim");
					global::MKS.Xd.HWy = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(125f, 100f, 110f, 20f), global::MKS.Xd.HWy, "Auto Pet");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(125f, 120f, 110f, 20f), "Save Last BStar"))
					{
						try
						{
							global::MKS.Xd.sjX = global::MKS.Xd.ljT;
						}
						catch (global::System.Exception ex4)
						{
							global::MelonLoader.MelonLogger.Error(ex4.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(125f, 140f, 110f, 20f), "Load BStar"))
					{
						try
						{
							global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().BlockStar.Load(global::MKS.Xd.sjX, true);
						}
						catch (global::System.Exception ex5)
						{
							global::MelonLoader.MelonLogger.Error(ex5.Message);
						}
					}
					global::MKS.Xd.Ojv = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(125f, 160f, 110f, 20f), global::MKS.Xd.Ojv, "Fake VIP");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(125f, 180f, 110f, 20f), "Edit World"))
					{
						try
						{
							global::Il2CppBSP.Scripts.Scenes.ArenaEditorScene.ArenaEditorSceneContext.Open(global::MKS.Xd.YjJ, 0);
						}
						catch (global::System.Exception ex6)
						{
							global::MelonLoader.MelonLogger.BigError("World Loading", ex6.Message);
						}
					}
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(245f, 20f, 40f, 20f), "Name:");
					global::MKS.Xd.FWw = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(290f, 20f, 75f, 20f), global::MKS.Xd.FWw);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(245f, 40f, 110f, 20f), "Load World File"))
					{
						try
						{
							global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().Arena.Load(new global::Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<byte>(global::System.IO.File.ReadAllBytes("c:\\maicjadir\\MKSBSP\\" + global::MKS.Xd.FWw)), false);
						}
						catch (global::System.Exception ex7)
						{
							global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("How to use load world?", "First you need to save world with name that you are trying to load", "bro what", true, null, null, null);
							global::MelonLoader.MelonLogger.Error(ex7.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(245f, 60f, 110f, 20f), "Save World File"))
					{
						try
						{
							this.WKg.DownloadFile(global::GR.VD, "c:\\maicjadir\\MKSBSP\\" + global::MKS.Xd.FWw);
						}
						catch (global::System.Exception ex8)
						{
							global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("How to use save world?", "To save world, first join any world, then put world name in \"Name\" textbox and click \"Save World File\"", "bro what", true, null, null, null);
							global::MelonLoader.MelonLogger.Error(ex8.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(245f, 100f, 110f, 20f), "Save Last World"))
					{
						try
						{
							global::MKS.Xd.Kjh = global::MKS.Xd.YjJ;
						}
						catch (global::System.Exception ex9)
						{
							global::MelonLoader.MelonLogger.Error(ex9.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(245f, 120f, 110f, 20f), "Load Saved World"))
					{
						try
						{
							global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().Arena.Load(global::MKS.Xd.Kjh, false, false);
						}
						catch (global::System.Exception ex10)
						{
							global::MelonLoader.MelonLogger.Error(ex10.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(245f, 140f, 75f, 20f), "masscheer"))
					{
						try
						{
							for (int i = 0; i < 10; i++)
							{
								global::wH.KP.Send(global::wH.Nx);
							}
						}
						catch (global::System.Exception ex11)
						{
							global::MelonLoader.MelonLogger.Error(ex11.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(320f, 140f, 35f, 20f), "help"))
					{
						try
						{
							global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("Mass cheer help", "First send 1 mass cheer manually, then you can send 10 cheers by clicking 'mass cheer' button", "ok boomer", false, null, null, null);
						}
						catch (global::System.Exception ex12)
						{
							global::MelonLoader.MelonLogger.Error(ex12.Message);
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(245f, 160f, 110f, 20f), "Last message"))
					{
						try
						{
							global::wH.cv.Send(global::wH.L9);
							global::MelonLoader.MelonLogger.Warning("Sent last message");
						}
						catch (global::System.Exception ex13)
						{
							global::MelonLoader.MelonLogger.Error(ex13.Message);
						}
					}
					this.HWD = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(245f, 180f, 110f, 20f), this.HWD, "Last message");
				}
				if (windowID == 6)
				{
					global::MKS.Xd.pWX = global::UnityEngine.GUILayout.BeginScrollView(global::MKS.Xd.pWX, global::System.Array.Empty<global::UnityEngine.GUILayoutOption>());
					foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
					{
						if (global::UnityEngine.GUILayout.Button(blockStar.GameModeData.Name, null))
						{
							global::MKS.Xd.hWM = blockStar.GameModeData.Name;
							global::MKS.Xd.lWh = blockStar.GameModeData.ActorId.ToString();
							global::MKS.Xd.PWJ = blockStar.GameModeData.BlockStarId.ToString();
							global::MKS.Xd.xWT = blockStar.GameModeData.Level.ToString();
						}
					}
					global::UnityEngine.GUILayout.EndScrollView();
				}
				if (windowID == 9)
				{
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 20f, 250f, 20f), "Name: " + global::MKS.Xd.hWM);
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 40f, 250f, 20f), "ActorID: " + global::MKS.Xd.lWh);
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 60f, 250f, 20f), "BStarID: " + global::MKS.Xd.PWJ);
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 80f, 150f, 20f), "Level: " + global::MKS.Xd.xWT);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 100f, 150f, 20f), "Teleport"))
					{
						global::UnityEngine.Vector3 position;
						position..ctor(0f, 0f, 0f);
						foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar2 in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
						{
							try
							{
								if (blockStar2.GameModeData.Name.Contains(global::MKS.Xd.hWM))
								{
									position = blockStar2.transform.position;
								}
							}
							catch (global::System.Exception)
							{
							}
						}
						if (position != new global::UnityEngine.Vector3(0f, 0f, 0f))
						{
							global::MKS.Helpers.WeI.TeleportMe(position, 20);
						}
					}
					this.arD = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 120f, 150f, 20f), this.arD, "Annoy Player");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 140f, 150f, 20f), "Client-Side:");
					this.Trx = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 160f, 150f, 20f), this.Trx, "Annoy Me");
					this.nrg = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 180f, 150f, 20f), this.nrg, "Annoy Me(all)");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 20f, 60f, 20f), "Player X:");
					global::UnityEngine.Rect rect = new global::UnityEngine.Rect(230f, 20f, 55f, 20f);
					global::UnityEngine.Vector3 vector = global::MKS.Xd.gS().transform.position;
					this.UWn = global::UnityEngine.GUI.TextField(rect, vector.x.ToString());
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 40f, 60f, 20f), "Player Y:");
					global::UnityEngine.Rect rect2 = new global::UnityEngine.Rect(230f, 40f, 55f, 20f);
					vector = global::MKS.Xd.gS().transform.position;
					this.UWn = global::UnityEngine.GUI.TextField(rect2, vector.y.ToString());
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 60f, 60f, 20f), "Player Z:");
					global::UnityEngine.Rect rect3 = new global::UnityEngine.Rect(230f, 60f, 55f, 20f);
					vector = global::MKS.Xd.gS().transform.position;
					this.UWn = global::UnityEngine.GUI.TextField(rect3, vector.z.ToString());
					this.Pr8 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(165f, 80f, 120f, 20f), this.Pr8, "Teleport To XYZ:");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 100f, 60f, 20f), "Player X:");
					this.PBq = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(230f, 100f, 55f, 20f), this.PBq);
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 120f, 60f, 20f), "Player Y:");
					this.lBc = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(230f, 120f, 55f, 20f), this.lBc);
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 140f, 60f, 20f), "Player Z:");
					this.cBQ = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(230f, 140f, 55f, 20f), this.cBQ);
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(165f, 160f, 80f, 20f), "TP Speed:");
					global::MKS.Xd.NWW = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(230f, 160f, 55f, 20f), global::MKS.Xd.NWW);
					global::MKS.Xd.Fb = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(165f, 180f, 120f, 20f), global::MKS.Xd.Fb, "Curve TP");
				}
				if (windowID == 7)
				{
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(5f, 20f, 80f, 20f), "ESP:");
					this.PKL = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 40f, 80f, 20f), this.PKL, "Box");
					this.lQ = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 60f, 80f, 20f), this.lQ, "Tracers");
					this.qa = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 80f, 80f, 20f), this.qa, "Nametags");
					this.gBL = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 100f, 80f, 20f), this.gBL, "Crystals");
					global::MKS.Xd.djH = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 120f, 80f, 20f), global::MKS.Xd.djH, "Keys");
					global::MKS.Xd.fj9 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 140f, 80f, 20f), global::MKS.Xd.fj9, "Chests");
					this.Wrj = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 180f, 80f, 20f), this.Wrj, "Fog");
					global::UnityEngine.GUI.Label(new global::UnityEngine.Rect(90f, 20f, 50f, 20f), "Lobby:");
					global::MKS.Xd.YW7 = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(90f, 40f, 122f, 20f), global::MKS.Xd.YW7);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(217f, 40f, 123f, 20f), "Change XP Text"))
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - ActivityBar/activity_bar_component/activity_content_container/activity_bar_currency_component/top_container/bottom_container/xp_button/xp_display/xp_numbers_text").GetComponent<global::Il2CppNebula.Core.UI.TextUI>().SetValueOverride(global::MKS.Xd.YW7);
					}
					global::MKS.Xd.aWE = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(90f, 60f, 122f, 20f), global::MKS.Xd.aWE);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(217f, 60f, 123f, 20f), "Change Level Text"))
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - ActivityBar/activity_bar_component/activity_content_container/activity_bar_currency_component/top_container/bottom_container/xp_button/xp_display/xp_level_text").GetComponent<global::Il2CppNebula.Core.UI.TextUI>().SetValueOverride(global::MKS.Xd.aWE);
					}
					global::MKS.Xd.hWV = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(90f, 80f, 122f, 20f), global::MKS.Xd.hWV);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(217f, 80f, 123f, 20f), "Change Coins"))
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - ActivityBar/activity_bar_component/activity_content_container/activity_bar_currency_component/top_container/soft_currency_container/coin_button/coin_display/soft_currency_text").GetComponent<global::Il2CppNebula.Core.UI.TextUI>().SetValueOverride(global::MKS.Xd.hWV);
					}
					global::MKS.Xd.LWC = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(90f, 100f, 122f, 20f), global::MKS.Xd.LWC);
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(217f, 100f, 123f, 20f), "Change Diamonds"))
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - ActivityBar/activity_bar_component/activity_content_container/activity_bar_currency_component/top_container/hard_currency_container/diamond_button/diamond_display/hard_currency_text").GetComponent<global::Il2CppNebula.Core.UI.TextUI>().SetValueOverride(global::MKS.Xd.LWC);
					}
					global::MKS.Xd.FWs = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(90f, 120f, 122f, 20f), global::MKS.Xd.FWs);
					this.LWZ = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(217f, 120f, 123f, 20f), this.LWZ, "Chat Bubbles");
					global::MKS.Xd.LW8 = global::UnityEngine.GUI.TextField(new global::UnityEngine.Rect(90f, 160f, 122f, 20f), global::MKS.Xd.LW8);
					global::MKS.Xd.PWp = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(217f, 160f, 123f, 20f), global::MKS.Xd.PWp, "NickHider");
				}
				if (windowID == 8)
				{
					this.SjI = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 20f, 120f, 20f), this.SjI, "Bunny hop");
					this.zj5 = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 40f, 120f, 20f), this.zj5, "Spinning");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 60f, 120f, 20f), "Inf Jump(255)"))
					{
						global::MKS.Helpers.HjL.Pjz().GetComponent<global::Il2CppBSP.Scripts.Components.BlockStars.Behaviors.Movement.BlockStarInputJumpBehavior>().maxJumpCount = byte.MaxValue;
					}
					global::MKS.Xd.urt = global::UnityEngine.GUI.Toggle(new global::UnityEngine.Rect(5f, 80f, 120f, 20f), global::MKS.Xd.urt, "Fly(space,shift)");
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 100f, 120f, 20f), this.srA))
					{
						try
						{
							if (this.frk)
							{
								global::MKS.Helpers.WeI.TeleportMe(global::MKS.Xd.Qrn, 20);
								this.srA = "Yellow key";
								this.frk = false;
							}
							else
							{
								global::MKS.Xd.Qrn = global::UnityEngine.GameObject.Find("MainRobot").transform.position;
								this.OWz = global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_YELLOW_KEY");
								global::MKS.Helpers.WeI.TeleportMe(this.OWz.transform.position, 20);
								this.srA = "Go back";
								this.frk = true;
							}
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 120f, 120f, 20f), this.mr4))
					{
						try
						{
							if (this.CrM)
							{
								global::MKS.Helpers.WeI.TeleportMe(global::MKS.Xd.Qrn, 20);
								this.mr4 = "Purple key";
								this.CrM = false;
							}
							else
							{
								global::MKS.Xd.Qrn = global::UnityEngine.GameObject.Find("MainRobot").transform.position;
								this.OWz = global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_PURPLE_KEY");
								global::MKS.Helpers.WeI.TeleportMe(this.OWz.transform.position, 20);
								this.mr4 = "Go back";
								this.CrM = true;
							}
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 140f, 120f, 20f), this.irh))
					{
						try
						{
							if (!this.Vrv)
							{
								global::MKS.Xd.Qrn = global::UnityEngine.GameObject.Find("MainRobot").transform.position;
								this.OWz = global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_RED_KEY");
								global::MKS.Helpers.WeI.TeleportMe(this.OWz.transform.position, 20);
								this.irh = "Go back";
								this.Vrv = true;
							}
							else
							{
								global::MKS.Helpers.WeI.TeleportMe(global::MKS.Xd.Qrn, 20);
								this.irh = "Red key";
								this.Vrv = false;
							}
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 160f, 120f, 20f), this.VrT))
					{
						try
						{
							if (!this.hrJ)
							{
								global::MKS.Xd.Qrn = global::UnityEngine.GameObject.Find("MainRobot").transform.position;
								this.OWz = global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_BLUE_KEY");
								global::MKS.Helpers.WeI.TeleportMe(this.OWz.transform.position, 20);
								this.VrT = "Go back";
								this.hrJ = true;
							}
							else
							{
								global::MKS.Helpers.WeI.TeleportMe(global::MKS.Xd.Qrn, 20);
								this.VrT = "Blue key";
								this.hrJ = false;
							}
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 180f, 120f, 20f), this.Hr9))
					{
						try
						{
							if (!this.OrX)
							{
								global::MKS.Xd.Qrn = global::UnityEngine.GameObject.Find("MainRobot").transform.position;
								this.OWz = global::UnityEngine.GameObject.Find("scene_layout_prefab/WorldRenderer/WorldItemsContainer/RB_WORLD_GREEN_KEY");
								global::MKS.Helpers.WeI.TeleportMe(this.OWz.transform.position, 20);
								this.Hr9 = "Go back";
								this.OrX = true;
							}
							else
							{
								global::MKS.Helpers.WeI.TeleportMe(global::MKS.Xd.Qrn, 20);
								this.Hr9 = "Green key";
								this.OrX = false;
							}
						}
						catch (global::System.Exception)
						{
						}
					}
				}
				if (windowID == 10 && global::UnityEngine.GUI.Button(new global::UnityEngine.Rect(5f, 20f, 100f, 20f), "MineAll"))
				{
					global::MelonLoader.MelonCoroutines.Start(this.mineall());
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002315 File Offset: 0x00000515
		private global::System.Collections.IEnumerator mineall()
		{
			return new global::MKS.Xd.<mineall>d__91(0);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000231D File Offset: 0x0000051D
		private global::System.Collections.IEnumerator buttonlajk()
		{
			try
			{
				this.Qrs = global::UnityEngine.GameObject.Find("freelook_third_person_camera").GetComponent<global::Il2CppCinemachine.CinemachineVirtualCamera>().m_Lens;
				this.Qrs.FieldOfView = this.eBF;
				global::UnityEngine.GameObject.Find("freelook_third_person_camera").GetComponent<global::Il2CppCinemachine.CinemachineVirtualCamera>().m_Lens = this.Qrs;
			}
			catch (global::System.Exception)
			{
			}
			try
			{
				this.Qrs = global::UnityEngine.GameObject.Find("first_person_camera").GetComponent<global::Il2CppCinemachine.CinemachineVirtualCamera>().m_Lens;
				this.Qrs.FieldOfView = this.eBF;
				global::UnityEngine.GameObject.Find("first_person_camera").GetComponent<global::Il2CppCinemachine.CinemachineVirtualCamera>().m_Lens = this.Qrs;
			}
			catch (global::System.Exception)
			{
			}
			try
			{
				this.Qrs = global::UnityEngine.GameObject.Find("third_person_camera").GetComponent<global::Il2CppCinemachine.CinemachineVirtualCamera>().m_Lens;
				this.Qrs.FieldOfView = this.eBF;
				global::UnityEngine.GameObject.Find("third_person_camera").GetComponent<global::Il2CppCinemachine.CinemachineVirtualCamera>().m_Lens = this.Qrs;
			}
			catch (global::System.Exception)
			{
			}
			yield return new global::UnityEngine.WaitForSeconds(1f);
			int num;
			if (num != 1)
			{
				yield break;
			}
			this.NBt = false;
			yield break;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000232C File Offset: 0x0000052C
		private global::System.Collections.IEnumerator HandleEachTP()
		{
			foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
			{
				this.GrG = 0;
				while (this.GrG < 15)
				{
					if (global::UnityEngine.GameObject.Find("MainRobot"))
					{
						try
						{
							global::MKS.Helpers.WeI.TeleportMe(blockStar.transform.position, 20);
						}
						catch (global::System.Exception)
						{
						}
						yield return new global::UnityEngine.WaitForSeconds(0.1f);
					}
					this.GrG++;
				}
				blockStar = null;
			}
			global::Il2CppSystem.Collections.Generic.List<global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar>.Enumerator enumerator = null;
			this.br7 = false;
			yield break;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022E8 File Offset: 0x000004E8
		public override void OnLateUpdate()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000063E4 File Offset: 0x000045E4
		public override void OnUpdate()
		{
			if (global::MKS.Xd.GWR)
			{
				try
				{
					if (global::MKS.Xd.gS().GameModeData.Health < 1)
					{
						if (this.mrN == 0)
						{
							global::wH.KP.Send(global::wH.ag);
							this.mrN++;
						}
					}
					else
					{
						this.mrN = 0;
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			if ((this.cKn == 0 || this.cKn == 2) && global::UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "LobbyScene")
			{
				if (this.cKn == 0)
				{
					this.cKn = 1;
				}
				else
				{
					global::MKS.Xd.NKD = true;
					global::UnityEngine.GUIUtility.systemCopyBuffer = global::MKS.Xd.KKy;
					global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open(global::MKS.Xd.KKZ, global::MKS.Xd.QKE, global::MKS.Xd.EKV + ".", false, null, null, null);
					base.Unregister(global::MKS.Xd.nBA, false);
				}
			}
			this.Ic = (1f / global::UnityEngine.Time.unscaledDeltaTime).ToString();
			if (!global::MKS.Xd.CWl)
			{
				this.arf = false;
			}
			else if (!this.arf)
			{
				global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("Relog required!", "To change game language, you need to relog.", "Ok?!", false, null, null, null);
				this.arf = true;
			}
			if (!this.Wrj)
			{
				global::Il2CppBSP.Scripts.Components.Environment.Fog.Enabled = false;
			}
			else
			{
				global::Il2CppBSP.Scripts.Components.Environment.Fog.Enabled = true;
			}
			if (this.Pr8)
			{
				global::MKS.Helpers.WeI.TeleportMe(new global::UnityEngine.Vector3((float)int.Parse(this.PBq), (float)int.Parse(this.lBc), (float)int.Parse(this.cBQ)), 20);
			}
			if (this.dr2)
			{
				try
				{
					foreach (global::Il2CppBSP.Scripts.UI.Tooltips.SocialItems.SocialItemTooltipBase socialItemTooltipBase in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppBSP.Scripts.UI.Tooltips.SocialItems.SocialItemTooltipBase>())
					{
						string localizeKey = socialItemTooltipBase.localizeKey;
						if (!(localizeKey == "RB_PLAY") && !(localizeKey == "RB_SHOW_PHOTO"))
						{
							global::UnityEngine.UI.Button.ButtonClickedEvent onClick = socialItemTooltipBase.button.Button.onClick;
							for (int i = 0; i < 20; i++)
							{
								onClick.Invoke();
							}
						}
					}
					foreach (global::Il2CppBSP.Scripts.UI.Tooltips.WorldItems.ClaimChestTooltip claimChestTooltip in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppBSP.Scripts.UI.Tooltips.WorldItems.ClaimChestTooltip>())
					{
						global::UnityEngine.UI.Button.ButtonClickedEvent onClick2 = claimChestTooltip.button.Button.onClick;
						for (int j = 0; j < 100; j++)
						{
							onClick2.Invoke();
						}
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			if (global::MKS.Xd.HWy)
			{
				try
				{
					foreach (global::Il2CppBSP.Scripts.UI.Tooltips.Pets.PetOthersNameTooltip petOthersNameTooltip in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppBSP.Scripts.UI.Tooltips.Pets.PetOthersNameTooltip>())
					{
						global::UnityEngine.UI.Button.ButtonClickedEvent onClick3 = petOthersNameTooltip.button.Button.onClick;
						for (int k = 0; k < 20; k++)
						{
							onClick3.Invoke();
						}
					}
					foreach (global::Il2CppBSP.Scripts.UI.Tooltips.Pets.ClickablePetNameTooltip clickablePetNameTooltip in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppBSP.Scripts.UI.Tooltips.Pets.ClickablePetNameTooltip>())
					{
						global::UnityEngine.UI.Button.ButtonClickedEvent onClick4 = clickablePetNameTooltip.button.Button.onClick;
						for (int l = 0; l < 20; l++)
						{
							onClick4.Invoke();
						}
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			if (global::MKS.Xd.qjk)
			{
				try
				{
					global::MKS.Xd.gS().EnableWeapons = true;
					global::MKS.Xd.gS().enableWeapons = true;
					global::MKS.Xd.gS().canLoadWeapon = true;
				}
				catch (global::System.Exception)
				{
				}
			}
			if (this.VBB && !this.NBt)
			{
				this.NBt = true;
				global::MelonLoader.MelonCoroutines.Start(this.buttonlajk());
			}
			try
			{
				if (global::MKS.Xd.PWp)
				{
					foreach (global::Il2CppTMPro.TextMeshProUGUI textMeshProUGUI in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppTMPro.TextMeshProUGUI>())
					{
						textMeshProUGUI.text = textMeshProUGUI.text.Replace(global::MKS.Xd.gS().GameModeData.Name, global::MKS.Xd.LW8);
					}
				}
				if (global::MKS.Xd.d1)
				{
					global::MKS.Lobby.Pjq.CrystalsCustomized(int.Parse(this.CW6));
				}
				if (this.HWD)
				{
					if (this.hKh > 0.2f)
					{
						global::wH.cv.Send(global::wH.L9);
						global::MelonLoader.MelonLogger.Warning("Sent nexus message");
						this.hKh = 0f;
					}
					else
					{
						this.hKh += 1.1f * global::UnityEngine.Time.deltaTime;
					}
				}
				if (this.VKQ)
				{
					this.NBh = "Press F1 to hide GUI | MKS-Cheat 2.2.4      Your license ID: " + global::UnityEngine.SystemInfo.deviceUniqueIdentifier;
				}
				else
				{
					this.NBh = "Press F1 to show GUI | MKS-Cheat 2.2.4      Your license ID: " + global::UnityEngine.SystemInfo.deviceUniqueIdentifier;
				}
				if (this.zrS && !this.br7)
				{
					this.br7 = true;
					global::MelonLoader.MelonCoroutines.Start(this.HandleEachTP());
				}
				if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/ugc_popup/popup_container/container_center/right_container/button_clone"))
				{
					try
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/ugc_popup/popup_container/container_center/right_container/button_clone").SetActive(true);
					}
					catch (global::System.Exception)
					{
					}
				}
				if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container/edit_button"))
				{
					try
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container/edit_button").SetActive(true);
					}
					catch (global::System.Exception)
					{
					}
				}
				if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/ugc_popup/popup_container/container_center/right_container/button_edit"))
				{
					try
					{
						global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/ugc_popup/popup_container/container_center/right_container/button_edit").SetActive(true);
					}
					catch (global::System.Exception)
					{
					}
				}
				if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup"))
				{
					if (this.mrC = global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/player_container/button_friend_ask"))
					{
						try
						{
							this.mrC.SetActive(true);
							this.mrC.transform.position = new global::UnityEngine.Vector3(2.16f, -2.456f, -9f);
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container/cheer_button"))
					{
						try
						{
							global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container/cheer_button").SetActive(true);
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container"))
					{
						try
						{
							global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container").SetActive(true);
						}
						catch (global::System.Exception)
						{
						}
					}
					if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container/chat_button"))
					{
						try
						{
							global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/player_popup/container_popup/actions_container/chat_button").SetActive(true);
						}
						catch (global::System.Exception)
						{
						}
					}
				}
				if (global::UnityEngine.Input.GetKeyDown(282))
				{
					this.VKQ = !this.VKQ;
				}
				if (global::MKS.Xd.OKz)
				{
					global::MKS.Lobby.Pjq.CrystalsBypassed();
					if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Critical/generic_info_popup/confirm_button"))
					{
						((global::UnityEngine.UI.Button)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Critical/generic_info_popup/confirm_button").GetComponent<global::UnityEngine.UI.Button>()).onClick.Invoke();
					}
				}
				if (this.ojK)
				{
					for (int m = 0; m <= global::MKS.Mining.fjp.ChestCount(); m++)
					{
						if (global::UnityEngine.Input.GetKeyDown(m + 49))
						{
							global::MKS.Mining.bjS.TeleportToChest(m);
						}
					}
				}
				if (this.ojK)
				{
					if (global::UnityEngine.Input.GetKey(114))
					{
						global::MKS.Helpers.WeI.MoveMeY(24f);
					}
					else if (global::UnityEngine.Input.GetKey(102))
					{
						global::MKS.Helpers.WeI.MoveMeY(-24f);
					}
					else if (!global::UnityEngine.Input.GetKey(327))
					{
						if (!global::UnityEngine.Input.GetKey(326))
						{
							if (global::UnityEngine.Input.GetKeyDown(113))
							{
								global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Tooltips/Layer - Tooltips - Viewport/social_item_tooltip/button").GetComponent<global::UnityEngine.UI.Button>().onClick.Invoke();
							}
							else if (global::UnityEngine.Input.GetKeyDown(101))
							{
								global::MelonLoader.MelonCoroutines.Start(global::MKS.Mining.Yj2.StartExtraction());
							}
						}
						else
						{
							global::MKS.Helpers.WeI.TeleportMe(500f, 200f, 500f, 20);
						}
					}
					else
					{
						global::MKS.Helpers.WeI.TeleportMe(500f, 2000f, 500f, 20);
					}
				}
				global::MKS.Mining.Yj2.OnlinePosition(!this.fji);
				if (global::UnityEngine.Input.GetKeyDown(304))
				{
					global::MKS.Helpers.HjL.Accepter();
				}
				if (this.Fjt && global::MKS.Xd.SKR == "MiningScene")
				{
					global::MKS.Mining.Yj2.IsStorageFull();
				}
				if (this.Hjr)
				{
					if (global::UnityEngine.Input.GetKeyDown(49))
					{
						global::MKS.Parkour.KjC.Pin("parkour_1");
					}
					else if (global::UnityEngine.Input.GetKeyDown(50))
					{
						global::MKS.Parkour.KjC.Pin("parkour_2");
					}
					else if (!global::UnityEngine.Input.GetKeyDown(51))
					{
						if (global::UnityEngine.Input.GetKeyDown(52))
						{
							global::MKS.Parkour.KjC.Pin("parkour_4");
						}
					}
					else
					{
						global::MKS.Parkour.KjC.Pin("parkour_3");
					}
				}
				if (global::MKS.Xd.QjB)
				{
					global::MKS.Parkour.Vjg.Action();
					if (global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Critical/generic_info_popup/confirm_button"))
					{
						((global::UnityEngine.UI.Button)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Critical/generic_info_popup/confirm_button").GetComponent<global::UnityEngine.UI.Button>()).onClick.Invoke();
					}
				}
				else if (!global::MKS.Xd.QjB)
				{
					global::MKS.Parkour.Vjg.jjY = true;
				}
				if (this.SjI && !this.JKc)
				{
					this.JKc = true;
					global::MKS.Helpers.WeI.MoveMeY(1f);
					global::UnityEngine.Time.timeScale = 1.5f;
				}
				else if (this.JKc)
				{
					global::UnityEngine.Time.timeScale = 1f;
					this.JKc = false;
				}
				if (this.zj5)
				{
					if (this.wK8 == 1)
					{
						global::MKS.Helpers.WeI.MoveMeX(6f);
						this.zKN++;
						if (this.zKN == 6)
						{
							this.wK8 = 0;
							this.PKp = 1;
						}
					}
					if (this.PKp == 1)
					{
						global::MKS.Helpers.WeI.MoveMeZ(6f);
						this.zKN++;
						if (this.zKN == 12)
						{
							this.PKp = 0;
							this.NK2 = 1;
						}
					}
					if (this.NK2 == 1)
					{
						global::MKS.Helpers.WeI.MoveMeX(-6f);
						this.zKN++;
						if (this.zKN == 18)
						{
							this.NK2 = 0;
							this.YKf = 1;
						}
					}
					if (this.YKf == 1)
					{
						global::MKS.Helpers.WeI.MoveMeZ(-6f);
						this.zKN++;
						if (this.zKN == 24)
						{
							this.YKf = 0;
							this.wK8 = 1;
							this.zKN = 0;
						}
					}
				}
				if (this.KjF)
				{
					if (global::UnityEngine.Input.GetKey(119))
					{
						global::MKS.Helpers.WeI.MoveMeZ(8f);
					}
					if (global::UnityEngine.Input.GetKey(115))
					{
						global::MKS.Helpers.WeI.MoveMeZ(-8f);
					}
					if (global::UnityEngine.Input.GetKey(97))
					{
						global::MKS.Helpers.WeI.MoveMeX(-8f);
					}
					if (global::UnityEngine.Input.GetKey(100))
					{
						global::MKS.Helpers.WeI.MoveMeX(8f);
					}
				}
				if (global::MKS.Xd.Uje)
				{
					global::MKS.Helpers.WeI.MoveMeY(3f);
					if (this.PKo == 1)
					{
						global::MKS.Helpers.WeI.MoveMeX(2f);
						this.mKq++;
						if (this.mKq == 12)
						{
							this.PKo = 0;
							this.MK3 = 1;
						}
					}
					if (this.MK3 == 1)
					{
						global::MKS.Helpers.WeI.MoveMeZ(2f);
						this.mKq++;
						if (this.mKq == 24)
						{
							this.MK3 = 0;
							this.QKd = 1;
						}
					}
					if (this.QKd == 1)
					{
						global::MKS.Helpers.WeI.MoveMeX(-2f);
						this.mKq++;
						if (this.mKq == 36)
						{
							this.QKd = 0;
							this.SKS = 1;
						}
					}
					if (this.SKS == 1)
					{
						global::MKS.Helpers.WeI.MoveMeZ(-2f);
						this.mKq++;
						if (this.mKq == 48)
						{
							this.SKS = 0;
							this.PKo = 1;
							this.mKq = 0;
						}
					}
				}
				if (this.arD)
				{
					global::UnityEngine.Vector3 position;
					position..ctor(0f, 0f, 0f);
					foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
					{
						if (blockStar.GameModeData.Name.Contains(global::MKS.Xd.hWM))
						{
							position = blockStar.transform.position;
						}
					}
					if (position != new global::UnityEngine.Vector3(0f, 0f, 0f))
					{
						global::MKS.Helpers.WeI.TeleportMe(position, 20);
					}
				}
				if (this.Trx)
				{
					foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar2 in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
					{
						if (blockStar2.GameModeData.Name.Contains(global::MKS.Xd.hWM))
						{
							blockStar2.transform.position = global::MKS.Helpers.HjL.Pjz().transform.position;
						}
					}
				}
				if (this.nrg)
				{
					foreach (global::Il2CppBSP.Scripts.Components.BlockStars.Renderers.BlockStar blockStar3 in global::Il2CppBSP.Scripts.Scenes.BspSceneContext.Current().GameData.BlockStars)
					{
						blockStar3.transform.position = global::MKS.Helpers.HjL.Pjz().transform.position;
					}
				}
				if (this.UKA)
				{
					if (this.dKs != 100)
					{
						this.dKs++;
						try
						{
							((global::UnityEngine.UI.Button)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/crafting_browser/Container/ItemList/ScrollView/Browser Panel/CollectiblesRedeemItemRenderer/collectable_container/craft_instant_button").GetComponent<global::UnityEngine.UI.Button>()).onClick.Invoke();
							global::MelonLoader.MelonLogger.Warning("CLICKED!");
							goto IL_0C7F;
						}
						catch (global::System.Exception ex)
						{
							string text = "EXCEPTON DESTROYING...\r\n";
							global::System.Exception ex2 = ex;
							global::MelonLoader.MelonLogger.Warning(text + ((ex2 == null) ? null : ex2.ToString()));
							global::UnityEngine.Object.Destroy(global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/crafting_browser/Container/ItemList/ScrollView/Browser Panel/CollectiblesRedeemItemRenderer/collectable_container/craft_instant_button"));
							global::MelonLoader.MelonLogger.Warning("DESTROYED!");
							this.UKA = false;
							((global::UnityEngine.UI.Button)global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/crafting_browser/top_bar_component/BackButtonContainer/BackButton").GetComponent<global::UnityEngine.UI.Button>()).onClick.Invoke();
							this.FK5 = true;
							goto IL_0C7F;
						}
					}
					this.dKs = 0;
					global::UnityEngine.Object.Destroy(global::UnityEngine.GameObject.Find("RootCanvas/RootContainer/Layer - Back/Layer - Back - Viewport/crafting_browser/Container/ItemList/ScrollView/Browser Panel/CollectiblesRedeemItemRenderer/collectable_container/craft_instant_button"));
				}
				IL_0C7F:
				if (this.RjW)
				{
					global::MKS.Parkour.Vjg.TeleportToMeta();
				}
				if (global::MKS.Xd.urt)
				{
					try
					{
						this.brP = global::MKS.Xd.gS().transform.position;
						if (this.prb)
						{
							this.prb = false;
							this.fra = this.brP.y;
						}
						if (global::UnityEngine.Input.GetKey(32))
						{
							this.fra += 2f;
						}
						else if (global::UnityEngine.Input.GetKey(304))
						{
							this.fra -= 2f;
						}
						global::MKS.Xd.gS().transform.position = new global::UnityEngine.Vector3(this.brP.x, this.fra, this.brP.z);
						goto IL_0D42;
					}
					catch (global::System.Exception)
					{
						goto IL_0D42;
					}
				}
				this.prb = true;
				IL_0D42:
				if (this.LWZ)
				{
					try
					{
						foreach (global::Il2CppNebula.Core.UI.TextBubbleUI textBubbleUI in global::UnityEngine.Object.FindObjectsOfType<global::Il2CppNebula.Core.UI.TextBubbleUI>())
						{
							textBubbleUI.Text.SetValueOverride(global::MKS.Xd.FWs);
						}
					}
					catch (global::System.Exception)
					{
					}
				}
				if (this.nWB && global::UnityEngine.Input.GetKey(120))
				{
					if (this.zKM > 0.2f)
					{
						global::MKS.Xd.gS().Weapon.ShowFireEffect();
						this.zKM = 0f;
					}
					else
					{
						this.zKM += 1f * global::UnityEngine.Time.deltaTime;
					}
				}
				if (!global::MKS.Xd.MWO)
				{
					global::MKS.Xd.gS().GetComponent<global::UnityEngine.Rigidbody>().isKinematic = false;
					global::UnityEngine.Object.FindObjectOfType<global::Il2CppCinemachine.CinemachineExtension>().enabled = true;
				}
				else
				{
					global::MKS.Xd.gS().GetComponent<global::UnityEngine.Rigidbody>().isKinematic = true;
					global::UnityEngine.Object.FindObjectOfType<global::Il2CppCinemachine.CinemachineExtension>().enabled = false;
					global::UnityEngine.Transform transform = global::MKS.Xd.gS().transform;
					global::UnityEngine.Vector3 vector = global::UnityEngine.Input.GetAxis("Vertical") * global::UnityEngine.Camera.main.transform.forward * global::UnityEngine.Time.deltaTime * 9f + global::UnityEngine.Input.GetAxis("Horizontal") * global::UnityEngine.Camera.main.transform.right * global::UnityEngine.Time.deltaTime * 9f;
					vector.x *= 64f;
					vector.y *= 64f;
					vector.z *= 64f;
					transform.position += vector;
				}
				if (this.Fro)
				{
					global::MKS.Xd.trd = global::MKS.Xd.gS().transform.rotation;
					global::MKS.Xd.gS().transform.Rotate(this.Cr3 * global::UnityEngine.Time.deltaTime);
					global::MKS.Xd.gS().transform.rotation = global::MKS.Xd.trd * global::MKS.Xd.gS().transform.rotation;
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000752C File Offset: 0x0000572C
		public static string check(string key)
		{
			if (global::System.Diagnostics.Process.GetProcesses().Any((global::System.Diagnostics.Process p) => p.ProcessName.Equals(global::MKS.Xd.hWk, global::System.StringComparison.OrdinalIgnoreCase)))
			{
				return global::EeE.smethod_20(350);
			}
			if (!global::System.Diagnostics.Process.GetProcesses().Any((global::System.Diagnostics.Process p) => p.ProcessName.Equals(global::MKS.Xd.qW4, global::System.StringComparison.OrdinalIgnoreCase)))
			{
				return global::EeE.smethod_20(0);
			}
			return global::EeE.smethod_20(350);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000075AC File Offset: 0x000057AC
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if (!sceneName.Contains("Cipa"))
			{
				try
				{
					global::MKS.Xd.SKR = sceneName;
					global::MelonLoader.MelonLogger.Warning("Current scene: " + sceneName);
					try
					{
						this.synccfg();
						global::Il2CppCodeStage.AntiCheat.Detectors.TimeCheatingDetector.StopDetection();
						global::Il2CppCodeStage.AntiCheat.Detectors.TimeCheatingDetector.Dispose();
						global::Il2CppCodeStage.AntiCheat.Detectors.WallHackDetector.StopDetection();
						global::Il2CppCodeStage.AntiCheat.Detectors.WallHackDetector.Dispose();
						global::Il2CppCodeStage.AntiCheat.Detectors.OCD.Destroy();
						global::Il2CppCodeStage.AntiCheat.Detectors.SHD.Destroy();
						global::Il2CppCodeStage.AntiCheat.Detectors.ID.Destroy();
					}
					catch (global::System.Exception)
					{
					}
					global::MKS.Xd.KKy = global::UnityEngine.SystemInfo.deviceUniqueIdentifier;
					try
					{
					}
					catch (global::System.Exception ex)
					{
					}
					if (sceneName == "LobbyScene")
					{
						global::MKS.Xd.NKD = true;
						global::Il2CppNebula.Core.UI.Popups.GenericInfoPopup.Open("Welcome " + global::MKS.Xd.TBW.Split(':', global::System.StringSplitOptions.None)[0], "MKS Cheat\r\nBlockStarPlanet\r\n\r\nv 2.2.4\r\n\r\nChangelog (2.2.4)\r\n-added NoMineCancel to Mining\r\n-optimized teleporting to mythical chests", "omg so cool", true, null, null, null);
					}
					if (this.brR)
					{
						global::MKS.Discord.aeX.SetPresence(sceneName);
					}
				}
				catch (global::System.Exception)
				{
				}
				return;
			}
			global::MelonLoader.MelonLogger.Warning("Current scene: " + sceneName);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000797C File Offset: 0x00005B7C
		private void synccfg()
		{
			if (!global::System.IO.File.Exists(this.BL))
			{
				global::System.IO.File.Create(this.BL);
			}
			if (!this.rKY)
			{
				try
				{
					this.yr0 = "\r\n";
					if (global::MKS.Xd.qjk)
					{
						this.yr0 += "noweaponlimits;0;1\r\n";
					}
					else
					{
						this.yr0 += "noweaponlimits;0;0\r\n";
					}
					if (!this.YBJ)
					{
						this.yr0 += "watermark;0;0\r\n";
					}
					else
					{
						this.yr0 += "watermark;0;1\r\n";
					}
					if (this.brR)
					{
						this.yr0 += "discordrpc;0;1\r\n";
					}
					else
					{
						this.yr0 += "discordrpc;0;0\r\n";
					}
					if (!this.VBB)
					{
						this.yr0 = this.yr0 + "fov;" + this.eBF.ToString() + ";0\r\n";
					}
					else
					{
						this.yr0 = this.yr0 + "fov;" + this.eBF.ToString() + ";1\r\n";
					}
					if (global::UnityEngine.QualitySettings.vSyncCount == 1)
					{
						this.yr0 += "vsync;0;1\r\n";
					}
					else
					{
						this.yr0 += "vsync;0;0\r\n";
					}
					if (this.Wrj)
					{
						this.yr0 += "fog;0;1\r\n";
					}
					else
					{
						this.yr0 += "fog;0;0\r\n";
					}
					if (!global::MKS.Xd.CWl)
					{
						this.yr0 += "lang;0;0\r\n";
					}
					else
					{
						this.yr0 += "lang;0;1\r\n";
					}
					global::System.IO.File.WriteAllText(this.BL, this.yr0);
					goto IL_01E4;
				}
				catch (global::System.Exception)
				{
					goto IL_01E4;
				}
			}
			this.rKY = false;
			IL_01E4:
			foreach (string text in global::System.IO.File.ReadAllLines(this.BL))
			{
				try
				{
					if (!text.StartsWith("discordrpc"))
					{
						if (!text.StartsWith("fov"))
						{
							if (text.StartsWith("noweaponlimits"))
							{
								if (text.Split(';', global::System.StringSplitOptions.None)[2].Contains("1"))
								{
									global::MKS.Xd.qjk = true;
								}
								else
								{
									global::MKS.Xd.qjk = false;
								}
							}
							else if (!text.StartsWith("watermark"))
							{
								if (!text.StartsWith("vsync"))
								{
									if (text.StartsWith("fog"))
									{
										if (!text.Split(';', global::System.StringSplitOptions.None)[2].Contains("1"))
										{
											this.Wrj = false;
										}
										else
										{
											this.Wrj = true;
										}
									}
									else if (text.StartsWith("lang"))
									{
										if (text.Split(';', global::System.StringSplitOptions.None)[2].Contains("1"))
										{
											global::MKS.Xd.CWl = true;
										}
										else
										{
											global::MKS.Xd.CWl = false;
										}
									}
								}
								else if (text.Split(';', global::System.StringSplitOptions.None)[2].Contains("1"))
								{
									global::UnityEngine.QualitySettings.vSyncCount = 1;
								}
								else
								{
									global::UnityEngine.QualitySettings.vSyncCount = 0;
								}
							}
							else if (text.Split(';', global::System.StringSplitOptions.None)[2].Contains("1"))
							{
								this.YBJ = true;
							}
							else
							{
								this.YBJ = false;
							}
						}
						else
						{
							string text2 = text.Split(';', global::System.StringSplitOptions.None)[1];
							string text3 = text.Split(';', global::System.StringSplitOptions.None)[2];
							this.eBF = float.Parse(text2);
							if (!text3.Contains("1"))
							{
								this.VBB = false;
							}
							else
							{
								this.VBB = true;
							}
						}
					}
					else if (text.Split(';', global::System.StringSplitOptions.None)[2].Contains("1"))
					{
						this.brR = true;
					}
					else
					{
						this.brR = false;
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			if (this.AKu)
			{
				if (this.brR)
				{
					try
					{
						global::MKS.Discord.aeX.initializediscord("Launching...");
					}
					catch (global::System.Exception ex)
					{
						global::MelonLoader.MelonLogger.BigError("DISCORD PRESENCE ERROR!: ", ex.Message);
					}
					this.frU = "Turn off";
				}
				else
				{
					this.frU = "Turn on";
				}
				this.AKu = false;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007DFC File Offset: 0x00005FFC
		public static float ClampCmyk(float value)
		{
			if (value < 0f || float.IsNaN(value))
			{
				value = 0f;
			}
			return value;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000233B File Offset: 0x0000053B
		public static global::System.Collections.IEnumerator updatenicks()
		{
			return new global::MKS.Xd.<updatenicks>d__297(0);
		}

		// Token: 0x0400001D RID: 29
		private string Ic = "0";

		// Token: 0x0400001E RID: 30
		public bool lQ;

		// Token: 0x0400001F RID: 31
		public static bool d1;

		// Token: 0x04000020 RID: 32
		public bool qa;

		// Token: 0x04000021 RID: 33
		public static bool Fb = true;

		// Token: 0x04000022 RID: 34
		private string BL = "c:\\maicjadir\\MKSBSP\\cfg.mks";

		// Token: 0x04000023 RID: 35
		private global::HarmonyLib.Harmony jz;

		// Token: 0x04000024 RID: 36
		private float eBF = 60f;

		// Token: 0x04000025 RID: 37
		private bool VBB;

		// Token: 0x04000026 RID: 38
		public static string TBW = "";

		// Token: 0x04000027 RID: 39
		private string dBr = "";

		// Token: 0x04000028 RID: 40
		private string mBK = "";

		// Token: 0x04000029 RID: 41
		private string KBj = "";

		// Token: 0x0400002A RID: 42
		public static string pBe = "";

		// Token: 0x0400002B RID: 43
		public static string kBI = "";

		// Token: 0x0400002C RID: 44
		public static int TB5 = 1232;

		// Token: 0x0400002D RID: 45
		private string nBm = global::EeE.smethod_20(454);

		// Token: 0x0400002E RID: 46
		public static global::UnityEngine.Color bBi = new global::UnityEngine.Color(64f, 64f, 44f);

		// Token: 0x0400002F RID: 47
		private bool NBt;

		// Token: 0x04000030 RID: 48
		private string sBU = "";

		// Token: 0x04000031 RID: 49
		public static string nBA = "";

		// Token: 0x04000032 RID: 50
		private float HBk;

		// Token: 0x04000033 RID: 51
		private float SB4;

		// Token: 0x04000034 RID: 52
		public bool VBM;

		// Token: 0x04000035 RID: 53
		public string NBh = "INITIALIZING...";

		// Token: 0x04000036 RID: 54
		public bool YBJ = true;

		// Token: 0x04000037 RID: 55
		public static bool IBT = false;

		// Token: 0x04000038 RID: 56
		public static bool YBX = false;

		// Token: 0x04000039 RID: 57
		public static bool rBH = false;

		// Token: 0x0400003A RID: 58
		public static bool KB9 = false;

		// Token: 0x0400003B RID: 59
		public static bool JBv = false;

		// Token: 0x0400003C RID: 60
		public static bool JBx = false;

		// Token: 0x0400003D RID: 61
		public static bool qBP = false;

		// Token: 0x0400003E RID: 62
		public static bool NB6 = false;

		// Token: 0x0400003F RID: 63
		private global::UnityEngine.Rect qBl = new global::UnityEngine.Rect(0f, 0f, 90f, 210f);

		// Token: 0x04000040 RID: 64
		private global::UnityEngine.Rect fBg = new global::UnityEngine.Rect(0f, 0f, 110f, 210f);

		// Token: 0x04000041 RID: 65
		private global::UnityEngine.Rect ABy = new global::UnityEngine.Rect(0f, 0f, 110f, 210f);

		// Token: 0x04000042 RID: 66
		private global::UnityEngine.Rect KBR = new global::UnityEngine.Rect(0f, 0f, 130f, 210f);

		// Token: 0x04000043 RID: 67
		private global::UnityEngine.Rect WBD = new global::UnityEngine.Rect(0f, 0f, 240f, 210f);

		// Token: 0x04000044 RID: 68
		private global::UnityEngine.Rect aBn = new global::UnityEngine.Rect(0f, 0f, 200f, 210f);

		// Token: 0x04000045 RID: 69
		private global::UnityEngine.Rect XBY = new global::UnityEngine.Rect(0f, 0f, 350f, 210f);

		// Token: 0x04000046 RID: 70
		private global::UnityEngine.Rect iBw = new global::UnityEngine.Rect(0f, 0f, 130f, 210f);

		// Token: 0x04000047 RID: 71
		private global::UnityEngine.Rect JBu = new global::UnityEngine.Rect(0f, 0f, 290f, 210f);

		// Token: 0x04000048 RID: 72
		private global::UnityEngine.Rect aBG = new global::UnityEngine.Rect(0f, 0f, 110f, 210f);

		// Token: 0x04000049 RID: 73
		private float YBO;

		// Token: 0x0400004A RID: 74
		private float jB0;

		// Token: 0x0400004B RID: 75
		public static float QB7 = 90f;

		// Token: 0x0400004C RID: 76
		private static global::UnityEngine.Vector3 ABZ;

		// Token: 0x0400004D RID: 77
		private bool CBE;

		// Token: 0x0400004E RID: 78
		private global::UnityEngine.Vector3 JBV;

		// Token: 0x0400004F RID: 79
		private global::UnityEngine.Vector3 NBC;

		// Token: 0x04000050 RID: 80
		private global::UnityEngine.Vector3 XBs;

		// Token: 0x04000051 RID: 81
		private global::UnityEngine.Vector3 fB8;

		// Token: 0x04000052 RID: 82
		private float mBp;

		// Token: 0x04000053 RID: 83
		private float NB2;

		// Token: 0x04000054 RID: 84
		private global::UnityEngine.Vector3 VBf;

		// Token: 0x04000055 RID: 85
		private global::UnityEngine.Vector3 PBN;

		// Token: 0x04000056 RID: 86
		private global::UnityEngine.Vector3 lBo;

		// Token: 0x04000057 RID: 87
		private global::UnityEngine.Vector3 jB3;

		// Token: 0x04000058 RID: 88
		private float tBd;

		// Token: 0x04000059 RID: 89
		private float dBS;

		// Token: 0x0400005A RID: 90
		private string PBq = "0";

		// Token: 0x0400005B RID: 91
		private string lBc = "0";

		// Token: 0x0400005C RID: 92
		private string cBQ = "0";

		// Token: 0x0400005D RID: 93
		private float gB1;

		// Token: 0x0400005E RID: 94
		private float ABa;

		// Token: 0x0400005F RID: 95
		private float bBb;

		// Token: 0x04000060 RID: 96
		public bool gBL;

		// Token: 0x04000061 RID: 97
		public bool BBz;

		// Token: 0x04000062 RID: 98
		public bool aWF;

		// Token: 0x04000063 RID: 99
		public bool nWB;

		// Token: 0x04000064 RID: 100
		public static string NWW = "12";

		// Token: 0x04000065 RID: 101
		private global::UnityEngine.Vector3 rWr;

		// Token: 0x04000066 RID: 102
		public int lWK;

		// Token: 0x04000067 RID: 103
		private global::System.Random cWj = new global::System.Random();

		// Token: 0x04000068 RID: 104
		private global::UnityEngine.Vector3 bWe;

		// Token: 0x04000069 RID: 105
		public string fWI = "60";

		// Token: 0x0400006A RID: 106
		private global::UnityEngine.Vector3 gW5;

		// Token: 0x0400006B RID: 107
		private global::UnityEngine.Vector3 GWm;

		// Token: 0x0400006C RID: 108
		private global::UnityEngine.Vector3 aWi;

		// Token: 0x0400006D RID: 109
		private global::UnityEngine.Vector3 aWt;

		// Token: 0x0400006E RID: 110
		private global::UnityEngine.Vector3 HWU;

		// Token: 0x0400006F RID: 111
		private global::UnityEngine.Vector3 UWA;

		// Token: 0x04000070 RID: 112
		public static string hWk = global::EeE.smethod_20(868);

		// Token: 0x04000071 RID: 113
		public static string qW4 = global::EeE.smethod_20(890);

		// Token: 0x04000072 RID: 114
		public static string hWM = "NULL";

		// Token: 0x04000073 RID: 115
		public static string lWh = "NULL";

		// Token: 0x04000074 RID: 116
		public static string PWJ = "NULL";

		// Token: 0x04000075 RID: 117
		public static string xWT = "NULL";

		// Token: 0x04000076 RID: 118
		public static global::UnityEngine.Vector2 pWX;

		// Token: 0x04000077 RID: 119
		public static int SWH = 0;

		// Token: 0x04000078 RID: 120
		public static string kW9 = "0";

		// Token: 0x04000079 RID: 121
		public static int rWv = 0;

		// Token: 0x0400007A RID: 122
		public static bool yWx = false;

		// Token: 0x0400007B RID: 123
		public static string KWP = "";

		// Token: 0x0400007C RID: 124
		public string CW6;

		// Token: 0x0400007D RID: 125
		public static bool CWl = false;

		// Token: 0x0400007E RID: 126
		public static global::UnityEngine.GameObject DWg;

		// Token: 0x0400007F RID: 127
		public static bool HWy;

		// Token: 0x04000080 RID: 128
		public static bool GWR = false;

		// Token: 0x04000081 RID: 129
		private bool HWD;

		// Token: 0x04000082 RID: 130
		public string UWn = "";

		// Token: 0x04000083 RID: 131
		public string cWY = "Cloned Object Name";

		// Token: 0x04000084 RID: 132
		public static string FWw = "NULL";

		// Token: 0x04000085 RID: 133
		public static string EWu = "NULL";

		// Token: 0x04000086 RID: 134
		public static string vWG = "player name";

		// Token: 0x04000087 RID: 135
		public static bool MWO = false;

		// Token: 0x04000088 RID: 136
		public int vW0;

		// Token: 0x04000089 RID: 137
		public static string YW7 = " ";

		// Token: 0x0400008A RID: 138
		public bool LWZ;

		// Token: 0x0400008B RID: 139
		public static string aWE = " ";

		// Token: 0x0400008C RID: 140
		public static string hWV = " ";

		// Token: 0x0400008D RID: 141
		public static string LWC = " ";

		// Token: 0x0400008E RID: 142
		public static string FWs = " ";

		// Token: 0x0400008F RID: 143
		public static string LW8 = " ";

		// Token: 0x04000090 RID: 144
		public static bool PWp = false;

		// Token: 0x04000091 RID: 145
		public static string lW2 = " ";

		// Token: 0x04000092 RID: 146
		public static string FWf = " ";

		// Token: 0x04000093 RID: 147
		public static string eWN = " ";

		// Token: 0x04000094 RID: 148
		public static string mWo = " ";

		// Token: 0x04000095 RID: 149
		public static string lW3 = " ";

		// Token: 0x04000096 RID: 150
		public static string rWd = " ";

		// Token: 0x04000097 RID: 151
		public static string jWS = " ";

		// Token: 0x04000098 RID: 152
		public static string TWq = "Photo/BStar ID";

		// Token: 0x04000099 RID: 153
		public static string KWc = "255";

		// Token: 0x0400009A RID: 154
		public static string eWQ = "255";

		// Token: 0x0400009B RID: 155
		public static string RW1 = "255";

		// Token: 0x0400009C RID: 156
		public static bool lWa = false;

		// Token: 0x0400009D RID: 157
		public static string IWb = "Player list on server:";

		// Token: 0x0400009E RID: 158
		public static string XWL = "Turn LiveUptade\r\nto see players.";

		// Token: 0x0400009F RID: 159
		public global::UnityEngine.GameObject OWz;

		// Token: 0x040000A0 RID: 160
		public bool PrF;

		// Token: 0x040000A1 RID: 161
		public bool XrB;

		// Token: 0x040000A2 RID: 162
		public bool SrW;

		// Token: 0x040000A3 RID: 163
		public bool Grr;

		// Token: 0x040000A4 RID: 164
		public bool JrK;

		// Token: 0x040000A5 RID: 165
		private bool Wrj = true;

		// Token: 0x040000A6 RID: 166
		public string sre = "1";

		// Token: 0x040000A7 RID: 167
		public static string SrI = "1";

		// Token: 0x040000A8 RID: 168
		public static string Dr5 = "1";

		// Token: 0x040000A9 RID: 169
		public bool frm;

		// Token: 0x040000AA RID: 170
		public string tri = "1";

		// Token: 0x040000AB RID: 171
		public static bool urt = false;

		// Token: 0x040000AC RID: 172
		public string frU = "Turn off";

		// Token: 0x040000AD RID: 173
		public string srA = "Yellow key";

		// Token: 0x040000AE RID: 174
		public bool frk;

		// Token: 0x040000AF RID: 175
		public string mr4 = "Purple key";

		// Token: 0x040000B0 RID: 176
		public bool CrM;

		// Token: 0x040000B1 RID: 177
		public string irh = "Red key";

		// Token: 0x040000B2 RID: 178
		public bool hrJ;

		// Token: 0x040000B3 RID: 179
		public string VrT = "Blue key";

		// Token: 0x040000B4 RID: 180
		public bool OrX;

		// Token: 0x040000B5 RID: 181
		private global::System.Random trH = new global::System.Random();

		// Token: 0x040000B6 RID: 182
		public string Hr9 = "Green key";

		// Token: 0x040000B7 RID: 183
		public bool Vrv;

		// Token: 0x040000B8 RID: 184
		public bool Trx;

		// Token: 0x040000B9 RID: 185
		private global::UnityEngine.Vector3 brP;

		// Token: 0x040000BA RID: 186
		private int Ar6;

		// Token: 0x040000BB RID: 187
		private int Xrl;

		// Token: 0x040000BC RID: 188
		public bool nrg;

		// Token: 0x040000BD RID: 189
		public bool Nry;

		// Token: 0x040000BE RID: 190
		public bool brR = true;

		// Token: 0x040000BF RID: 191
		public bool arD;

		// Token: 0x040000C0 RID: 192
		public static global::UnityEngine.Vector3 Qrn;

		// Token: 0x040000C1 RID: 193
		public int WrY = 10;

		// Token: 0x040000C2 RID: 194
		public bool Vrw;

		// Token: 0x040000C3 RID: 195
		public static bool oru = false;

		// Token: 0x040000C4 RID: 196
		private int GrG;

		// Token: 0x040000C5 RID: 197
		public static global::Il2Cpp.CKCGOBBEAKK prO;

		// Token: 0x040000C6 RID: 198
		private string yr0 = "0";

		// Token: 0x040000C7 RID: 199
		private bool br7;

		// Token: 0x040000C8 RID: 200
		private global::UnityEngine.Vector3 SrZ;

		// Token: 0x040000C9 RID: 201
		public bool QrE;

		// Token: 0x040000CA RID: 202
		public static bool mrV = false;

		// Token: 0x040000CB RID: 203
		private global::UnityEngine.GameObject mrC;

		// Token: 0x040000CC RID: 204
		private global::Il2CppCinemachine.LensSettings Qrs;

		// Token: 0x040000CD RID: 205
		private bool Pr8;

		// Token: 0x040000CE RID: 206
		private static bool zrp = false;

		// Token: 0x040000CF RID: 207
		private bool dr2;

		// Token: 0x040000D0 RID: 208
		private bool arf;

		// Token: 0x040000D1 RID: 209
		private int mrN;

		// Token: 0x040000D2 RID: 210
		private bool Fro;

		// Token: 0x040000D3 RID: 211
		public global::UnityEngine.Vector3 Cr3 = new global::UnityEngine.Vector3(0f, 5f, 0f);

		// Token: 0x040000D4 RID: 212
		private static global::UnityEngine.Quaternion trd;

		// Token: 0x040000D5 RID: 213
		public bool zrS;

		// Token: 0x040000D6 RID: 214
		public bool xrq = true;

		// Token: 0x040000D7 RID: 215
		public int crc = -3;

		// Token: 0x040000D8 RID: 216
		public bool VrQ;

		// Token: 0x040000D9 RID: 217
		public bool kr1;

		// Token: 0x040000DA RID: 218
		private float fra;

		// Token: 0x040000DB RID: 219
		private bool prb;

		// Token: 0x040000DC RID: 220
		public bool nrL;

		// Token: 0x040000DD RID: 221
		public int urz;

		// Token: 0x040000DE RID: 222
		public bool XKF;

		// Token: 0x040000DF RID: 223
		public int dKB;

		// Token: 0x040000E0 RID: 224
		public static string JKW;

		// Token: 0x040000E1 RID: 225
		public bool MKr;

		// Token: 0x040000E2 RID: 226
		public int iKK;

		// Token: 0x040000E3 RID: 227
		public int wKj;

		// Token: 0x040000E4 RID: 228
		public int uKe;

		// Token: 0x040000E5 RID: 229
		public static string pKI;

		// Token: 0x040000E6 RID: 230
		public bool FK5;

		// Token: 0x040000E7 RID: 231
		public int TKm;

		// Token: 0x040000E8 RID: 232
		public int SKi;

		// Token: 0x040000E9 RID: 233
		public bool SKt;

		// Token: 0x040000EA RID: 234
		public bool oKU = true;

		// Token: 0x040000EB RID: 235
		public bool UKA;

		// Token: 0x040000EC RID: 236
		public bool cKk;

		// Token: 0x040000ED RID: 237
		public bool hK4;

		// Token: 0x040000EE RID: 238
		private float zKM;

		// Token: 0x040000EF RID: 239
		private float hKh;

		// Token: 0x040000F0 RID: 240
		private float YKJ;

		// Token: 0x040000F1 RID: 241
		private int gKT;

		// Token: 0x040000F2 RID: 242
		public float SKX;

		// Token: 0x040000F3 RID: 243
		public float gKH;

		// Token: 0x040000F4 RID: 244
		public int DK9;

		// Token: 0x040000F5 RID: 245
		public string HKv;

		// Token: 0x040000F6 RID: 246
		public string aKx;

		// Token: 0x040000F7 RID: 247
		public int uKP;

		// Token: 0x040000F8 RID: 248
		public bool KK6;

		// Token: 0x040000F9 RID: 249
		public static readonly string iKl = global::EeE.smethod_20(906);

		// Token: 0x040000FA RID: 250
		private global::System.Net.WebClient WKg = new global::System.Net.WebClient();

		// Token: 0x040000FB RID: 251
		public static string KKy = "cracked";

		// Token: 0x040000FC RID: 252
		public static string SKR = "";

		// Token: 0x040000FD RID: 253
		public static bool NKD = false;

		// Token: 0x040000FE RID: 254
		private int cKn;

		// Token: 0x040000FF RID: 255
		private bool rKY = true;

		// Token: 0x04000100 RID: 256
		private string XKw = global::EeE.smethod_20(466);

		// Token: 0x04000101 RID: 257
		private bool AKu = true;

		// Token: 0x04000102 RID: 258
		public static string OKG = global::EeE.smethod_20(932);

		// Token: 0x04000103 RID: 259
		public static string iKO = global::EeE.smethod_20(962);

		// Token: 0x04000104 RID: 260
		public static string PK0 = global::EeE.smethod_20(1256);

		// Token: 0x04000105 RID: 261
		public static string nK7 = global::EeE.smethod_20(1276);

		// Token: 0x04000106 RID: 262
		public static string KKZ = global::EeE.smethod_20(1310);

		// Token: 0x04000107 RID: 263
		public static string QKE = global::EeE.smethod_20(1342);

		// Token: 0x04000108 RID: 264
		public static string EKV = global::EeE.smethod_20(1384);

		// Token: 0x04000109 RID: 265
		private string XKC = global::EeE.smethod_20(654);

		// Token: 0x0400010A RID: 266
		private int dKs;

		// Token: 0x0400010B RID: 267
		private int wK8 = 1;

		// Token: 0x0400010C RID: 268
		private int PKp;

		// Token: 0x0400010D RID: 269
		private int NK2;

		// Token: 0x0400010E RID: 270
		private int YKf;

		// Token: 0x0400010F RID: 271
		private int zKN;

		// Token: 0x04000110 RID: 272
		private int PKo = 1;

		// Token: 0x04000111 RID: 273
		private int MK3;

		// Token: 0x04000112 RID: 274
		private int QKd;

		// Token: 0x04000113 RID: 275
		private int SKS;

		// Token: 0x04000114 RID: 276
		private int mKq;

		// Token: 0x04000115 RID: 277
		private bool JKc;

		// Token: 0x04000116 RID: 278
		public bool VKQ = true;

		// Token: 0x04000117 RID: 279
		public static bool yK1 = false;

		// Token: 0x04000118 RID: 280
		public global::UnityEngine.Rect kKa = new global::UnityEngine.Rect(20f, (float)(global::UnityEngine.Screen.height / 2), 90f, 210f);

		// Token: 0x04000119 RID: 281
		public static bool iKb = true;

		// Token: 0x0400011A RID: 282
		public bool PKL;

		// Token: 0x0400011B RID: 283
		public static bool OKz;

		// Token: 0x0400011C RID: 284
		public bool KjF;

		// Token: 0x0400011D RID: 285
		public static bool QjB = false;

		// Token: 0x0400011E RID: 286
		public bool RjW;

		// Token: 0x0400011F RID: 287
		public bool Hjr;

		// Token: 0x04000120 RID: 288
		public bool ojK;

		// Token: 0x04000121 RID: 289
		public static int vjj = 0;

		// Token: 0x04000122 RID: 290
		public static bool Uje = false;

		// Token: 0x04000123 RID: 291
		public bool SjI;

		// Token: 0x04000124 RID: 292
		public bool zj5;

		// Token: 0x04000125 RID: 293
		public bool njm;

		// Token: 0x04000126 RID: 294
		public bool fji;

		// Token: 0x04000127 RID: 295
		public bool Fjt;

		// Token: 0x04000128 RID: 296
		public bool xjU;

		// Token: 0x04000129 RID: 297
		public bool DjA;

		// Token: 0x0400012A RID: 298
		public static bool qjk;

		// Token: 0x0400012B RID: 299
		public static string mj4 = "2";

		// Token: 0x0400012C RID: 300
		private static global::System.Net.WebClient jjM = new global::System.Net.WebClient();

		// Token: 0x0400012D RID: 301
		public static global::Il2Cpp.CKCGOBBEAKK Kjh;

		// Token: 0x0400012E RID: 302
		public static global::Il2Cpp.CKCGOBBEAKK YjJ;

		// Token: 0x0400012F RID: 303
		public static global::Il2Cpp.PJPAFJBIDAL ljT;

		// Token: 0x04000130 RID: 304
		public static global::Il2Cpp.PJPAFJBIDAL sjX;

		// Token: 0x04000131 RID: 305
		public static bool djH = false;

		// Token: 0x04000132 RID: 306
		public static bool fj9 = false;

		// Token: 0x04000133 RID: 307
		public static bool Ojv = false;

		// Token: 0x04000134 RID: 308
		private static global::System.DateTime zjx = default(global::System.DateTime);

		// Token: 0x04000135 RID: 309
		private static string FjP;

		// Token: 0x04000136 RID: 310
		private static string Ij6;

		// Token: 0x04000137 RID: 311
		public static bool mjl = false;

		// Token: 0x0200001E RID: 30
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		public enum weD
		{

		}
	}
}
