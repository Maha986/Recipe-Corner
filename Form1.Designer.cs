namespace Recipe_Corner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.Maximized = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Minimized = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.doubleopen = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.loginbutton = new FontAwesome.Sharp.IconButton();
            this.skipbutton = new FontAwesome.Sharp.IconButton();
            this.Registerbutton = new System.Windows.Forms.LinkLabel();
            this.loginmsg = new MaterialSkin.Controls.MaterialLabel();
            this.textpassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.showpassword = new System.Windows.Forms.Button();
            this.hidepassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-5, 36);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.Gainsboro;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1250, 14);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.PaleVioletRed;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(-5, 528);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.Gainsboro;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1250, 148);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 1;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.PaleVioletRed;
            // 
            // Maximized
            // 
            this.Maximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maximized.BackgroundImage")));
            this.Maximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximized.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Maximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximized.Location = new System.Drawing.Point(1174, 2);
            this.Maximized.Name = "Maximized";
            this.Maximized.Size = new System.Drawing.Size(28, 28);
            this.Maximized.TabIndex = 3;
            this.Maximized.UseVisualStyleBackColor = true;
            this.Maximized.Click += new System.EventHandler(this.Maximized_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(1204, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(28, 28);
            this.Close.TabIndex = 3;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimized
            // 
            this.Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimized.BackgroundImage")));
            this.Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimized.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimized.Location = new System.Drawing.Point(1140, 2);
            this.Minimized.Name = "Minimized";
            this.Minimized.Size = new System.Drawing.Size(28, 28);
            this.Minimized.TabIndex = 3;
            this.Minimized.UseVisualStyleBackColor = true;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(71, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 177);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // doubleopen
            // 
            this.doubleopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleopen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doubleopen.BackgroundImage")));
            this.doubleopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doubleopen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.doubleopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleopen.Location = new System.Drawing.Point(1174, 2);
            this.doubleopen.Name = "doubleopen";
            this.doubleopen.Size = new System.Drawing.Size(28, 28);
            this.doubleopen.TabIndex = 5;
            this.doubleopen.UseVisualStyleBackColor = true;
            this.doubleopen.Click += new System.EventHandler(this.doubleopen_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(331, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(332, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Password";
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginbutton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.loginbutton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loginbutton.IconColor = System.Drawing.Color.Black;
            this.loginbutton.IconSize = 16;
            this.loginbutton.Location = new System.Drawing.Point(469, 316);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Rotation = 0D;
            this.loginbutton.Size = new System.Drawing.Size(104, 34);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // skipbutton
            // 
            this.skipbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skipbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.skipbutton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.skipbutton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.skipbutton.IconColor = System.Drawing.Color.Black;
            this.skipbutton.IconSize = 16;
            this.skipbutton.Location = new System.Drawing.Point(653, 316);
            this.skipbutton.Name = "skipbutton";
            this.skipbutton.Rotation = 0D;
            this.skipbutton.Size = new System.Drawing.Size(104, 34);
            this.skipbutton.TabIndex = 9;
            this.skipbutton.Text = "Skip";
            this.skipbutton.UseVisualStyleBackColor = false;
            this.skipbutton.Click += new System.EventHandler(this.skipbutton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registerbutton.AutoSize = true;
            this.Registerbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbutton.Location = new System.Drawing.Point(451, 398);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(340, 19);
            this.Registerbutton.TabIndex = 13;
            this.Registerbutton.TabStop = true;
            this.Registerbutton.Text = "Don\'t already have an account? Register Now";
            this.Registerbutton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registerbutton_LinkClicked);
            // 
            // loginmsg
            // 
            this.loginmsg.AutoSize = true;
            this.loginmsg.Depth = 0;
            this.loginmsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginmsg.Location = new System.Drawing.Point(465, 258);
            this.loginmsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginmsg.Name = "loginmsg";
            this.loginmsg.Size = new System.Drawing.Size(30, 24);
            this.loginmsg.TabIndex = 14;
            this.loginmsg.Text = "    ";
            // 
            // textpassword
            // 
            this.textpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textpassword.Depth = 0;
            this.textpassword.Hint = "";
            this.textpassword.Location = new System.Drawing.Point(477, 215);
            this.textpassword.MaxLength = 32767;
            this.textpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.SelectedText = "";
            this.textpassword.SelectionLength = 0;
            this.textpassword.SelectionStart = 0;
            this.textpassword.Size = new System.Drawing.Size(445, 28);
            this.textpassword.TabIndex = 17;
            this.textpassword.TabStop = false;
            this.textpassword.UseSystemPasswordChar = false;
            // 
            // textname
            // 
            this.textname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textname.Depth = 0;
            this.textname.Hint = "";
            this.textname.Location = new System.Drawing.Point(477, 134);
            this.textname.MaxLength = 32767;
            this.textname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textname.Name = "textname";
            this.textname.PasswordChar = '\0';
            this.textname.SelectedText = "";
            this.textname.SelectionLength = 0;
            this.textname.SelectionStart = 0;
            this.textname.Size = new System.Drawing.Size(445, 28);
            this.textname.TabIndex = 17;
            this.textname.TabStop = false;
            this.textname.UseSystemPasswordChar = false;
            // 
            // showpassword
            // 
            this.showpassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showpassword.BackColor = System.Drawing.Color.Transparent;
            this.showpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showpassword.BackgroundImage")));
            this.showpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showpassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpassword.Location = new System.Drawing.Point(928, 211);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(37, 35);
            this.showpassword.TabIndex = 18;
            this.showpassword.UseVisualStyleBackColor = false;
            this.showpassword.Click += new System.EventHandler(this.showpassword_Click_1);
            // 
            // hidepassword
            // 
            this.hidepassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hidepassword.BackColor = System.Drawing.Color.Transparent;
            this.hidepassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidepassword.BackgroundImage")));
            this.hidepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hidepassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hidepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidepassword.Location = new System.Drawing.Point(928, 211);
            this.hidepassword.Name = "hidepassword";
            this.hidepassword.Size = new System.Drawing.Size(37, 35);
            this.hidepassword.TabIndex = 18;
            this.hidepassword.UseVisualStyleBackColor = false;
            this.hidepassword.Click += new System.EventHandler(this.hidepassword_Click_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.hidepassword);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.loginmsg);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.skipbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.doubleopen);
            this.Controls.Add(this.Maximized);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.Button Maximized;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimized;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button doubleopen;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconButton loginbutton;
        private FontAwesome.Sharp.IconButton skipbutton;
        private System.Windows.Forms.LinkLabel Registerbutton;
        private MaterialSkin.Controls.MaterialLabel loginmsg;
        private MaterialSkin.Controls.MaterialSingleLineTextField textpassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textname;
        private System.Windows.Forms.Button showpassword;
        private System.Windows.Forms.Button hidepassword;
    }
}

