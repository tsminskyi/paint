using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace paint
{


    public partial class Form1 : Form
    {

        private Pen pen;
        private Graphics g;
        private bool isdraw = false;
        
        private Bitmap bmp;
        private List<Bitmap> pic;
        private Color pixelColorMem;
        private Color newColor;
        private int pos;
       

        private Point start;
        private Point start1;

        private Rectangle r;


        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;

        }

        public void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            var data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            var bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            var check = new LinkedList<Point>();
            var floodTo = color.ToArgb();
            var floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodTo != floodFrom)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    var cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (var off in new[]
                                            {
                                                new Point(-1, 0),new Point(-1, -1),
                                                new Point(1, 0), new Point(1, 1),
                                                new Point(0, -1), new Point(0, 1)
                                            })
                    {
                        var next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X < 0 || next.Y < 0 || next.X >= data.Width || next.Y >= data.Height) continue;
                        var col = bits[next.X + next.Y * data.Stride / 4];
                        if (floodFrom != col) continue;
                        check.AddLast(next);
                        bits[next.X + next.Y * data.Stride / 4] = floodTo;
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pic = new List<Bitmap>();

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color pixelColor = bmp.GetPixel(i, x);
                    Color newColor = Color.White;
                    bmp.SetPixel(i, x, newColor);
                }
            }

            pictureBox1.Image = bmp;
            pic.Add(new Bitmap(pictureBox1.Image));
            pos = pic.Count - 1;
            pen = new Pen(panel2.BackColor, trackBar1.Value);

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((e.X >= 0 && e.X < pictureBox1.Image.Width) && (e.Y >= 0 && e.Y < pictureBox1.Image.Height))
                {
                   
                    isdraw = true;
                    start.X = e.X;
                    start.Y = e.Y;
                    pixelColorMem = bmp.GetPixel(start.X, start.Y);

                    if (fill_b.Checked)
                    {
                        newColor = panel2.BackColor;
                        if (bmp.GetPixel(e.X, e.Y) != newColor)
                        {
                            FloodFill(bmp, e.X, e.Y, newColor);
                            pictureBox1.Image = bmp;
                        }

                    }
                }
            }
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"x- {e.X} y- {e.Y}";
            if (isdraw)
            {
                using (g = Graphics.FromImage(pictureBox1.Image))
                {
                    if (pen_b.Checked)
                    {
                        pen.Color = panel2.BackColor;
                        pen.Width = trackBar1.Value;
                        RectangleF rf = new RectangleF(start.X, start.Y, trackBar1.Value, trackBar1.Value);
                        g.FillEllipse(pen.Brush, rf);
                        start = e.Location;
                        

                    }
                    else if (marcker_b.Checked)
                    {
                        pen.Color = panel2.BackColor;
                        pen.Width = trackBar1.Value;
                        RectangleF rf = new RectangleF(start.X, start.Y, trackBar1.Value*3, trackBar1.Value);
                        g.FillRectangle(pen.Brush, rf);
                        start = e.Location;
                    }
                    else if (elastic_b.Checked)
                    {

                        pen.Color = Color.White;
                        pen.Width = trackBar1.Value;
                        RectangleF rf = new RectangleF(start.X, start.Y, trackBar1.Value, trackBar1.Value);
                        g.FillRectangle(pen.Brush, rf);
                        start = e.Location;

                    }
                    else if (rectangle_b.Checked || circle_b.Checked || triangle_b.Checked || line_b.Checked)
                    {
                        
                        start1 = e.Location;

                    }
                    pictureBox1.Invalidate();
                }
            }
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            isdraw = false;

            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                if (rectangle_b.Checked)
                {
                    
                        pen.Color = panel2.BackColor;
                        pen.Width = trackBar1.Value;
                        g.DrawRectangle(pen, r);
                    
                }
                else if (circle_b.Checked)
                {

                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;
                    g.DrawEllipse(pen, r);
                }
                else if (triangle_b.Checked)
                {
                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;

                    PointF point2 = new PointF(start.X, start1.Y);

                    PointF[] curvePoints = { start, point2, start1, };
                    g.DrawPolygon(pen, curvePoints);
                }
                else if (line_b.Checked)
                {

                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;
                    g.DrawLine(pen, start, start1);
                }
            }
            if (pos != pic.Count - 1)
            {
                pic.RemoveRange(pos, pic.Count - pos);

            }

            pic.Add(new Bitmap(pictureBox1.Image));


            if (pic.Count == 16) pic.RemoveAt(0);
            pos = pic.Count - 1;



        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (isdraw)
            {

                if (rectangle_b.Checked)
                {
                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;
                    if (start.X < start1.X && start.Y < start1.Y) r = new Rectangle(start.X, start.Y, start1.X - start.X, start1.Y - start.Y);
                    if (start1.X < start.X && start1.Y < start.Y) r = new Rectangle(start1.X, start1.Y, start.X - start1.X, start.Y - start1.Y);
                    if (start1.X < start.X && start.Y < start1.Y) r = new Rectangle(start1.X, start.Y, start.X - start1.X, start1.Y - start.Y);
                    if (start.X < start1.X && start1.Y < start.Y) r = new Rectangle(start.X, start1.Y, start1.X - start.X, start.Y - start1.Y);
                    e.Graphics.DrawRectangle(pen, r);

                }
                else if (circle_b.Checked)
                {
                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;
                    if (start.X < start1.X && start.Y < start1.Y) r = new Rectangle(start.X, start.Y, start1.X - start.X, start1.Y - start.Y);
                    if (start1.X < start.X && start1.Y < start.Y) r = new Rectangle(start1.X, start1.Y, start.X - start1.X, start.Y - start1.Y);
                    if (start1.X < start.X && start.Y < start1.Y) r = new Rectangle(start1.X, start.Y, start.X - start1.X, start1.Y - start.Y);
                    if (start.X < start1.X && start1.Y < start.Y) r = new Rectangle(start.X, start1.Y, start1.X - start.X, start.Y - start1.Y);
                    e.Graphics.DrawEllipse(pen, r);

                }
                else if (triangle_b.Checked)
                {
                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;

                    PointF point2 = new PointF(start.X, start1.Y);

                    PointF[] curvePoints = { start, point2, start1, };
                    e.Graphics.DrawPolygon(pen, curvePoints);

                }
                else if (line_b.Checked)
                {

                    pen.Color = panel2.BackColor;
                    pen.Width = trackBar1.Value;
                    e.Graphics.DrawLine(pen, start, start1);
                }
            }
        }



        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pos--;
            if (pos < 0) pos = 0; pictureBox1.Image = pic[pos];

            pictureBox1.Image = pic[pos];

        }

        private void naxteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos == pic.Count) pos = pic.Count - 1;

            pictureBox1.Image = pic[pos];
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
            if (save.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image.Save(save.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                if (pic.Count > 0) pic.Clear();
                try
                {
                    bmp = new Bitmap(open_dialog.FileName);
                    pictureBox1.Size = new Size(bmp.Width, bmp.Height);
                    pictureBox1.Image = bmp;
                    pic.Add(new Bitmap(pictureBox1.Image));
                    pos = pic.Count - 1;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Error - can't open file",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (pic.Count > 0) pic.Clear();
            bmp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color pixelColor = bmp.GetPixel(i, x);
                    Color newColor = Color.White;
                    bmp.SetPixel(i, x, newColor);
                }
            }
            pictureBox1.Image = bmp;
            pic.Add(new Bitmap(pictureBox1.Image));
            pos = pic.Count - 1;
            pictureBox1.Invalidate();
        }
        

        //private void trackBar2_Scroll(object sender, EventArgs e)
        //{
        //    if(trackBar1.Value>0)
        //    {
        //        pictureBox1.Image = new Bitmap( bmp.Width + (bmp.Width * bmp.Width / 100), bmp.Height + (bmp.Height * bmp.Height / 100));
        //        pictureBox1.Invalidate();
        //    }
        //}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
