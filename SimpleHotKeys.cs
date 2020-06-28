using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SimpleHotKeys
{
    
    public abstract class HotKey : System.Windows.Forms.Form
    {
        [DllImport("user32.dll")] public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);
        Keys hotKey;
        IntPtr MainWindowHandler;
        bool toggle;
        Thread executer;
        public HotKey(Keys hotKey, bool toggle)
        {
            this.hotKey = hotKey;
            MainWindowHandler = this.Handle;
            this.toggle = toggle;
            if (toggle)
            {
                executer = new Thread(new ThreadStart(toggleWhenPressed));
            }
            RegisterHotKey(MainWindowHandler, 1, 0x4000, hotKey.GetHashCode());
        }
        public abstract void whenPressed();
        
        private void toggleWhenPressed()
        {
            while (true) whenPressed();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (toggle)
                {
                    if (executer.IsAlive)
                    {
                        executer.Abort();
                        executer = new Thread(new ThreadStart(toggleWhenPressed));
                    }
                    else
                    {
                        executer.Start();
                    }
                }
                else
                {
                    whenPressed();
                }
            }
            base.WndProc(ref m);
        }
    }
}
