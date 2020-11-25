using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Test
{
	public partial class GDI : Form
	{
		int a = 500, b = 200;
		bool isMoveDown = true;
		public GDI()
		{
			InitializeComponent();
			timer1.Enabled = true;
			this.DoubleBuffered = true; 
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(isMoveDown==true)
			{
				if (a > 0)
				{
					a -= 5;
					b -= 5;
				}
				else
				{
					isMoveDown = false;
				}
			}
			else
			{
				if (a < this.Height)
				{
					a += 5;
					b += 5;
				}
				else
				{
					isMoveDown = true;
				}
			}
			this.Invalidate();
			this.Update();
			this.Refresh();
		}

		private void GDI_Paint(object sender, PaintEventArgs e)
		{
			// Kiểu kẻ 1 đường thẳng
			//Graphics g = e.Graphics;
			//Pen pen = new Pen(Color.Red);
			//g.DrawLine(pen, 0, 0, a, b);

		}
		protected override void OnPaint(PaintEventArgs e)
		{
			//Bitmap bmp = new Bitmap(200, 200);
			//Graphics g = Graphics.FromImage(bmp);
			//g.FillRectangle(Brushes.Cyan, 0, 0, 200, 200);
			//Pen pen = new Pen(Color.Magenta, 5);
			//g.DrawLine(pen, new Point(0, 150), new Point(100, 50));
			//e.Graphics.DrawImageUnscaled(bmp, 0, 0);
			Graphics g = e.Graphics;
			Rectangle rect = new Rectangle(10, 10, 100, 120);
			int x = 30, y = 40, width = 400, height = 50;
			g.DrawRectangle(Pens.Black, rect);
			g.DrawRectangle(Pens.Red, x, y, width, height);
		}


	}
}
