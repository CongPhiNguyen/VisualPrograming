using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DropingShape
{
	class Triangle : Shape
	{
		GraphicsPath gp = new GraphicsPath();
		public Triangle(int _x, int _y, int _w)
		{
			Point A = new Point(_x + _w / 2, _y);
			Point B = new Point(_x, _y + _w );
			Point C = new Point(_x + _w, _y + _w );
			gp.AddLines(new PointF[] { B, A, C, B });
		}
		public override void Draw(PaintEventArgs e)
		{
			e.Graphics.FillPath(Brushes.Cyan, gp);
		}
		public override void Draw(PaintEventArgs e, Brush a)
		{
			e.Graphics.FillPath(a, gp);
		}
		public override void Move()
		{
			System.Drawing.RectangleF h = gp.GetBounds();
			gp = new GraphicsPath();
			Point A = new Point((int)h.X + (int)h.Width/2, (int)h.Y + 5);
			Point B = new Point((int)h.X , (int)h.Y + 5 + (int)h.Width);
			Point C = new Point((int)h.X + (int)h.Width, (int)h.Y + 5 + (int)h.Width);
			gp.AddLines(new PointF[] { B, A, C, B });
			top = (int)h.Y + 5;
		}
	}
}
