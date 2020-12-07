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
		LineMaster lineMaster;
		public GDI_container()
		{
			InitializeComponent();
			this.menuStrip1.AllowMerge = false;
		}
		private void gDIBrushToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.gDIToolStripMenuItem.ForeColor = Color.White;
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
			this.gDIToolStripMenuItem.ForeColor = Color.White;
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
		private void lMaster_Close(object sender, FormClosedEventArgs e)
		{
			lineMaster = null;
		}
		private void lineMasterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.gDIToolStripMenuItem.ForeColor = Color.White;
			if (lineMaster == null)
			{
				lineMaster = new LineMaster();
				lineMaster.MdiParent = this;
				lineMaster.FormClosed += new FormClosedEventHandler(lMaster_Close);
				lineMaster.Show();
			}
			else lineMaster.Activate();
			lineMaster.WindowState = FormWindowState.Maximized;
		}
		private void gDIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.gDIToolStripMenuItem.ForeColor = Color.Black;
		}
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.gDIToolStripMenuItem.ForeColor = Color.White;
		}
		private void GDI_container_Load(object sender, EventArgs e)
		{
			this.gDIToolStripMenuItem.ForeColor = Color.White;
		}
	}
}
