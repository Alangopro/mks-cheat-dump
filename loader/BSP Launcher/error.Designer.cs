namespace BSP_Launcher
{
	// Token: 0x02000003 RID: 3
	public partial class error : global::System.Windows.Forms.Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000219B File Offset: 0x0000039B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021BC File Offset: 0x000003BC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BSP_Launcher.error));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackgroundImage = global::BSP_Launcher.Properties.Resources.banane_sex;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(534, 284);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(534, 284);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.ForeColor = global::System.Drawing.SystemColors.Control;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "error";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "error";
			base.Load += new global::System.EventHandler(this.error_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
