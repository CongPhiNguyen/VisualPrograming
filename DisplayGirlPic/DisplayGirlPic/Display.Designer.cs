namespace DisplayGirlPic
{
	partial class Display
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tab1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btPrev = new System.Windows.Forms.Button();
			this.cbName = new System.Windows.Forms.ComboBox();
			this.btNext = new System.Windows.Forms.Button();
			this.picMain = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lbLink = new System.Windows.Forms.TextBox();
			this.tab1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.Controls.Add(this.tabPage1);
			this.tab1.Controls.Add(this.tabPage2);
			this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab1.Location = new System.Drawing.Point(0, 0);
			this.tab1.Name = "tab1";
			this.tab1.SelectedIndex = 0;
			this.tab1.Size = new System.Drawing.Size(800, 525);
			this.tab1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lbLink);
			this.tabPage1.Controls.Add(this.btPrev);
			this.tabPage1.Controls.Add(this.cbName);
			this.tabPage1.Controls.Add(this.btNext);
			this.tabPage1.Controls.Add(this.picMain);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 499);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Picture and link";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btPrev
			// 
			this.btPrev.Location = new System.Drawing.Point(23, 203);
			this.btPrev.Name = "btPrev";
			this.btPrev.Size = new System.Drawing.Size(64, 61);
			this.btPrev.TabIndex = 4;
			this.btPrev.Text = "Previous";
			this.btPrev.UseVisualStyleBackColor = true;
			this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
			// 
			// cbName
			// 
			this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbName.FormattingEnabled = true;
			this.cbName.Location = new System.Drawing.Point(247, 6);
			this.cbName.Name = "cbName";
			this.cbName.Size = new System.Drawing.Size(297, 21);
			this.cbName.TabIndex = 3;
			this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point(693, 203);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(67, 61);
			this.btNext.TabIndex = 2;
			this.btNext.Text = "Next";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler(this.btNext_Click);
			// 
			// picMain
			// 
			this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picMain.Location = new System.Drawing.Point(117, 33);
			this.picMain.Name = "picMain";
			this.picMain.Size = new System.Drawing.Size(557, 420);
			this.picMain.TabIndex = 0;
			this.picMain.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 499);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lbLink
			// 
			this.lbLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbLink.Font = new System.Drawing.Font("SVN-Agency FB", 16.25F);
			this.lbLink.Location = new System.Drawing.Point(117, 461);
			this.lbLink.Name = "lbLink";
			this.lbLink.Size = new System.Drawing.Size(557, 28);
			this.lbLink.TabIndex = 5;
			this.lbLink.TabStop = false;
			this.lbLink.Text = "Link: ";
			this.lbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.lbLink.DoubleClick += new System.EventHandler(this.lbLink_Click);
			// 
			// Display
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 525);
			this.Controls.Add(this.tab1);
			this.Name = "Display";
			this.Text = "Pic Here";
			this.tab1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tab1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.PictureBox picMain;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.ComboBox cbName;
		private System.Windows.Forms.Button btPrev;
		private System.Windows.Forms.TextBox lbLink;
	}
}

