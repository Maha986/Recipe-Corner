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
    
    public partial class Form2 : Form
    {
        string profilepath;

        public Form2()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Doubleopen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximized.BringToFront();
        }

        private void Maximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Doubleopen.BringToFront();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Maximized.BringToFront();
            emailpic.Hide();
            passwordpic.Hide();
            confrmpasspic.Hide();
            uservalidation.Hide();
            showpassword.BringToFront();
        }

        private void profilepicbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box 
                profilepic.Image = Image.FromFile(open.FileName);
                profilepic.SizeMode = PictureBoxSizeMode.StretchImage;   //strech image during run time
                profilepath = open.FileName;

            }
        }

        //Submit button
        private void submitbtn_Click(object sender, EventArgs e)
        {
            labelemail.Text = "";
            passlabel.Text = "";
            confirmpasslabel.Text = "";
            userlabel.Text = "";
            emailpic.Hide();
            passwordpic.Hide();
            confrmpasspic.Hide();
            uservalidation.Hide();
            User user1 = new User();
            user1.register(textname.Text.ToString(), textemail.Text, profilepath, textuser.Text, textpassword.Text, textconfirmpass.Text, metroDateTime1.Value.Date); //.value use kya kyn k hume date time format he chaye na k string
            
            if (user1.success == true)
            {
                Form f6 = new Form6();
                f6.Show();
                this.Hide();
            }
            else
            {
                if (textuser.Text=="")
                {
                    userlabel.Text = "Please enter username";
                    userlabel.ForeColor = Color.Red;
                    uservalidation.Show();
                }    
                
                if (user1.usermsg != "")
                {
                    userlabel.Text = user1.usermsg;
                    uservalidation.Show();
                }
                if (!(user1.mail.IsMatch(textemail.Text)))
                {
                    emailpic.Show();
                    labelemail.Text = "Invalid Email";
                    labelemail.ForeColor = Color.Red;
                }

                if (textpassword.Text.Length < 8)
                {
                    passwordpic.Show();
                    passlabel.Text = "Password must be 8 letters or more";
                    passlabel.ForeColor = Color.Red;
                }

                if (textpassword.Text != textconfirmpass.Text)
                {
                    confrmpasspic.Show();
                    confirmpasslabel.Text = "Confirm Password is incorrect";
                    confirmpasslabel.ForeColor = Color.Red;
                }
            }
        }


        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            if (this.WindowState==FormWindowState.Maximized)
            {
                f1.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }

        private void showpassword_Click_1(object sender, EventArgs e)
        {
            textpassword.PasswordChar = '\0'; //passing null character to password char
            textconfirmpass.PasswordChar = '\0';
            hidepassword.BringToFront();
        }

        private void hidepassword_Click_1(object sender, EventArgs e)
        {
            textpassword.PasswordChar = '*';
            textconfirmpass.PasswordChar = '*';
            showpassword.BringToFront();
        }
    }
}
