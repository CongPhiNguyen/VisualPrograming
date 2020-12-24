using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIIII
{
    public partial class GUII : Form
    {
        private Point MouseDownLocation;
        bool isMovable = false;
        Rectangle rec = new Rectangle(100, 100, 100, 100);
        public GUII()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void GUI_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rec);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rec);
           // e.Graphics.Dispose();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if(isMovable==true)
            {
                rec.Location = new Point((e.X - MouseDownLocation.X) + rec.Left, (e.Y - MouseDownLocation.Y) + rec.Top);
                MouseDownLocation = e.Location;
                this.Invalidate();
            }      
        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            if (MouseDownLocation.X <= rec.X + rec.Width && MouseDownLocation.X > rec.X 
                && MouseDownLocation.Y >= rec.Y && MouseDownLocation.Y <= rec.Y + rec.Height)
            {
                if (e.Button == MouseButtons.Left)
                    isMovable = !isMovable;
            }     
        }
    }
}
