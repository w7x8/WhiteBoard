using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_app
{
 
    public partial class WhiteBoard : Form
    {
        public Point current = new Point();
        public Point old = new Point();

        public Graphics g;

        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);


        Bitmap surface;

        

        public WhiteBoard()
        {
            InitializeComponent();

            g = canvasPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(canvasPanel.Width, canvasPanel.Height);

            graph = Graphics.FromImage(surface);

            canvasPanel.BackgroundImage = surface;
            canvasPanel.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)paintbrushSize.Value;
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void canvasMouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void canvasMouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);

                old = current;
            }
        }
        private Point mouseOffsetPos;
        private Boolean isMouseDwon = false;

        private void topPanelMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(-e.X, e.Y);
                isMouseDwon = true;
            }
        }

        private void topPanelMouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDwon)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffsetPos.X, mouseOffsetPos.Y);
                this.Location = mousePos;
            }
        }

        private void topPanelMouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDwon = false;
             
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
            btnBrush.BackColor = cd.Color;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            canvasPanel.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Png Files (*png) | *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void paintbrushSizeChange(object sender, EventArgs e)
        {
            pen.Width = (float)paintbrushSize.Value;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void hidePictureBox_Click(object sender, EventArgs e)
        {
            topPanel.Hide();
            hidePictureBox.Hide();
            showPictureBox.Show();
        }

        private void showPictureBox_Click(object sender, EventArgs e)
        {
            topPanel.Show();
            hidePictureBox.Show();
            showPictureBox.Hide();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    }

