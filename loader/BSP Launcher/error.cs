using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSP_Launcher.Properties;

namespace BSP_Launcher
{
	// Token: 0x02000003 RID: 3
	public partial class error : Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002155 File Offset: 0x00000355
		public error()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002164 File Offset: 0x00000364
		private async void error_Load(object sender, EventArgs e)
		{
			await Task.Delay(1000);
			MessageBox.Show(Form1.errortext, "ERROR!");
			base.Close();
		}
	}
}
