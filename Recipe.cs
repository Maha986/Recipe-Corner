using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VideoLibrary;
using System.IO;

namespace Recipe_Corner
{
    class Recipe
    {
        public string URL;
        public int count = 0;
        public string date;
        string descript;

        Regex youtubeurl = new Regex(@"(?:.+?)?(?:\/v\/|watch\/|\?v=|\&v=|youtu\.be\/|\/v=|^youtu\.be\/|watch\%3Fv\%3D)([a-zA-Z0-9_-]{11})+");


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7VO9EU6; Initial Catalog=Registration; Integrated Security=True;");
        SqlCommand cmd;


        public void uploadvideo(string url, string path, string name, string title, DateTime date, string imgloc, string user, string descript)
        {

            con.Open();
            try
            {
                if ((String.IsNullOrEmpty(path)) || (String.IsNullOrEmpty(url)))
                {
                    if (!(String.IsNullOrEmpty(path)) && (String.IsNullOrEmpty(url)))
                    {

                        cmd = new SqlCommand("insert into RecipeInfo (RecipeName, [Recipe Link],Thumbnail,Username, Date, Title, Description) values (@Name,@Path,@Img,@Username,@Date,@Title,@Description)", con);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Path", path);
                        cmd.Parameters.AddWithValue("@Img", imgloc);
                        cmd.Parameters.AddWithValue("@Username", user);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", descript);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("You have uploaded successfully.");


                    }
                    else if ((String.IsNullOrEmpty(path)) && !(String.IsNullOrEmpty(url)))
                    {
                        if (youtubeurl.IsMatch(url))
                        {
                            Form f5 = new Form5();
                            f5.Show();
                            var youtube = YouTube.Default;
                            var video = youtube.GetVideo(url);
                            File.WriteAllBytes(@"E:\Pictures\" + video.FullName, video.GetBytes());


                            path = "E:\\Pictures\\" + video.FullName;

                            cmd = new SqlCommand("insert into RecipeInfo (RecipeName, [Recipe Link],Thumbnail,Username, Date, Title, Description) values (@Name,@URL,@Img,@Username,@Date,@Title,@Description)", con);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@URL", path);
                            cmd.Parameters.AddWithValue("@Img", imgloc);
                            cmd.Parameters.AddWithValue("@Username", user);
                            cmd.Parameters.AddWithValue("@Date", date);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Description", descript);
                            cmd.ExecuteNonQuery();

                            f5.Close();
                            MessageBox.Show("You have uploaded successfully.", "Congratulations");

                        }
                        else
                        {
                            MessageBox.Show("Please write YouTube Url", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter either youtube path or your file path", "Error");
                }
            
            }
            catch (SqlException)
            {
                MessageBox.Show("Recipe Name already exists", "Error");
                Form f5 = new Form5();
                f5.Hide();
            }

            con.Close();
        }


        public void viewvideo(string title)
        {
            cmd = new SqlCommand("select [Recipe Link],Date from RecipeInfo where Title=@Recipe", con);
            cmd.Parameters.AddWithValue("@Recipe", title);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                URL = reader[0].ToString();
                DateTime d = (DateTime)reader[1];
                date = d.ToShortDateString();
            }
            reader.Close();
            con.Close();

        }

        public string viewdescription(string title)
        {

            cmd = new SqlCommand("select Description from RecipeInfo where Title=@Recipe", con);
            cmd.Parameters.AddWithValue("@Recipe", title);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                descript = reader[0].ToString();
            }
            reader.Close();
            con.Close();
            return descript;
        }
    }
}
