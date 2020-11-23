using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropingShape
{
	abstract class Shape
	{
		public int top;	
		//public Shape(int _x, int _y, int _w, int _h)
		//{
		//	Rectangle rect = new Rectangle(_x, _y, _w, _h);
		//}
		public abstract void Draw(PaintEventArgs e);
		public abstract void Draw(PaintEventArgs e, Brush a);
		public abstract void Move();
	}
}
