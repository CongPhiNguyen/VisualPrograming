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

namespace ImageDisplayer
{
	public partial class ImageDisplayer : Form
	{
		List<string> allJpg = new List<string>();
		int currentImage = 0;
		public ImageDisplayer()
		{
			InitializeComponent();
			getAllJpg();
			Display();
		}
		public void getAllJpg()
		{
			DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());//Assuming Test is your Folder
			FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files
			// Có thể sort nhiều kiểu ở đây
			Array.Sort(Files, delegate (FileInfo f1, FileInfo f2)
			{
				return f2.LastWriteTime.CompareTo(f1.LastWriteTime);
			});
			foreach (FileInfo file in Files)
			{
				allJpg.Add(file.Name);
			}
		}
		public void Display()
		{
			if (allJpg.Count == 0) return;
			picMain.BackgroundImage = Bitmap.FromFile(allJpg[currentImage]);
			this.btName.Text = allJpg[currentImage];
			this.lbNum.Text = currentImage.ToString();
		}

		private void btNext_Click(object sender, EventArgs e)
		{
			currentImage++;
			if(currentImage>=allJpg.Count)
			{
				currentImage = 0;
			}
			Display();
		}
		private void btPrev_Click(object sender, EventArgs e)
		{
			currentImage--;
			if (currentImage <0)
			{
				currentImage = allJpg.Count-1;
			}
			
			Display();
		}

		private void ImageDisplayer_SizeChanged(object sender, EventArgs e)
		{
			Control ct = (Control)sender;
			this.btName.Size = new Size((ct.Size.Width - 140),23);
			this.btNext.Location = new Point(ct.Size.Width - 90, ct.Size.Height / 2 - btNext.Size.Height);
			this.btPrev.Location = new Point(5, ct.Size.Height / 2 - btPrev.Size.Height);
			this.picMain.Size = new Size((ct.Size.Width - 140), ct.Size.Height - 70);
		}

		private void ImageDisplayer_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.D || e.KeyCode==Keys.Right)
			{
				currentImage++;
				if (currentImage >= allJpg.Count)
				{
					currentImage = 0;
				}
			}
			else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
			{
				currentImage--;
				if (currentImage < 0)
				{
					currentImage = allJpg.Count - 1;
				}
			}
			Display();
		}

		private void ImageDisplayer_KeyPress(object sender, KeyPressEventArgs e)
		{
			//if (e.KeyChar == Keys.Right)
			//{
			//	currentImage++;
			//	if (currentImage >= allJpg.Count)
			//	{
			//		currentImage = 0;
			//	}
			//	Display();
			//}
			//else if (e.KeyChar == K)
			//{
			//	currentImage--;
			//	if (currentImage <= 0)
			//	{
			//		currentImage = allJpg.Count - 1;
			//	}
			//	Display();
			//}
		}

		private void ImageDisplayer_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.A)
			{
				currentImage++;
				if (currentImage >= allJpg.Count)
				{
					currentImage = 0;
				}
			}
			else if (e.KeyCode == Keys.D)
			{
				currentImage--;
				if (currentImage <= 0)
				{
					currentImage = allJpg.Count - 1;
				}
			}
			Display();
		}
	}
}
