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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Login_Form_About = new System.Windows.Forms.PictureBox();
            this.pictureBox_Hide = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_playstation_logo = new System.Windows.Forms.PictureBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_PlayStation_Desktop_1 = new System.Windows.Forms.Label();
            this.label_PlayStation_Desktop_2 = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.pictureBox_develpoer_avatar = new System.Windows.Forms.PictureBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_Welcom = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_crossline_2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_crossline_1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.materialDivider_Login_Form_1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCheckBox_Login_Remember = new MaterialSkin.Controls.MaterialCheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login_Form_About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_playstation_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_develpoer_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox_Login_Form_About);
            this.panel1.Controls.Add(this.pictureBox_Hide);
            this.panel1.Controls.Add(this.pictureBox_Close);
            this.panel1.Controls.Add(this.pictureBox_playstation_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // pictureBox_Login_Form_About
            // 
            this.pictureBox_Login_Form_About.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Login_Form_About.Image")));
            this.pictureBox_Login_Form_About.Location = new System.Drawing.Point(1110, 5);
            this.pictureBox_Login_Form_About.Name = "pictureBox_Login_Form_About";
            this.pictureBox_Login_Form_About.Size = new System.Drawing.Size(50, 35);
            this.pictureBox_Login_Form_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Login_Form_About.TabIndex = 3;
            this.pictureBox_Login_Form_About.TabStop = false;
            this.pictureBox_Login_Form_About.Click += new System.EventHandler(this.pictureBox_Login_Form_About_Click);
            // 
            // pictureBox_Hide
            // 
            this.pictureBox_Hide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hide.Image")));
            this.pictureBox_Hide.Location = new System.Drawing.Point(1170, 5);
            this.pictureBox_Hide.Name = "pictureBox_Hide";
            this.pictureBox_Hide.Size = new System.Drawing.Size(50, 35);
            this.pictureBox_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Hide.TabIndex = 2;
            this.pictureBox_Hide.TabStop = false;
            this.pictureBox_Hide.Click += new System.EventHandler(this.pictureBox_Hide_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(1230, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Close.TabIndex = 1;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // pictureBox_playstation_logo
            // 
            this.pictureBox_playstation_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_playstation_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_playstation_logo.Image")));
            this.pictureBox_playstation_logo.Location = new System.Drawing.Point(565, 25);
            this.pictureBox_playstation_logo.Name = "pictureBox_playstation_logo";
            this.pictureBox_playstation_logo.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_playstation_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_playstation_logo.TabIndex = 0;
            this.pictureBox_playstation_logo.TabStop = false;
            this.pictureBox_playstation_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // button_Login
            // 
            this.button_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Login.BackgroundImage")));
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(825, 600);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(150, 60);
            this.button_Login.TabIndex = 1;
            this.button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_PlayStation_Desktop_1
            // 
            this.label_PlayStation_Desktop_1.BackColor = System.Drawing.Color.Transparent;
            this.label_PlayStation_Desktop_1.Font = new System.Drawing.Font("Emotion Engine", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayStation_Desktop_1.Location = new System.Drawing.Point(0, 540);
            this.label_PlayStation_Desktop_1.Margin = new System.Windows.Forms.Padding(0);
            this.label_PlayStation_Desktop_1.Name = "label_PlayStation_Desktop_1";
            this.label_PlayStation_Desktop_1.Size = new System.Drawing.Size(400, 62);
            this.label_PlayStation_Desktop_1.TabIndex = 2;
            this.label_PlayStation_Desktop_1.Text = "PlayStation";
            this.label_PlayStation_Desktop_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_PlayStation_Desktop_1.Click += new System.EventHandler(this.label_PlayStation_Desktop_1_Click);
            // 
            // label_PlayStation_Desktop_2
            // 
            this.label_PlayStation_Desktop_2.BackColor = System.Drawing.Color.Transparent;
            this.label_PlayStation_Desktop_2.Font = new System.Drawing.Font("Emotion Engine", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayStation_Desktop_2.Location = new System.Drawing.Point(0, 600);
            this.label_PlayStation_Desktop_2.Margin = new System.Windows.Forms.Padding(0);
            this.label_PlayStation_Desktop_2.Name = "label_PlayStation_Desktop_2";
            this.label_PlayStation_Desktop_2.Size = new System.Drawing.Size(400, 53);
            this.label_PlayStation_Desktop_2.TabIndex = 3;
            this.label_PlayStation_Desktop_2.Text = "Desktop";
            this.label_PlayStation_Desktop_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Description
            // 
            this.label_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Description.Font = new System.Drawing.Font("NEOTERIC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(0, 670);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(400, 27);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = "View Your PSN Profile Freely";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_develpoer_avatar
            // 
            this.pictureBox_develpoer_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_develpoer_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_develpoer_avatar.Image")));
            this.pictureBox_develpoer_avatar.Location = new System.Drawing.Point(0, 330);
            this.pictureBox_develpoer_avatar.Name = "pictureBox_develpoer_avatar";
            this.pictureBox_develpoer_avatar.Size = new System.Drawing.Size(400, 160);
            this.pictureBox_develpoer_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_develpoer_avatar.TabIndex = 5;
            this.pictureBox_develpoer_avatar.TabStop = false;
            // 
            // label_UserID
            // 
            this.label_UserID.BackColor = System.Drawing.Color.Transparent;
            this.label_UserID.Font = new System.Drawing.Font("Emotion Engine", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.Location = new System.Drawing.Point(0, 280);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(400, 40);
            this.label_UserID.TabIndex = 6;
            this.label_UserID.Text = "A-mazin-G";
            this.label_UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Welcom
            // 
            this.label_Welcom.BackColor = System.Drawing.Color.Transparent;
            this.label_Welcom.Font = new System.Drawing.Font("Emotion Engine", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcom.Location = new System.Drawing.Point(0, 220);
            this.label_Welcom.Name = "label_Welcom";
            this.label_Welcom.Size = new System.Drawing.Size(400, 50);
            this.label_Welcom.TabIndex = 7;
            this.label_Welcom.Text = "Welcome";
            this.label_Welcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Emotion Engine", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(500, 380);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(200, 40);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "USER ID:";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_password
            // 
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Emotion Engine", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(500, 460);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(200, 40);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "PASSWD:";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(1138, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Version: 0.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_crossline_2
            // 
            this.label_crossline_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_crossline_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_crossline_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_crossline_2.Location = new System.Drawing.Point(700, 500);
            this.label_crossline_2.Name = "label_crossline_2";
            this.label_crossline_2.Size = new System.Drawing.Size(400, 3);
            this.label_crossline_2.TabIndex = 12;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Emotion Engine", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_password.Location = new System.Drawing.Point(700, 459);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '>';
            this.textBox_password.Size = new System.Drawing.Size(400, 41);
            this.textBox_password.TabIndex = 13;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_crossline_1
            // 
            this.label_crossline_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_crossline_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_crossline_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_crossline_1.Location = new System.Drawing.Point(700, 421);
            this.label_crossline_1.Name = "label_crossline_1";
            this.label_crossline_1.Size = new System.Drawing.Size(400, 3);
            this.label_crossline_1.TabIndex = 11;
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("Emotion Engine", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_username.Location = new System.Drawing.Point(700, 380);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(400, 37);
            this.textBox_username.TabIndex = 10;
            this.textBox_username.Text = "example@email.com";
            this.textBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialDivider_Login_Form_1
            // 
            this.materialDivider_Login_Form_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider_Login_Form_1.Depth = 0;
            this.materialDivider_Login_Form_1.Location = new System.Drawing.Point(400, 200);
            this.materialDivider_Login_Form_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Login_Form_1.Name = "materialDivider_Login_Form_1";
            this.materialDivider_Login_Form_1.Size = new System.Drawing.Size(2, 520);
            this.materialDivider_Login_Form_1.TabIndex = 15;
            this.materialDivider_Login_Form_1.Text = "materialDivider1";
            // 
            // materialCheckBox_Login_Remember
            // 
            this.materialCheckBox_Login_Remember.AutoSize = true;
            this.materialCheckBox_Login_Remember.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckBox_Login_Remember.Depth = 0;
            this.materialCheckBox_Login_Remember.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox_Login_Remember.Location = new System.Drawing.Point(700, 520);
            this.materialCheckBox_Login_Remember.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox_Login_Remember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox_Login_Remember.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox_Login_Remember.Name = "materialCheckBox_Login_Remember";
            this.materialCheckBox_Login_Remember.Ripple = true;
            this.materialCheckBox_Login_Remember.Size = new System.Drawing.Size(120, 30);
            this.materialCheckBox_Login_Remember.TabIndex = 16;
            this.materialCheckBox_Login_Remember.Text = "Remember Me";
            this.materialCheckBox_Login_Remember.UseVisualStyleBackColor = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialCheckBox_Login_Remember);
            this.Controls.Add(this.materialDivider_Login_Form_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_crossline_2);
            this.Controls.Add(this.label_crossline_1);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_Welcom);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.pictureBox_develpoer_avatar);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_PlayStation_Desktop_2);
            this.Controls.Add(this.label_PlayStation_Desktop_1);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Text = "UI SAMPLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login_Form_About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_playstation_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_develpoer_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_playstation_logo;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Hide;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_PlayStation_Desktop_1;
        private System.Windows.Forms.Label label_PlayStation_Desktop_2;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.PictureBox pictureBox_develpoer_avatar;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Label label_Welcom;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_crossline_2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_crossline_1;
        private System.Windows.Forms.TextBox textBox_username;
        private MaterialSkin.Controls.MaterialDivider materialDivider_Login_Form_1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox_Login_Remember;
        private System.Windows.Forms.PictureBox pictureBox_Login_Form_About;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

