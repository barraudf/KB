using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KB.Code
{
    public partial class WindowSelector : PictureBox
    {
        // http://www.experts-exchange.com/Programming/Languages/.NET/Visual_CSharp/Q_26913842.html

        public Color WindowOutlineColor { get; set; }
        public FrameStyle WindowOutlineFrameStyle { get; set; }
        public event EventHandler<WindowSelect_EventArgs> WindowSelect;
        public event EventHandler<WindowSelect_EventArgs> WindowOver;
        
        private WindowInfo LastWindow = null;

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point point);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetAncestor(IntPtr hWnd, int flags);

        public const int GA_ROOT = 3;
        static int i = 0;


        public WindowSelector()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point pt = Cursor.Position;

                IntPtr childWindow = WindowFromPoint(pt);
                WindowInfo CurWindow = new WindowInfo(GetAncestor(childWindow, GA_ROOT));

                if(CurWindow != LastWindow)
                    OnWindowOver(new WindowSelect_EventArgs(CurWindow));

                if (LastWindow == null)
                {
                    ControlPaint.DrawReversibleFrame(CurWindow.Rect, WindowOutlineColor, WindowOutlineFrameStyle);
                }
                else if (CurWindow != LastWindow)
                {
                    ControlPaint.DrawReversibleFrame(LastWindow.Rect, WindowOutlineColor, WindowOutlineFrameStyle);
                    ControlPaint.DrawReversibleFrame(CurWindow.Rect, WindowOutlineColor, WindowOutlineFrameStyle);
                }

                LastWindow = CurWindow;
                Cursor.Current = Cursors.Cross;
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (LastWindow != null)
                {
                    ControlPaint.DrawReversibleFrame(LastWindow.Rect, WindowOutlineColor, WindowOutlineFrameStyle);
                    Cursor.Current = Cursors.Arrow;

                    OnWindowSelect(new WindowSelect_EventArgs(LastWindow));

                }
            }

            base.OnMouseUp(e);
        }

        protected void OnWindowSelect(WindowSelect_EventArgs e)
        {
            if (WindowSelect != null)
                WindowSelect(this, e);
        }

        protected void OnWindowOver(WindowSelect_EventArgs e)
        {
            if (WindowOver != null)
                WindowOver(this, e);
        }
    }

    #region custom event args
    public class WindowSelect_EventArgs : EventArgs
    {
        private WindowInfo _info;

        public WindowInfo info
        {
            get { return _info; }
        }

        public WindowSelect_EventArgs(WindowInfo info)
        {
            _info = info;
        }
    }
    #endregion custom event args
}
