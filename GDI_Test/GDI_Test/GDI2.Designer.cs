namespace GDI_Test
{
	partial class GDI2
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
			this.Start = new System.Windows.Forms.Label();
			this.lbSweepAngle = new System.Windows.Forms.Label();
			this.tbStartAngle = new System.Windows.Forms.TextBox();
			this.tbSweepAngle = new System.Windows.Forms.TextBox();
			this.btReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Start
			// 
			this.Start.AutoSize = true;
			this.Start.Location = new System.Drawing.Point(7, 52);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(59, 13);
			this.Start.TabIndex = 0;
			this.Start.Text = "Start Angle";
			// 
			// lbSweepAngle
			// 
			this.lbSweepAngle.AutoSize = true;
			this.lbSweepAngle.Location = new System.Drawing.Point(7, 90);
			this.lbSweepAngle.Name = "lbSweepAngle";
			this.lbSweepAngle.Size = new System.Drawing.Size(70, 13);
			this.lbSweepAngle.TabIndex = 0;
			this.lbSweepAngle.Text = "Sweep Angle";
			// 
			// tbStartAngle
			// 
			this.tbStartAngle.Location = new System.Drawing.Point(83, 45);
			this.tbStartAngle.Name = "tbStartAngle";
			this.tbStartAngle.Size = new System.Drawing.Size(100, 20);
			this.tbStartAngle.TabIndex = 1;
			// 
			// tbSweepAngle
			// 
			this.tbSweepAngle.Location = new System.Drawing.Point(83, 83);
			this.tbSweepAngle.Name = "tbSweepAngle";
			this.tbSweepAngle.Size = new System.Drawing.Size(100, 20);
			this.tbSweepAngle.TabIndex = 1;
			// 
			// btReset
			// 
			this.btReset.Location = new System.Drawing.Point(83, 125);
			this.btReset.Name = "btReset";
			this.btReset.Size = new System.Drawing.Size(100, 22);
			this.btReset.TabIndex = 2;
			this.btReset.Text = "Reset Angle";
			this.btReset.UseVisualStyleBackColor = true;
			this.btReset.Click += new System.EventHandler(this.btReset_Click);
			// 
			// GDI2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 318);
			this.Controls.Add(this.btReset);
			this.Controls.Add(this.tbSweepAngle);
			this.Controls.Add(this.tbStartAngle);
			this.Controls.Add(this.lbSweepAngle);
			this.Controls.Add(this.Start);
			this.Name = "GDI2";
			this.Text = "GDI2";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GDI2_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Start;
		private System.Windows.Forms.Label lbSweepAngle;
		private System.Windows.Forms.TextBox tbStartAngle;
		private System.Windows.Forms.TextBox tbSweepAngle;
		private System.Windows.Forms.Button btReset;
	}
}