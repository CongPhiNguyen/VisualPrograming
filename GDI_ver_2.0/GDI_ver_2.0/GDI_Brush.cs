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
using System.IO;

namespace GDI_ver_2._0
{
	public partial class GDI_Brush : Form
	{

		bool isPainting = false, isSizeChang=false;
		List<Rectangle> ls= new List<Rectangle>();
		List<Brush> lsbrush = new List<Brush>();
		int num = 0;
		int count = 0;
		int brsize = 20, oldbrsize=20;
		HatchStyle style = HatchStyle.BackwardDiagonal;
		int type = 1;
		int limit_count=10;
		Point MouseLocation= new Point();
		Rectangle cursorCircle= new Rectangle(10,10,20,20);
		Point beginIncrease = new Point();

		List<string> allJpg = new List<string>();
		string pathTexture;

		public GDI_Brush()
		{
			InitializeComponent();
			this.Cursor = Cursors.Cross;
			//this.Cursor.Size = new Size(4, 4);
			this.DoubleBuffered = true;
			getAllJpg();
			for(int i=0;i<allJpg.Count;i++)
			{
				cbTexture.Items.Add(allJpg[i]);
			}
			pathTexture = cbTexture.Items[0].ToString();
		}
		public void getAllJpg()
		{
			DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());//Assuming Test is your Folder
			FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files
			foreach (FileInfo file in Files)
			{
				allJpg.Add(file.Name);
			}
		}
		private void Brush_Paint(object sender, PaintEventArgs e)
		{
			cursorCircle = new Rectangle(new Point(MouseLocation.X - brsize / 2, MouseLocation.Y - brsize / 2), new Size(brsize, brsize));
			for (int i = num; i < ls.Count; i++)
			{
				if (i<lsbrush.Count)
				{
					e.Graphics.FillEllipse(lsbrush[i], ls[i]);
				}	
			}
			e.Graphics.DrawEllipse(new Pen(Brushes.Black),cursorCircle);
			//num = ls.Count;
		}
		private void GDI_Brush_MouseDown(object sender, MouseEventArgs e)
		{
			isPainting = true;
			isSizeChang = true;
			beginIncrease = MouseLocation;
			oldbrsize = brsize;
		}
		private void GDI_Brush_MouseUp(object sender, MouseEventArgs e)
		{
			isPainting = false;
			isSizeChang = false;
		}
		private void GDI_Brush_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)
			{
				if (isPainting == true)
				{
					ls.Add(new Rectangle(new Point(e.X - brsize / 2, e.Y - brsize / 2), new Size(brsize, brsize)));
					if (type == 1)
					{
						lsbrush.Add(new SolidBrush(btColor.BackColor));
					}
					else if (type == 2)
					{
						lsbrush.Add(new HatchBrush(style, btForeColor.BackColor, btBackColor.BackColor));
					}
					else if (type == 3)
					{
						lsbrush.Add(new LinearGradientBrush(new Point(0, 10), new Point(int.Parse(this.tbGraSize.Text), 10), btGra1.BackColor, btGra2.BackColor));
					}
					else if (type == 4)
					{
						Image image = new Bitmap(Image.FromFile(pathTexture));
						TextureBrush textbrush = new TextureBrush(image);
						lsbrush.Add(textbrush);
					}
					count++;
				}
				if (count > limit_count)
				{
					count = 0;
					this.Invalidate();
					this.Update();
					this.Refresh();
				}
			}	
			else if(e.Button==MouseButtons.Right && isSizeChang==true)
			{
				if(e.X-beginIncrease.X>0)
				{
					brsize = oldbrsize + e.X - beginIncrease.X;
					cursorCircle.Size=new Size(brsize, brsize);
					this.tbSize.Text = brsize.ToString();
				}
				else
				{
					brsize = oldbrsize + e.X - beginIncrease.X;
					if(brsize < 5)
					{
						brsize = 5;
					}	
					cursorCircle.Size = new Size(brsize, brsize);
					this.tbSize.Text = brsize.ToString();
				}
				this.Invalidate();
			}	
			MouseLocation = e.Location;
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
		private void tbSize_Leave(object sender, EventArgs e)
		{
			if(tbSize.Text=="")
			{
				MessageBox.Show("Fuck, you can leave this textbox blank");
				tbSize.Focus();
			}
			try
			{
				brsize = int.Parse(tbSize.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				tbSize.Focus();
			}
			
		}
		private void btSolidBrush_Click(object sender, EventArgs e)
		{
			type = 1;
			limit_count = 10;
		}
		private void btHatch_Click(object sender, EventArgs e)
		{
			type = 2;
			limit_count = 10;
		}
		private void btGradient_Click(object sender, EventArgs e)
		{
			type = 3;
			limit_count = 10;
		}
		private void btForeColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDlg = new ColorDialog();
			colorDlg.AllowFullOpen = false;
			colorDlg.AnyColor = true;
			colorDlg.SolidColorOnly = false;
			colorDlg.Color = Color.Red;

			if (colorDlg.ShowDialog() == DialogResult.OK)
			{
				btForeColor.BackColor = colorDlg.Color;
			}
		}
		private void btBackColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDlg = new ColorDialog();
			colorDlg.AllowFullOpen = false;
			colorDlg.AnyColor = true;
			colorDlg.SolidColorOnly = false;
			colorDlg.Color = Color.Red;

			if (colorDlg.ShowDialog() == DialogResult.OK)
			{
				btBackColor.BackColor = colorDlg.Color;
			}
		}
		private void cbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbType.SelectedIndex==0)
			{
				style = HatchStyle.BackwardDiagonal;
			}
			else if(cbType.SelectedIndex==1)
			{
				style = HatchStyle.Cross;
			}
			else if (cbType.SelectedIndex == 2)
			{
				style = HatchStyle.DiagonalCross;
			}
			else if (cbType.SelectedIndex == 3)
			{
				style = HatchStyle.HorizontalBrick;
			}
			else if (cbType.SelectedIndex == 4)
			{
				style = HatchStyle.LightDownwardDiagonal;
			}
			else if (cbType.SelectedIndex == 4)
			{
				style = HatchStyle.LightUpwardDiagonal;
			}
		}
		private void btTexture_Click(object sender, EventArgs e)
		{
			type = 4;
			limit_count = 1;
		}
		private void tbSize_Enter(object sender, EventArgs e)
		{
			if (tbSize.Text == "")
			{
				MessageBox.Show("Fuck, you can leave this textbox blank");
				tbSize.Focus();
			}
			try
			{
				brsize = int.Parse(tbSize.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				tbSize.Focus();
			}
		}
		private void GDI_Brush_Click(object sender, EventArgs e)
		{
			ls.Add(new Rectangle(new Point(MouseLocation.X - brsize / 2, MouseLocation.Y - brsize / 2), new Size(brsize, brsize)));
			if (type == 1)
			{
				lsbrush.Add(new SolidBrush(btColor.BackColor));
			}
			else if (type == 2)
			{
				lsbrush.Add(new HatchBrush(style, btForeColor.BackColor, btBackColor.BackColor));
			}
			else if (type == 3)
			{
				lsbrush.Add(new LinearGradientBrush(new Point(0, 10), new Point(int.Parse(this.tbGraSize.Text), 10), btGra1.BackColor, btGra2.BackColor));
			}
			else if (type == 4)
			{
				Image image = new Bitmap(Image.FromFile(pathTexture));
				TextureBrush textbrush = new TextureBrush(image);
				lsbrush.Add(textbrush);
			}
			count++;
			this.Invalidate();
			this.Update();
			this.Refresh();
		}
		private void cbTexture_SelectedIndexChanged(object sender, EventArgs e)
		{
			pathTexture = cbTexture.SelectedItem.ToString();
		}
		private void btGra1_Click(object sender, EventArgs e)
		{
			ColorDialog colorDlg = new ColorDialog();
			colorDlg.AllowFullOpen = false;
			colorDlg.AnyColor = true;
			colorDlg.SolidColorOnly = false;
			colorDlg.Color = Color.Red;

			if (colorDlg.ShowDialog() == DialogResult.OK)
			{
				btGra1.BackColor = colorDlg.Color;
			}
		}
		private void btGra2_Click(object sender, EventArgs e)
		{
			ColorDialog colorDlg = new ColorDialog();
			colorDlg.AllowFullOpen = false;
			colorDlg.AnyColor = true;
			colorDlg.SolidColorOnly = false;
			colorDlg.Color = Color.Red;
			if (colorDlg.ShowDialog() == DialogResult.OK)
			{
				btGra2.BackColor = colorDlg.Color;
			}
		}
	}
}
