namespace DropingShape
{
	partial class DropingShape
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
			this.components = new System.ComponentModel.Container();
			this.bttriangle = new System.Windows.Forms.Button();
			this.btRectangle = new System.Windows.Forms.Button();
			this.btCircle = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbListcount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bttriangle
			// 
			this.bttriangle.Location = new System.Drawing.Point(12, 32);
			this.bttriangle.Name = "bttriangle";
			this.bttriangle.Size = new System.Drawing.Size(75, 23);
			this.bttriangle.TabIndex = 0;
			this.bttriangle.Text = "Triangle";
			this.bttriangle.UseVisualStyleBackColor = true;
			this.bttriangle.Click += new System.EventHandler(this.bttriangle_Click);
			// 
			// btRectangle
			// 
			this.btRectangle.Location = new System.Drawing.Point(12, 73);
			this.btRectangle.Name = "btRectangle";
			this.btRectangle.Size = new System.Drawing.Size(75, 23);
			this.btRectangle.TabIndex = 0;
			this.btRectangle.Text = "Rectangle";
			this.btRectangle.UseVisualStyleBackColor = true;
			this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
			// 
			// btCircle
			// 
			this.btCircle.Location = new System.Drawing.Point(12, 117);
			this.btCircle.Name = "btCircle";
			this.btCircle.Size = new System.Drawing.Size(75, 23);
			this.btCircle.TabIndex = 0;
			this.btCircle.Text = "Circle";
			this.btCircle.UseVisualStyleBackColor = true;
			this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbListcount
			// 
			this.lbListcount.AutoSize = true;
			this.lbListcount.Location = new System.Drawing.Point(12, 289);
			this.lbListcount.Name = "lbListcount";
			this.lbListcount.Size = new System.Drawing.Size(29, 13);
			this.lbListcount.TabIndex = 1;
			this.lbListcount.Text = "List: ";
			// 
			// DropingShape
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 311);
			this.Controls.Add(this.lbListcount);
			this.Controls.Add(this.bttriangle);
			this.Controls.Add(this.btRectangle);
			this.Controls.Add(this.btCircle);
			this.Name = "DropingShape";
			this.Text = "Dropping shape";
			this.Click += new System.EventHandler(this.DropingShape_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DropingShape_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bttriangle;
		private System.Windows.Forms.Button btRectangle;
		private System.Windows.Forms.Button btCircle;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbListcount;
	}
}

