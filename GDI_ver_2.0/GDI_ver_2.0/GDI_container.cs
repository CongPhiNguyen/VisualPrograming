using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_ver_2._0
{
	public partial class GDI_container : Form
	{
		GDI_Brush gdibr;
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
	}
}
