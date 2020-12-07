namespace GDI_ver_2._0
{
	partial class LineMaster
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
			this.cbStartCap = new System.Windows.Forms.ComboBox();
			this.cbEndCap = new System.Windows.Forms.ComboBox();
			this.cbDash = new System.Windows.Forms.ComboBox();
			this.lbStartCap = new System.Windows.Forms.Label();
			this.lbEndCap = new System.Windows.Forms.Label();
			this.lbDashStyle = new System.Windows.Forms.Label();
			this.tbSize = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbColor = new System.Windows.Forms.Label();
			this.btColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbStartCap
			// 
			this.cbStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStartCap.FormattingEnabled = true;
			this.cbStartCap.Items.AddRange(new object[] {
            " AnchorMask",
            " ArrowAnchor",
            " Custom",
            " DiamondAnchor",
            " Flat",
            " NoAnchor",
            " Round",
            " RoundAnchor",
            " Square",
            " SquareAnchor",
            " Triangle"});
			this.cbStartCap.Location = new System.Drawing.Point(88, 26);
			this.cbStartCap.Name = "cbStartCap";
			this.cbStartCap.Size = new System.Drawing.Size(103, 21);
			this.cbStartCap.TabIndex = 0;
			// 
			// cbEndCap
			// 
			this.cbEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEndCap.FormattingEnabled = true;
			this.cbEndCap.Items.AddRange(new object[] {
            " AnchorMask",
            " ArrowAnchor",
            " Custom",
            " DiamondAnchor",
            " Flat",
            " NoAnchor",
            " Round",
            " RoundAnchor",
            " Square",
            " SquareAnchor",
            " Triangle"});
			this.cbEndCap.Location = new System.Drawing.Point(268, 26);
			this.cbEndCap.Name = "cbEndCap";
			this.cbEndCap.Size = new System.Drawing.Size(133, 21);
			this.cbEndCap.TabIndex = 1;
			// 
			// cbDash
			// 
			this.cbDash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDash.FormattingEnabled = true;
			this.cbDash.Items.AddRange(new object[] {
            "• Custom",
            "• Dash",
            "• DashDot",
            "• DashDotDot",
            "• Dot",
            "• Solid"});
			this.cbDash.Location = new System.Drawing.Point(492, 26);
			this.cbDash.Name = "cbDash";
			this.cbDash.Size = new System.Drawing.Size(133, 21);
			this.cbDash.TabIndex = 1;
			// 
			// lbStartCap
			// 
			this.lbStartCap.AutoSize = true;
			this.lbStartCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.lbStartCap.Location = new System.Drawing.Point(12, 29);
			this.lbStartCap.Name = "lbStartCap";
			this.lbStartCap.Size = new System.Drawing.Size(70, 18);
			this.lbStartCap.TabIndex = 2;
			this.lbStartCap.Text = "Start Cap";
			// 
			// lbEndCap
			// 
			this.lbEndCap.AutoSize = true;
			this.lbEndCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.lbEndCap.Location = new System.Drawing.Point(197, 29);
			this.lbEndCap.Name = "lbEndCap";
			this.lbEndCap.Size = new System.Drawing.Size(65, 18);
			this.lbEndCap.TabIndex = 2;
			this.lbEndCap.Text = "End Cap";
			// 
			// lbDashStyle
			// 
			this.lbDashStyle.AutoSize = true;
			this.lbDashStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.lbDashStyle.Location = new System.Drawing.Point(407, 29);
			this.lbDashStyle.Name = "lbDashStyle";
			this.lbDashStyle.Size = new System.Drawing.Size(79, 18);
			this.lbDashStyle.TabIndex = 2;
			this.lbDashStyle.Text = "Dash Style";
			// 
			// tbSize
			// 
			this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.tbSize.Location = new System.Drawing.Point(674, 26);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(37, 24);
			this.tbSize.TabIndex = 3;
			this.tbSize.Text = "4";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label4.Location = new System.Drawing.Point(631, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "Size";
			// 
			// lbColor
			// 
			this.lbColor.AutoSize = true;
			this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.lbColor.Location = new System.Drawing.Point(739, 29);
			this.lbColor.Name = "lbColor";
			this.lbColor.Size = new System.Drawing.Size(45, 18);
			this.lbColor.TabIndex = 4;
			this.lbColor.Text = "Color";
			// 
			// btColor
			// 
			this.btColor.BackColor = System.Drawing.Color.DimGray;
			this.btColor.Location = new System.Drawing.Point(790, 25);
			this.btColor.Name = "btColor";
			this.btColor.Size = new System.Drawing.Size(31, 28);
			this.btColor.TabIndex = 5;
			this.btColor.UseVisualStyleBackColor = false;
			this.btColor.Click += new System.EventHandler(this.btColor_Click);
			// 
			// LineMaster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 392);
			this.Controls.Add(this.btColor);
			this.Controls.Add(this.lbColor);
			this.Controls.Add(this.tbSize);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbDashStyle);
			this.Controls.Add(this.lbEndCap);
			this.Controls.Add(this.lbStartCap);
			this.Controls.Add(this.cbDash);
			this.Controls.Add(this.cbEndCap);
			this.Controls.Add(this.cbStartCap);
			this.Name = "LineMaster";
			this.Text = "LineMaster";
			this.Click += new System.EventHandler(this.LineMaster_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.LineMaster_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LineMaster_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbStartCap;
		private System.Windows.Forms.ComboBox cbEndCap;
		private System.Windows.Forms.ComboBox cbDash;
		private System.Windows.Forms.Label lbStartCap;
		private System.Windows.Forms.Label lbEndCap;
		private System.Windows.Forms.Label lbDashStyle;
		private System.Windows.Forms.TextBox tbSize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbColor;
		private System.Windows.Forms.Button btColor;
	}
}