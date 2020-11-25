namespace GDI_Test
{
	partial class GDI4_Pentool
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
			this.tbA = new System.Windows.Forms.TextBox();
			this.tbB = new System.Windows.Forms.TextBox();
			this.tbC = new System.Windows.Forms.TextBox();
			this.tbD = new System.Windows.Forms.TextBox();
			this.lbA = new System.Windows.Forms.Label();
			this.lbB = new System.Windows.Forms.Label();
			this.lbC = new System.Windows.Forms.Label();
			this.lbD = new System.Windows.Forms.Label();
			this.btDraw = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbA
			// 
			this.tbA.Location = new System.Drawing.Point(42, 16);
			this.tbA.Name = "tbA";
			this.tbA.Size = new System.Drawing.Size(87, 20);
			this.tbA.TabIndex = 0;
			// 
			// tbB
			// 
			this.tbB.Location = new System.Drawing.Point(42, 42);
			this.tbB.Name = "tbB";
			this.tbB.Size = new System.Drawing.Size(87, 20);
			this.tbB.TabIndex = 0;
			// 
			// tbC
			// 
			this.tbC.Location = new System.Drawing.Point(42, 68);
			this.tbC.Name = "tbC";
			this.tbC.Size = new System.Drawing.Size(87, 20);
			this.tbC.TabIndex = 0;
			// 
			// tbD
			// 
			this.tbD.Location = new System.Drawing.Point(42, 94);
			this.tbD.Name = "tbD";
			this.tbD.Size = new System.Drawing.Size(87, 20);
			this.tbD.TabIndex = 0;
			// 
			// lbA
			// 
			this.lbA.AutoSize = true;
			this.lbA.Location = new System.Drawing.Point(12, 23);
			this.lbA.Name = "lbA";
			this.lbA.Size = new System.Drawing.Size(14, 13);
			this.lbA.TabIndex = 1;
			this.lbA.Text = "A";
			// 
			// lbB
			// 
			this.lbB.AutoSize = true;
			this.lbB.Location = new System.Drawing.Point(12, 49);
			this.lbB.Name = "lbB";
			this.lbB.Size = new System.Drawing.Size(14, 13);
			this.lbB.TabIndex = 1;
			this.lbB.Text = "B";
			// 
			// lbC
			// 
			this.lbC.AutoSize = true;
			this.lbC.Location = new System.Drawing.Point(12, 75);
			this.lbC.Name = "lbC";
			this.lbC.Size = new System.Drawing.Size(14, 13);
			this.lbC.TabIndex = 1;
			this.lbC.Text = "C";
			// 
			// lbD
			// 
			this.lbD.AutoSize = true;
			this.lbD.Location = new System.Drawing.Point(12, 101);
			this.lbD.Name = "lbD";
			this.lbD.Size = new System.Drawing.Size(15, 13);
			this.lbD.TabIndex = 1;
			this.lbD.Text = "D";
			// 
			// btDraw
			// 
			this.btDraw.Location = new System.Drawing.Point(42, 120);
			this.btDraw.Name = "btDraw";
			this.btDraw.Size = new System.Drawing.Size(87, 23);
			this.btDraw.TabIndex = 2;
			this.btDraw.Text = "Draw Bezier";
			this.btDraw.UseVisualStyleBackColor = true;
			this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
			// 
			// GDI4_Pentool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 300);
			this.Controls.Add(this.btDraw);
			this.Controls.Add(this.lbD);
			this.Controls.Add(this.lbC);
			this.Controls.Add(this.lbB);
			this.Controls.Add(this.lbA);
			this.Controls.Add(this.tbD);
			this.Controls.Add(this.tbC);
			this.Controls.Add(this.tbB);
			this.Controls.Add(this.tbA);
			this.Name = "GDI4_Pentool";
			this.Text = "GDI4_Pentool";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GDI4_Pentool_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbA;
		private System.Windows.Forms.TextBox tbB;
		private System.Windows.Forms.TextBox tbC;
		private System.Windows.Forms.TextBox tbD;
		private System.Windows.Forms.Label lbA;
		private System.Windows.Forms.Label lbB;
		private System.Windows.Forms.Label lbC;
		private System.Windows.Forms.Label lbD;
		private System.Windows.Forms.Button btDraw;
	}
}