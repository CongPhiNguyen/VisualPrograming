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
	public partial class GDI_Brush : Form
	{
		bool isPainting = false;
		List<Rectangle> ls= new List<Rectangle>();
		List<Brush> lsbrush = new List<Brush>();
		int num = 0;
		int count = 0;
		int brsize = 10;
		HatchStyle style = HatchStyle.BackwardDiagonal;
		//Point MouseLocation= new Point();
		int type = 1;
		int limit_count=10;
		private void TextureBrushEx_Load(object sender, EventArgs e)
		{
			
		}

		public GDI_Brush()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		private void Brush_Paint(object sender, PaintEventArgs e)
		{
			for (int i = num; i < ls.Count; i++)
			{
				e.Graphics.FillEllipse(lsbrush[i], ls[i]);
			}
			//num = ls.Count;
		}
		//protected override void OnMouseDown(MouseEventArgs e)
		//{
		//	if (e.Button == MouseButtons.Left)
		//	{
		//		MouseLocation = e.Location;
		//	}
		//}

		private void GDI_Brush_MouseDown(object sender, MouseEventArgs e)
		{
			isPainting = true;
		}

		private void GDI_Brush_MouseUp(object sender, MouseEventArgs e)
		{
			isPainting = false;
		}

		private void GDI_Brush_MouseMove(object sender, MouseEventArgs e)
		{
			if(isPainting==true)
			{
				ls.Add(new Rectangle(new Point(e.X, e.Y), new Size(brsize, brsize)));
				if(type==1)	
					lsbrush.Add(new SolidBrush(btColor.BackColor));
				else if(type==2)
				{
					lsbrush.Add(new HatchBrush(style, btForeColor.BackColor, btBackColor.BackColor));
				}	
				else if(type==3)
				{

				}	
				else if(type==4)
				{
					Image image = new Bitmap(Image.FromFile("Texture.jpg"));
					TextureBrush textbrush = new TextureBrush(image);
					lsbrush.Add(textbrush);
				}	
				count++;
			}
			if(count > limit_count)
			{
				count = 0;
				this.Invalidate();
				this.Update();
				this.Refresh();
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
	}
}
