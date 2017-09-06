﻿using System;
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
    public partial class Main_Interface : Form
    {
        private Login_Form login_form_in_main_interface;
        public Main_Interface(Login_Form login_Form)
        {
            login_form_in_main_interface = login_Form;
            InitializeComponent();
        }

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

        private void pictureBox_Main_Interface_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label_Main_Interface_Profile_Platium_Click(object sender, EventArgs e)
        {

        }

        private void button_Main_Interface_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form_in_main_interface.Close();
        }

        private void button_Main_Interface_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button_Main_Interface_Profile_Click(object sender, EventArgs e)
        {
            this.panel_Main_Interface_Profile.Visible = true;
        }

        private void button_Main_Interface_Trophy_Click(object sender, EventArgs e)
        {
            this.panel_Main_Interface_Profile.Visible = false;
        }
    }
}
