using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace BSP_Launcher
{
	// Token: 0x02000005 RID: 5
	public partial class loginform : Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000347B File Offset: 0x0000167B
		public loginform()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003494 File Offset: 0x00001694
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.button1.Text == "Show")
			{
				this.button1.Text = "Hide";
				this.textBox2.UseSystemPasswordChar = false;
				return;
			}
			this.button1.Text = "Show";
			this.textBox2.UseSystemPasswordChar = true;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000034F4 File Offset: 0x000016F4
		private async void button2_Click(object sender, EventArgs e)
		{
			string text = Form1.urlname;
			string text2 = this.textBox1.Text;
			string text3 = await encryption.EncryptPassword(this.textBox1.Text, this.textBox2.Text, Form1.urlname);
			string text4 = string.Concat(new string[] { "http://", text, "/login?name=", text2, "&pass=", text3 });
			text = null;
			text2 = null;
			string text5 = await this.fdsa.DownloadStringTaskAsync(text4);
			MessageBox.Show(text5);
			if (text5 == "Logged in")
			{
				File.WriteAllText("c:\\maicjadir\\MKSBSP\\mks.acc", this.textBox1.Text + ";" + this.textBox2.Text);
				Form1.czymoge = true;
				base.Close();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000352B File Offset: 0x0000172B
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("http://" + Form1.urlname + "/account");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003547 File Offset: 0x00001747
		private void loginform_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Form1.czymoge)
			{
				Application.Exit();
			}
		}

		// Token: 0x0400001D RID: 29
		private WebClient fdsa = new WebClient();
	}
}
