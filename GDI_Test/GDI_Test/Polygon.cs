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
	public partial class Polygon : Form
	{
		Point MouseLocation = new Point();
		List<Rectangle> points = new List<Rectangle>();
		bool isDraw = false;
		public Polygon()
		{
			InitializeComponent();
		}
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MouseLocation = e.Location;
			}
		}

		private void btDraw_Click(object sender, EventArgs e)
		{
			if(points.Count>2)
			{
				isDraw = true;
			}
			this.Invalidate();
			this.Update();
			this.Refresh();
		}

		private void Polygon_Click(object sender, EventArgs e)
		{
			Rectangle rect = new Rectangle(MouseLocation, new Size(4, 4));
			points.Add(rect);
			this.Invalidate();
			this.Update();
			this.Refresh();
		}

		private void Polygon_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			if(isDraw==true)
			{
				Point[] p = new Point[points.Count];
				for (int i = 0; i < points.Count; i++)
				{
					p[i] = points[i].Location;
				}
				g.DrawPolygon(new Pen(Color.Red, 3), p);
			}	
			for (int i = 0; i < points.Count; i++)
			{
				e.Graphics.FillRectangle(Brushes.Blue,points[i]);
			}
		}
	}
}
