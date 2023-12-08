using System.Windows.Forms;

namespace Hotel_Management_System
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnDashborad = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkLogout = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userControlDashboard1 = new Hotel_Management_System.UserControlDashboard();
            this.userControlReservation1 = new Hotel_Management_System.UserControlReservation();
            this.userControlRoom1 = new Hotel_Management_System.UserControlRoom();
            this.userControlClient1 = new Hotel_Management_System.UserControlClient();
            this.userControlSetting2 = new Hotel_Management_System.UserControlSetting();
            this.userControlSetting1 = new Hotel_Management_System.UserControlSetting();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.userControlSetting1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 774);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.MovingPanel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRoom);
            this.panel2.Controls.Add(this.btnReservation);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnDashborad);
            this.panel2.Controls.Add(this.btnClient);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 774);
            this.panel2.TabIndex = 0;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MovingPanel.Location = new System.Drawing.Point(12, 304);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(10, 42);
            this.MovingPanel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hotel Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(53, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "System";
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoom.Image = global::Hotel_Management_System.Properties.Resources.add_room;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(24, 403);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(163, 45);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservation.Image = global::Hotel_Management_System.Properties.Resources.Employee;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(24, 509);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(163, 45);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetting.Location = new System.Drawing.Point(24, 623);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(163, 45);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnDashborad
            // 
            this.btnDashborad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDashborad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashborad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnDashborad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDashborad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashborad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashborad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashborad.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDashborad.Location = new System.Drawing.Point(24, 207);
            this.btnDashborad.Name = "btnDashborad";
            this.btnDashborad.Size = new System.Drawing.Size(163, 45);
            this.btnDashborad.TabIndex = 0;
            this.btnDashborad.Text = "Dashborad";
            this.btnDashborad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashborad.UseVisualStyleBackColor = false;
            this.btnDashborad.TextChanged += new System.EventHandler(this.btnDashborad_TextChanged);
            this.btnDashborad.Click += new System.EventHandler(this.btnDashborad_Click);
            this.btnDashborad.Enter += new System.EventHandler(this.btnDashborad_Enter);
            this.btnDashborad.MouseEnter += new System.EventHandler(this.btnDashborad_MouseEnter);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClient.Image = global::Hotel_Management_System.Properties.Resources.customer_Details;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(24, 301);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(163, 45);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management_System.Properties.Resources.home2;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogout.ForeColor = System.Drawing.Color.Red;
            this.lnkLogout.Location = new System.Drawing.Point(1137, 53);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(76, 20);
            this.lnkLogout.TabIndex = 5;
            this.lnkLogout.Text = "Log Out";
            this.lnkLogout.Click += new System.EventHandler(this.lnkLogout_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(227, 97);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 16);
            this.lblTimer.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTime.Location = new System.Drawing.Point(233, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(23, 25);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(58, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "System";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblName.Location = new System.Drawing.Point(182, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 25);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(199, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 116);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_Management_System.Properties.Resources.customer_registration;
            this.pictureBox2.Location = new System.Drawing.Point(1034, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.Location = new System.Drawing.Point(206, 227);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(914, 541);
            this.userControlDashboard1.TabIndex = 12;
            this.userControlDashboard1.Load += new System.EventHandler(this.userControlDashboard1_Load);
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.Location = new System.Drawing.Point(220, 231);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(914, 538);
            this.userControlReservation1.TabIndex = 11;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.Location = new System.Drawing.Point(220, 231);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1018, 543);
            this.userControlRoom1.TabIndex = 2;
            this.userControlRoom1.Visible = false;
            // 
            // userControlClient1
            // 
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlClient1.Location = new System.Drawing.Point(200, 194);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1038, 580);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            this.userControlClient1.Load += new System.EventHandler(this.userControlClient1_Load);
            // 
            // userControlSetting2
            // 
            this.userControlSetting2.Location = new System.Drawing.Point(200, 231);
            this.userControlSetting2.Name = "userControlSetting2";
            this.userControlSetting2.Size = new System.Drawing.Size(1038, 543);
            this.userControlSetting2.TabIndex = 0;
            this.userControlSetting2.Visible = false;
            this.userControlSetting2.Load += new System.EventHandler(this.userControlSetting2_Load);
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.Location = new System.Drawing.Point(230, -464);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(708, 365);
            this.userControlSetting1.TabIndex = 11;
            this.userControlSetting1.Visible = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 874);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.userControlReservation1);
            this.Controls.Add(this.userControlRoom1);
            this.Controls.Add(this.userControlClient1);
            this.Controls.Add(this.userControlSetting2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnDashborad;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lnkLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
       

        public Label Username { get; private set; }

        private System.Windows.Forms.Label lblTimer;
        private Label lblTime;
        private Timer timer1;
        private UserControlSetting userControlSetting1;
        private UserControlSetting userControlSetting2;
        private Label label3;
        private Label label1;
        private Label lblName;
        private Panel panel3;
        private Label label4;
        private UserControlClient userControlClient1;
        private UserControlRoom userControlRoom1;
        private Panel MovingPanel;
        private UserControlReservation userControlReservation1;
        private UserControlDashboard userControlDashboard1;
    }
}