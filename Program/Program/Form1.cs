using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Imaging;

namespace Program
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageFolderBrowser.SelectedPath = "images";
            LabelImagePath.Text ="Текущая папка сохранения изображений: \n"+ ImageFolderBrowser.SelectedPath;
            MapView.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WindowState = FormWindowState.Maximized;
            
        }

        /**
         * Флаг начала определения области
         * 
         * Используется для начала определения
         * мест передвижения курсора и захвата координат.
         */
        private bool IsGetArea = false;

        /**
         * Стадия определения области
         * 
         * Используется для определения того, кикие точки
         * мест уже выбраны.
         */
        private int GetAreaState = 0;

        /**
         * Первый угол передвижения курсора
         * 
         * Используется для определения места передвижения
         * курсора. Верхний левый угол прямоугольника
         * области, в которой передвигается курсор.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCursorX1 = 0, AreaCursorY1 = 0;

        /**
         * Второй угол передвижения курсора
         * 
         * Используется для определения места передвижения
         * курсора. Нижний правый угол прямоугольника
         * области, в которой передвигается курсор.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCursorX2 = 0, AreaCursorY2 = 0;

        /**
         * Первый угол захвата координат
         * 
         * Используется для определения места захвата координат. 
         * Верхний левый угол прямоугольника
         * области, в которой идет захват.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCoordinatesX1 = 0, AreaCoordinatesY1 = 0;

        /**
         * Второй угол захвата координат
         * 
         * Используется для определения места захвата координат. 
         * Правый нижний угол прямоугольника
         * области, в которой идет захват.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCoordinatesX2 = 0, AreaCoordinatesY2 = 0;



        /**
         * Событие нажатия кнопки "Выбрать точки"
         * 
         * При нажатии окно становиться полупрозрачным.
         * Флаг для перехвата события нажатия на клавишу
         * пристваивается true
         */
        private void GetPlaceBtn_Click(object sender, EventArgs e)
        {
            if(IsGisReady())
            {
                CoordinatesAreaForm form = new CoordinatesAreaForm();

                Bitmap cords = new Bitmap(MapBitmap.Width, MapBitmap.Height / 4);
                Graphics g = Graphics.FromImage(cords);
                Rectangle section = new Rectangle(new Point(0, 3*MapBitmap.Height / 4), new Size(MapBitmap.Width, MapBitmap.Height / 4));
                g.DrawImage(MapBitmap, 0, 0, section, GraphicsUnit.Pixel);
                form.SetImage(cords);
                form.ShowDialog();

                if(form.IsDone)
                {

                    AreaCoordinatesX1 = CursorArea.Left+  form.Left;
                    AreaCoordinatesX2 = CursorArea.Left + form.Right;
                    AreaCoordinatesY1 = CursorArea.Top + (MapBitmap.Height - form.Top);
                    AreaCoordinatesY2 = CursorArea.Bottom;

                    CutView.Image = form.CutBitmap;


                    StartMoveBtn.Enabled = true;

                }
                







                /*IntPtr deskriptor = process.MainWindowHandle;
                ShowWindow(deskriptor, 1);
                ShowWindow(deskriptor, 3);
                this.Hide();
                this.Show();

                IsGetArea = true;
                this.Opacity = 0.8;             //this используется для обращение к объекту формы. Opacity-прозрачность
                GetAreaState = 3;*/
            }
            else
            {
                MessageBox.Show("Не удалось найти процеес Google Earth");
            }


            
        }

        /**
         * Событие нажатия кнопки "Начать захват"
         * 
         * Курсор начинает движение по полученной области
         * Для наглядного отображения добавлена задержка
         */
        private void StartMoveBtn_Click(object sender, EventArgs e)
        {
            if (IsGisReady())
            {
                IntPtr deskriptor = process.MainWindowHandle;
                ShowWindow(deskriptor, 1);
                ShowWindow(deskriptor, 3);

                Screeneng se = new Screeneng();

                se.CreateBitmap(AreaCoordinatesX1, AreaCoordinatesY1, AreaCoordinatesX2, AreaCoordinatesY2);
                int iter = 0;
                string path;
                for (int i = CursorArea.Left; i < CursorArea.Right; i += (int)CounterThickness.Value)
                {
                    for (int j = CursorArea.Top; j < CursorArea.Bottom; j += (int)CounterThickness.Value)
                    {
                        Cursor.Position = new Point(i, j);
                        path = ImageFolderBrowser.SelectedPath+"\\"+iter;
                        se.SaveCoordinates(AreaCoordinatesX1, AreaCoordinatesY1, AreaCoordinatesX2, AreaCoordinatesY2, path);
                        iter++;
                        
                    }
                }
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show("Не удалось найти процеес Google Earth");
            }
        }




        /**
         * Проверка готовности GoogleEarth
         * 
         * Возвращает true, если процесс GoogleEarth запущен
         * и false в обратном случае.
         */
        private bool IsGisReady()
        {
            bool check = false;
            Process[] proclist = Process.GetProcessesByName("googleearth");
            if(proclist.Length!=0)
            {
                check = true;
                process = proclist[0];
            }

            return check;
        }


        /**
         * Процесс Google Earth
         * 
         * Объект процесса Goole Earth. Присваивается каждый раз, при вызове 
         * функции IsGisReady(). 
         * ВАЖНО!!! Это первый процесс из списка процессов, с именем googleearth.
         */
        private Process process;




        /**
         * Функция вывода окна Google Earth на передний план
         * 
         * Импортируется функция WinAPI, для работы с окнами.
         * IntPtr hWnd - дескриптор окна процесса
         * int nCmdShow - способ вывода окна
         */
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private void ChooseImageFolderBtn_Click(object sender, EventArgs e)
        {
            if (ImageFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                LabelImagePath.Text = "Текущая папка сохранения изображений: \n" + ImageFolderBrowser.SelectedPath;
            }
        }

        private void ClearImageFolderBtn_Click(object sender, EventArgs e)
        {
            var dirInfo = new DirectoryInfo(@ImageFolderBrowser.SelectedPath);
            foreach (var file in dirInfo.GetFiles())
                file.Delete();
        }

        private Bitmap ResultBitmap = null;
        private Bitmap MapBitmap = null;
        private Bitmap GridBitmap = null;
        private Graphics ResultGraphics = null;
        private Graphics MapGraphics = null;
        private Graphics GridGraphics = null;

        private void GetAutoAreaBtn_Click(object sender, EventArgs e)
        {
            if (IsGisReady())
            {
                IntPtr deskriptor = process.MainWindowHandle;

                ShowWindow(deskriptor, 1);
                ShowWindow(deskriptor, 3);


                IntPtr ptr = FindWindow("QWidget", null);
                FindHandle(ptr);

                MapBitmap = Screeneng.GetMap(CursorArea.Left, CursorArea.Top, CursorArea.Right, CursorArea.Bottom);
                MapGraphics = Graphics.FromImage(MapBitmap);
                GridBitmap = new Bitmap(MapBitmap.Width, MapBitmap.Height);
                ResultBitmap = new Bitmap(MapBitmap.Width, MapBitmap.Height);
                GridGraphics = Graphics.FromImage(GridBitmap);
                ResultGraphics = Graphics.FromImage(ResultBitmap);


                this.Hide();
                this.Show();
                this.WindowState = FormWindowState.Maximized;

                Draw();

                MapView.Image = Image.FromHbitmap(ResultBitmap.GetHbitmap());

                GetAreaBtn.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Не удалось найти процеес Google Earth");
            }
        }
        private void Draw()
        {
            if(MapBitmap!=null)
            {               

                Pen pen=new Pen(Brushes.Red);
                pen.Width=1;
                GridGraphics.Clear(Color.Empty);
                if(CheckBoxGridView.Checked)
                {
                    for (int i = 0; i < GridBitmap.Width; i += (int)CounterThickness.Value)
                    {
                        for (int j = 0; j < GridBitmap.Height; j += (int)CounterThickness.Value)
                        {
                            GridGraphics.DrawLine(pen, new Point(i-2, j), new Point(i + 2, j));
                            GridGraphics.DrawLine(pen, new Point(i, j-2), new Point(i, j + 2));
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < GridBitmap.Width; i += (int)CounterThickness.Value)
                    {
                        GridGraphics.DrawLine(pen, new Point(i, 0), new Point(i, GridBitmap.Height));
                    }
                    for (int j = 0; j < GridBitmap.Height; j += (int)CounterThickness.Value)
                    {
                        GridGraphics.DrawLine(pen, new Point(0, j), new Point(GridBitmap.Width, j));
                    }
                }

                ResultGraphics.Clear(Color.Empty);
                if(CheckBoxMap.Checked)
                {
                    ResultGraphics.DrawImage(MapBitmap, 0, 0);
                }
                if (CheckBoxGrid.Checked)
                {
                    ResultGraphics.DrawImage(GridBitmap, 0, 0);
                }


                MapView.Image = Image.FromHbitmap(ResultBitmap.GetHbitmap());
            }
        }


        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        private RECT CursorArea;

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = System.Runtime.InteropServices.CharSet.Auto)] //
        public static extern bool SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(int hWnd, int Msg, int wparam, int lparam);


        const int WM_GETTEXT = 0x000D;
        const int WM_GETTEXTLENGTH = 0x000E;

        public string GetControlText(IntPtr hWnd)
        {

            StringBuilder title = new StringBuilder();

            // Get the size of the string required to hold the window title. 
            Int32 size = SendMessage((int)hWnd, WM_GETTEXTLENGTH, 0, 0).ToInt32();

            // If the return is 0, there is no title. 
            StringBuilder sb = new StringBuilder(65535);
            if (size > 0)
            {
                title = new StringBuilder(size + 1);


                SendMessage(hWnd, (int)WM_GETTEXT, sb.Length, sb);

                SendMessage(hWnd, (int)WM_GETTEXT, title.Capacity, title);


            }
            return title.ToString();
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        private void FindHandle(IntPtr parent)
        {
            IntPtr child;
            child = IntPtr.Zero;
            do
            {
                child = FindWindowEx(parent, child, "QWidget", null);
                if (child.ToInt32() != 0)
                {
                    if (GetControlText(child) == "RenderFrame")
                    {
                        GetWindowRect(child, out CursorArea);
                    }
                    if (FindWindowEx(child, IntPtr.Zero, "QWidget", null).ToInt32() != 0)
                    {
                        FindHandle(child);
                    }
                }
            } while (child != IntPtr.Zero);
        }

        private void CheckBoxMap_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void CheckBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void CheckBoxGridView_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void CounterThickness_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void SaveCoordinatesTextBtn_Click(object sender, EventArgs e)
        {
            if (IsGisReady())
            {
                IntPtr deskriptor = process.MainWindowHandle;
                ShowWindow(deskriptor, 1);
                ShowWindow(deskriptor, 3);

                Screeneng se = new Screeneng();
                
                se.CreateBitmap(AreaCoordinatesX1, AreaCoordinatesY1, AreaCoordinatesX2, AreaCoordinatesY2);

                MemoryStream stream = new MemoryStream();
                byte[] imageBytes;

                string path;


                for (int i = CursorArea.Left; i < CursorArea.Right; i += (int)CounterThickness.Value)
                {
                    for (int j = CursorArea.Top; j < CursorArea.Bottom; j += (int)CounterThickness.Value)
                    {
                        Cursor.Position = new Point(i, j);
                        //path = ImageFolderBrowser.SelectedPath + "\\" + iter;
                        se.GetCoordinates(AreaCoordinatesX1, AreaCoordinatesY1, AreaCoordinatesX2, AreaCoordinatesY2).Save(stream, ImageFormat.Jpeg);
                        imageBytes = stream.ToArray();
                        OCRConvertor convertor = new OCRConvertor();
                        convertor.ConverToText(imageBytes);
                    }
                }
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show("Не удалось найти процеес Google Earth");
            }
        }

    }
}
