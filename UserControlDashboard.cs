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
    public partial class UserControlDashboard : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        
        public void room_count()
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbRoom",con);

            // Use the SqlCommand.ExecuteScalar() method to execute the query and get the number of rows as an integer.
            int count = (int)cmd.ExecuteScalar();
            lblRoom.Text = count.ToString();
            con.Close();

        }
        public void client_count()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbClient", con);
            int countClient = (int)cmd.ExecuteScalar();
            lblClient.Text = countClient.ToString();
            con.Close();
        }
        public void user_count()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbUser", con);
            int countUser = (int)cmd.ExecuteScalar();
            lblUser.Text = countUser.ToString();
            con.Close();
        }
        public void UserControlDashboard_Load(object sender, EventArgs e)
        {
            room_count();
            client_count();
            user_count();
        }

        private void UserControlDashboard_Enter(object sender, EventArgs e)
        {
            room_count();
            client_count();
            user_count();
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
