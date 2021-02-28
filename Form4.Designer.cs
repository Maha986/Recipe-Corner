namespace Recipe_Corner
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.descriptiontextbox = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.videotitle = new MaterialSkin.Controls.MaterialLabel();
            this.videodate = new MaterialSkin.Controls.MaterialLabel();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaplayer
            // 
            this.mediaplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(12, 52);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(879, 562);
            this.mediaplayer.TabIndex = 0;
            // 
            // descriptiontextbox
            // 
            this.descriptiontextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptiontextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptiontextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptiontextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontextbox.Location = new System.Drawing.Point(897, 88);
            this.descriptiontextbox.Name = "descriptiontextbox";
            this.descriptiontextbox.ReadOnly = true;
            this.descriptiontextbox.Size = new System.Drawing.Size(343, 526);
            this.descriptiontextbox.TabIndex = 2;
            this.descriptiontextbox.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(897, 52);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Description:";
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Indigo;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-5, 30);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.Gainsboro;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1250, 14);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 4;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.PaleVioletRed;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.PaleVioletRed;
            // 
            // videotitle
            // 
            this.videotitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.videotitle.AutoSize = true;
            this.videotitle.Depth = 0;
            this.videotitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.videotitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.videotitle.Location = new System.Drawing.Point(12, 633);
            this.videotitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.videotitle.Name = "videotitle";
            this.videotitle.Size = new System.Drawing.Size(50, 24);
            this.videotitle.TabIndex = 6;
            this.videotitle.Text = "        ";
            // 
            // videodate
            // 
            this.videodate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.videodate.AutoSize = true;
            this.videodate.Depth = 0;
            this.videodate.Font = new System.Drawing.Font("Roboto", 11F);
            this.videodate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.videodate.Location = new System.Drawing.Point(775, 633);
            this.videodate.MouseState = MaterialSkin.MouseState.HOVER;
            this.videodate.Name = "videodate";
            this.videodate.Size = new System.Drawing.Size(55, 24);
            this.videodate.TabIndex = 6;
            this.videodate.Text = "         ";
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Location = new System.Drawing.Point(12, 1);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(64, 23);
            this.backbutton.TabIndex = 7;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.videodate);
            this.Controls.Add(this.videotitle);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.descriptiontextbox);
            this.Controls.Add(this.mediaplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private System.Windows.Forms.RichTextBox descriptiontextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private MaterialSkin.Controls.MaterialLabel videotitle;
        private MaterialSkin.Controls.MaterialLabel videodate;
        private System.Windows.Forms.Button backbutton;
    }
}