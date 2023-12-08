using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hotel_Management_System
{
    public partial class UserControlSetting : UserControl
    {
        public string ID;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn4 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        private void clear()
        {
            txtUsername.Clear();

            txtPassword.Clear();
            tabControl1.SelectedTab = tabPageAddUser;
        }
        private void clear1()
        {
            txtUpdateName.Clear();
            txtUpdatePassword.Clear();
            ID = "";
        }
        public UserControlSetting()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserName, UserPassword FROM tbUser WHERE UserName = @Username AND UserPassword = @Password", conn);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataReader read = cmd.ExecuteReader();
            if (!(read.HasRows))
            {
                conn3.Open();
                cmd = new SqlCommand("INSERT INTO tbUser Values (@username,@password)", conn3);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Username is creating Successfully");
                clear();
                conn.Close();

            }

            else
            {

                MessageBox.Show("Username is already exist");
                clear();
                conn.Close();

            }
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           dataGridViewSearch.DataSource = dt;
            conn.Close();
        }

        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSearch.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtUsername.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                txtUpdateName.Text = row.Cells[1].Value.ToString();
                txtUpdatePassword.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {

                SqlCommand cmd1 = new SqlCommand("Update tbUser SET UserName=@username,UserPassword=@password WHERE UserID=@ID", conn2);
                conn2.Open();
                cmd1.Parameters.AddWithValue("@ID", ID);
                cmd1.Parameters.AddWithValue("@username", txtUpdateName.Text);
                cmd1.Parameters.AddWithValue("@password", txtUpdatePassword.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Update is  Successfully");
                clear1();
                clear();
                conn2.Close();

            }
            else
            {

                MessageBox.Show("Please select ", "Selection of row");
                clear();
                conn2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                DialogResult result = MessageBox.Show("Do you want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    SqlCommand cmd1 = new SqlCommand("Delete From tbUser WHERE UserID=@ID", conn3);
                    conn3.Open();
                    cmd1.Parameters.AddWithValue("@ID", ID);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    clear();
                    clear1();
                    conn3.Close();
                }


            }
            else
            {

                MessageBox.Show("Please select ", "Selection of row");
                clear1();
                conn3.Close();
            }
        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser WHERE UserName LIKE '%" + txtSearch.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearch.DataSource = dt;
            con.Close();
        }

        private void tabPageSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
