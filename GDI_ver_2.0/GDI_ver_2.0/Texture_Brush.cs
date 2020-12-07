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
	public partial class Texture_Brush : Form
	{
		int diameter = 300;
		Image image = new Bitmap("1.jpg");
        float scaleX, scaleY;

        Point beginIncrease=new Point(), MouseLocation = new Point();
        int olddiameter;
        public Texture_Brush()
		{
			InitializeComponent();
            this.DoubleBuffered = true;
		}

        private void Texture_Brush_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if (e.X - beginIncrease.X > 0)
                {
                    diameter = olddiameter + e.X - beginIncrease.X;
                }
                else
                {
                    diameter = olddiameter + e.X - beginIncrease.X;
                    if (diameter < 5)
                    {
                        diameter = 5;
                    }
                }
            }
            this.Invalidate();
            MouseLocation = e.Location;
        }

        private void Texture_Brush_MouseDown(object sender, MouseEventArgs e)
        {
            beginIncrease = MouseLocation;
            olddiameter = diameter;
        }
        private void Texture_Brush_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Texture_Brush_Paint(object sender, PaintEventArgs e)
		{
            //while(true)
            {
                scaleX = 1f * diameter / image.Size.Width;
                scaleY = 1f * diameter / image.Size.Height;
                using (TextureBrush tbr = new TextureBrush(image))
                {
                    //tbr.RotateTransform(i * 4);   // optional
                    var p = PointToClient(Cursor.Position);
                    tbr.Transform = new Matrix( scaleX, 0.0f, 0.0f, scaleY, 0.0f, 0.0f);
                    // any tile mode will work, though not all the same way
                    tbr.WrapMode = WrapMode.TileFlipXY;
                    if (cbTile.Checked)
                    {
                        e.Graphics.FillEllipse(tbr, p.X - diameter / 2,
                                                    p.Y - diameter / 2, diameter, diameter);
                    }
                    else
                    {
                        ((Bitmap)image).SetResolution(e.Graphics.DpiX, e.Graphics.DpiY);   // (**)
                        e.Graphics.ScaleTransform(scaleX, scaleY);
                        e.Graphics.DrawImage(image, (p.X - diameter / 2) / scaleX,
                                                     (p.Y - diameter / 2) / scaleY);
                        e.Graphics.ResetTransform();

                    }
                    /// ? Pen p3 = new Pen(tbr);
                    e.Graphics.DrawEllipse(Pens.Black, p.X - diameter / 2, p.Y - diameter / 2, diameter, diameter);
                }
            }
        }

	}
}
