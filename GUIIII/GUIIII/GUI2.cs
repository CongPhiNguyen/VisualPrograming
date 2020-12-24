using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIIII
{
	public partial class GUI2 : Form
	{
		List<Rectangle> ls = new List<Rectangle>();
		void Render()
		{
			for(int i=0;i<10;i++)
			{

			}	
		}
		public GUI2()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		private void GUI2_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Left)
			{
				if(pbSpaceShip.Location.X - 5 > 0)
					pbSpaceShip.Location= new System.Drawing.Point(pbSpaceShip.Location.X - 5, pbSpaceShip.Location.Y);
			}
			else if (e.KeyCode == Keys.Right)
			{
				if(pbSpaceShip.Location.X + 5 < this.Width - pbSpaceShip.Size.Width)
					pbSpaceShip.Location = new System.Drawing.Point(pbSpaceShip.Location.X + 5, pbSpaceShip.Location.Y);
			}
			else if (e.KeyCode == Keys.Up)
			{
				if(pbSpaceShip.Location.Y - 5 > 0)
				{
					pbSpaceShip.Location = new System.Drawing.Point(pbSpaceShip.Location.X , pbSpaceShip.Location.Y - 5);
				}	
			}
			else if (e.KeyCode == Keys.Down)
			{
				if (pbSpaceShip.Location.Y + 5 < this.Height - pbSpaceShip.Size.Height)
					pbSpaceShip.Location = new System.Drawing.Point(pbSpaceShip.Location.X , pbSpaceShip.Location.Y + 5);
			}
		}
	}
}
