namespace PlayStation_Desktop
{
    partial class Fetching_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fetching_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_Fetch_Form_wait = new System.Windows.Forms.Label();
            this.button_Fetch_Form_Cancel = new System.Windows.Forms.Button();
            this.materialDivider_Fetch_Form_Top = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider_Fetch_Form_Bottom = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider_Fetch_Form_Left = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider_Fetch_Form_Right = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_Fetch_Form_wait
            // 
            this.label_Fetch_Form_wait.Font = new System.Drawing.Font("NEOTERIC", 18F, System.Drawing.FontStyle.Bold);
            this.label_Fetch_Form_wait.Location = new System.Drawing.Point(135, 40);
            this.label_Fetch_Form_wait.Name = "label_Fetch_Form_wait";
            this.label_Fetch_Form_wait.Size = new System.Drawing.Size(210, 30);
            this.label_Fetch_Form_wait.TabIndex = 1;
            this.label_Fetch_Form_wait.Text = "Fetching Profile ...";
            this.label_Fetch_Form_wait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Fetch_Form_wait.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // button_Fetch_Form_Cancel
            // 
            this.button_Fetch_Form_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.button_Fetch_Form_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fetch_Form_Cancel.Font = new System.Drawing.Font("NEOTERIC", 18F, System.Drawing.FontStyle.Bold);
            this.button_Fetch_Form_Cancel.Location = new System.Drawing.Point(190, 251);
            this.button_Fetch_Form_Cancel.Name = "button_Fetch_Form_Cancel";
            this.button_Fetch_Form_Cancel.Size = new System.Drawing.Size(100, 40);
            this.button_Fetch_Form_Cancel.TabIndex = 2;
            this.button_Fetch_Form_Cancel.Text = "Cancel";
            this.button_Fetch_Form_Cancel.UseVisualStyleBackColor = true;
            this.button_Fetch_Form_Cancel.Click += new System.EventHandler(this.button_Fetch_Form_Cancel_Click);
            // 
            // materialDivider_Fetch_Form_Top
            // 
            this.materialDivider_Fetch_Form_Top.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider_Fetch_Form_Top.Depth = 0;
            this.materialDivider_Fetch_Form_Top.Location = new System.Drawing.Point(0, 0);
            this.materialDivider_Fetch_Form_Top.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Fetch_Form_Top.Name = "materialDivider_Fetch_Form_Top";
            this.materialDivider_Fetch_Form_Top.Size = new System.Drawing.Size(480, 2);
            this.materialDivider_Fetch_Form_Top.TabIndex = 3;
            this.materialDivider_Fetch_Form_Top.Text = "materialDivider1";
            // 
            // materialDivider_Fetch_Form_Bottom
            // 
            this.materialDivider_Fetch_Form_Bottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider_Fetch_Form_Bottom.Depth = 0;
            this.materialDivider_Fetch_Form_Bottom.Location = new System.Drawing.Point(0, 318);
            this.materialDivider_Fetch_Form_Bottom.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Fetch_Form_Bottom.Name = "materialDivider_Fetch_Form_Bottom";
            this.materialDivider_Fetch_Form_Bottom.Size = new System.Drawing.Size(480, 2);
            this.materialDivider_Fetch_Form_Bottom.TabIndex = 4;
            this.materialDivider_Fetch_Form_Bottom.Text = "materialDivider2";
            // 
            // materialDivider_Fetch_Form_Left
            // 
            this.materialDivider_Fetch_Form_Left.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider_Fetch_Form_Left.Depth = 0;
            this.materialDivider_Fetch_Form_Left.Location = new System.Drawing.Point(0, 0);
            this.materialDivider_Fetch_Form_Left.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Fetch_Form_Left.Name = "materialDivider_Fetch_Form_Left";
            this.materialDivider_Fetch_Form_Left.Size = new System.Drawing.Size(2, 320);
            this.materialDivider_Fetch_Form_Left.TabIndex = 5;
            this.materialDivider_Fetch_Form_Left.Text = "materialDivider3";
            // 
            // materialDivider_Fetch_Form_Right
            // 
            this.materialDivider_Fetch_Form_Right.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider_Fetch_Form_Right.Depth = 0;
            this.materialDivider_Fetch_Form_Right.Location = new System.Drawing.Point(478, 0);
            this.materialDivider_Fetch_Form_Right.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Fetch_Form_Right.Name = "materialDivider_Fetch_Form_Right";
            this.materialDivider_Fetch_Form_Right.Size = new System.Drawing.Size(2, 320);
            this.materialDivider_Fetch_Form_Right.TabIndex = 6;
            this.materialDivider_Fetch_Form_Right.Text = "materialDivider3";
            // 
            // Fetching_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.materialDivider_Fetch_Form_Right);
            this.Controls.Add(this.materialDivider_Fetch_Form_Left);
            this.Controls.Add(this.materialDivider_Fetch_Form_Bottom);
            this.Controls.Add(this.materialDivider_Fetch_Form_Top);
            this.Controls.Add(this.button_Fetch_Form_Cancel);
            this.Controls.Add(this.label_Fetch_Form_wait);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fetching_Form";
            this.Text = "Fetching_Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_Fetch_Form_wait;
        private System.Windows.Forms.Button button_Fetch_Form_Cancel;
        private MaterialSkin.Controls.MaterialDivider materialDivider_Fetch_Form_Top;
        private MaterialSkin.Controls.MaterialDivider materialDivider_Fetch_Form_Bottom;
        private MaterialSkin.Controls.MaterialDivider materialDivider_Fetch_Form_Left;
        private MaterialSkin.Controls.MaterialDivider materialDivider_Fetch_Form_Right;
    }
}