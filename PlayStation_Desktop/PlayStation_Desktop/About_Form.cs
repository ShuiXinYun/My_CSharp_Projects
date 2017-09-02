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

namespace PlayStation_Desktop
{
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
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

        private void pictureBox_About_Form_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_About_Form_aboutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_About_Form_aboutlink.LinkVisited = true;
            System.Diagnostics.Process.Start("www.yunshuixin.cn/playstation-desktop");
        }

        private void linkLabel_About_Form_Tustin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_About_Form_Tustin.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Tustin/psn-csharp");
        }

        private void linkLabel_About_Form_Aboutme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_About_Form_Aboutme.LinkVisited = true;
            System.Diagnostics.Process.Start("http://yunshuixin.cn/about-me/");
        }
    }
}
