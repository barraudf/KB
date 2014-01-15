using System;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;

namespace KB.Code
{
    public class WindowInfo
    {
        public const int WM_GETTEXT = 0xD;
        public const int WM_GETTEXTLENGTH = 0x000E;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr handle, out RECT Rect);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr handle, StringBuilder ClassName, int MaxCount);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr handle, int msg, int Param1, int Param2);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr handle, int msg, int Param, System.Text.StringBuilder text);

        public IntPtr Handle;
        public string ClassName;
        public string Text;
        public Rectangle Rect;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

        }

        public WindowInfo(IntPtr handle)
        {
            Handle = handle;
            ClassName = GetWindowClassName(Handle);
            Text = GetWindowText(Handle);
            Rect = GetWindowRectangle(Handle);
        }

        private static string GetWindowClassName(IntPtr handle)
        {
            StringBuilder buffer = new StringBuilder(128);
            GetClassName(handle, buffer, buffer.Capacity);
            return buffer.ToString();
        }

        private static string GetWindowText(IntPtr handle)
        {
            StringBuilder buffer = new StringBuilder(SendMessage(handle, WM_GETTEXTLENGTH, 0, 0) + 1);
            SendMessage(handle, WM_GETTEXT, buffer.Capacity, buffer);
            return buffer.ToString();
        }

        private static Rectangle GetWindowRectangle(IntPtr handle)
        {
            RECT rect = new RECT();
            GetWindowRect(handle, out rect);
            return new Rectangle(rect.Left, rect.Top, (rect.Right - rect.Left) + 1, (rect.Bottom - rect.Top) + 1);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (obj is WindowInfo)
                return ((WindowInfo)obj).Handle == Handle;
            else
                return base.Equals(obj);
        }
    }
}
