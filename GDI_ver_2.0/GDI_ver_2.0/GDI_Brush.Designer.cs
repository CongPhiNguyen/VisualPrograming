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
			this.tbSize = new System.Windows.Forms.TextBox();
			this.btColor = new System.Windows.Forms.Button();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.btForeColor = new System.Windows.Forms.Button();
			this.btBackColor = new System.Windows.Forms.Button();
			this.btTexture = new System.Windows.Forms.Button();
			this.btGra1 = new System.Windows.Forms.Button();
			this.btGra2 = new System.Windows.Forms.Button();
			this.tbGraSize = new System.Windows.Forms.TextBox();
			this.pnBrush = new System.Windows.Forms.FlowLayoutPanel();
			this.btSize_nouse = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnBrush.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSolidBrush
			// 
			this.btSolidBrush.Location = new System.Drawing.Point(3, 3);
			this.btSolidBrush.Name = "btSolidBrush";
			this.btSolidBrush.Size = new System.Drawing.Size(75, 23);
			this.btSolidBrush.TabIndex = 0;
			this.btSolidBrush.Text = "Solid Brush";
			this.btSolidBrush.UseVisualStyleBackColor = true;
			this.btSolidBrush.Click += new System.EventHandler(this.btSolidBrush_Click);
			// 
			// btHatch
			// 
			this.btHatch.Location = new System.Drawing.Point(121, 3);
			this.btHatch.Name = "btHatch";
			this.btHatch.Size = new System.Drawing.Size(78, 23);
			this.btHatch.TabIndex = 0;
			this.btHatch.Text = "Hatch Brush";
			this.btHatch.UseVisualStyleBackColor = true;
			this.btHatch.Click += new System.EventHandler(this.btHatch_Click);
			// 
			// btGradient
			// 
			this.btGradient.Location = new System.Drawing.Point(483, 3);
			this.btGradient.Name = "btGradient";
			this.btGradient.Size = new System.Drawing.Size(87, 23);
			this.btGradient.TabIndex = 0;
			this.btGradient.Text = "Gradient Brush";
			this.btGradient.UseVisualStyleBackColor = true;
			this.btGradient.Click += new System.EventHandler(this.btGradient_Click);
			// 
			// tbSize
			// 
			this.tbSize.Location = new System.Drawing.Point(742, 3);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(34, 20);
			this.tbSize.TabIndex = 2;
			this.tbSize.Enter += new System.EventHandler(this.tbSize_Enter);
			this.tbSize.Leave += new System.EventHandler(this.tbSize_Leave);
			// 
			// btColor
			// 
			this.btColor.BackColor = System.Drawing.Color.Cyan;
			this.btColor.Location = new System.Drawing.Point(84, 3);
			this.btColor.Name = "btColor";
			this.btColor.Size = new System.Drawing.Size(31, 23);
			this.btColor.TabIndex = 4;
			this.btColor.UseVisualStyleBackColor = false;
			this.btColor.Click += new System.EventHandler(this.btColor_Click);
			// 
			// cbType
			// 
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
            "BackwardDiagonal",
            "Cross",
            "DiagonalCross",
            "HorizontalBrick",
            "LightDownwardDiagonal",
            "LightUpwardDiagonal"});
			this.cbType.Location = new System.Drawing.Point(205, 3);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(103, 21);
			this.cbType.TabIndex = 5;
			this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
			// 
			// btForeColor
			// 
			this.btForeColor.BackColor = System.Drawing.Color.Blue;
			this.btForeColor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btForeColor.Location = new System.Drawing.Point(314, 3);
			this.btForeColor.Name = "btForeColor";
			this.btForeColor.Size = new System.Drawing.Size(35, 23);
			this.btForeColor.TabIndex = 6;
			this.btForeColor.UseVisualStyleBackColor = false;
			this.btForeColor.Click += new System.EventHandler(this.btForeColor_Click);
			// 
			// btBackColor
			// 
			this.btBackColor.BackColor = System.Drawing.Color.Red;
			this.btBackColor.Location = new System.Drawing.Point(355, 3);
			this.btBackColor.Name = "btBackColor";
			this.btBackColor.Size = new System.Drawing.Size(32, 23);
			this.btBackColor.TabIndex = 7;
			this.btBackColor.UseVisualStyleBackColor = false;
			this.btBackColor.Click += new System.EventHandler(this.btBackColor_Click);
			// 
			// btTexture
			// 
			this.btTexture.Location = new System.Drawing.Point(393, 3);
			this.btTexture.Name = "btTexture";
			this.btTexture.Size = new System.Drawing.Size(84, 23);
			this.btTexture.TabIndex = 8;
			this.btTexture.Text = "Texture Brush";
			this.btTexture.UseVisualStyleBackColor = true;
			this.btTexture.Click += new System.EventHandler(this.btTexture_Click);
			// 
			// btGra1
			// 
			this.btGra1.BackColor = System.Drawing.Color.Cyan;
			this.btGra1.Location = new System.Drawing.Point(576, 3);
			this.btGra1.Name = "btGra1";
			this.btGra1.Size = new System.Drawing.Size(36, 23);
			this.btGra1.TabIndex = 9;
			this.btGra1.UseVisualStyleBackColor = false;
			this.btGra1.Click += new System.EventHandler(this.btGra1_Click);
			// 
			// btGra2
			// 
			this.btGra2.BackColor = System.Drawing.Color.Magenta;
			this.btGra2.Location = new System.Drawing.Point(618, 3);
			this.btGra2.Name = "btGra2";
			this.btGra2.Size = new System.Drawing.Size(36, 23);
			this.btGra2.TabIndex = 10;
			this.btGra2.UseVisualStyleBackColor = false;
			this.btGra2.Click += new System.EventHandler(this.btGra2_Click);
			// 
			// tbGraSize
			// 
			this.tbGraSize.Location = new System.Drawing.Point(660, 3);
			this.tbGraSize.Name = "tbGraSize";
			this.tbGraSize.Size = new System.Drawing.Size(30, 20);
			this.tbGraSize.TabIndex = 11;
			this.tbGraSize.Text = "20";
			// 
			// pnBrush
			// 
			this.pnBrush.Controls.Add(this.btSolidBrush);
			this.pnBrush.Controls.Add(this.btColor);
			this.pnBrush.Controls.Add(this.btHatch);
			this.pnBrush.Controls.Add(this.cbType);
			this.pnBrush.Controls.Add(this.btForeColor);
			this.pnBrush.Controls.Add(this.btBackColor);
			this.pnBrush.Controls.Add(this.btTexture);
			this.pnBrush.Controls.Add(this.btGradient);
			this.pnBrush.Controls.Add(this.btGra1);
			this.pnBrush.Controls.Add(this.btGra2);
			this.pnBrush.Controls.Add(this.tbGraSize);
			this.pnBrush.Controls.Add(this.btSize_nouse);
			this.pnBrush.Controls.Add(this.tbSize);
			this.pnBrush.Location = new System.Drawing.Point(0, 27);
			this.pnBrush.Name = "pnBrush";
			this.pnBrush.Size = new System.Drawing.Size(903, 33);
			this.pnBrush.TabIndex = 12;
			// 
			// btSize_nouse
			// 
			this.btSize_nouse.Location = new System.Drawing.Point(696, 3);
			this.btSize_nouse.Name = "btSize_nouse";
			this.btSize_nouse.Size = new System.Drawing.Size(40, 23);
			this.btSize_nouse.TabIndex = 12;
			this.btSize_nouse.Text = "Size";
			this.btSize_nouse.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(915, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// brushToolStripMenuItem
			// 
			this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
			this.brushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.brushToolStripMenuItem.Text = "Brush";
			// 
			// GDI_Brush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 392);
			this.Controls.Add(this.pnBrush);
			this.Controls.Add(this.menuStrip1);
			this.Name = "GDI_Brush";
			this.Text = "Brush";
			this.Click += new System.EventHandler(this.GDI_Brush_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Brush_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GDI_Brush_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GDI_Brush_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GDI_Brush_MouseUp);
			this.pnBrush.ResumeLayout(false);
			this.pnBrush.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btSolidBrush;
		private System.Windows.Forms.Button btHatch;
		private System.Windows.Forms.Button btGradient;
		private System.Windows.Forms.TextBox tbSize;
		private System.Windows.Forms.Button btColor;
		public System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Button btForeColor;
		private System.Windows.Forms.Button btBackColor;
		private System.Windows.Forms.Button btTexture;
		private System.Windows.Forms.Button btGra1;
		private System.Windows.Forms.Button btGra2;
		private System.Windows.Forms.TextBox tbGraSize;
		private System.Windows.Forms.FlowLayoutPanel pnBrush;
		private System.Windows.Forms.Button btSize_nouse;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
	}
}