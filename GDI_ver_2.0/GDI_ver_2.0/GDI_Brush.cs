using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDI_ver_2._0
{
	public partial class GDI_Brush : Form
	{
		bool isPainting = false;
		List<Rectangle> ls= new List<Rectangle>();
		List<Brush> lsbrush = new List<Brush>();
		int num = 0;
		//Point MouseLocation= new Point();
		public GDI_Brush()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		private void Brush_Paint(object sender, PaintEventArgs e)
		{
			for (int i = num; i < ls.Count; i++)
			{
				e.Graphics.FillEllipse(lsbrush[i], ls[i]);
			}
			//num = ls.Count;
		}
		//protected override void OnMouseDown(MouseEventArgs e)
		//{
		//	if (e.Button == MouseButtons.Left)
		//	{
		//		MouseLocation = e.Location;
		//	}
		//}

		private void GDI_Brush_MouseDown(object sender, MouseEventArgs e)
		{
			isPainting = true;
		}

		private void GDI_Brush_MouseUp(object sender, MouseEventArgs e)
		{
			isPainting = false;
		}

		private void GDI_Brush_MouseMove(object sender, MouseEventArgs e)
		{
			if(isPainting==true)
			{
				ls.Add(new Rectangle(new Point(e.X, e.Y), new Size(4, 4)));
				lsbrush.Add(new SolidBrush(Color.DarkCyan));
				this.Invalidate();
				this.Update();
				this.Refresh();
			}	
		}
	}
}
