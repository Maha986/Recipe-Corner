using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;             //USE FOR SQL 
using System.Windows.Forms;              //USE FOR FORMS
using System.Text.RegularExpressions;    //USE FOR REGEX (Validation Checking)

namespace Recipe_Corner
{
    class User
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7VO9EU6; Initial Catalog=Registration; Integrated Security=True;");
        SqlCommand cmd;
        public string message;
        public string usermsg="";
        protected string picpath;
        public string Picpath
        {
            get { return picpath; }
            set { picpath = value; }
        }
        protected string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        protected string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public bool success;   // for checking if login is success
        public Regex mail = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
        public Regex Mail
        {
            get; set;
        }

        //lOGIN FUNCTION
        public void login(string username, string password)
        {
            this.username = username;
            success = false;
            cmd = new SqlCommand($"Select * from UserInfo where Username='{username}' and Password='{password}'",con);
            
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                success = true;
            }
            else
            {
                message = "Username or Password is incorrect!!";
            }
            reader.Close();
            con.Close();
        }

        // REGISTER FUNCTION
        public void register(string name, string id, string profilepath, string username, string password, string confrmpass, DateTime dob)
        {

            string format = "yyyy-MM-dd"; // DateTime store date in different format and sql require in different format
            try
            {
                if (mail.IsMatch(id) && password.Length >= 8 && password == confrmpass && !(String.IsNullOrEmpty(username)))
                {
                    con.Open();
                    cmd = new SqlCommand($"insert into UserInfo (Username,Password,[Full Name],Email,ProfilePic,[Date of birth]) values ('{username}','{password}','{name}','{id}','{profilepath}','{dob.ToString(format)}')", con);
                    cmd.ExecuteNonQuery();
                    success = true;
                    con.Close();
                }
            }
            catch(SqlException)
            {
                usermsg = "Username already exist";
            }
        }

        //Profile Function
        public void profile(string user)
        {
            this.username = user;
            cmd = new SqlCommand($"Select * from UserInfo where Username='{user}'");

            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.email = reader[3].ToString();
                this.picpath = reader[5].ToString();
            }
            reader.Close();
            con.Close();
        }
    }
}
