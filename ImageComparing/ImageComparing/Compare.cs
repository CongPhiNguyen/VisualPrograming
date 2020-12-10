using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComparing
{
	public partial class Compare : Form
	{
		Timer timer1 = new Timer();
		int lastValue;
		bool stillChange = false;
		int currentGroup = 0;
		int currentIndex = 0;
		public Compare()
		{
			InitializeComponent();
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			timer1.Interval = 1000;
			timer1.Enabled = true;
			Executing();
			lastValue = int.Parse(this.lbValue.Text);
			this.trackBar1.Value = int.Parse(this.lbValue.Text);
		}
		List<List<string>> Results = new List<List<string>>();
		public void Executing()
		{
			currentGroup = 0;
			currentIndex = 0;
			tbIndex.Text = "0";
			ImgComparator comparator = new ImgComparator();
			comparator.AddPicFolderByPath(Directory.GetCurrentDirectory());
			var _comparationResult = comparator.FindDuplicatesWithTollerance(this.trackBar1.Value);
			Results.Clear();
			foreach (var hashBlock in _comparationResult)
			{
				if (hashBlock.Count > 1)
				{
					List<string> temp= new List<string>();
					foreach (var singleHash in hashBlock)
					{
						temp.Add(singleHash.FilePath);
					}
					Results.Add(temp);
				}
			}
			if(Results.Count==0)
			{
				pb1.BackgroundImage = Image.FromFile("Resource/NoImage.jpg");
				pb2.BackgroundImage = Image.FromFile("Resource/NoImage.jpg");
				lbResultGroup.Text = "No similar image available";
				lbGroupSize.Text = "";
			}
			else
			{
				pb1.BackgroundImage = Image.FromFile(Results[currentGroup][0]);
				pb2.BackgroundImage = Image.FromFile(Results[currentGroup][1]);
				lbResultGroup.Text = "Group :" + (currentGroup + 1) + "/" + Results.Count;
				lbGroupSize.Text = "Group size: " + Results[currentGroup].Count;
			}
			
		}
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.lbValue.Text = this.trackBar1.Value.ToString();
		}
		private void trackBar1_MouseUp(object sender, MouseEventArgs e)
		{
			this.lbDone.Visible = false;
			this.lbValue.Text = this.trackBar1.Value.ToString();
			Executing();
			lastValue = int.Parse(this.lbValue.Text);
			this.lbDone.Visible = true;
			stillChange = false;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if(stillChange==false)
			{
				if (int.Parse(this.lbValue.Text) != lastValue)
				{
					this.lbDone.Visible = false;
					Executing();
					this.lbDone.Visible = true;
				}
				lastValue = int.Parse(this.lbValue.Text);
			}	
			
		}
		private void trackBar1_MouseDown(object sender, MouseEventArgs e)
		{
			stillChange = true;
		}
		private void btNext_Click(object sender, EventArgs e)
		{
			if (Results.Count <= 1) return;
			currentGroup++;
			if(currentGroup>=Results.Count)
			{
				currentGroup = 0;
			}
			pb1.BackgroundImage = Image.FromFile(Results[currentGroup][0]);
			pb2.BackgroundImage = Image.FromFile(Results[currentGroup][1]);
			lbResultGroup.Text = "Group :" + (currentGroup + 1) + "/" + Results.Count;
			lbGroupSize.Text = "Group size: " + Results[currentGroup].Count;
			currentIndex = 0;
			tbIndex.Text = "0";
		}
		private void btPrev_Click(object sender, EventArgs e)
		{
			if (Results.Count <= 1) return;
			currentGroup--;
			if (currentGroup < 0)
			{
				currentGroup = Results.Count-1;
			}
			pb1.BackgroundImage = Image.FromFile(Results[currentGroup][0]);
			pb2.BackgroundImage = Image.FromFile(Results[currentGroup][1]);
			lbResultGroup.Text = "Group :" + (currentGroup + 1) + "/" + Results.Count;
			lbGroupSize.Text = "Group size: " + Results[currentGroup].Count;
			currentIndex = 0;
			tbIndex.Text = "0";
		}
		private void btPrevPic_Click(object sender, EventArgs e)
		{
			if (Results[currentGroup].Count <= 2) return;
			currentIndex--;
			if (currentIndex < 0)
				currentIndex = Results[currentGroup].Count-2;
			pb1.BackgroundImage = Image.FromFile(Results[currentGroup][currentIndex]);
			pb2.BackgroundImage = Image.FromFile(Results[currentGroup][currentIndex + 1]);
			tbIndex.Text = currentIndex.ToString();
		}
		private void btNextPic_Click(object sender, EventArgs e)
		{
			if (Results[currentGroup].Count <= 2) return;
			currentIndex++;
			if (currentIndex >= Results[currentGroup].Count - 1)
				currentIndex = 0;
			pb1.BackgroundImage = Image.FromFile(Results[currentGroup][currentIndex]);
			pb2.BackgroundImage = Image.FromFile(Results[currentGroup][currentIndex + 1]);
			tbIndex.Text = currentIndex.ToString();
		}
	}
}
