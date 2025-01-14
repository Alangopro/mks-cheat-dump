using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSP_Launcher.Properties;

namespace BSP_Launcher
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002354 File Offset: 0x00000554
		public void DownloadFile(string urlAddress, string location, long sizee)
		{
			this.button1.Enabled = false;
			this.button2.Enabled = false;
			this.checkBoxcheat.Enabled = false;
			this.checkBoxcheatreinstall.Enabled = false;
			this.checkBoxgamereinstall.Enabled = false;
			this.checkBoxnoupdate.Enabled = false;
			using (this.webClient = new WebClient())
			{
				this.webClient.DownloadFileCompleted += this.Completed;
				this.webClient.DownloadProgressChanged += this.ProgressChanged;
				Uri uri = new Uri(urlAddress);
				this.filename = uri.OriginalString;
				foreach (string text in this.filename.Split(new char[] { '/' }))
				{
					this.filename = text;
				}
				foreach (string text2 in this.filename.Split(new char[] { '\\' }))
				{
					this.filename = text2;
				}
				this.filename = " " + this.filename;
				string text3 = "";
				foreach (string text3 in location.Split(new char[] { '\\' }))
				{
				}
				text3 = location.Replace(text3, "");
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				Form1.toadd = sizee / 1000L;
				this.sw.Start();
				try
				{
					this.webClient.DownloadFileAsync(uri, location);
				}
				catch (Exception ex)
				{
					Form1.HandleError(ex.Message);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002544 File Offset: 0x00000744
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.labeldownload.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00")) + this.filename + string.Format("\r\n{0}/{1} MB", Form1.downloadedbytes / 1000L, Form1.sizebytes / 1000L);
			this.progressBar1.Maximum = (int)(e.TotalBytesToReceive / 1000L);
			this.progressBar1.Value = (int)(e.BytesReceived / 1000L);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002604 File Offset: 0x00000804
		private async void Completed(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				MessageBox.Show("DOWNLOAD CANCELLED");
			}
			Form1.downloadedbytes += Form1.toadd;
			this.sw.Reset();
			Form1.cheatdownloaded = true;
			this.button1.Enabled = true;
			this.button2.Enabled = true;
			this.checkBoxcheat.Enabled = true;
			this.checkBoxcheatreinstall.Enabled = true;
			this.checkBoxgamereinstall.Enabled = true;
			this.checkBoxnoupdate.Enabled = true;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002644 File Offset: 0x00000844
		public void DownloadFile2(string urlAddress, string location)
		{
			this.button1.Enabled = false;
			this.button2.Enabled = false;
			this.checkBoxcheat.Enabled = false;
			this.checkBoxcheatreinstall.Enabled = false;
			this.checkBoxgamereinstall.Enabled = false;
			this.checkBoxnoupdate.Enabled = false;
			using (this.webClient = new WebClient())
			{
				this.webClient.DownloadFileCompleted += this.Completed2;
				this.webClient.DownloadProgressChanged += this.ProgressChanged2;
				Uri uri = new Uri(urlAddress);
				this.filename = uri.OriginalString;
				foreach (string text in this.filename.Split(new char[] { '/' }))
				{
					this.filename = text;
				}
				foreach (string text2 in this.filename.Split(new char[] { '\\' }))
				{
					this.filename = text2;
				}
				this.filename = " " + this.filename;
				string text3 = "";
				foreach (string text3 in location.Split(new char[] { '\\' }))
				{
				}
				text3 = location.Replace(text3, "");
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				this.sw.Start();
				try
				{
					this.webClient.DownloadFileAsync(uri, location);
				}
				catch (Exception ex)
				{
					Form1.HandleError(ex.Message);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002828 File Offset: 0x00000A28
		private void ProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
		{
			this.progressBar1.Maximum = 100;
			this.labeldownload.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00")) + this.filename + string.Format("\r\n{0} MB's / {1} MB's", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
			this.progressBar1.Value = e.ProgressPercentage;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002900 File Offset: 0x00000B00
		private async void Completed2(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				MessageBox.Show("DOWNLOAD CANCELLED");
			}
			this.sw.Reset();
			Form1.cheatdownloaded = true;
			this.button1.Enabled = true;
			this.button2.Enabled = true;
			this.checkBoxcheat.Enabled = true;
			this.checkBoxcheatreinstall.Enabled = true;
			this.checkBoxgamereinstall.Enabled = true;
			this.checkBoxnoupdate.Enabled = true;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002940 File Offset: 0x00000B40
		public static string CalculateMD5(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return "ERR";
			}
			string text;
			try
			{
				using (MD5 md = MD5.Create())
				{
					using (FileStream fileStream = File.OpenRead(fileName))
					{
						text = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
					}
				}
			}
			catch (Exception)
			{
				text = "ERR";
			}
			return text;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000029D4 File Offset: 0x00000BD4
		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			try
			{
				Directory.CreateDirectory(targetPath);
				try
				{
					string[] array = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
					for (int i = 0; i < array.Length; i++)
					{
						Directory.CreateDirectory(array[i].Replace(sourcePath, targetPath));
					}
					Task.Delay(100);
				}
				catch (Exception)
				{
				}
				foreach (string text in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
				{
					if (!File.Exists(text.Replace(sourcePath, targetPath)))
					{
						File.Copy(text, text.Replace(sourcePath, targetPath), true);
					}
				}
				Task.Delay(100);
			}
			catch (Exception ex)
			{
				Form1.HandleError(ex.Message);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A90 File Offset: 0x00000C90
		public Form1()
		{
			this.InitializeComponent();
			if (!Directory.Exists(this.rootFolder))
			{
				Directory.CreateDirectory(this.rootFolder);
			}
			if (!Directory.Exists(this.cheatFolder))
			{
				Directory.CreateDirectory(this.cheatFolder);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B14 File Offset: 0x00000D14
		private async void button1_Click(object sender, EventArgs e)
		{
			this.labeldownload.Text = "Checking files.\r\nWaiting for system response.";
			try
			{
				if (this.checkBoxgamereinstall.Checked)
				{
					Directory.Delete(this.rootFolder, true);
					await Task.Delay(1000);
					Directory.CreateDirectory(this.rootFolder);
				}
				bool flag = false;
				if (!Directory.Exists(this.cheatFolder + "maicjaload"))
				{
					flag = true;
				}
				if (!Directory.Exists(this.cheatFolder + "bibliotekiuzytkownikow"))
				{
					flag = true;
				}
				if (!Directory.Exists(this.cheatFolder + "daneuzytkownikow"))
				{
					flag = true;
				}
				if (!Directory.Exists(this.cheatFolder + "tenizszeodjajamidzwoniacych"))
				{
					flag = true;
				}
				if (!File.Exists(this.cheatFolder + "dobby.dll"))
				{
					flag = true;
				}
				if (!File.Exists(this.cheatFolder + "version.dll"))
				{
					flag = true;
				}
				if (this.checkBoxcheatreinstall.Checked)
				{
					flag = true;
				}
				if (flag && this.checkBoxcheat.Checked)
				{
					if (!Directory.Exists("c:\\maicjadir\\temp"))
					{
						Directory.CreateDirectory("c:\\maicjadir\\temp");
					}
					if (Directory.Exists(this.rootFolder + "MonoBleedingEdge"))
					{
						Directory.Delete(this.rootFolder + "MonoBleedingEdge", true);
					}
					if (Directory.Exists(this.rootFolder + "maicjaload"))
					{
						Directory.Delete(this.rootFolder + "maicjaload", true);
					}
					if (Directory.Exists(this.cheatFolder))
					{
						Directory.Delete(this.cheatFolder, true);
					}
					Console.WriteLine("Downloading ZIP...");
					Form1.cheatdownloaded = false;
					this.DownloadFile2("http://" + Form1.urlname + "/hujzdupybtw.zip", "c:\\maicjadir\\temp\\czid.zip");
					while (!Form1.cheatdownloaded)
					{
						await Task.Delay(50);
					}
					this.labeldownload.Text = "";
					this.progressBar1.Value = 0;
					await Task.Delay(100);
					Console.WriteLine("Installing...");
					ZipFile.ExtractToDirectory("c:\\maicjadir\\temp\\czid.zip", this.cheatFolder);
				}
				if (this.checkBoxcheat.Checked)
				{
					bool needpass = false;
					try
					{
						if (!File.Exists("c:\\maicjadir\\MKSBSP\\mks.acc"))
						{
							using (FileStream fileStream = File.Create("c:\\maicjadir\\MKSBSP\\mks.acc"))
							{
								byte[] bytes = new UTF8Encoding(true).GetBytes("");
								fileStream.Write(bytes, 0, bytes.Length);
							}
							await Task.Delay(10);
						}
						string text = File.ReadAllText("c:\\maicjadir\\MKSBSP\\mks.acc");
						if (text.Contains(';'))
						{
							string text2 = text.Split(new char[] { ';' })[0];
							string text3 = text.Split(new char[] { ';' })[1];
							WebClient webClient = this.webClient34234234;
							string text4 = Form1.urlname;
							string text5 = text2;
							if (webClient.DownloadString(string.Concat(new string[]
							{
								"http://",
								text4,
								"/login?name=",
								text5,
								"&pass=",
								await encryption.EncryptPassword(text2, text3, Form1.urlname)
							})) != "Logged in")
							{
								webClient = null;
								text4 = null;
								text5 = null;
								needpass = true;
							}
						}
						else
						{
							needpass = true;
						}
					}
					catch (Exception)
					{
						needpass = true;
					}
					if (needpass)
					{
						Form1.czymoge = false;
						new loginform().Show();
						while (!Form1.czymoge)
						{
							await Task.Delay(500);
						}
					}
					try
					{
						Form1.CopyFilesRecursively(this.cheatFolder, this.rootFolder);
						goto IL_09F5;
					}
					catch (Exception)
					{
						goto IL_09F5;
					}
				}
				if (File.Exists(this.rootFolder + "version.dll"))
				{
					if (Directory.Exists(this.cheatFolder + "maicjaload"))
					{
						Directory.Delete(this.cheatFolder + "maicjaload", true);
					}
					if (Directory.Exists(this.cheatFolder + "bibliotekiuzytkownikow"))
					{
						Directory.Delete(this.cheatFolder + "bibliotekiuzytkownikow", true);
					}
					if (Directory.Exists(this.cheatFolder + "daneuzytkownikow"))
					{
						Directory.Delete(this.cheatFolder + "daneuzytkownikow", true);
					}
					if (Directory.Exists(this.cheatFolder + "tenizszeodjajamidzwoniacych"))
					{
						Directory.Delete(this.cheatFolder + "tenizszeodjajamidzwoniacych", true);
					}
					if (Directory.Exists(this.cheatFolder + "tecojajamidzwoniom"))
					{
						Directory.Delete(this.cheatFolder + "tecojajamidzwoniom", true);
					}
					if (File.Exists(this.cheatFolder + "dobby.dll"))
					{
						File.Delete(this.cheatFolder + "dobby.dll");
					}
					if (File.Exists(this.cheatFolder + "version.dll"))
					{
						File.Delete(this.cheatFolder + "version.dll");
					}
					await Task.Delay(150);
					Form1.CopyFilesRecursively(this.rootFolder + "maicjaload", this.cheatFolder + "maicjaload");
					if (Directory.Exists(this.rootFolder + "maicjaload"))
					{
						Directory.Delete(this.rootFolder + "maicjaload", true);
					}
					Form1.CopyFilesRecursively(this.rootFolder + "bibliotekiuzytkownikow", this.cheatFolder + "bibliotekiuzytkownikow");
					if (Directory.Exists(this.rootFolder + "bibliotekiuzytkownikow"))
					{
						Directory.Delete(this.rootFolder + "bibliotekiuzytkownikow", true);
					}
					Form1.CopyFilesRecursively(this.rootFolder + "daneuzytkownikow", this.cheatFolder + "daneuzytkownikow");
					if (Directory.Exists(this.rootFolder + "daneuzytkownikow"))
					{
						Directory.Delete(this.rootFolder + "daneuzytkownikow", true);
					}
					Form1.CopyFilesRecursively(this.rootFolder + "tenizszeodjajamidzwoniacych", this.cheatFolder + "tenizszeodjajamidzwoniacych");
					if (Directory.Exists(this.rootFolder + "tenizszeodjajamidzwoniacych"))
					{
						Directory.Delete(this.rootFolder + "tenizszeodjajamidzwoniacych", true);
					}
					Form1.CopyFilesRecursively(this.rootFolder + "tecojajamidzwoniom", this.cheatFolder + "tecojajamidzwoniom");
					if (Directory.Exists(this.rootFolder + "tecojajamidzwoniom"))
					{
						Directory.Delete(this.rootFolder + "tecojajamidzwoniom", true);
					}
					File.Copy(this.rootFolder + "version.dll", this.cheatFolder + "version.dll");
					if (File.Exists(this.rootFolder + "version.dll"))
					{
						File.Delete(this.rootFolder + "version.dll");
					}
					File.Copy(this.rootFolder + "dobby.dll", this.cheatFolder + "dobby.dll");
					if (File.Exists(this.rootFolder + "dobby.dll"))
					{
						File.Delete(this.rootFolder + "dobby.dll");
					}
				}
				IL_09F5:
				if (!this.checkBoxnoupdate.Checked)
				{
					string text5 = "https://blockstarplanet.com/";
					string text6 = text5 + "launcher/v4/content.txt";
					string text7 = this.webClient34234234.DownloadString(text6);
					string text8 = "";
					foreach (string text9 in text7.Split(new char[] { '\n' }))
					{
						string[] array2 = text9.Split(new char[] { '|' });
						string text10 = Form1.CalculateMD5(this.rootFolder + array2[0]);
						try
						{
							if (!text9.Contains("BlockStarPlanet_Launcher.exe") && text10 != array2[1])
							{
								Form1.sizebytes += long.Parse(array2[3]);
								text8 = text8 + text9.Replace("\r", "") + "\n";
							}
						}
						catch (Exception)
						{
						}
					}
					Form1.sizebytes /= 1000L;
					foreach (string text11 in text8.Split(new char[] { '\n' }))
					{
						try
						{
							Form1.cheatdownloaded = false;
							string[] array4 = text11.Split(new char[] { '|' });
							this.DownloadFile(text5 + array4[2], this.rootFolder + array4[0], long.Parse(array4[3]));
							while (!Form1.cheatdownloaded)
							{
								await Task.Delay(50);
							}
						}
						catch (Exception)
						{
						}
					}
					string[] array3 = null;
					this.labeldownload.Text = "";
					this.progressBar1.Value = 0;
					text5 = null;
				}
				if (Directory.Exists(this.rootFolder + "MonoBleedingEdge"))
				{
					Directory.Delete(this.rootFolder + "MonoBleedingEdge", true);
				}
				string text12 = this.rootFolder + "BlockStarPlanet.exe";
				ProcessStartInfo processStartInfo = new ProcessStartInfo
				{
					FileName = text12,
					Arguments = "SecretThingOmgSoHardToGuess",
					WorkingDirectory = this.rootFolder
				};
				Process process = new Process();
				process.StartInfo = processStartInfo;
				process.Start();
				process.Close();
				try
				{
					File.Delete(this.rootFolder + "BlockStarPlanet_Launcher.exe");
				}
				catch (Exception)
				{
				}
				Application.Exit();
			}
			catch (Exception ex)
			{
				Form1.HandleError(ex.Message);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B4B File Offset: 0x00000D4B
		public static void HandleError(string error)
		{
			Form1.errortext = error;
			new error().Show();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002B60 File Offset: 0x00000D60
		private async void button2_Click(object sender, EventArgs e)
		{
			try
			{
				Form1.cheatdownloaded = false;
				this.DownloadFile2("http://" + Form1.urlname + "/hwids/netcore.exe", "c:\\maicjadir\\netcore.exe");
				while (!Form1.cheatdownloaded)
				{
					await Task.Delay(50);
				}
				this.labeldownload.Text = "";
				this.progressBar1.Value = 0;
				await Task.Delay(100);
				Console.WriteLine("Installing...");
				Process.Start("c:\\maicjadir\\netcore.exe");
			}
			catch (Exception ex)
			{
				Form1.HandleError(ex.Message);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B98 File Offset: 0x00000D98
		private async void Form1_Load(object sender, EventArgs e)
		{
			if (Directory.Exists("c:\\majagejtlejzabijsie"))
			{
				Form1.urlname = "dev.mksteam.ovh";
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				File.Delete("c:\\maicjadir\\MKSBSP\\mks.acc");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002BF4 File Offset: 0x00000DF4
		private void checkBoxcheatreinstall_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxcheatreinstall.Checked)
			{
				this.checkBoxcheat.Checked = true;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002C0F File Offset: 0x00000E0F
		private void checkBoxcheat_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkBoxcheat.Checked)
			{
				this.checkBoxcheatreinstall.Checked = false;
			}
		}

		// Token: 0x04000004 RID: 4
		private string rootFolder = "c:\\maicjadir\\MKSBSP\\Game\\";

		// Token: 0x04000005 RID: 5
		private string cheatFolder = "c:\\maicjadir\\MKSBSP\\maicjaloadfiles\\";

		// Token: 0x04000006 RID: 6
		private WebClient webClient;

		// Token: 0x04000007 RID: 7
		public static string urlname = "mksteam.ovh";

		// Token: 0x04000008 RID: 8
		public static long toadd = 0L;

		// Token: 0x04000009 RID: 9
		private WebClient webClient34234234 = new WebClient();

		// Token: 0x0400000A RID: 10
		private Stopwatch sw = new Stopwatch();

		// Token: 0x0400000B RID: 11
		private string filename = "Xunknown";

		// Token: 0x0400000C RID: 12
		public static long bcontainer = 0L;

		// Token: 0x0400000D RID: 13
		public static long sizebytes = 0L;

		// Token: 0x0400000E RID: 14
		public static long downloadedbytes = 0L;

		// Token: 0x0400000F RID: 15
		public static string errortext = "";

		// Token: 0x04000010 RID: 16
		public static bool cheatdownloaded = false;

		// Token: 0x04000011 RID: 17
		public static bool czymoge = true;
	}
}
