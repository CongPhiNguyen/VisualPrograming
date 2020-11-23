namespace MDIdemo
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
			this.mDI1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mDI2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrangreIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.typeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(529, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// formToolStripMenuItem
			// 
			this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDI1ToolStripMenuItem,
            this.mDI2ToolStripMenuItem});
			this.formToolStripMenuItem.Name = "formToolStripMenuItem";
			this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.formToolStripMenuItem.Text = "Form";
			// 
			// mDI1ToolStripMenuItem
			// 
			this.mDI1ToolStripMenuItem.Name = "mDI1ToolStripMenuItem";
			this.mDI1ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.mDI1ToolStripMenuItem.Text = "MDI1";
			this.mDI1ToolStripMenuItem.Click += new System.EventHandler(this.mDI1ToolStripMenuItem_Click);
			// 
			// mDI2ToolStripMenuItem
			// 
			this.mDI2ToolStripMenuItem.Name = "mDI2ToolStripMenuItem";
			this.mDI2ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.mDI2ToolStripMenuItem.Text = "MDI2";
			this.mDI2ToolStripMenuItem.Click += new System.EventHandler(this.mDI2ToolStripMenuItem_Click);
			// 
			// typeToolStripMenuItem
			// 
			this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.arrangreIconToolStripMenuItem});
			this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
			this.typeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.typeToolStripMenuItem.Text = "Type";
			// 
			// tileHorizontalToolStripMenuItem
			// 
			this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
			this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
			this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
			// 
			// tileVerticalToolStripMenuItem
			// 
			this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
			this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
			this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
			// 
			// cascadeToolStripMenuItem
			// 
			this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
			this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.cascadeToolStripMenuItem.Text = "Cascade";
			this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
			// 
			// arrangreIconToolStripMenuItem
			// 
			this.arrangreIconToolStripMenuItem.Name = "arrangreIconToolStripMenuItem";
			this.arrangreIconToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.arrangreIconToolStripMenuItem.Text = "Arrangre Icon";
			this.arrangreIconToolStripMenuItem.Click += new System.EventHandler(this.arrangreIconToolStripMenuItem_Click);
			// 
			// MDI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 314);
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
		private System.Windows.Forms.ToolStripMenuItem mDI1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mDI2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arrangreIconToolStripMenuItem;
	}
}

