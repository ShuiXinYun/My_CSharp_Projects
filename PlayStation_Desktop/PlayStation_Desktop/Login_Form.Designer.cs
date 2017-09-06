namespace PlayStation_Desktop
{
    partial class Login_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel_Login_Form_upper_panel = new System.Windows.Forms.Panel();
            this.label_crossline3 = new System.Windows.Forms.Label();
            this.button_Login_Form_PsStore = new System.Windows.Forms.Button();
            this.button_Login_Form_About = new System.Windows.Forms.Button();
            this.button_Login_Form_Close = new System.Windows.Forms.Button();
            this.button_Login_Form_Hide = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_Login_Form_Welcome_panel = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_crossline_2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_crossline_1 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_PlayStation_Desktop_2 = new System.Windows.Forms.Label();
            this.label_PlayStation_Desktop_1 = new System.Windows.Forms.Label();
            this.panel_Login_Form_Login_panel = new System.Windows.Forms.Panel();
            this.pictureBox_login_background = new System.Windows.Forms.PictureBox();
            this.panel_Login_Form_upper_panel.SuspendLayout();
            this.panel_Login_Form_Welcome_panel.SuspendLayout();
            this.panel_Login_Form_Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_background)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login_Form_upper_panel
            // 
            this.panel_Login_Form_upper_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_Login_Form_upper_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Login_Form_upper_panel.Controls.Add(this.label_crossline3);
            this.panel_Login_Form_upper_panel.Controls.Add(this.button_Login_Form_PsStore);
            this.panel_Login_Form_upper_panel.Controls.Add(this.button_Login_Form_About);
            this.panel_Login_Form_upper_panel.Controls.Add(this.button_Login_Form_Close);
            this.panel_Login_Form_upper_panel.Controls.Add(this.button_Login_Form_Hide);
            this.panel_Login_Form_upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Login_Form_upper_panel.Location = new System.Drawing.Point(0, 0);
            this.panel_Login_Form_upper_panel.Name = "panel_Login_Form_upper_panel";
            this.panel_Login_Form_upper_panel.Size = new System.Drawing.Size(1440, 220);
            this.panel_Login_Form_upper_panel.TabIndex = 0;
            this.panel_Login_Form_upper_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel_Login_Form_upper_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // label_crossline3
            // 
            this.label_crossline3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_crossline3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_crossline3.Location = new System.Drawing.Point(3, 218);
            this.label_crossline3.Name = "label_crossline3";
            this.label_crossline3.Size = new System.Drawing.Size(1440, 2);
            this.label_crossline3.TabIndex = 33;
            // 
            // button_Login_Form_PsStore
            // 
            this.button_Login_Form_PsStore.FlatAppearance.BorderSize = 0;
            this.button_Login_Form_PsStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Form_PsStore.Image = ((System.Drawing.Image)(resources.GetObject("button_Login_Form_PsStore.Image")));
            this.button_Login_Form_PsStore.Location = new System.Drawing.Point(640, 30);
            this.button_Login_Form_PsStore.Name = "button_Login_Form_PsStore";
            this.button_Login_Form_PsStore.Size = new System.Drawing.Size(160, 160);
            this.button_Login_Form_PsStore.TabIndex = 27;
            this.button_Login_Form_PsStore.UseVisualStyleBackColor = true;
            this.button_Login_Form_PsStore.Click += new System.EventHandler(this.button_Login_Form_PsStore_Click);
            // 
            // button_Login_Form_About
            // 
            this.button_Login_Form_About.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Login_Form_About.FlatAppearance.BorderSize = 0;
            this.button_Login_Form_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Form_About.Image = ((System.Drawing.Image)(resources.GetObject("button_Login_Form_About.Image")));
            this.button_Login_Form_About.Location = new System.Drawing.Point(1280, 0);
            this.button_Login_Form_About.Name = "button_Login_Form_About";
            this.button_Login_Form_About.Size = new System.Drawing.Size(50, 50);
            this.button_Login_Form_About.TabIndex = 13;
            this.button_Login_Form_About.UseVisualStyleBackColor = false;
            this.button_Login_Form_About.Click += new System.EventHandler(this.button_Login_Form_About_Click);
            // 
            // button_Login_Form_Close
            // 
            this.button_Login_Form_Close.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Login_Form_Close.FlatAppearance.BorderSize = 0;
            this.button_Login_Form_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Form_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Login_Form_Close.Image")));
            this.button_Login_Form_Close.Location = new System.Drawing.Point(1390, 0);
            this.button_Login_Form_Close.Name = "button_Login_Form_Close";
            this.button_Login_Form_Close.Size = new System.Drawing.Size(50, 50);
            this.button_Login_Form_Close.TabIndex = 12;
            this.button_Login_Form_Close.UseVisualStyleBackColor = false;
            this.button_Login_Form_Close.Click += new System.EventHandler(this.button_Login_Form_Close_Click);
            // 
            // button_Login_Form_Hide
            // 
            this.button_Login_Form_Hide.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Login_Form_Hide.FlatAppearance.BorderSize = 0;
            this.button_Login_Form_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Form_Hide.Image = ((System.Drawing.Image)(resources.GetObject("button_Login_Form_Hide.Image")));
            this.button_Login_Form_Hide.Location = new System.Drawing.Point(1330, 0);
            this.button_Login_Form_Hide.Name = "button_Login_Form_Hide";
            this.button_Login_Form_Hide.Size = new System.Drawing.Size(50, 50);
            this.button_Login_Form_Hide.TabIndex = 11;
            this.button_Login_Form_Hide.UseVisualStyleBackColor = false;
            this.button_Login_Form_Hide.Click += new System.EventHandler(this.button_Login_Form_Hide_Click);
            // 
            // panel_Login_Form_Welcome_panel
            // 
            this.panel_Login_Form_Welcome_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.button_Login);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_crossline_2);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.textBox_password);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.textBox_username);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_crossline_1);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_username);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_Welcome);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_Description);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_password);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_PlayStation_Desktop_2);
            this.panel_Login_Form_Welcome_panel.Controls.Add(this.label_PlayStation_Desktop_1);
            this.panel_Login_Form_Welcome_panel.Location = new System.Drawing.Point(0, 220);
            this.panel_Login_Form_Welcome_panel.Name = "panel_Login_Form_Welcome_panel";
            this.panel_Login_Form_Welcome_panel.Size = new System.Drawing.Size(516, 520);
            this.panel_Login_Form_Welcome_panel.TabIndex = 19;
            this.panel_Login_Form_Welcome_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Login.BackgroundImage")));
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(183, 287);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(150, 60);
            this.button_Login.TabIndex = 26;
            this.button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_crossline_2
            // 
            this.label_crossline_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_crossline_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_crossline_2.Location = new System.Drawing.Point(160, 275);
            this.label_crossline_2.Name = "label_crossline_2";
            this.label_crossline_2.Size = new System.Drawing.Size(320, 3);
            this.label_crossline_2.TabIndex = 31;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Emotion Engine", 20F);
            this.textBox_password.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_password.Location = new System.Drawing.Point(160, 242);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '>';
            this.textBox_password.Size = new System.Drawing.Size(320, 31);
            this.textBox_password.TabIndex = 32;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("Emotion Engine", 20F);
            this.textBox_username.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_username.Location = new System.Drawing.Point(160, 182);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(320, 31);
            this.textBox_username.TabIndex = 29;
            this.textBox_username.Text = "example@email.com";
            this.textBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_crossline_1
            // 
            this.label_crossline_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_crossline_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_crossline_1.Location = new System.Drawing.Point(160, 215);
            this.label_crossline_1.Name = "label_crossline_1";
            this.label_crossline_1.Size = new System.Drawing.Size(320, 3);
            this.label_crossline_1.TabIndex = 30;
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Emotion Engine", 24F);
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_username.Location = new System.Drawing.Point(0, 185);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(150, 40);
            this.label_username.TabIndex = 27;
            this.label_username.Text = "USER ID:";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_username.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // label_Welcome
            // 
            this.label_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Welcome.Font = new System.Drawing.Font("NEOTERIC", 45F, System.Drawing.FontStyle.Bold);
            this.label_Welcome.Location = new System.Drawing.Point(0, 60);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(516, 65);
            this.label_Welcome.TabIndex = 26;
            this.label_Welcome.Text = "WELCOME";
            this.label_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Welcome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // label_Description
            // 
            this.label_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Description.Font = new System.Drawing.Font("NEOTERIC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(0, 470);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(516, 27);
            this.label_Description.TabIndex = 25;
            this.label_Description.Text = "View Your PSN Profile Freely";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Description.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // label_password
            // 
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Emotion Engine", 24F);
            this.label_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_password.Location = new System.Drawing.Point(0, 245);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(150, 40);
            this.label_password.TabIndex = 28;
            this.label_password.Text = "PASSWD:";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // label_PlayStation_Desktop_2
            // 
            this.label_PlayStation_Desktop_2.BackColor = System.Drawing.Color.Transparent;
            this.label_PlayStation_Desktop_2.Font = new System.Drawing.Font("Emotion Engine", 32F);
            this.label_PlayStation_Desktop_2.Location = new System.Drawing.Point(0, 410);
            this.label_PlayStation_Desktop_2.Margin = new System.Windows.Forms.Padding(0);
            this.label_PlayStation_Desktop_2.Name = "label_PlayStation_Desktop_2";
            this.label_PlayStation_Desktop_2.Size = new System.Drawing.Size(516, 53);
            this.label_PlayStation_Desktop_2.TabIndex = 24;
            this.label_PlayStation_Desktop_2.Text = "Desktop";
            this.label_PlayStation_Desktop_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_PlayStation_Desktop_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // label_PlayStation_Desktop_1
            // 
            this.label_PlayStation_Desktop_1.BackColor = System.Drawing.Color.Transparent;
            this.label_PlayStation_Desktop_1.Font = new System.Drawing.Font("Emotion Engine", 36F);
            this.label_PlayStation_Desktop_1.Location = new System.Drawing.Point(0, 360);
            this.label_PlayStation_Desktop_1.Margin = new System.Windows.Forms.Padding(0);
            this.label_PlayStation_Desktop_1.Name = "label_PlayStation_Desktop_1";
            this.label_PlayStation_Desktop_1.Size = new System.Drawing.Size(516, 62);
            this.label_PlayStation_Desktop_1.TabIndex = 23;
            this.label_PlayStation_Desktop_1.Text = "PlayStation";
            this.label_PlayStation_Desktop_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_PlayStation_Desktop_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // panel_Login_Form_Login_panel
            // 
            this.panel_Login_Form_Login_panel.Controls.Add(this.pictureBox_login_background);
            this.panel_Login_Form_Login_panel.Location = new System.Drawing.Point(516, 220);
            this.panel_Login_Form_Login_panel.Name = "panel_Login_Form_Login_panel";
            this.panel_Login_Form_Login_panel.Size = new System.Drawing.Size(924, 520);
            this.panel_Login_Form_Login_panel.TabIndex = 20;
            // 
            // pictureBox_login_background
            // 
            this.pictureBox_login_background.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_login_background.Image")));
            this.pictureBox_login_background.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_login_background.Name = "pictureBox_login_background";
            this.pictureBox_login_background.Size = new System.Drawing.Size(924, 520);
            this.pictureBox_login_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_login_background.TabIndex = 0;
            this.pictureBox_login_background.TabStop = false;
            this.pictureBox_login_background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 740);
            this.Controls.Add(this.panel_Login_Form_Login_panel);
            this.Controls.Add(this.panel_Login_Form_Welcome_panel);
            this.Controls.Add(this.panel_Login_Form_upper_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Text = "UI SAMPLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel_Login_Form_upper_panel.ResumeLayout(false);
            this.panel_Login_Form_Welcome_panel.ResumeLayout(false);
            this.panel_Login_Form_Welcome_panel.PerformLayout();
            this.panel_Login_Form_Login_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login_Form_upper_panel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Login_Form_Close;
        private System.Windows.Forms.Button button_Login_Form_Hide;
        private System.Windows.Forms.Button button_Login_Form_About;
        private System.Windows.Forms.Panel panel_Login_Form_Welcome_panel;
        private System.Windows.Forms.Button button_Login_Form_PsStore;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_PlayStation_Desktop_2;
        private System.Windows.Forms.Label label_PlayStation_Desktop_1;
        private System.Windows.Forms.Panel panel_Login_Form_Login_panel;
        private System.Windows.Forms.PictureBox pictureBox_login_background;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_crossline_2;
        private System.Windows.Forms.Label label_crossline_1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_crossline3;
    }
}

