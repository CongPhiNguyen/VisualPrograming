namespace GDI_Test
{
	partial class Polygon
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
			this.btDraw = new System.Windows.Forms.Button();
			this.btFill = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btDraw
			// 
			this.btDraw.Location = new System.Drawing.Point(12, 12);
			this.btDraw.Name = "btDraw";
			this.btDraw.Size = new System.Drawing.Size(73, 26);
			this.btDraw.TabIndex = 0;
			this.btDraw.Text = "Draw";
			this.btDraw.UseVisualStyleBackColor = true;
			this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
			// 
			// btFill
			// 
			this.btFill.Location = new System.Drawing.Point(10, 58);
			this.btFill.Name = "btFill";
			this.btFill.Size = new System.Drawing.Size(75, 23);
			this.btFill.TabIndex = 1;
			this.btFill.Text = "Fill";
			this.btFill.UseVisualStyleBackColor = true;
			this.btFill.Click += new System.EventHandler(this.btFill_Click);
			// 
			// Polygon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(608, 299);
			this.Controls.Add(this.btFill);
			this.Controls.Add(this.btDraw);
			this.Name = "Polygon";
			this.Text = "Polygon";
			this.Click += new System.EventHandler(this.Polygon_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Polygon_Paint);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btDraw;
		private System.Windows.Forms.Button btFill;
	}
}