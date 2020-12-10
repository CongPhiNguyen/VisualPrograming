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
namespace DisplayGirlPic
{
	public partial class Display : Form
	{
		string[] folders;
		List<string> allJpg = new List<string>();
		int currentImage = 0;
		int currentFolder = 0;
		public Display()
		{
			InitializeComponent();
			getAllFolder();
			for(int i=0;i<folders.Length;i++)
			{
				 cbName.Items.Add(folders[i].Substring(folders[i].LastIndexOf("\\") + 1));
			}
			cbName.SelectedIndex = 0;
			getAllJpg(folders[currentFolder]);
			this.lbLink.Text = "Link facebook: " + getLinkFacebook(folders[currentFolder]);
			DisplayImage();
		}
		public string getLinkFacebook(string path)
		{
			string link = "";
			try
			{
				string line;

				// Read the file and display it line by line.  
				StreamReader file = new StreamReader(path + "/Link.txt");
				while ((line = file.ReadLine()) != null)
				{
					if (line.IndexOf("facebook") != 0)
					{
						link = line;
						file.Close();
						return link;
					}
				}
				file.Close();
			}
			catch(Exception ev)
			{

			}
			return link;
		}
		public void getAllJpg(string path)
		{
			allJpg.Clear();
			DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
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
		void getAllFolder()
		{
			folders = Directory.GetDirectories(Directory.GetCurrentDirectory());
		}
		public void DisplayImage()
		{
			if (allJpg.Count == 0) return;
			picMain.BackgroundImage = Bitmap.FromFile(folders[currentFolder] + "/" + allJpg[currentImage]);
			//this.btName.Text = allJpg[currentImage];
			//this.lbNum.Text = currentImage.ToString();
		}

		private void btNext_Click(object sender, EventArgs e)
		{
			currentImage++;
			if (currentImage >= allJpg.Count)
			{
				currentImage = 0;
			}
			DisplayImage();
		}
		private void btPrev_Click(object sender, EventArgs e)
		{
			currentImage--;
			if (currentImage < 0)
			{
				currentImage = allJpg.Count - 1;
			}
			DisplayImage();
		}
		protected override bool ProcessCmdKey(ref Message m, Keys keyData)
		{
			bool blnProcess = false;
			if (keyData == Keys.Z || keyData == Keys.Left)
			{
				blnProcess = true;
				currentImage--;
				if (tab1.SelectedIndex == 0)
				{
					if (currentImage < 0)
					{
						currentImage = allJpg.Count - 1;
					}
				}
			}
			if (keyData == Keys.C || keyData==Keys.Right)
			{
				blnProcess = true;
				if (tab1.SelectedIndex == 0)
				{
					currentImage++;
					if (currentImage >= allJpg.Count)
					{
						currentImage = 0;
					}
				}
			}
			DisplayImage();
			return blnProcess;
		}

		private void cbName_SelectedIndexChanged(object sender, EventArgs e)
		{
			currentImage = 0;
			currentFolder = cbName.SelectedIndex;
			getAllJpg(folders[currentFolder]);
			this.lbLink.Text = "Link facebook: " + getLinkFacebook(folders[currentFolder]);
			DisplayImage();
		}

		private void lbLink_Click(object sender, EventArgs e)
		{
			string h = getLinkFacebook(folders[currentFolder]);
			if(h!="")
			{
				System.Diagnostics.Process.Start("chrome.exe", h);
			}	
		}
	}
}
