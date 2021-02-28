using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Corner
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            mediaplayer.URL = Form3.url;
            videotitle.Text = Form3.title;
            videodate.Text = Form3.date;
            if (Form1.skipButtonWasClicked)
            {
                descriptiontextbox.Text = "You can view description after loging in";
            }
            else
            {
                if (String.IsNullOrEmpty(Form3.description))
                {
                    descriptiontextbox.Text = "There is no relevant description for this recipe.";
                }
                else
                {
                    descriptiontextbox.Text = Form3.description;

                }
            }
        }

        

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                f.WindowState = FormWindowState.Maximized;
            }
            this.Close();
        }
    }
}
