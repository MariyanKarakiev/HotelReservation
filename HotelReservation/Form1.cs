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
    public partial class MainPage : Form
    {
        
        // Making the Top menu moveable.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public MainPage()
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

        // Moving redline in navigation
       // TODO: Make the redline go back to home whenever the mouse leaves the menu.
        private void btnReserve_MouseHover(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 50);
        }

        private void btnPrices_MouseHover(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 98);
        }

        private void btnAboutUs_MouseHover(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 145);
        }

        private void btnContactUs_MouseHover(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 192);
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 2);
        }

        private void panelMenu_MouseLeave_1(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 2);
        }

        private void panelContentHolder_MouseHover(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 2);
        }

        private void panelSideNav_MouseLeave(object sender, EventArgs e)
        {
            pnlRedLine.Location = new Point(2, 2);
        }
    }
}
