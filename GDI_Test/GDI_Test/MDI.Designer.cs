namespace GDI_Test
{
	partial class MDI
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
			this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gDI2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gDI3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gDI4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(641, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// formToolStripMenuItem
			// 
			this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDIToolStripMenuItem,
            this.gDI2ToolStripMenuItem,
            this.gDI3ToolStripMenuItem,
            this.gDI4ToolStripMenuItem,
            this.polygonToolStripMenuItem});
			this.formToolStripMenuItem.Name = "formToolStripMenuItem";
			this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.formToolStripMenuItem.Text = "Form";
			// 
			// gDIToolStripMenuItem
			// 
			this.gDIToolStripMenuItem.Name = "gDIToolStripMenuItem";
			this.gDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gDIToolStripMenuItem.Text = "GDI";
			this.gDIToolStripMenuItem.Click += new System.EventHandler(this.gDIToolStripMenuItem_Click);
			// 
			// gDI2ToolStripMenuItem
			// 
			this.gDI2ToolStripMenuItem.Name = "gDI2ToolStripMenuItem";
			this.gDI2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gDI2ToolStripMenuItem.Text = "GDI2";
			this.gDI2ToolStripMenuItem.Click += new System.EventHandler(this.gDI2ToolStripMenuItem_Click);
			// 
			// gDI3ToolStripMenuItem
			// 
			this.gDI3ToolStripMenuItem.Name = "gDI3ToolStripMenuItem";
			this.gDI3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gDI3ToolStripMenuItem.Text = "GDI3";
			this.gDI3ToolStripMenuItem.Click += new System.EventHandler(this.gDI3ToolStripMenuItem_Click);
			// 
			// gDI4ToolStripMenuItem
			// 
			this.gDI4ToolStripMenuItem.Name = "gDI4ToolStripMenuItem";
			this.gDI4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gDI4ToolStripMenuItem.Text = "GDI4";
			this.gDI4ToolStripMenuItem.Click += new System.EventHandler(this.gDI4ToolStripMenuItem_Click);
			// 
			// polygonToolStripMenuItem
			// 
			this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
			this.polygonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.polygonToolStripMenuItem.Text = "Polygon";
			this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
			// 
			// MDI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 332);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDI";
			this.Text = "MDI";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gDIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gDI2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gDI3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gDI4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
	}
}