using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropingShape
{
	class Rectangle: Shape
	{
		RectangleF rect;
		public Rectangle(int _x, int _y, int _w, int _h)
		{
			rect = new RectangleF(new Point(_x - _w/2, _y - _h/2 ), new Size(_w, _h));
		}	
		public override void Draw(PaintEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rect);
		}
		public override void Draw(PaintEventArgs e, Brush a)
		{
			e.Graphics.FillRectangle(a, rect);
		}
		public override void Move()
		{
			rect = new RectangleF(new Point((int)rect.X, (int)rect.Y + 2), new Size((int)rect.Width, (int)rect.Height));
			top = (int)rect.Y;
		}
	}

}
