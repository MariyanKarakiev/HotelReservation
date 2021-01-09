using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        // Making the Top menu moveable.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();

            //Removing default top menu navigation
            FormBorderStyle = FormBorderStyle.None;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExpandProgram_Click(object sender, EventArgs e)
        {
            //Checking whether the program is maximized or not
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizeProgram_Click(object sender, EventArgs e)
        {
            //Minimazing program
            WindowState = FormWindowState.Minimized;
        }

        private void panelTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            //Addition to the moving function
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void topMenuName_MouseDown(object sender, MouseEventArgs e)
        {
            //Addition to the moving function
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
