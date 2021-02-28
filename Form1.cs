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
    public partial class Form1 : Form
    {
        User user2 = new User();
        public static string setname;  // Being use in Form3 for having user who logged in info
        public static bool skipButtonWasClicked = false; //Use in next form to give condition if user is not login
        public Form1()
        {
            InitializeComponent();
           
        }
        
        //SCREEN DOWN BUTTON

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //SCREEN MAXIMIZE BUTTON
        private void Maximized_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Maximized;
             doubleopen.BringToFront();
        }

        //APPLICATION CLOSE BUTTON
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //SCREEN NORMAL BUTTON
        private void doubleopen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximized.BringToFront();
        }

        // Form load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            Maximized.BringToFront();
            showpassword.BringToFront();
        }

        // Login Button
        private void loginbutton_Click(object sender, EventArgs e)
        {
            user2.login(textname.Text, textpassword.Text);
            if (user2.success == true)
            {
                setname = textname.Text;
                Form f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                loginmsg.Text = user2.message;  //loginmsg is transparent label which will have text only when user input wrong info
                loginmsg.ForeColor = Color.Red;
            }
        }

        //Skip Button
        private void skipbutton_Click(object sender, EventArgs e)
        {
            skipButtonWasClicked = true;
            Form f3 = new Form3();
            f3.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                f3.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }

        //Register Now
        private void Registerbutton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                f2.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }


       
        //Password show
        private void showpassword_Click_1(object sender, EventArgs e)
        {
            textpassword.PasswordChar = '\0'; //passing null character to password char
            hidepassword.BringToFront();
        }
        //Password Hide
        private void hidepassword_Click_1(object sender, EventArgs e)
        {
            textpassword.PasswordChar = '*';
            showpassword.BringToFront();
        }
    }
}
