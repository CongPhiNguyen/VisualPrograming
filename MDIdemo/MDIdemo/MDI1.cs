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
	public partial class MDI1 : Form
	{
		public MDI1()
		{
			InitializeComponent();
		}
		MDI2 mdi2;
		private void oKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//if (mdi2 == null)
			//{
				mdi2 = new MDI2();
				//mdi2.MdiParent = this;
				mdi2.FormClosed += new FormClosedEventHandler(mdi2_FormClosed);
				mdi2.Show();
			//}
			//else mdi2.Activate();
		}
		private void mdi2_FormClosed(object sender, FormClosedEventArgs e)
		{
			mdi2 = null;
		}
	}
}
