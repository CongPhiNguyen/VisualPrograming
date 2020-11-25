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
	public partial class GDI4_Pentool : Form
	{
		Point pt1 = new Point(10, 50);
		Point pt2 = new Point(20, 200);
		Point pt3 = new Point(190, 20);
		Point pt4 = new Point(200, 100);
		public GDI4_Pentool()
		{
			InitializeComponent();
		}

		private void GDI4_Pentool_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawBezier(Pens.Blue, pt1, pt2, pt3, pt4);
		}

		private void btDraw_Click(object sender, EventArgs e)
		{
			try
			{
				string x = tbA.Text.Substring(0, tbA.Text.IndexOf(','));
				string y = tbA.Text.Substring(tbA.Text.IndexOf(',') + 1, tbA.Text.Length - tbA.Text.IndexOf(',') - 1);
				pt1 = new Point(int.Parse(x), int.Parse(y));
				x = tbB.Text.Substring(0, tbB.Text.IndexOf(','));
				y = tbB.Text.Substring(tbB.Text.IndexOf(',') + 1, tbB.Text.Length - tbB.Text.IndexOf(',') - 1);
				pt2 = new Point(int.Parse(x), int.Parse(y));
				x = tbC.Text.Substring(0, tbC.Text.IndexOf(','));
				y = tbC.Text.Substring(tbC.Text.IndexOf(',') + 1, tbC.Text.Length - tbC.Text.IndexOf(',') - 1);
				pt3 = new Point(int.Parse(x), int.Parse(y));
				x = tbD.Text.Substring(0, tbD.Text.IndexOf(','));
				y = tbD.Text.Substring(tbD.Text.IndexOf(',') + 1, tbD.Text.Length - tbD.Text.IndexOf(',') - 1);
				pt4 = new Point(int.Parse(x), int.Parse(y));
				this.Invalidate();
				this.Update();
				this.Refresh();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Fuck");
			}
		}
	}
}
