using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GDI_ver_2._0
{
	public partial class GDI_container : Form
	{
		GDI_Brush gdibr;
		Texture_Brush txtBrush;
		public GDI_container()
		{
			InitializeComponent();
			this.menuStrip1.AllowMerge = false;
		}
		private void gDIBrushToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gdibr == null)
			{
				gdibr = new GDI_Brush();
				gdibr.MdiParent = this;
				gdibr.FormClosed += new FormClosedEventHandler(gdibr_Close);
				gdibr.Show();
			}
			else gdibr.Activate();
			gdibr.WindowState = FormWindowState.Maximized;
		}
		private void gdibr_Close(object sender, FormClosedEventArgs e)
		{
			gdibr = null;
		}

		private void textureBrushToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (txtBrush == null)
			{
				txtBrush = new Texture_Brush();
				txtBrush.MdiParent = this;
				txtBrush.FormClosed += new FormClosedEventHandler(txtBrush_Close);
				txtBrush.Show();
			}
			else txtBrush.Activate();
			txtBrush.WindowState = FormWindowState.Maximized;
		}
		private void txtBrush_Close(object sender, FormClosedEventArgs e)
		{
			txtBrush = null;
		}
	}
}
