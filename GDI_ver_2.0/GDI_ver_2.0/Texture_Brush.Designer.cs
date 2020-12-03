namespace GDI_ver_2._0
{
	partial class Texture_Brush
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
			this.cbTile = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cbTile
			// 
			this.cbTile.AutoSize = true;
			this.cbTile.Location = new System.Drawing.Point(12, 12);
			this.cbTile.Name = "cbTile";
			this.cbTile.Size = new System.Drawing.Size(81, 17);
			this.cbTile.TabIndex = 0;
			this.cbTile.Text = "Tiling Brush";
			this.cbTile.UseVisualStyleBackColor = true;
			// 
			// Texture_Brush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(609, 334);
			this.Controls.Add(this.cbTile);
			this.Name = "Texture_Brush";
			this.Text = "Texture_Brush";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Texture_Brush_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Texture_Brush_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbTile;
	}
}