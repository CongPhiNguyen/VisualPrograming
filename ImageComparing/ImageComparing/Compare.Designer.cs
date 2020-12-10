namespace ImageComparing
{
	partial class Compare
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
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.pb2 = new System.Windows.Forms.PictureBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.lbValue = new System.Windows.Forms.Label();
			this.lbTolerance = new System.Windows.Forms.Label();
			this.lbDone = new System.Windows.Forms.Label();
			this.lbResultGroup = new System.Windows.Forms.Label();
			this.btNext = new System.Windows.Forms.Button();
			this.btPrev = new System.Windows.Forms.Button();
			this.lbGroupSize = new System.Windows.Forms.Label();
			this.btPrevPic = new System.Windows.Forms.Button();
			this.btNextPic = new System.Windows.Forms.Button();
			this.tbIndex = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// pb1
			// 
			this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pb1.Location = new System.Drawing.Point(12, 114);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(287, 267);
			this.pb1.TabIndex = 0;
			this.pb1.TabStop = false;
			// 
			// pb2
			// 
			this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pb2.Location = new System.Drawing.Point(305, 114);
			this.pb2.Name = "pb2";
			this.pb2.Size = new System.Drawing.Size(287, 267);
			this.pb2.TabIndex = 0;
			this.pb2.TabStop = false;
			// 
			// lbTitle
			// 
			this.lbTitle.AllowDrop = true;
			this.lbTitle.Font = new System.Drawing.Font("SVN-Agency FB", 35.25F);
			this.lbTitle.Location = new System.Drawing.Point(7, -3);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(577, 79);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Similiar picture";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.Location = new System.Drawing.Point(168, 79);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(237, 32);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
			this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
			// 
			// lbValue
			// 
			this.lbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lbValue.Location = new System.Drawing.Point(406, 81);
			this.lbValue.Name = "lbValue";
			this.lbValue.Size = new System.Drawing.Size(42, 30);
			this.lbValue.TabIndex = 3;
			this.lbValue.Text = "30";
			// 
			// lbTolerance
			// 
			this.lbTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lbTolerance.Location = new System.Drawing.Point(76, 81);
			this.lbTolerance.Name = "lbTolerance";
			this.lbTolerance.Size = new System.Drawing.Size(86, 30);
			this.lbTolerance.TabIndex = 3;
			this.lbTolerance.Text = "Tolerance";
			// 
			// lbDone
			// 
			this.lbDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lbDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lbDone.Location = new System.Drawing.Point(454, 81);
			this.lbDone.Name = "lbDone";
			this.lbDone.Size = new System.Drawing.Size(49, 30);
			this.lbDone.TabIndex = 3;
			this.lbDone.Text = "Done";
			this.lbDone.Visible = false;
			// 
			// lbResultGroup
			// 
			this.lbResultGroup.AllowDrop = true;
			this.lbResultGroup.AutoSize = true;
			this.lbResultGroup.Font = new System.Drawing.Font("SVN-Agency FB", 16.25F);
			this.lbResultGroup.Location = new System.Drawing.Point(12, 401);
			this.lbResultGroup.Name = "lbResultGroup";
			this.lbResultGroup.Size = new System.Drawing.Size(58, 29);
			this.lbResultGroup.TabIndex = 1;
			this.lbResultGroup.Text = "Group ";
			this.lbResultGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point(519, 399);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(73, 31);
			this.btNext.TabIndex = 4;
			this.btNext.Text = "Next Group";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler(this.btNext_Click);
			// 
			// btPrev
			// 
			this.btPrev.Location = new System.Drawing.Point(411, 399);
			this.btPrev.Name = "btPrev";
			this.btPrev.Size = new System.Drawing.Size(92, 31);
			this.btPrev.TabIndex = 4;
			this.btPrev.Text = "Previous Group";
			this.btPrev.UseVisualStyleBackColor = true;
			this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
			// 
			// lbGroupSize
			// 
			this.lbGroupSize.AllowDrop = true;
			this.lbGroupSize.AutoSize = true;
			this.lbGroupSize.Font = new System.Drawing.Font("SVN-Agency FB", 13.25F);
			this.lbGroupSize.Location = new System.Drawing.Point(13, 430);
			this.lbGroupSize.Name = "lbGroupSize";
			this.lbGroupSize.Size = new System.Drawing.Size(77, 24);
			this.lbGroupSize.TabIndex = 1;
			this.lbGroupSize.Text = "Group size: ";
			this.lbGroupSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btPrevPic
			// 
			this.btPrevPic.Location = new System.Drawing.Point(410, 436);
			this.btPrevPic.Name = "btPrevPic";
			this.btPrevPic.Size = new System.Drawing.Size(65, 31);
			this.btPrevPic.TabIndex = 4;
			this.btPrevPic.Text = "Previous";
			this.btPrevPic.UseVisualStyleBackColor = true;
			this.btPrevPic.Click += new System.EventHandler(this.btPrevPic_Click);
			// 
			// btNextPic
			// 
			this.btNextPic.Location = new System.Drawing.Point(531, 436);
			this.btNextPic.Name = "btNextPic";
			this.btNextPic.Size = new System.Drawing.Size(61, 31);
			this.btNextPic.TabIndex = 4;
			this.btNextPic.Text = "Next";
			this.btNextPic.UseVisualStyleBackColor = true;
			this.btNextPic.Click += new System.EventHandler(this.btNextPic_Click);
			// 
			// tbIndex
			// 
			this.tbIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
			this.tbIndex.Location = new System.Drawing.Point(481, 439);
			this.tbIndex.Name = "tbIndex";
			this.tbIndex.Size = new System.Drawing.Size(44, 28);
			this.tbIndex.TabIndex = 5;
			this.tbIndex.Text = "0";
			this.tbIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Compare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 469);
			this.Controls.Add(this.tbIndex);
			this.Controls.Add(this.btPrevPic);
			this.Controls.Add(this.btNextPic);
			this.Controls.Add(this.btPrev);
			this.Controls.Add(this.btNext);
			this.Controls.Add(this.lbTolerance);
			this.Controls.Add(this.lbDone);
			this.Controls.Add(this.lbValue);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.lbGroupSize);
			this.Controls.Add(this.lbResultGroup);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pb2);
			this.Controls.Add(this.pb1);
			this.Name = "Compare";
			this.Text = "Compare";
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pb1;
		private System.Windows.Forms.PictureBox pb2;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label lbValue;
		private System.Windows.Forms.Label lbTolerance;
		private System.Windows.Forms.Label lbDone;
		private System.Windows.Forms.Label lbResultGroup;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.Button btPrev;
		private System.Windows.Forms.Label lbGroupSize;
		private System.Windows.Forms.Button btPrevPic;
		private System.Windows.Forms.Button btNextPic;
		private System.Windows.Forms.TextBox tbIndex;
	}
}

