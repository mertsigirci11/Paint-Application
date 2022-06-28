using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox.Image = bitmap;
                
        }

        Bitmap bitmap;
        Graphics graphics;
        Point x_point, y_point;
        Pen pencil = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 5);

        bool paint_permission = false;
        int paint_index;
        int x, y, sX, sY, cX, cY;
        Color new_color;


        public void ButtonBorder()
        {
            btn_red.FlatAppearance.BorderColor = Color.White;
            btn_green.FlatAppearance.BorderColor = Color.White;
            btn_blue.FlatAppearance.BorderColor = Color.White;
            btn_orange.FlatAppearance.BorderColor = Color.White;
            btn_black.FlatAppearance.BorderColor = Color.White;
            btn_yellow.FlatAppearance.BorderColor = Color.White;
            btn_purple.FlatAppearance.BorderColor = Color.White;
            btn_brown.FlatAppearance.BorderColor = Color.White;
            btn_white.FlatAppearance.BorderColor = Color.White;
            
           
        }
        public void Validate(Bitmap bitmap, Stack<Point> sp, int x, int y, Color old_color,Color new_color)
        {
            Color cx = bitmap.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bitmap.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bitmap,int x,int y,Color color)
        {
            Color old_color = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x,y));
            bitmap.SetPixel(x, y, color);
            if (old_color == color) return;

            while(pixel.Count>0)
            {
                Point point = (Point)pixel.Pop();
                if (point.X>0 && point.Y>0 && point.X<bitmap.Width-1 && point.Y<bitmap.Height-1)
                {
                    Validate(bitmap, pixel, point.X - 1, point.Y, old_color, color);
                    Validate(bitmap, pixel, point.X, point.Y - 1, old_color, color);
                    Validate(bitmap, pixel, point.X + 1, point.Y, old_color, color);
                    Validate(bitmap, pixel, point.X, point.Y + 1, old_color, color);
                }
            }

            
        }
        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;

            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        


        private void btn_rect_Click(object sender, EventArgs e)
        {
            paint_index = 4;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint_permission)
            {
                if (paint_index == 3)
                {
                    g.DrawEllipse(pencil, cX, cY, sX, sY);

                }

                if (paint_index == 4)
                {
                    g.DrawRectangle(pencil, cX, cY, sX, sY);

                }

                if (paint_index == 5)
                {


                }
            }
           
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            paint_index = 3;
        }



        private void btn_pencil_Click(object sender, EventArgs e)
        {
            paint_index = 1;
        }

        private void btn_rubbish_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox.Image = bitmap;
            paint_index = 0;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Red;
            btn_red.FlatAppearance.BorderColor = Color.Black;
            new_color = pencil.Color;
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Blue;
            btn_blue.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Green;
            btn_green.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_orange_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Orange;
            btn_orange.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_black_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Black;
            btn_black.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Yellow;
            btn_yellow.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_purple_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Purple;
            btn_purple.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_brown_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Brown;
            btn_brown.FlatAppearance.BorderColor = Color.Black;
        }

        private void btn_white_Click(object sender, EventArgs e)
        {
            ButtonBorder();
            pencil.Color = Color.Brown;
            btn_white.FlatAppearance.BorderColor = Color.Black;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(paint_index == 7)
            {
                Point point = SetPoint(pictureBox, e.Location);
                Fill(bitmap, point.X, point.Y, pencil.Color);
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            paint_index = 7;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmap = bitmap.Clone(new Rectangle(0,0,pictureBox.Width,pictureBox.Height),bitmap.PixelFormat);
                bmap.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox.Image = Image.FromFile(filePath);
        }

        private void btn_hand_Click(object sender, EventArgs e)
        {

        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            paint_index = 2;
            
            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint_permission = false;
            sX = x - cX;
            sY = y - cY;

            if (paint_index == 3)
            {
                graphics.DrawEllipse(pencil, cX, cY, sX, sY);
            }
            if (paint_index == 4)
            {
                graphics.DrawRectangle(pencil, cX, cY, sX, sY);
            }
            if (paint_index == 5)//hexagon
            {

            }


           
           
            
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint_permission)
            {
                if (paint_index == 1)
                {
                    x_point = e.Location;
                    graphics.DrawLine(pencil, x_point, y_point);
                    y_point = x_point;
                }
                if (paint_index == 2)
                {
                    x_point = e.Location;
                    graphics.DrawLine(eraser, x_point, y_point);
                    y_point = x_point;
                }
            }
            pictureBox.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint_permission = true;
            y_point = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

    }
}
