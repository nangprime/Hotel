using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormDashboard : Form
    { 
        public string showName;
        public FormDashboard()
        {
            InitializeComponent();
        }
        

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblTime.Text= DateTime.Now.ToString("dd-MMM-yyyy hh-mm-ss tt");
            lblName.Text = showName;
            MovePanel(btnDashborad);
        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        
        }
        private void MovePanel(Control btn)
        {
            MovingPanel.Top = btn.Top;
            MovingPanel.Height = btn.Height;
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            MovePanel(btnSetting);
            userControlSetting2.Hide();
            userControlSetting2.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }

        private void userControlSetting2_Load(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
            userControlSetting2.Hide();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }
        

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
            userControlSetting2.Hide();
            userControlClient1.Hide();
            userControlRoom1.Show();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }
        UserControlDashboard ucd = new UserControlDashboard();
        private void btnDashborad_Click(object sender, EventArgs e)
        {
            ucd.client_count();
            ucd.user_count();
            ucd.room_count();

            MovePanel(btnDashborad);
            userControlSetting2.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlDashboard1.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            userControlSetting2.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Show();
            userControlDashboard1.Hide();
        }

        private void btnDashborad_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnDashborad_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void userControlClient1_Load(object sender, EventArgs e)
        {

        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDashborad_MouseEnter(object sender, EventArgs e)
        {
           
        }
    }
}
