namespace GUIIII
{
	partial class GUI4
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
			this.SuspendLayout();
			// 
			// GUI4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 344);
			this.Name = "GUI4";
			this.Text = "GUI4";
			this.Click += new System.EventHandler(this.Mouse_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GUI4_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI4_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion
	}
}