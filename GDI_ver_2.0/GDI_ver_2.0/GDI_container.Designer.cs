namespace GDI_ver_2._0
{
	partial class GDI_container
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gDIBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textureBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDIToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(915, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gDIToolStripMenuItem
			// 
			this.gDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDIBrushToolStripMenuItem,
            this.textureBrushToolStripMenuItem});
			this.gDIToolStripMenuItem.Name = "gDIToolStripMenuItem";
			this.gDIToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.gDIToolStripMenuItem.Text = "GDI";
			// 
			// gDIBrushToolStripMenuItem
			// 
			this.gDIBrushToolStripMenuItem.Name = "gDIBrushToolStripMenuItem";
			this.gDIBrushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gDIBrushToolStripMenuItem.Text = "GDI Brush";
			this.gDIBrushToolStripMenuItem.Click += new System.EventHandler(this.gDIBrushToolStripMenuItem_Click);
			// 
			// textureBrushToolStripMenuItem
			// 
			this.textureBrushToolStripMenuItem.Name = "textureBrushToolStripMenuItem";
			this.textureBrushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.textureBrushToolStripMenuItem.Text = "Texture Brush";
			this.textureBrushToolStripMenuItem.Click += new System.EventHandler(this.textureBrushToolStripMenuItem_Click);
			// 
			// GDI_container
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 392);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GDI_container";
			this.Text = "Main";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem gDIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gDIBrushToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textureBrushToolStripMenuItem;
	}
}

