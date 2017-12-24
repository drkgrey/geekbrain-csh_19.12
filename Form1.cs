using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh_19._12
   
{
    public partial class Form1 : Form
    {
        bool paint = false;
        Pen color;
        PointF start, end;
        Bitmap map;
        
        public Form1()
        {
            InitializeComponent();
            Graphics g = labi.CreateGraphics();
            color = new Pen(Color.Black, 2);
            map = new Bitmap(labi.Width, labi.Height);
            g.Clear(Color.White);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Graphics g = labi.CreateGraphics();
            g.Clear(Color.White);
            map = new Bitmap(labi.Width, labi.Height);
        }

        private void pathFindButton_Click(object sender, EventArgs e)
        {
            int[,] mapKey = new int[map.Width, map.Height];
            for (int i = 0; i < mapKey.GetLength(0); i++)
            {
                for (int j = 0; j < mapKey.GetLength(1); j++)
                {
                    if (map.GetPixel(i, j).ToArgb() == color.Color.ToArgb())
                    {
                        mapKey[i, j] = -2;
                    }
                    else  mapKey[i, j] = -1;
                }
                
            }
            point a = new point();
            List<point> list =  a.CreateMap(mapKey);
            if (a.IsPath(list))
            {
                var listb = a.ShowPath(list);
                foreach (var el in listb)
                {
                    map.SetPixel(el.x, el.y, Color.Red);
                }
            }
            else this.Close();
            labi.Refresh();
        }

        private void labi_MouseUp(object sender, MouseEventArgs e)
              {
            paint = false;
            labi.DrawToBitmap(map, new Rectangle(0, 0, map.Width, map.Height));
        }

        private void labi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                start = e.Location; 
                paint = true;
            }

        }

        private void labi_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                end = e.Location;
                labi.Invalidate();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labi_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(map, 0, 0);
            e.Graphics.DrawLine(color, start, end);         
        }
    }
}
