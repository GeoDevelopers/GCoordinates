using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using Program.MainWindow;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace Program
{
    class Screeneng
    {

        /*[DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            //public int
        }
        */

        /* private Process proc;
         public Process Proc { set { proc = value; } get { return proc; } }
         private Form form1;
         public Form Form1 { set { form1 = value; } get { return form1; } }



         public void screenclick(object sender, EventArgs e)
         {
             if (SetForegroundWindow(proc.MainWindowHandle))
             {
                 RECT srcRect;
                 if (!proc.MainWindowHandle.Equals(IntPtr.Zero))
                 {
                     if (GetWindowRect(proc.MainWindowHandle, out srcRect))
                     {
                         int width = srcRect.Right - srcRect.Left;
                         int height = srcRect.Bottom - srcRect.Top;

                         Bitmap bmp = new Bitmap(width, height);
                         Graphics screenG = Graphics.FromImage(bmp);

                         try
                         {
                             screenG.CopyFromScreen(srcRect.Left, srcRect.Top,
                                 0, 0, new Size(width, height),
                                 CopyPixelOperation.SourceCopy);

                             bmp.Save("notepad.jpg", ImageFormat.Jpeg);
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message);
                         }
                         finally
                         {
                             screenG.Dispose();
                             bmp.Dispose();
                         }
                     }

                 }
             }
         }*/

        private Bitmap bitmap;
        private int width, height;
        private Graphics screenG;
        private Size size;
        public void CreateBitmap(int x1, int y1, int x2, int y2)
        {
            width = x2 - x1;
            height = y2 - y1;


            bitmap = new Bitmap(width, height);
            screenG = Graphics.FromImage(bitmap);
            size = new Size(width, height);
            screenG.CopyFromScreen(x1, y1, 0, 0, size, CopyPixelOperation.SourceCopy);
        }
        public void SaveCoordinates(int x1, int y1, int x2, int y2, string filename)
        {
            try
            {
                screenG.CopyFromScreen(x1, y1, 0, 0, size, CopyPixelOperation.SourceCopy);
                bitmap.Save(filename + ".jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //screenG.Dispose();
                //bitmap.Dispose();
            }
        }
        public Bitmap GetCoordinates(int x1, int y1, int x2, int y2)
        {
            try
            {
                screenG.CopyFromScreen(x1, y1,
                    0, 0, new Size(width, height),
                    CopyPixelOperation.SourceCopy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //screenG.Dispose();
                //bmp.Dispose();
            }
            return bitmap;
        }

    }
}
