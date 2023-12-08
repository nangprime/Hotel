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
    public partial class UserControlClient : UserControl
    {
        private string ID;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn4 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        public UserControlClient()
        {
            InitializeComponent();
        }
       private  void clear()
        {
            txtfn.Clear();
            txtln.Clear();
            txtph.Clear();
            txtAddress.Clear();
        }
        private void clear1()
        {
            txtUpdatefn.Clear();
            txtUpdateln.Clear();
            txtUpdatephone.Clear();
            txtUpdateadd.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbClient WHERE FirstName = @fn AND LastName = @ln AND Phone =@ph AND ClientAddress=@add", conn);
            cmd.Parameters.AddWithValue("@fn", txtfn.Text);
            cmd.Parameters.AddWithValue("@ln", txtln.Text);
            cmd.Parameters.AddWithValue("@ph", txtph.Text);
            cmd.Parameters.AddWithValue("@add", txtadd.Text);
            SqlDataReader read = cmd.ExecuteReader();
            if (txtfn.Text.Trim() == string.Empty || txtln.Text.Trim() == string.Empty|| txtph.Text.Trim() == string.Empty || txtadd.Text.Trim() == string.Empty)
                MessageBox.Show("*Some Fields are empty , Pls input again");
            else if (!(read.HasRows))
            {
                conn3.Open();
                cmd = new SqlCommand("INSERT INTO tbClient Values (@fn,@ln,@ph,@add)", conn3);
                cmd.Parameters.AddWithValue("@fn", txtfn.Text);
                cmd.Parameters.AddWithValue("@ln", txtln.Text);
                cmd.Parameters.AddWithValue("@ph", txtph.Text);
                cmd.Parameters.AddWithValue("@add", txtadd.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Client is creating Successfully");
                clear();
                conn.Close();
                conn3.Close();

            }

            else
            {

                MessageBox.Show("Client is already exist");
                clear();
                conn.Close();

            }
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbClient ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearch.DataSource = dt;
            conn.Close();
        }

        private void dataGridViewSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSearch.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtfn.Text = row.Cells[1].Value.ToString();
                txtln.Text = row.Cells[2].Value.ToString();
                txtph.Text = row.Cells[3].Value.ToString();
                txtAddress.Text = row.Cells[4].Value.ToString();

                // for update 
                txtUpdatefn.Text = row.Cells[1].Value.ToString();
                txtUpdateln.Text = row.Cells[2].Value.ToString();
                txtUpdatephone.Text = row.Cells[3].Value.ToString();
                txtUpdateadd.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {

                SqlCommand cmd1 = new SqlCommand("Update tbClient SET FirstName = @fn,LastName = @ln , Phone =@ph , ClientAddress=@add WHERE ClientID=@ID", conn2);
                conn2.Open();
                cmd1.Parameters.AddWithValue("@ID", ID);
                cmd1.Parameters.AddWithValue("@fn", txtUpdatefn.Text);
                cmd1.Parameters.AddWithValue("@ln", txtUpdateln.Text);
                cmd1.Parameters.AddWithValue("@ph", txtUpdatephone.Text);
                cmd1.Parameters.AddWithValue("@add", txtUpdateadd.Text);
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
                    SqlCommand cmd1 = new SqlCommand("Delete From tbClient WHERE ClientID=@ID", conn3);
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

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
           // SqlCommand cmd = new SqlCommand("SELECT * FROM tbRoom , conn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbClient WHERE  Phone LIKE  '%" + txtSearchPhone.Text + "%'" , conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearch.DataSource = dt;
        }

        private void tabPageSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
