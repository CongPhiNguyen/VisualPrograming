namespace GDI_ver_2._0
{
	partial class GDI_Brush
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
			this.btSolidBrush = new System.Windows.Forms.Button();
			this.btHatch = new System.Windows.Forms.Button();
			this.btGradient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btSolidBrush
			// 
			this.btSolidBrush.Location = new System.Drawing.Point(0, 12);
			this.btSolidBrush.Name = "btSolidBrush";
			this.btSolidBrush.Size = new System.Drawing.Size(87, 23);
			this.btSolidBrush.TabIndex = 0;
			this.btSolidBrush.Text = "Solid Brush";
			this.btSolidBrush.UseVisualStyleBackColor = true;
			// 
			// btHatch
			// 
			this.btHatch.Location = new System.Drawing.Point(0, 50);
			this.btHatch.Name = "btHatch";
			this.btHatch.Size = new System.Drawing.Size(87, 23);
			this.btHatch.TabIndex = 0;
			this.btHatch.Text = "Hatch Brush";
			this.btHatch.UseVisualStyleBackColor = true;
			// 
			// btGradient
			// 
			this.btGradient.Location = new System.Drawing.Point(0, 89);
			this.btGradient.Name = "btGradient";
			this.btGradient.Size = new System.Drawing.Size(87, 23);
			this.btGradient.TabIndex = 0;
			this.btGradient.Text = "Gradient Brush";
			this.btGradient.UseVisualStyleBackColor = true;
			// 
			// GDI_Brush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 347);
			this.Controls.Add(this.btGradient);
			this.Controls.Add(this.btHatch);
			this.Controls.Add(this.btSolidBrush);
			this.Name = "GDI_Brush";
			this.Text = "Brush";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Brush_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GDI_Brush_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GDI_Brush_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GDI_Brush_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btSolidBrush;
		private System.Windows.Forms.Button btHatch;
		private System.Windows.Forms.Button btGradient;
	}
}