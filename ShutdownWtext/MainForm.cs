using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ShutdownWtext
{
    public partial class MainForm : Form
    {

        [DllImport("user32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Auto)]
        static extern IntPtr GetWindowCaption(IntPtr hwnd, StringBuilder lpString, int maxCount);
        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        static extern int SendMessage3(IntPtr hwndControl, uint Msg,
          int wParam, StringBuilder strBuffer); // get text

        [DllImport("user32.dll", EntryPoint = "SendMessage",
          CharSet = CharSet.Auto)]
        static extern int SendMessage4(IntPtr hwndControl, uint Msg,
          int wParam, int lParam);  // text length
        [DllImport("user32.dll")]
        static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, Point Point);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point Point);

        [DllImport("user32.dll")]
        static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int RegisterWindowMessage(string lpString);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx",
  CharSet = CharSet.Auto)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent,
          IntPtr hwndChildAfter, string lpszClass, string lpszWindow);



        static string GetWindowCaption(IntPtr hwnd)
        {
            StringBuilder sb = new StringBuilder(256);
            GetWindowCaption(hwnd, sb, 256);
            return sb.ToString();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static int GetTextBoxTextLength(IntPtr hTextBox)
        {
            // helper for GetTextBoxText
            uint WM_GETTEXTLENGTH = 0x000E;
            int result = SendMessage4(hTextBox, WM_GETTEXTLENGTH,
              0, 0);
            return result;
        }

        static string GetTextBoxText(IntPtr hTextBox)
        {
            uint WM_GETTEXT = 0x000D;
            int len = GetTextBoxTextLength(hTextBox);
            if (len <= 0) return null;  // no text
            StringBuilder sb = new StringBuilder(len + 1);
            SendMessage3(hTextBox, WM_GETTEXT, len + 1, sb);
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            Point p = Cursor.Position;
            IntPtr phwnd = WindowFromPoint(Cursor.Position);
            ScreenToClient(phwnd, ref p);
            IntPtr hwnd = ChildWindowFromPoint(phwnd, p);
            handleWindowEdt.Text = hwnd.ToString();
            tituloJanelaEdt.Text = GetTextBoxText(hwnd);
            button2.PerformClick();

            // Need to capture to see mouse move messages...
            this.Capture = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (handleWindowEdt.Text == String.Empty)
            {
                return;
            }

            // get handle to app
            // get and store handles to children
            Console.WriteLine("The text/caption of each child" +
              "control window is:");
            List<IntPtr> children = GetAllChildrenWindowHandles(new IntPtr(Convert.ToInt32(handleWindowEdt.Text)), 999);
            textList.Items.Clear();
            for (int i = 0; i < children.Count; ++i)
            {
                IntPtr hControl = children[i];
                string caption = GetTextBoxText(hControl);
                if (!String.IsNullOrEmpty(caption))
                {
                    textList.Items.Add(caption);
                }
            }
        }




        static List<IntPtr> GetAllChildrenWindowHandles(IntPtr hParent,
  int maxCount)
        {
            List<IntPtr> result = new List<IntPtr>();
            int ct = 0;
            IntPtr prevChild = IntPtr.Zero;
            IntPtr currChild = IntPtr.Zero;
            while (true && ct < maxCount)
            {
                currChild = FindWindowEx(hParent, prevChild, null, null);
                if (currChild == IntPtr.Zero) break;
                result.Add(currChild);
                prevChild = currChild;
                ++ct;
            }
            return result;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            IntPtr hWnd = WindowFromPoint(Control.MousePosition);
            if (hWnd != IntPtr.Zero)
            {
                Control ctl = Control.FromHandle(hWnd);
                if (ctl != null) label1.Text = ctl.Name;
            }
        }
    }
}
