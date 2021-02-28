using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Text.RegularExpressions;
using System.Xml;

namespace Recipe_Corner
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        User user2 = new User();
        Recipe r1 = new Recipe();
        public static string url;
        public static string description;
        public static string date;
        public static string title;
        string thumbnailpath;
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7VO9EU6; Initial Catalog=Registration; Integrated Security=True;");
        SqlCommand cmd;

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Doubleopen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximized.BringToFront();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Doubleopen.BringToFront();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Maximized.BringToFront();
            aboutpanel.Hide();
            loginicon.ContextMenuStrip = contextMenuStrip1;

            if (this.WindowState == FormWindowState.Maximized)
            {
                listView1.TileSize = new Size(620, 150);
                listView2.TileSize = new Size(620, 150);
            }
            
            
            //SKIP BUTTON PRESSED
            if (Form1.skipButtonWasClicked)
            {
                contextMenuStrip1.Items.Add("Login");
                contextMenuStrip1.Items.Add("About");
            }
            //LOGIN BUTTON PRESSED
            else
            {
                user2.profile(Form1.setname);
                loginicon.Image = Image.FromFile(@user2.Picpath);
                loginicon.SizeMode = PictureBoxSizeMode.StretchImage;
                contextMenuStrip1.Items.Add(user2.Username);
                contextMenuStrip1.Items.Add(user2.Email);
                contextMenuStrip1.Items.Add("Logout");
                contextMenuStrip1.Items.Add("About");
            }
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contexMenu_ItemClicked);

            //HOME PAGE
            homedisplay();
        }

        void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.Text == "Login")
            {
                Form1.skipButtonWasClicked = false;
                Form f1 = new Form1();
                f1.Show();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    f1.WindowState = FormWindowState.Maximized;
                }
                this.Hide();

            }
            if (e.ClickedItem.Text == "Logout")
            {
                Form1.skipButtonWasClicked = true;
                loginicon.Image = Image.FromFile(@"E:\Pictures\myprofile.png");
                loginicon.SizeMode = PictureBoxSizeMode.StretchImage;
                contextMenuStrip1.Items.Clear();
                contextMenuStrip1.Items.Add("Login");
                skippanel.Visible = true;
                upload.Visible = false;
                yourvideos.Visible = false;

            }
            if (e.ClickedItem.Text=="About")
            {
                Maximized.Visible = false;
                Doubleopen.Visible = false;
                aboutpanel.Show();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listviewselecteditem(listView1);
        }

        private void opentxtbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;
                string filetext = File.ReadAllText(filename);
                descriptionbox.Text = filetext;
            }
        }

        private void browsevideobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openvideo = new OpenFileDialog();
            if (openvideo.ShowDialog() == DialogResult.OK)
            {
                recipepathtext.Text = openvideo.FileName;
            }
        }

        private void uploadvideo_Click(object sender, EventArgs e)
        {
            r1.uploadvideo(urltext.Text, recipepathtext.Text, recipenametext.Text, recipetitle.Text, DateTime.Now, thumbnailpath, Form1.setname, descriptionbox.Text);
            con.Open();
            var text = ingredientbox.Text;
            char[] separator = { '\n' };
            string[] words = null;
            words = text.Split(separator);
            foreach (string i in words)
            {
                if (!(string.IsNullOrEmpty(i)))
                {
                    cmd = new SqlCommand("insert into Ingredients(Ingredient,RecipeName) values (@ingre,@rname) ", con);

                    cmd.Parameters.AddWithValue("@ingre", i);
                    cmd.Parameters.AddWithValue("@rname", recipenametext.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            List<int> amount = new List<int>();
            foreach (string i in words)
            {
                if (i != "\n")
                {
                    cmd = new SqlCommand("select Price from Budget where IngredientName=@name", con);
                    cmd.Parameters.AddWithValue("@name", i);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        amount.Add((int)reader[0]);

                    }
                    reader.Close();
                }
            }

            int sum = amount.Sum();

            cmd = new SqlCommand("update RecipeInfo set RecipePrice=@price where RecipeName=@name ", con);
            cmd.Parameters.AddWithValue("@price", sum);
            cmd.Parameters.AddWithValue("name", recipenametext.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void thumbnailbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                thumbnailpic.Image = Image.FromFile(open.FileName);
                thumbnailpic.SizeMode = PictureBoxSizeMode.StretchImage;   //strech image during run time
                thumbnailpath = open.FileName;
            }
        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {
            if (Form1.skipButtonWasClicked)
            {
                skippanel.Visible = true;
                upload.Visible = false;
                yourvideos.Visible = false;
            }
            else
            {
                skippanel.Visible = false;
                upload.Visible = true;
                yourvideos.Visible = false;
            }
        }

        private void yourvideosbutton_Click(object sender, EventArgs e)
        {
            if (Form1.skipButtonWasClicked)
            {
                skippanel.Visible = true;
                upload.Visible = false;
                yourvideos.Visible = false;
            }
            else
            {
                skippanel.Visible = false;
                yourvideos.Visible = true;
                upload.Visible = false;

                List<string> paths = new List<string>();
                List<string> titleofrecipe = new List<string>();

                paths.Clear();
                titleofrecipe.Clear();
                imageList1.Images.Clear();
                listView1.Clear();

                int c1 = -1;

                cmd = new SqlCommand("select Title,Thumbnail from RecipeInfo where Username=@username", con);
                cmd.Parameters.AddWithValue("@username", Form1.setname);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    listView1.Visible = true;
                    messagelabel.Visible = false;
                    while (reader.Read())
                    {
                        titleofrecipe.Add(reader[0].ToString());
                        paths.Add($@"{reader[1].ToString()}");
                    }
                }

                else
                {
                    listView1.Visible = false;
                }

                reader.Close();
                con.Close();

                foreach (string imgpath in paths)
                {
                    ListViewItem imagetest = listView1.FindItemWithText(@imgpath);
                    if (imagetest == null)
                    {
                        imageList1.Images.Add(Image.FromFile(@imgpath));
                    }
                }

                listView1.LargeImageList = imageList1;

                foreach (string title in titleofrecipe)
                {
                    ListViewItem item = listView1.FindItemWithText(title);
                    if (item == null)
                    {
                        c1++;
                        listView1.Items.Add(title, c1);
                    }
                }
            }
        }

        public void homedisplay()
        {
            int c3 = -1;

            List<string> hometitles = new List<string>();
            List<string> homepaths = new List<string>();

            hometitles.Clear();
            homepaths.Clear();
            imageList2.Images.Clear();
            listView2.Clear();

            con.Open();
            cmd = new SqlCommand("select  Title, Thumbnail from RecipeInfo", con);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.HasRows)
            {

                while (read.Read())
                {

                    hometitles.Add(read[0].ToString());
                    homepaths.Add($@"{read[1].ToString()}");


                }

                read.Close();

                foreach (string ipath in homepaths)
                {
                    ListViewItem img = listView2.FindItemWithText(ipath);
                    if (img == null)
                    {

                        imageList2.Images.Add(Image.FromFile(ipath));
                    }
                }
                listView2.LargeImageList = imageList2;
                foreach (string hometitle in hometitles)
                {
                    ListViewItem list = listView2.FindItemWithText(hometitle);
                    if (list == null)
                    {
                        c3++;

                        listView2.Items.Add(hometitle, c3);

                    }
                }
            }
            con.Close();


        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                homedisplay();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                skippanel.Visible = false;
                yourvideos.Visible = false;
                upload.Visible = false;
            }
        }


       //search button
        private void searchbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void listviewselecteditem(ListView list)
        {
            ListView.SelectedListViewItemCollection selectedList = list.SelectedItems;

            foreach (ListViewItem viewItem in selectedList)
            {
                title = viewItem.Text;
                r1.viewvideo(title);
                url = r1.URL;
                date = r1.date;
                description = r1.viewdescription(title);
            }

            
            Form f4 = new Form4();
            f4.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                f4.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listviewselecteditem(listView2);
        }

        private void hidepanel_Click_1(object sender, EventArgs e)
        {
            aboutpanel.Hide();
            Maximized.Visible = true;
            Doubleopen.Visible = true;
        }

        private void ingredientcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientbox.Text += ingredientcombo.SelectedItem+Environment.NewLine;
        }

        private void ingredientsearch_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count > 0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
            searchbyingredient.Visible = true;
            ingredient.Visible = true;
            down.Visible = true;

            con.Open();
            cmd = new SqlCommand("update RecipeInfo set RecipeCount=1", con);

                cmd.ExecuteNonQuery();

            con.Close();
        }

        List<string> searchingredient = new List<string>();
        List<string> recipes = new List<string>();
        List<string> recipepath = new List<string>();

        private void searchbyingredient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Home);
            searchbyingredient.Visible = false;
            ingredient.Visible = false;
            checkedListBox1.Visible = false;
            down.Visible = false;
            up.Visible = false;



            listView2.Items.Clear();
            imageList3.Images.Clear();

            int c4 = -1;

            searchingredient.Clear();
            recipes.Clear();
            recipepath.Clear();
            


            string[] wordlist = ingredient.Text.Split(' ');  
            foreach(string item in wordlist)
            {
                cmd = new SqlCommand("select RecipeName from Ingredients where Ingredient=@ing", con);
                cmd.Parameters.AddWithValue("@ing", item);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (searchingredient.Contains(reader[0].ToString()))
                        {
                            cmd = new SqlCommand("update RecipeInfo set RecipeCount=RecipeCount+1 where RecipeName=@nameofrecipe", con);
                            cmd.Parameters.AddWithValue("@nameofrecipe", reader[0].ToString());
                           
                        }
                        else
                        {
                            searchingredient.Add(reader[0].ToString());
                        }
                    }
                    reader.Close();
                    cmd.ExecuteNonQuery();
                }
           
                con.Close();
            }
            if (searchingredient.Count == 0)
            {
                listView2.Items.Add("No relevant search found");
            }
            foreach (string item in searchingredient)
            {
                
                imageList3.Images.Clear();
                cmd = new SqlCommand("select Title,Thumbnail from RecipeInfo where RecipeName=@recipe", con);
               
                
                cmd.Parameters.AddWithValue("@recipe", item);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        recipes.Add(reader1[0].ToString());
                        recipepath.Add($@"{reader1[1].ToString()}");
                    }
                }

                foreach (string img in recipepath)
                {
                    ListViewItem list = listView2.FindItemWithText(img);
                    if (list == null)
                    {
                        imageList3.Images.Add(Image.FromFile(@img));
                    }
                }
                listView2.LargeImageList = imageList3;
                foreach (string title in recipes)
                {
                    ListViewItem list = listView2.FindItemWithText(title);
                    if (list == null)
                    {
                        c4++;
                        listView2.Items.Add(title, c4);
                    }
                }
                reader1.Close();
                con.Close();     
            }

            
        }



        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Home);
            int c2 = -1;

            List<string> searchrecipe = new List<string>();
            List<string> searchpath = new List<string>();
            List<string> searchtitle = new List<string>();

            listView2.Clear();
            searchrecipe.Clear();
            searchtitle.Clear();
            searchpath.Clear();
            imageList3.Images.Clear();
            var text = textBox1.Text; 
            char[] separator = { ' ' };
            string[] words = null;
            words = text.Split(separator);
            foreach (string word in words)
            {

                cmd = new SqlCommand("select Title, Thumbnail,RecipeName from RecipeInfo where RecipeName like @WORD ", con);
                cmd.Parameters.AddWithValue("@WORD", string.Format("%{0}%", word));
                con.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.HasRows)
                {

                    while (read.Read())
                    {
                        searchtitle.Add(read[0].ToString());
                        searchpath.Add($@"{read[1].ToString()}");
                        searchrecipe.Add(read[2].ToString());

                    }
                }
                read.Close();
                con.Close();
            }

            foreach (string ipath in searchpath)
            {
                ListViewItem img = listView2.FindItemWithText(ipath);
                if (img == null)
                {

                    imageList3.Images.Add(Image.FromFile(ipath));
                }
            }
            listView2.LargeImageList = imageList3;
            foreach (string hometitle in searchtitle)
            {
                ListViewItem list = listView2.FindItemWithText(hometitle);
                if (list == null)
                {
                    c2++;

                    listView2.Items.Add(hometitle, c2);

                }
            }


            if (searchtitle.Count == 0)
            {
                listView2.Items.Add("No relevant search found");
            }


            textBox1.Visible = false;
            searchbutton.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //autocompletion
            cmd = new SqlCommand("Select Title from RecipeInfo", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                autoComplete.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();

            textBox1.AutoCompleteCustomSource = autoComplete;
        }

        private void budgetsearch_Click(object sender, EventArgs e)
        {
            budget.Visible = true;
            searchbybudget.Visible = true;
        }

        private void recipesearch_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            searchbutton.Visible = true;
        }

        private void searchbybudget_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Home);
            string output = Regex.Replace(budget.SelectedItem.ToString(), "[^0-9]+", string.Empty);
            int no = Convert.ToInt32(output);
            int c2 = -1;

            
            List<string> budgetpath = new List<string>();
            List<string> budgettitle = new List<string>();

            listView2.Clear();
            
            budgettitle.Clear();
            budgetpath.Clear();
            imageList3.Images.Clear();

            cmd = new SqlCommand("select Title, Thumbnail, RecipePrice from RecipeInfo where RecipePrice between 1 and @recipeprice", con);
            cmd.Parameters.AddWithValue("recipeprice", no);

          
                con.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.HasRows)
                {

                    while (read.Read())
                    {
                        budgettitle.Add(read[0].ToString());
                        budgetpath.Add($@"{read[1].ToString()}");

                    }
                }
                read.Close();
                con.Close();
            

            foreach (string ipath in budgetpath)
            {
                ListViewItem img = listView2.FindItemWithText(ipath);
                if (img == null)
                {

                    imageList3.Images.Add(Image.FromFile(ipath));
                }
            }
            listView2.LargeImageList = imageList3;
            foreach (string title in budgettitle)
            {
                ListViewItem list = listView2.FindItemWithText(title);
                if (list == null)
                {
                    c2++;

                    listView2.Items.Add(title, c2);

                }
            }


            if (budgettitle.Count == 0)
            {
                listView2.Items.Add("No relevant search found");
            }


           


            budget.Visible = false;
            searchbybudget.Visible = false;
        }

       
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredient.Text = "";
            foreach(string item in checkedListBox1.CheckedItems)
            {
                
                ingredient.Text += item + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void down_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;
            down.Visible = false;
            up.Visible = true;
        }

        private void up_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
            up.Visible = false;
            down.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
