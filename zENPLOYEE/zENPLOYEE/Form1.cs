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
            Load += MainForm_Load;
        }
        private void MainForm_Load(Object sender, EventArgs e)
        {
            btnHome.PerformClick();
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

        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
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
            if (!pnlDisplay.Controls.Contains(uscHome.Instance))
            {
                pnlDisplay.Controls.Add(uscHome.Instance);
                uscHome.Instance.Dock = DockStyle.Fill;
                uscHome.Instance.BringToFront();
            }
            else
                uscHome.Instance.BringToFront();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
            if (!pnlDisplay.Controls.Contains(uscTime.Instance))
            {
                pnlDisplay.Controls.Add(uscTime.Instance);
                uscTime.Instance.Dock = DockStyle.Fill;
                uscTime.Instance.BringToFront();
            }
            else
                uscTime.Instance.BringToFront();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
            if (!pnlDisplay.Controls.Contains(uscLeave.Instance))
            {
                pnlDisplay.Controls.Add(uscLeave.Instance);
                uscLeave.Instance.Dock = DockStyle.Fill;
                uscLeave.Instance.BringToFront();
            }
            else
                uscLeave.Instance.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
            if (!pnlDisplay.Controls.Contains(uscSettings.Instance))
            {
                pnlDisplay.Controls.Add(uscSettings.Instance);
                uscSettings.Instance.Dock = DockStyle.Fill;
                uscSettings.Instance.BringToFront();
            }
            else
                uscSettings.Instance.BringToFront();
        }
        
    }
}
