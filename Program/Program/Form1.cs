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

namespace Program
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageFolderBrowser.SelectedPath = "images";
            LabelImagePath.Text ="Текущая папка сохранения изображений: \n"+ ImageFolderBrowser.SelectedPath;
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
                IntPtr deskriptor = process.MainWindowHandle;
                ShowWindow(deskriptor, 1);
                ShowWindow(deskriptor, 3);
                this.Hide();
                this.Show();

                IsGetArea = true;
                this.Opacity = 0.8;             //this используется для обращение к объекту формы. Opacity-прозрачность
                GetAreaState = 1;
            }
            else
            {
                MessageBox.Show("Не удалось найти процеес Google Earth");
            }


            
        }


        /**
         * Событие нажатия клавиши
         * 
         * При установленном флаге получения областей и, если нажата
         * клавиша C, текущее место положение курсора 
         * будет запомнено как угол области.
         */
        private void WindowKey_Down(object sender, KeyEventArgs e)
        {
            if(IsGetArea && e.KeyCode==Keys.C)
            {
                switch(GetAreaState)
                {
                    case 1:
                        AreaCursorX1 = Cursor.Position.X;
                        AreaCursorY1 = Cursor.Position.Y;
                        GetAreaState = 2;
                        break;
                    case 2:
                        AreaCursorX2 = Cursor.Position.X;
                        AreaCursorY2 = Cursor.Position.Y;
                        GetAreaState = 3;
                        break;
                    case 3:
                        AreaCoordinatesX1 = Cursor.Position.X;
                        AreaCoordinatesY1 = Cursor.Position.Y;
                        GetAreaState = 4;
                        break;
                    case 4:
                        AreaCoordinatesX2 = Cursor.Position.X;
                        AreaCoordinatesY2 = Cursor.Position.Y;
                        GetAreaState = 0;
                        IsGetArea = false;
                        this.Opacity = 1;
                        break;
                }
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
                for (int i = AreaCursorX1; i <= AreaCursorX2; i += (int)CounterThickness.Value)
                {
                    for (int j = AreaCursorY1; j <= AreaCursorY2; j += (int)CounterThickness.Value)
                    {
                        Thread.Sleep(100);
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

    }
}
