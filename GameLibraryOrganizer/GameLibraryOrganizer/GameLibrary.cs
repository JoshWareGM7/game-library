using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GameLibraryOrganizer
{
    public partial class GameLibrary : Form
    {
        private string state = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\games.mdf;Integrated Security=True;Connect Timeout=30");
        public GameLibrary()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            TitleBox.Text = "";
            YearBox.Text = "";
            ESRBBox.Text = "";
            DevBox.Text = "";
            GenreBox.Text = "";
            DescBox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gamestable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void GameLibrary_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            if (radioButton1.Checked)
            {
                state = "Yet to play";
            }
            if (radioButton2.Checked)
            {
                state = "In progress";
            }
            if (radioButton3.Checked)
            {
                state = "Completed";
            }
            if (radioButton4.Checked)
            {
                state = "Completed 100%";
            }
            if (radioButton5.Checked)
            {
                state = "Want to get";
            }
            cmd.CommandText = "insert into gamestable(Title,Year,ESRB,Developer,Genre,Description,State) values(@Title,@Year,@ESRB,@Developer,@Genre,@Description,@State)";
            cmd.Parameters.AddWithValue("@Title", TitleBox.Text);
            cmd.Parameters.AddWithValue("@Year", YearBox.Text);
            cmd.Parameters.AddWithValue("@ESRB", ESRBBox.Text);
            cmd.Parameters.AddWithValue("@Developer", DevBox.Text);
            cmd.Parameters.AddWithValue("@Genre", GenreBox.Text);
            cmd.Parameters.AddWithValue("@Description", DescBox.Text);
            cmd.Parameters.AddWithValue("@State", state);
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            ClearFields();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from gamestable where Title='" + TitleBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            ClearFields();
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (radioButton1.Checked)
            {
                state = "Yet to play";
            }
            if (radioButton2.Checked)
            {
                state = "In progress";
            }
            if (radioButton3.Checked)
            {
                state = "Completed";
            }
            if (radioButton4.Checked)
            {
                state = "Completed 100%";
            }
            if (radioButton5.Checked)
            {
                state = "Want to get";
            }

            cmd.CommandText = "update gamestable set State = @State where Title='" + TitleBox.Text + "'";
            cmd.Parameters.AddWithValue("@State", state);
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            ClearFields();
        }
    }
}
