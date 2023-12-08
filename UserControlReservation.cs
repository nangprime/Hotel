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
    public partial class UserControlReservation : UserControl
    {
        public string ID;
        public UserControlReservation()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        SqlConnection conn4 = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        public void clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            txtID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControl1.SelectedTab = tabPagereserv;
        }
        public void clear1()
        {
            comboBoxNoUpdate.SelectedIndex = 0;
            comboBoxTypeUpdate.SelectedIndex = 0;
            textClientIDUpdate.Clear();
            dateTimePickerInUpdate.Value = DateTime.Now;
            dateTimePickerOutUpdate.Value = DateTime.Now;
            tabControl1.SelectedTab =tabPageUpdatereserv;
        }
        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbReservation WHERE Reservation_Room_Type = @rType AND Reservation_Room_Number= @rNum AND  Reservation_ClientID=@client AND  Reservation_in=@rin " +
                "AND  Reservation_out=@rout", conn);
            cmd.Parameters.AddWithValue("@rType", comboBoxType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@rNum", comboBoxNo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@client ", txtID.Text);
            cmd.Parameters.AddWithValue("@rin", dateTimePickerIn.Text);
            cmd.Parameters.AddWithValue("@rout", dateTimePickerOut.Text);

            SqlDataReader read = cmd.ExecuteReader();
            if (comboBoxType.SelectedIndex == 0 || txtID.Text.Trim() == string.Empty || comboBoxNo.SelectedIndex == 0)
            {
                MessageBox.Show("*Some Fields are empty , Pls input again");
                conn.Close();
            }
            else if (!(read.HasRows))
            {
                conn1.Open();
                cmd = new SqlCommand("INSERT INTO tbReservation Values (@rType,@rNum,@client,@rin,@rout)", conn1);
                cmd.Parameters.AddWithValue("@rType", comboBoxType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@rNum", comboBoxNo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@client ", txtID.Text);
                cmd.Parameters.AddWithValue("@rin", dateTimePickerIn.Text);
                cmd.Parameters.AddWithValue("@rout", dateTimePickerOut.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Room is creating Successfully");
                clear();
                conn1.Close();
                conn.Close();
            }

            else
            {
                MessageBox.Show("Room is already exist");
                clear();
                conn1.Close();
                conn.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {

                SqlCommand cmd1 = new SqlCommand("Update tbReservation SET Reservation_Room_Type = @rType , Reservation_Room_Number= @rNum ,  Reservation_ClientID=@client ,  Reservation_in=@rin,Reservation_out=@rout WHERE Reservation_ID=@ID", conn2);
                conn2.Open();
                cmd1.Parameters.AddWithValue("@ID", ID);
                cmd1.Parameters.AddWithValue("@rType", comboBoxTypeUpdate.SelectedItem.ToString());
                cmd1.Parameters.AddWithValue("@rNum", comboBoxNoUpdate.SelectedItem.ToString());
                cmd1.Parameters.AddWithValue("@client ", textClientIDUpdate.Text);
                cmd1.Parameters.AddWithValue("@rin", dateTimePickerInUpdate.Text);
                cmd1.Parameters.AddWithValue("@rout", dateTimePickerOutUpdate.Text);
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbReservation  WHERE Reservation_ClientID  LIKE  '%" + txtSearch + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearchRoom.DataSource = dt;
        }

        private void dataGridViewSearchRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSearchRoom.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                comboBoxType.Text = row.Cells[1].Value.ToString();
                comboBoxNo.Text = row.Cells[2].Value.ToString();
                txtID.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut.Text = row.Cells[5].Value.ToString();
               //for update
                ID = row.Cells[0].Value.ToString();
                comboBoxTypeUpdate.Text = row.Cells[1].Value.ToString();
                comboBoxNoUpdate.Text = row.Cells[2].Value.ToString();
                textClientIDUpdate.Text = row.Cells[3].Value.ToString();
               dateTimePickerInUpdate.Text = row.Cells[4].Value.ToString();
                dateTimePickerOutUpdate.Text = row.Cells[5].Value.ToString();

            }
        }

        private void tabPageSearchreserv_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbReservation ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSearchRoom.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                DialogResult result = MessageBox.Show("Do you want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    SqlCommand cmd1 = new SqlCommand("Delete From tbReservation WHERE Reservation_ID=@ID", conn3);
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
    }
}
