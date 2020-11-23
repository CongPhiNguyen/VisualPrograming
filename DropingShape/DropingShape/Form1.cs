using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropingShape
{	
	public partial class DropingShape : Form
	{
		private Point MouseDownLocation;
		int num = 1;
		List<Shape> ls = new List<Shape>();
		List<Brush> br = new List<Brush>();
		Brush[] myBrush = {Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Magenta, Brushes.Purple};
		Random r = new Random();
		public DropingShape()
		{
			InitializeComponent();
			timer1.Interval = 2;
			timer1.Enabled = true;
			this.DoubleBuffered = true;
		}

		private void bttriangle_Click(object sender, EventArgs e)
		{
			num = 1;
		}

		private void DropingShape_Paint(object sender, PaintEventArgs e)
		{
			this.lbListcount.Text = "Number: " + ls.Count;
			for (int i=0;i<ls.Count;i++)
			{
				ls[i].Draw(e,br[i]);
			}	
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MouseDownLocation = e.Location;
			}
		}

		private void btRectangle_Click(object sender, EventArgs e)
		{
			num = 2;
		}

		private void btCircle_Click(object sender, EventArgs e)
		{
			num = 3;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < ls.Count; i++)
			{
				ls[i].Move();
				if(ls[i].top > this.Height)
				{
					if (i < ls.Count && i >= 0)
					{
						ls.RemoveAt(i);
						br.RemoveAt(i);
					}
				}	
			}
			this.Invalidate();
			this.Update();
			this.Refresh();
		}

		private void DropingShape_Click(object sender, EventArgs e)
		{
			if (num == 1)
			{
				ls.Add(new Triangle(MouseDownLocation.X, MouseDownLocation.Y, 50));
				br.Add(myBrush[r.Next(0,9) % 7]);			
			}
			else if (num == 2)
			{
				ls.Add(new Rectangle(MouseDownLocation.X, MouseDownLocation.Y, 50, 50));
				br.Add(myBrush[r.Next(0,9) % 7]);
			}	
			else if(num==3)
			{
				ls.Add(new Circle(MouseDownLocation.X, MouseDownLocation.Y, 50));
				br.Add(myBrush[r.Next(0,9) % 7]);
			}
				
		}
	}
}
