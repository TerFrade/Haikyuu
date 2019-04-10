using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace zENPLOYEE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void ButtonClick(object sender)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.FromArgb(242, 115, 4);

            foreach (Button btn in clickedButton.Parent.Controls.OfType<Button>())
            {
                if (btn != clickedButton)
                {
                    btn.BackColor = Color.FromArgb(59, 67, 82);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopNavPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
    }
}
