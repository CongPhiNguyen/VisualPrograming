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
	class Circle : Shape
	{
		RectangleF rect;
		public Circle(int _x, int _y, int _r)
		{
			rect = new RectangleF(new Point(_x - _r/ 2, _y - _r / 2), new Size(_r ,_r));
		}
		public override void Draw(PaintEventArgs e)
		{
			e.Graphics.FillEllipse(Brushes.Cyan, rect);
		}
		public override void Draw(PaintEventArgs e, Brush a)
		{
			e.Graphics.FillEllipse(a, rect);
		}
		public override void Move()
		{
			rect = new RectangleF(new Point((int)rect.X, (int)rect.Y + 2), new Size((int)rect.Width, (int)rect.Height));
			top = (int)rect.Y;		
		}
	}
}
