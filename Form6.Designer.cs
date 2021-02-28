namespace Recipe_Corner
{
    partial class Form6
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
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Loginbtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, -3);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.Gainsboro;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(508, 13);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.PaleVioletRed;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 167);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.Gainsboro;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(502, 53);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 1;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.PaleVioletRed;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 49);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(435, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Congratulations!! You have registered successfully";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Loginbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Loginbtn.IconColor = System.Drawing.Color.Black;
            this.Loginbtn.IconSize = 16;
            this.Loginbtn.Location = new System.Drawing.Point(190, 105);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Rotation = 0D;
            this.Loginbtn.Size = new System.Drawing.Size(97, 38);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 217);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FontAwesome.Sharp.IconButton Loginbtn;
    }
}