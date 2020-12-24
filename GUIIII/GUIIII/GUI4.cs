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
	public partial class GUI4 : Form
	{
		private Point MouseDownLocation;
		Random r = new Random();
		List<int> Size;
		List<Rectangle> Shape = new List<Rectangle>();
		public GUI4()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			
		}
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MouseDownLocation = e.Location;
			}
		}
		private void GUI4_Paint(object sender, PaintEventArgs e)
		{

			for(int i=0;i<Shape.Count;i++)
			{
				e.Graphics.FillEllipse(Brushes.DeepSkyBlue, Shape[i]);
			}	
		}

		private void GUI4_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.OemMinus)
			{
				for (int i = 0; i < Shape.Count; i++)
				{
					if (Shape[i].Width > 0 && Shape[i].Height > 0)
					{
						int _X = Shape[i].X, _Y = Shape[i].Y, _Width = Shape[i].Width, _Height = Shape[i].Height;
						//if (_Width - 10 < 0) _Width = 0;
						//else _Width -= 10;
						//if (_Height - 10 < 0) _Height = 0;
						//else _Height -= 10;
						Shape[i] = new Rectangle(_X + 5, _Y + 5, _Width-10, _Height-10);
					}
				}
			}
			else if (e.KeyCode == Keys.Oemplus)
			{
				for (int i = 0; i < Shape.Count; i++)
				{
					int _X = Shape[i].X, _Y = Shape[i].Y, _Width = Shape[i].Width, _Height = Shape[i].Height;
					Shape[i] = new Rectangle(_X - 5, _Y - 5, _Width + 10, _Height + 10);
				}
			}
			this.Invalidate();     
			this.Update(); 
			this.Refresh();
		}

		private void Mouse_Click(object sender, EventArgs e)
		{
			int t = r.Next(1,15)*10;
			Rectangle rec = new Rectangle(MouseDownLocation.X - t/2, MouseDownLocation.Y - t/2, t, t);
			Shape.Add(rec);
			this.Invalidate();
			this.Update();
			this.Refresh();
		}
	}
}
