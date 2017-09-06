using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PlayStation_Desktop
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //实现无边界Form可拖拽
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
       
        private void pictureBox_Login_Form_About_Click(object sender, EventArgs e)
        {
            About_Form about_form = new About_Form();
            about_form.ShowDialog();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //Fetching_Form fetching_form = new Fetching_Form();
            //fetching_form.ShowDialog();
            Main_Interface main_interface = new Main_Interface(this);
            main_interface.Show();
            this.Hide();
        }

        private void button_Login_Form_PsStore_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://store.playstation.com");
        }

        private void button_Login_Form_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Form_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Login_Form_About_Click(object sender, EventArgs e)
        {
            About_Form about_form = new About_Form();
            about_form.Show();
        }

    }
}
