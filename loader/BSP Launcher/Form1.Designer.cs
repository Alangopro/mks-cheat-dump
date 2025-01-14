namespace BSP_Launcher
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002C2A File Offset: 0x00000E2A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002C4C File Offset: 0x00000E4C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BSP_Launcher.Form1));
			this.button1 = new global::System.Windows.Forms.Button();
			this.checkBoxnoupdate = new global::System.Windows.Forms.CheckBox();
			this.checkBoxcheat = new global::System.Windows.Forms.CheckBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.labeldownload = new global::System.Windows.Forms.Label();
			this.checkBoxcheatreinstall = new global::System.Windows.Forms.CheckBox();
			this.checkBoxgamereinstall = new global::System.Windows.Forms.CheckBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button3 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(622, 18);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(173, 68);
			this.button1.TabIndex = 1;
			this.button1.Text = "Launch Game";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.checkBoxnoupdate.AutoSize = true;
			this.checkBoxnoupdate.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBoxnoupdate.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxnoupdate.Location = new global::System.Drawing.Point(504, 22);
			this.checkBoxnoupdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxnoupdate.Name = "checkBoxnoupdate";
			this.checkBoxnoupdate.Size = new global::System.Drawing.Size(103, 24);
			this.checkBoxnoupdate.TabIndex = 2;
			this.checkBoxnoupdate.Text = "No Update";
			this.checkBoxnoupdate.UseVisualStyleBackColor = false;
			this.checkBoxcheat.AutoSize = true;
			this.checkBoxcheat.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBoxcheat.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxcheat.Location = new global::System.Drawing.Point(504, 90);
			this.checkBoxcheat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxcheat.Name = "checkBoxcheat";
			this.checkBoxcheat.Size = new global::System.Drawing.Size(102, 24);
			this.checkBoxcheat.TabIndex = 3;
			this.checkBoxcheat.Text = "MKS Cheat";
			this.checkBoxcheat.UseVisualStyleBackColor = false;
			this.checkBoxcheat.CheckedChanged += new global::System.EventHandler(this.checkBoxcheat_CheckedChanged);
			this.button2.Location = new global::System.Drawing.Point(622, 96);
			this.button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(173, 68);
			this.button2.TabIndex = 4;
			this.button2.Text = "Install NetCore6";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.progressBar1.Location = new global::System.Drawing.Point(18, 381);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(777, 29);
			this.progressBar1.TabIndex = 5;
			this.labeldownload.AutoSize = true;
			this.labeldownload.BackColor = global::System.Drawing.Color.Transparent;
			this.labeldownload.ForeColor = global::System.Drawing.Color.White;
			this.labeldownload.Location = new global::System.Drawing.Point(503, 333);
			this.labeldownload.Name = "labeldownload";
			this.labeldownload.Size = new global::System.Drawing.Size(183, 40);
			this.labeldownload.TabIndex = 6;
			this.labeldownload.Text = "BlockStarPlanet Launcher\r\nby maicja";
			this.checkBoxcheatreinstall.AutoSize = true;
			this.checkBoxcheatreinstall.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBoxcheatreinstall.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxcheatreinstall.Location = new global::System.Drawing.Point(504, 124);
			this.checkBoxcheatreinstall.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxcheatreinstall.Name = "checkBoxcheatreinstall";
			this.checkBoxcheatreinstall.Size = new global::System.Drawing.Size(115, 24);
			this.checkBoxcheatreinstall.TabIndex = 7;
			this.checkBoxcheatreinstall.Text = "Cheat Repair";
			this.checkBoxcheatreinstall.UseVisualStyleBackColor = false;
			this.checkBoxcheatreinstall.CheckedChanged += new global::System.EventHandler(this.checkBoxcheatreinstall_CheckedChanged);
			this.checkBoxgamereinstall.AutoSize = true;
			this.checkBoxgamereinstall.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBoxgamereinstall.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxgamereinstall.Location = new global::System.Drawing.Point(504, 56);
			this.checkBoxgamereinstall.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxgamereinstall.Name = "checkBoxgamereinstall";
			this.checkBoxgamereinstall.Size = new global::System.Drawing.Size(85, 24);
			this.checkBoxgamereinstall.TabIndex = 8;
			this.checkBoxgamereinstall.Text = "ReInstall";
			this.checkBoxgamereinstall.UseVisualStyleBackColor = false;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::BSP_Launcher.Properties.Resources.logo;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new global::System.Drawing.Point(18, 18);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(478, 355);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.button3.Location = new global::System.Drawing.Point(622, 181);
			this.button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(173, 43);
			this.button3.TabIndex = 9;
			this.button3.Text = "Clear MKS login data";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(815, 426);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.checkBoxgamereinstall);
			base.Controls.Add(this.checkBoxcheatreinstall);
			base.Controls.Add(this.labeldownload);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.checkBoxcheat);
			base.Controls.Add(this.checkBoxnoupdate);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BlockStarPlanet Launcher";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000012 RID: 18
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.CheckBox checkBoxnoupdate;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.CheckBox checkBoxcheat;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label labeldownload;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.CheckBox checkBoxcheatreinstall;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.CheckBox checkBoxgamereinstall;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button button3;
	}
}
