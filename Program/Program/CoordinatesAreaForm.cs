using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class CoordinatesAreaForm : Form
    {
        public CoordinatesAreaForm()
        {
            InitializeComponent();
            ResultView.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WindowState = FormWindowState.Maximized;
            CutView.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private Bitmap SourceBitmap;
        private Bitmap LeftBitmap;
        private Bitmap RightBitmap;
        private Bitmap TopBitmap;
        private Bitmap ResultBitmap;

        private Graphics SourceGraphics;
        private Graphics LeftGraphics;
        private Graphics RightGraphics;
        private Graphics TopGraphics;
        private Graphics ResultGraphics;


        private int left, top, right;
        public int Left { get { return left; } }
        public int Top { get { return top; } }
        public int Right { get { return right; } }


        private bool LChange, RChange, TChange;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        public void SetImage(Bitmap Coordinates)
        {

            right = Coordinates.Width;
            left = 0;
            top = Coordinates.Height;

            SourceBitmap = new Bitmap(Coordinates);
            LeftBitmap = new Bitmap(Coordinates.Width, Coordinates.Height);
            RightBitmap = new Bitmap(Coordinates.Width, Coordinates.Height);
            TopBitmap = new Bitmap(Coordinates.Width, Coordinates.Height);
            ResultBitmap = new Bitmap(Coordinates.Width, Coordinates.Height);

            SourceGraphics = Graphics.FromImage(SourceBitmap);
            LeftGraphics = Graphics.FromImage(LeftBitmap);
            RightGraphics = Graphics.FromImage(RightBitmap);
            TopGraphics = Graphics.FromImage(TopBitmap);
            ResultGraphics = Graphics.FromImage(ResultBitmap);

            ResultGraphics.DrawImage(Coordinates,new Point(0,0));

            ResultView.Image = ResultBitmap;

            CounterLeft.Maximum = TrackBarLeft.Maximum = Coordinates.Width;
            CounterRight.Maximum = TrackBarRight.Maximum = Coordinates.Width;
            CounterRight.Value = TrackBarRight.Value = Coordinates.Width;
            CounterTop.Maximum = TrackBarTop.Maximum = Coordinates.Height;
            CounterTop.Value = TrackBarTop.Value = Coordinates.Height;


            

        }

        private void DrawLeft()
        {
            LeftGraphics.Clear(Color.Empty);
            LeftGraphics.FillRectangle(Brushes.Black, new Rectangle(0,0,TrackBarLeft.Value,LeftBitmap.Height));

           
        }
        private void DrawRight()
        {
            RightGraphics.Clear(Color.Empty);
            RightGraphics.FillRectangle(Brushes.Black, new Rectangle(TrackBarRight.Value, 0, (TrackBarRight.Maximum-TrackBarRight.Value), RightBitmap.Height));
        }
        private void DrawTop()
        {
            TopGraphics.Clear(Color.Empty);
            TopGraphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, TopBitmap.Width, (TrackBarTop.Maximum - TrackBarTop.Value)));
        }
        private void DrawResult()
        {
            ResultGraphics.DrawImage(SourceBitmap,0,0);
            ResultGraphics.DrawImage(LeftBitmap,0,0);
            ResultGraphics.DrawImage(RightBitmap, 0, 0);
            ResultGraphics.DrawImage(TopBitmap, 0, 0);


            ResultView.Image = ResultBitmap;
        }

        private void TrackBarLeft_ValueChanged(object sender, EventArgs e)
        {
            if(TrackBarLeft.Value<TrackBarRight.Value)
            {
                DrawLeft();
                DrawResult();
                left = TrackBarLeft.Value;
                CounterLeft.Value = TrackBarLeft.Value;
            }
            
        }

        private void TrackBarRight_ValueChanged(object sender, EventArgs e)
        {
            if (TrackBarRight.Value > TrackBarLeft.Value)
            {
                DrawRight();
                DrawResult();
                right = TrackBarRight.Value;
                CounterRight.Value = TrackBarRight.Value;
            }
        }

        private void TrackBarTop_ValueChanged(object sender, EventArgs e)
        {
            if(TrackBarTop.Value>0)
            {
                DrawTop();
                DrawResult();
                top = TrackBarTop.Value;
                CounterTop.Value = TrackBarTop.Value;
            }
        }

        private void CounterRight_ValueChanged(object sender, EventArgs e)
        {
            if (CounterRight.Value > TrackBarLeft.Value)
            {
                TrackBarRight.Value = (int)CounterRight.Value;
                DrawRight();
                DrawResult();
                right = TrackBarRight.Value;
                ShowCut();
            }
        }

        private void CounterLeft_ValueChanged(object sender, EventArgs e)
        {
            if (CounterLeft.Value < TrackBarRight.Value)
            {
                TrackBarLeft.Value = (int)CounterLeft.Value;
                DrawLeft();
                DrawResult();
                left = TrackBarLeft.Value;
                ShowCut();
            }
        }

        private void CounterTop_ValueChanged(object sender, EventArgs e)
        {   
                TrackBarTop.Value = (int)CounterTop.Value;
                DrawTop();
                DrawResult();
                top = TrackBarTop.Value;
                ShowCut();
        }


        private Bitmap cutBitmap;
        public Bitmap CutBitmap
        {
            get { return cutBitmap; }
        }


        private void ShowCut()
        {
            cutBitmap = new Bitmap(right - left, top);
            Graphics g = Graphics.FromImage(cutBitmap);
            Rectangle section = new Rectangle(new Point(left, SourceBitmap.Height-top), new Size(right-left, top));
            g.DrawImage(ResultBitmap, 0, 0, section, GraphicsUnit.Pixel);
            CutView.Image = cutBitmap;

        }


        private bool isDone=false;
        public bool IsDone
        {
            get { return isDone; }
        }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            isDone = true;
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            isDone = false;
            this.Close();
        }
    }
}
