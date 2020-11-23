namespace MDIdemo
{
	partial class MDI1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMDI1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(654, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// formToolStripMenuItem
			// 
			this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMDI1ToolStripMenuItem});
			this.formToolStripMenuItem.Name = "formToolStripMenuItem";
			this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.formToolStripMenuItem.Text = "Form";
			// 
			// closeMDI1ToolStripMenuItem
			// 
			this.closeMDI1ToolStripMenuItem.Name = "closeMDI1ToolStripMenuItem";
			this.closeMDI1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.closeMDI1ToolStripMenuItem.Text = "Close MDI1";
			// 
			// MDI1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(654, 393);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDI1";
			this.Text = "MDI1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeMDI1ToolStripMenuItem;
	}
}