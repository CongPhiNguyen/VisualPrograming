namespace ImageDisplayer
{
	partial class ImageDisplayer
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
			this.picMain = new System.Windows.Forms.PictureBox();
			this.btPrev = new System.Windows.Forms.Button();
			this.btNext = new System.Windows.Forms.Button();
			this.btName = new System.Windows.Forms.Button();
			this.lbNum = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
			this.SuspendLayout();
			// 
			// picMain
			// 
			this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picMain.Location = new System.Drawing.Point(70, 30);
			this.picMain.Name = "picMain";
			this.picMain.Size = new System.Drawing.Size(650, 340);
			this.picMain.TabIndex = 0;
			this.picMain.TabStop = false;
			// 
			// btPrev
			// 
			this.btPrev.Location = new System.Drawing.Point(5, 158);
			this.btPrev.Name = "btPrev";
			this.btPrev.Size = new System.Drawing.Size(59, 52);
			this.btPrev.TabIndex = 1;
			this.btPrev.Text = "Previous";
			this.btPrev.UseVisualStyleBackColor = true;
			this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
			this.btPrev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageDisplayer_KeyDown);
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point(725, 158);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(59, 52);
			this.btNext.TabIndex = 1;
			this.btNext.Text = "Next";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler(this.btNext_Click);
			this.btNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageDisplayer_KeyDown);
			// 
			// btName
			// 
			this.btName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btName.Location = new System.Drawing.Point(70, 2);
			this.btName.Name = "btName";
			this.btName.Size = new System.Drawing.Size(650, 23);
			this.btName.TabIndex = 2;
			this.btName.UseVisualStyleBackColor = true;
			// 
			// lbNum
			// 
			this.lbNum.AutoSize = true;
			this.lbNum.Location = new System.Drawing.Point(2, 12);
			this.lbNum.Name = "lbNum";
			this.lbNum.Size = new System.Drawing.Size(29, 13);
			this.lbNum.TabIndex = 3;
			this.lbNum.Text = "Num";
			// 
			// ImageDisplayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 371);
			this.Controls.Add(this.lbNum);
			this.Controls.Add(this.btName);
			this.Controls.Add(this.btNext);
			this.Controls.Add(this.btPrev);
			this.Controls.Add(this.picMain);
			this.Name = "ImageDisplayer";
			this.Text = "Image Displayer";
			this.SizeChanged += new System.EventHandler(this.ImageDisplayer_SizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageDisplayer_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImageDisplayer_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImageDisplayer_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picMain;
		private System.Windows.Forms.Button btPrev;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.Button btName;
		private System.Windows.Forms.Label lbNum;
	}
}

