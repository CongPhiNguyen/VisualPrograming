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
	public partial class GDI2 : Form
	{
		private float startAngle = 45.0f;
		private float sweepAngle = 90.0f;
		public GDI2()
		{
			InitializeComponent();
		}

		private void btReset_Click(object sender, EventArgs e)
		{
			try
			{
				startAngle = float.Parse(tbStartAngle.Text);
				sweepAngle = float.Parse(tbSweepAngle.Text);
				this.Invalidate();
				this.Update();
				this.Refresh();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void GDI2_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle rect = new Rectangle(200, 20, 600, 600);
			g.DrawArc(new Pen(Color.Cyan, 3), rect, startAngle, sweepAngle);
		}
	}
}
