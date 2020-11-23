using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIdemo
{
	public partial class MDI : Form
	{
		public MDI()
		{
			InitializeComponent();
			//this.MergedMenu = MenuMerge.MergeItems;
			//this.Merged = MenuMerge.MergeItems;

			//Không merge được

			//this.menuStrip1.MergeType = MenuMerge.MergeItems;
		}
		
	   MDI1 mdi1;
		private void mDI1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//if (mdi1 == null)
			//{
				mdi1 = new MDI1();
				mdi1.MdiParent = this;
				mdi1.FormClosed += new FormClosedEventHandler(mdi1_FormClosed);
				mdi1.Show();
			//}
			//else mdi1.Activate();
		}
		private void mdi1_FormClosed(object sender, FormClosedEventArgs e)
		{
			mdi1 = null;
		}
		MDI2 mdi2;
		private void mDI2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//if (mdi2 == null)
			//{
				mdi2 = new MDI2();
				mdi2.MdiParent = this;
				mdi2.FormClosed += new FormClosedEventHandler(mdi2_FormClosed);
				mdi2.Show();
			//}
			//else mdi2.Activate();
		}
		private void mdi2_FormClosed(object sender, FormClosedEventArgs e)
		{
			mdi2 = null;
		}

		private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void arrangreIconToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Minimized;
			}
		}
	}
}
