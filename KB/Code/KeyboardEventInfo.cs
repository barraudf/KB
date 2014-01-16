using System;
using System.Runtime.InteropServices;

namespace KB.Code
{
    public class KeyboardEventInfo
    {
        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hwnd, uint wMsg, int wParam, int lParam);

        public uint lParam { get; set; }
        public uint m_Msg { get; set; }
        public int m_Key { get; set; }

        public KeyboardEventInfo(KeyboardListener.UniversalKeyEventArgs eventArgs)
        {
            switch (eventArgs.m_Msg)
            {
                /*WM_KEYDOWN*/
                case 0x0100: lParam = 0x00000001; break;
                /*WM_KEYUP*/
                case 0x0101: lParam = 0xC0000001; break;
                /*WM_CHAR*/
                case 0x0102: lParam = 0xC0000001; break;
                /*WM_DEADCHAR*/
                case 0x0103: lParam = 0xC0000001; break;
                /*WM_SYSKEYDOWN*/
                case 0x0104: lParam = 0x00000001; break;
                /*WM_SYSKEYUP*/
                case 0x0105: lParam = 0xC0000001; break;
                default: lParam = 0x00000001; break;
            }
            m_Msg = eventArgs.m_Msg;
            m_Key = eventArgs.m_Key;
        }

        public void PostMessage(IntPtr handle)
        {
            PostMessage(handle, m_Msg, m_Key, (int)lParam);
        }

        public void Replay(IntPtr handle)
        {
            if (m_Key == (int)WindowsInput.VirtualKeyCode.SHIFT)
            {
                if (m_Msg == 0x0100)
                    WindowsInput.InputSimulator.SimulateKeyDown(WindowsInput.VirtualKeyCode.SHIFT);
                else if(m_Msg == 0x0101)
                    WindowsInput.InputSimulator.SimulateKeyUp(WindowsInput.VirtualKeyCode.SHIFT);
            }
            PostMessage(handle);
        }
    }
}
