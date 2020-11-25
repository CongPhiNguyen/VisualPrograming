namespace GDI_Test
{
	partial class GDI3
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
			this.tbTension = new System.Windows.Forms.TextBox();
			this.lbTension = new System.Windows.Forms.Label();
			this.btDraw = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbTension
			// 
			this.tbTension.Location = new System.Drawing.Point(504, 25);
			this.tbTension.Name = "tbTension";
			this.tbTension.Size = new System.Drawing.Size(100, 20);
			this.tbTension.TabIndex = 0;
			// 
			// lbTension
			// 
			this.lbTension.AutoSize = true;
			this.lbTension.Location = new System.Drawing.Point(453, 32);
			this.lbTension.Name = "lbTension";
			this.lbTension.Size = new System.Drawing.Size(45, 13);
			this.lbTension.TabIndex = 1;
			this.lbTension.Text = "Tension";
			// 
			// btDraw
			// 
			this.btDraw.Location = new System.Drawing.Point(504, 61);
			this.btDraw.Name = "btDraw";
			this.btDraw.Size = new System.Drawing.Size(100, 23);
			this.btDraw.TabIndex = 2;
			this.btDraw.Text = "Draw";
			this.btDraw.UseVisualStyleBackColor = true;
			this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
			// 
			// GDI3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 321);
			this.Controls.Add(this.btDraw);
			this.Controls.Add(this.lbTension);
			this.Controls.Add(this.tbTension);
			this.Name = "GDI3";
			this.Text = "GDI3";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GDI3_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbTension;
		private System.Windows.Forms.Label lbTension;
		private System.Windows.Forms.Button btDraw;
	}
}