using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            pictureBoxOpen.Hide();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Hide(); pictureBoxOpen.Show();
            txtPassword.UseSystemPasswordChar = true;
           
        }

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            pictureBoxOpen.Hide();
            txtPassword.UseSystemPasswordChar =false ;
            pictureBoxClose.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5RL8C2F;Initial Catalog=\"Hotel-management -system\";Integrated Security=True");
            con.Open();
              SqlCommand cmd = new SqlCommand("SELECT UserName,UserPassword FROM tbUser WHERE UserName = @Username AND UserPassword = @Password", con);
              cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
              cmd.Parameters.AddWithValue("@password", txtPassword.Text);
              SqlDataReader reader = cmd.ExecuteReader();

            // Check if the user exists.
            if (reader.HasRows)
            {
                // The user exists, so the password must be correct.
                // clear data in textbox
                FormDashboard fd = new FormDashboard();
                fd.showName = txtUsername.Text;
                clear();
                fd.Show();

            }
            else
            {
                // The user does not exist, so the password is incorrect.
                MessageBox.Show("Username or password are Incorrect");

            }

           // con.Close();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
