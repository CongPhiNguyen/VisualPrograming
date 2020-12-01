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
			this.lbSize = new System.Windows.Forms.Label();
			this.btColor = new System.Windows.Forms.Button();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.btForeColor = new System.Windows.Forms.Button();
			this.btBackColor = new System.Windows.Forms.Button();
			this.btTexture = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btSolidBrush
			// 
			this.btSolidBrush.Location = new System.Drawing.Point(0, 3);
			this.btSolidBrush.Name = "btSolidBrush";
			this.btSolidBrush.Size = new System.Drawing.Size(87, 23);
			this.btSolidBrush.TabIndex = 0;
			this.btSolidBrush.Text = "Solid Brush";
			this.btSolidBrush.UseVisualStyleBackColor = true;
			this.btSolidBrush.Click += new System.EventHandler(this.btSolidBrush_Click);
			// 
			// btHatch
			// 
			this.btHatch.Location = new System.Drawing.Point(138, 3);
			this.btHatch.Name = "btHatch";
			this.btHatch.Size = new System.Drawing.Size(87, 23);
			this.btHatch.TabIndex = 0;
			this.btHatch.Text = "Hatch Brush";
			this.btHatch.UseVisualStyleBackColor = true;
			this.btHatch.Click += new System.EventHandler(this.btHatch_Click);
			// 
			// btGradient
			// 
			this.btGradient.Location = new System.Drawing.Point(530, 3);
			this.btGradient.Name = "btGradient";
			this.btGradient.Size = new System.Drawing.Size(87, 23);
			this.btGradient.TabIndex = 0;
			this.btGradient.Text = "Gradient Brush";
			this.btGradient.UseVisualStyleBackColor = true;
			this.btGradient.Click += new System.EventHandler(this.btGradient_Click);
			// 
			// tbSize
			// 
			this.tbSize.Location = new System.Drawing.Point(774, 3);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(41, 20);
			this.tbSize.TabIndex = 2;
			this.tbSize.Enter += new System.EventHandler(this.tbSize_Enter);
			this.tbSize.Leave += new System.EventHandler(this.tbSize_Leave);
			// 
			// lbSize
			// 
			this.lbSize.AutoSize = true;
			this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSize.Location = new System.Drawing.Point(731, 3);
			this.lbSize.Name = "lbSize";
			this.lbSize.Size = new System.Drawing.Size(37, 18);
			this.lbSize.TabIndex = 3;
			this.lbSize.Text = "Size";
			// 
			// btColor
			// 
			this.btColor.BackColor = System.Drawing.Color.Cyan;
			this.btColor.Location = new System.Drawing.Point(93, 3);
			this.btColor.Name = "btColor";
			this.btColor.Size = new System.Drawing.Size(39, 23);
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
			this.cbType.Location = new System.Drawing.Point(231, 3);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(124, 21);
			this.cbType.TabIndex = 5;
			this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
			// 
			// btForeColor
			// 
			this.btForeColor.BackColor = System.Drawing.Color.Blue;
			this.btForeColor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btForeColor.Location = new System.Drawing.Point(361, 3);
			this.btForeColor.Name = "btForeColor";
			this.btForeColor.Size = new System.Drawing.Size(35, 23);
			this.btForeColor.TabIndex = 6;
			this.btForeColor.UseVisualStyleBackColor = false;
			this.btForeColor.Click += new System.EventHandler(this.btForeColor_Click);
			// 
			// btBackColor
			// 
			this.btBackColor.BackColor = System.Drawing.Color.Red;
			this.btBackColor.Location = new System.Drawing.Point(402, 3);
			this.btBackColor.Name = "btBackColor";
			this.btBackColor.Size = new System.Drawing.Size(32, 23);
			this.btBackColor.TabIndex = 7;
			this.btBackColor.UseVisualStyleBackColor = false;
			this.btBackColor.Click += new System.EventHandler(this.btBackColor_Click);
			// 
			// btTexture
			// 
			this.btTexture.Location = new System.Drawing.Point(440, 3);
			this.btTexture.Name = "btTexture";
			this.btTexture.Size = new System.Drawing.Size(84, 23);
			this.btTexture.TabIndex = 8;
			this.btTexture.Text = "Texture Brush";
			this.btTexture.UseVisualStyleBackColor = true;
			this.btTexture.Click += new System.EventHandler(this.btTexture_Click);
			// 
			// GDI_Brush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 392);
			this.Controls.Add(this.btTexture);
			this.Controls.Add(this.btBackColor);
			this.Controls.Add(this.btForeColor);
			this.Controls.Add(this.cbType);
			this.Controls.Add(this.btColor);
			this.Controls.Add(this.lbSize);
			this.Controls.Add(this.tbSize);
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
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btSolidBrush;
		private System.Windows.Forms.Button btHatch;
		private System.Windows.Forms.Button btGradient;
		private System.Windows.Forms.TextBox tbSize;
		private System.Windows.Forms.Label lbSize;
		private System.Windows.Forms.Button btColor;
		public System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Button btForeColor;
		private System.Windows.Forms.Button btBackColor;
		private System.Windows.Forms.Button btTexture;
	}
}