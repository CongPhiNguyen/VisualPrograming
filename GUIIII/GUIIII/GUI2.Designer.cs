namespace GUIIII
{
	partial class GUI2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI2));
			this.pbSpaceShip = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbSpaceShip)).BeginInit();
			this.SuspendLayout();
			// 
			// pbSpaceShip
			// 
			this.pbSpaceShip.BackColor = System.Drawing.Color.Transparent;
			this.pbSpaceShip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSpaceShip.BackgroundImage")));
			this.pbSpaceShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbSpaceShip.Location = new System.Drawing.Point(273, 291);
			this.pbSpaceShip.Name = "pbSpaceShip";
			this.pbSpaceShip.Size = new System.Drawing.Size(104, 113);
			this.pbSpaceShip.TabIndex = 0;
			this.pbSpaceShip.TabStop = false;
			// 
			// GUI2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(719, 404);
			this.Controls.Add(this.pbSpaceShip);
			this.Name = "GUI2";
			this.Text = "GUI2";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI2_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pbSpaceShip)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbSpaceShip;
	}
}