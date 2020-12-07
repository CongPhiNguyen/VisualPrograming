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
	public partial class LineMaster : Form
	{
		List<LineCap> lc = new List<LineCap>();
		List<DashStyle> ds = new List<DashStyle>();
		Point MouseLocation;
		List<Point> start = new List<Point>();
		List<Point> end = new List<Point>();
		List<Rectangle> points = new List<Rectangle>();
		List<Pen> pens = new List<Pen>();
		int sizeofPoint = 6;

		bool isStart = true;

		Point tempPoint;
		Pen tempPen;
		public LineMaster()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			lc = new List<LineCap>()
			{
				LineCap.AnchorMask,LineCap.ArrowAnchor, LineCap.Custom, LineCap.DiamondAnchor, LineCap.Flat, LineCap.NoAnchor,
				LineCap.Round, LineCap.RoundAnchor,LineCap.Square, LineCap.SquareAnchor, LineCap.Triangle
			};
			ds = new List<DashStyle>
			{
				DashStyle.Custom, DashStyle.Dash, DashStyle.DashDot, DashStyle.DashDotDot, DashStyle.Dot, DashStyle.Solid
			};
			cbDash.SelectedIndex = 0;
			cbEndCap.SelectedIndex = 0;
			cbStartCap.SelectedIndex = 0;
		}

		private void LineMaster_MouseMove(object sender, MouseEventArgs e)
		{
			MouseLocation = e.Location;
			if(isStart==false)
			{
				tempPoint = MouseLocation;
				tempPen = new Pen(btColor.BackColor);
				try
				{
					tempPen.Width = int.Parse(tbSize.Text);
				}
				catch (Exception ex)
				{
					tempPen.Width = 3;
					tbSize.Text = "3";
				}
				tempPen.StartCap = lc[cbStartCap.SelectedIndex];
				tempPen.EndCap = lc[cbEndCap.SelectedIndex];
				tempPen.DashStyle = ds[cbDash.SelectedIndex];
				this.Invalidate();
			}	
		}

		private void LineMaster_Click(object sender, EventArgs e)
		{
			Point point = MouseLocation;
			points.Add(new Rectangle(MouseLocation.X - sizeofPoint / 2, MouseLocation.Y - sizeofPoint / 2, sizeofPoint, sizeofPoint));
			if (isStart == true)
			{
				start.Add(point);
			}
			else
			{
				end.Add(point);
				Pen pen = new Pen(btColor.BackColor);
				pen.Width = int.Parse(tbSize.Text);
				pen.StartCap = lc[cbStartCap.SelectedIndex];
				pen.EndCap = lc[cbEndCap.SelectedIndex];
				pen.DashStyle = ds[cbDash.SelectedIndex];
				pens.Add(pen);
			}
			isStart = !isStart;
			this.Invalidate();
		}

		private void LineMaster_Paint(object sender, PaintEventArgs e)
		{
			
			for(int i=0;i < points.Count; i++)
			{
				e.Graphics.FillEllipse(Brushes.Cyan,points[i]);
			}	
			for(int i=0;i<start.Count && i<end.Count;i++)
			{
				e.Graphics.DrawLine(pens[i], start[i], end[i]);
			}	
			if(isStart==false)
			{
				e.Graphics.DrawLine(tempPen, start[start.Count - 1], tempPoint);
			}	
		}

		private void btColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDlg = new ColorDialog();
			colorDlg.AllowFullOpen = false;
			colorDlg.AnyColor = true;
			colorDlg.SolidColorOnly = false;
			colorDlg.Color = Color.Red;

			if (colorDlg.ShowDialog() == DialogResult.OK)
			{
				btColor.BackColor = colorDlg.Color;
			}
		}
	}
}
