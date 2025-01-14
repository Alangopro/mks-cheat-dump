namespace BSP_Launcher
{
	// Token: 0x02000005 RID: 5
	public partial class loginform : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003555 File Offset: 0x00001755
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003574 File Offset: 0x00001774
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BSP_Launcher.loginform));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(11, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(268, 20);
			this.textBox1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 3);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			this.textBox2.Location = new global::System.Drawing.Point(11, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(204, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.UseSystemPasswordChar = true;
			this.button1.Location = new global::System.Drawing.Point(222, 69);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(57, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "show";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(11, 112);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(77, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Login";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.Location = new global::System.Drawing.Point(173, 112);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(106, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Create account";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.GrayText;
			base.ClientSize = new global::System.Drawing.Size(291, 150);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "loginform";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Login into MKS account";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.loginform_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001E RID: 30
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Button button3;
	}
}
