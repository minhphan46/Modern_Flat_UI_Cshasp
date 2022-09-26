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

namespace Modern_Flat_UI
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

         );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = buttonDashboard.Height;
            pnlNav.Top = buttonDashboard.Top;
            pnlNav.Left = buttonDashboard.Left;
            //buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "DashBoard";
            this.panelFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonDashboard.Height;
            pnlNav.Top = buttonDashboard.Top;
            pnlNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "DashBoard";
            this.panelFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonAnalytics.Height;
            pnlNav.Top = buttonAnalytics.Top;
            buttonAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.panelFormLoader.Controls.Clear();
            frmAnalytics FrmAnalytics_Vrb = new frmAnalytics()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            FrmAnalytics_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmAnalytics_Vrb);
            FrmAnalytics_Vrb.Show();
        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonCalender.Height;
            pnlNav.Top = buttonCalender.Top;
            buttonCalender.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calender";
            this.panelFormLoader.Controls.Clear();
            frmCalender FrmCalender_Vrb = new frmCalender()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            FrmCalender_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmCalender_Vrb);
            FrmCalender_Vrb.Show();
        }

        private void buttonContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonContactUs.Height;
            pnlNav.Top = buttonContactUs.Top;
            buttonContactUs.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "ContactUs";
            this.panelFormLoader.Controls.Clear();
            frmContactUs FrmContactUs_Vrb = new frmContactUs()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            FrmContactUs_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmContactUs_Vrb);
            FrmContactUs_Vrb.Show();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonSetting.Height;
            pnlNav.Top = buttonSetting.Top;
            buttonSetting.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Setting";
            this.panelFormLoader.Controls.Clear();
            frmSetting FrmSetting_Vrb = new frmSetting()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            FrmSetting_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmSetting_Vrb);
            FrmSetting_Vrb.Show();
        }

        private void buttonDashboard_Leave(object sender, EventArgs e)
        {
            buttonDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonAnalytics_Leave(object sender, EventArgs e)
        {
            buttonAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonCalender_Leave(object sender, EventArgs e)
        {
            buttonCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonContactUs_Leave(object sender, EventArgs e)
        {
            buttonContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonSetting_Leave(object sender, EventArgs e)
        {
            buttonSetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Xu ly di chuyen form =======================================
        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        //=========================================================
    }
}
