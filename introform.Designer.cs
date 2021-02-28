namespace Recipe_Corner
{
    partial class introform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introform));
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialProgressBar3 = new MaterialSkin.Controls.MaterialProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialProgressBar4 = new MaterialSkin.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(-19, -19);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar1.TabIndex = 0;
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(-19, -19);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar2.TabIndex = 1;
            // 
            // materialProgressBar3
            // 
            this.materialProgressBar3.Depth = 0;
            this.materialProgressBar3.Location = new System.Drawing.Point(-19, -19);
            this.materialProgressBar3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar3.Name = "materialProgressBar3";
            this.materialProgressBar3.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialProgressBar4
            // 
            this.materialProgressBar4.Depth = 0;
            this.materialProgressBar4.Location = new System.Drawing.Point(1, 670);
            this.materialProgressBar4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar4.Name = "materialProgressBar4";
            this.materialProgressBar4.Size = new System.Drawing.Size(1244, 5);
            this.materialProgressBar4.TabIndex = 3;
            // 
            // introform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.materialProgressBar4);
            this.Controls.Add(this.materialProgressBar3);
            this.Controls.Add(this.materialProgressBar2);
            this.Controls.Add(this.materialProgressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "introform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "introform";
            this.Load += new System.EventHandler(this.introform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar3;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar4;
    }
}