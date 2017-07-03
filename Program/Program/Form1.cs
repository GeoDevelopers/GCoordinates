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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
        private int AreaCursorX1, AreaCursorY1;

        /**
         * Второй угол передвижения курсора
         * 
         * Используется для определения места передвижения
         * курсора. Нижний правый угол прямоугольника
         * области, в которой передвигается курсор.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCursorX2, AreaCursorY2;

        /**
         * Первый угол захвата координат
         * 
         * Используется для определения места захвата координат. 
         * Верхний левый угол прямоугольника
         * области, в которой идет захват.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCoordinatesX1, AreaCoordinatesY1;

        /**
         * Второй угол захвата координат
         * 
         * Используется для определения места захвата координат. 
         * Правый нижний угол прямоугольника
         * области, в которой идет захват.
         * Выражено двумя переменными X и Y.
         */
        private int AreaCoordinatesX2, AreaCoordinatesY2;



        /**
         * Событие нажатия кнопки "Выбрать точки"
         * 
         * При нажатии окно становиться полупрозрачным.
         * Флаг для перехвата события нажатия на клавишу
         * пристваивается true
         */
        private void GetPlaceBtn_Click(object sender, EventArgs e)
        {
            IsGetArea = true;
            this.Opacity = 0.8;             //this используется для обращение к объекту формы. Opacity-прозрачность
            GetAreaState = 1;
        }

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






    }
}
