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
	public partial class MDI : Form
	{
		GDI gdi;
		GDI2 gdi2;
		GDI3 gdi3;
		GDI4_Pentool gdi4;
		Polygon p ;
		public MDI()
		{
			InitializeComponent();
		}
		private void gDIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gdi == null)
			{
				gdi = new GDI();
				gdi.MdiParent = this;
				gdi.FormClosed += new FormClosedEventHandler(gdi_Close);
				gdi.Show();
			}
			else gdi.Activate();
			gdi.WindowState = FormWindowState.Maximized;
		}
		private void gdi_Close(object sender, FormClosedEventArgs e)
		{
			gdi = null;
		}

		private void gDI2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gdi2 == null)
			{
				gdi2 = new GDI2();
				gdi2.MdiParent = this;
				gdi2.FormClosed += new FormClosedEventHandler(gdi2_Close);
				gdi2.Show();
			}
			else gdi2.Activate();
			gdi2.WindowState = FormWindowState.Maximized;
		}
		private void gdi2_Close(object sender, FormClosedEventArgs e)
		{
			gdi2 = null;
		}

		private void gDI3ToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (gdi3 == null)
			{
				gdi3 = new GDI3();
				gdi3.MdiParent = this;
				gdi3.FormClosed += new FormClosedEventHandler(gdi3_Close);
				gdi3.Show();
			}
			else gdi3.Activate();
			gdi3.WindowState = FormWindowState.Maximized;
		}
		private void gdi3_Close(object sender, FormClosedEventArgs e)
		{
			gdi3 = null;
		}

		private void gDI4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gdi4 == null)
			{
				gdi4 = new GDI4_Pentool();
				gdi4.MdiParent = this;
				gdi4.FormClosed += new FormClosedEventHandler(gdi4_Close);
				gdi4.Show();
			}
			else gdi4.Activate();
			gdi4.WindowState = FormWindowState.Maximized;
		}
		private void gdi4_Close(object sender, FormClosedEventArgs e)
		{
			gdi4 = null;
		}

		private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (p == null)
			{
				p = new Polygon();
				p.MdiParent = this;
				p.FormClosed += new FormClosedEventHandler(p_Close);
				p.Show();
			}
			else p.Activate();
			p.WindowState = FormWindowState.Maximized;
		}
		private void p_Close(object sender, FormClosedEventArgs e)
		{
			p = null;
		}
	}
}
