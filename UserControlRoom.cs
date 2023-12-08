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
    public partial class UserControlRoom : UserControl
    {
        string No = "", Free = "";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn4 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        public UserControlRoom()
        {
            InitializeComponent();
        }
        private void clear()
        {
            comboBoxType.SelectedIndex=-1;
            txtPhonerm.Clear();
            rdNoUpdate.Checked = false;
            rdYes.Checked = false;
           tabControl.SelectedTab = tabPageAddRoom;


        }
        private void clear1()
        {
            cbTypeUpdate.SelectedIndex = -1;
            txtPhoneUpdate.Clear();
            rbNoUpdate.Checked = false;
            rbYesUpdate.Checked = false;
            tabControl.SelectedTab =tabPageUpdate;
            No = "";


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbRoom ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearchRoom.DataSource = dt;
            conn.Close();
        }

        private void dataGridViewSearchRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (Free == "Yes") rdYes.Checked = true;
                if (Free == "No") rdNoUpdate.Checked = true;
                DataGridViewRow row = dataGridViewSearchRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType.Text = row.Cells[1].Value.ToString();
                txtPhonerm.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();


                // for update 
                if (Free == "Yes") rbYesUpdate.Checked = true;
                if (Free == "No") rbNoUpdate.Checked = true;
                No = row.Cells[0].Value.ToString();
                cbTypeUpdate.Text = row.Cells[1].Value.ToString();
                txtPhoneUpdate.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (No != "")
            {

                SqlCommand cmd1 = new SqlCommand("Update tbRoom SET Room_Type = @rType , Room_Phone = @rPh ,Room_Free=@rFree WHERE Room_Number=@No", conn2);
                conn2.Open();
                if (rbYesUpdate.Checked) Free = "Yes";
                if (rbNoUpdate.Checked) Free = "No";
                cmd1.Parameters.AddWithValue("@No", No);
                cmd1.Parameters.AddWithValue("@rType", cbTypeUpdate.SelectedItem.ToString());
                cmd1.Parameters.AddWithValue("@rPh", txtPhoneUpdate.Text);
                cmd1.Parameters.AddWithValue("@rFree",Free);
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
            if (No != "")
            {

                DialogResult result = MessageBox.Show("Do you want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    SqlCommand cmd1 = new SqlCommand("Delete tbRoom  WHERE Room_Number=@No", conn2);
                    conn2.Open();
                    if (rbYesUpdate.Checked) Free = "Yes";
                    if (rbNoUpdate.Checked) Free = "No";
                    cmd1.Parameters.AddWithValue("@No", No);
                    cmd1.Parameters.AddWithValue("@rType", cbTypeUpdate.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@rPh", txtPhoneUpdate.Text);
                    cmd1.Parameters.AddWithValue("@rFree", Free);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Delete is  Successfully");
                    clear1();
                    clear();
                    conn2.Close();
                }
                   
               

            }
            else
            {

                MessageBox.Show("Please select ", "Selection of row");
                clear();
                conn2.Close();
            }
        }

        private void txtPhoneSearch_TextChanged(object sender, EventArgs e)
        {  
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbRoom WHERE  Room_Phone LIKE  '%" + txtPhoneSearch.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearchRoom.DataSource = dt;

        }

        private void tabPageSearchRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn1.Open();
            if (rdYes.Checked) Free = "Yes";
            if (rdNoUpdate.Checked) Free = "No";
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbRoom WHERE Room_Type = @rType AND Room_Phone = @rPh AND  Room_Free=@rFree", conn1);
            cmd.Parameters.AddWithValue("@rType", comboBoxType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@rPh", txtPhonerm.Text);
            cmd.Parameters.AddWithValue("@rFree", Free);
            SqlDataReader read = cmd.ExecuteReader();
            if (txtPhonerm.Text.Trim() == string.Empty || Free=="")
                MessageBox.Show("*Some Fields are empty , Pls input again");
            else if (!(read.HasRows))
            {
                conn3.Open();
                cmd = new SqlCommand("INSERT INTO tbRoom Values (@rType,@rPh,@rFree)", conn3);
                cmd.Parameters.AddWithValue("@rType", comboBoxType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@rPh", txtPhonerm.Text);
                cmd.Parameters.AddWithValue("@rFree", Free);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Room is creating Successfully");
                clear();
                conn3.Close();
                conn1.Close();
            }
           
            else
            {
                MessageBox.Show("Room is already exist");
                clear();
                conn1.Close();
            }
        }
    }
}
