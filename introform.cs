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
    public partial class introform : Form
    {
        public introform()
        {
            InitializeComponent();
        }

        private void introform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            materialProgressBar4.Value+=1;
            if (materialProgressBar4.Value == 100)
            {
                
                timer1.Stop();
                Form f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

    }
}
