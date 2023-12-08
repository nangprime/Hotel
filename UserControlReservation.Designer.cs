namespace Hotel_Management_System
{
    partial class UserControlReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagereserv = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboBoxNo = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.tabPageSearchreserv = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchRoom = new System.Windows.Forms.DataGridView();
            this.tabPageUpdatereserv = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerOutUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInUpdate = new System.Windows.Forms.DateTimePicker();
            this.textClientIDUpdate = new System.Windows.Forms.TextBox();
            this.comboBoxNoUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeUpdate = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPagereserv.SuspendLayout();
            this.tabPageSearchreserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRoom)).BeginInit();
            this.tabPageUpdatereserv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPagereserv);
            this.tabControl1.Controls.Add(this.tabPageSearchreserv);
            this.tabControl1.Controls.Add(this.tabPageUpdatereserv);
            this.tabControl1.Location = new System.Drawing.Point(107, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagereserv
            // 
            this.tabPagereserv.Controls.Add(this.btnAdd);
            this.tabPagereserv.Controls.Add(this.label4);
            this.tabPagereserv.Controls.Add(this.label3);
            this.tabPagereserv.Controls.Add(this.label2);
            this.tabPagereserv.Controls.Add(this.label1);
            this.tabPagereserv.Controls.Add(this.txtPhone);
            this.tabPagereserv.Controls.Add(this.dateTimePickerOut);
            this.tabPagereserv.Controls.Add(this.dateTimePickerIn);
            this.tabPagereserv.Controls.Add(this.label10);
            this.tabPagereserv.Controls.Add(this.txtID);
            this.tabPagereserv.Controls.Add(this.comboBoxNo);
            this.tabPagereserv.Controls.Add(this.comboBoxType);
            this.tabPagereserv.Location = new System.Drawing.Point(4, 4);
            this.tabPagereserv.Name = "tabPagereserv";
            this.tabPagereserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagereserv.Size = new System.Drawing.Size(695, 402);
            this.tabPagereserv.TabIndex = 0;
            this.tabPagereserv.Text = "Add Reservation";
            this.tabPagereserv.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(59, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 45);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Out :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "In :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ClientID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Room No";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(55, 37);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(94, 20);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.Text = "Room Type";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(375, 264);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(266, 22);
            this.dateTimePickerOut.TabIndex = 23;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(37, 264);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(266, 22);
            this.dateTimePickerIn.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Add Reservation";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(37, 172);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(266, 32);
            this.txtID.TabIndex = 20;
            // 
            // comboBoxNo
            // 
            this.comboBoxNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo.FormattingEnabled = true;
            this.comboBoxNo.Items.AddRange(new object[] {
            "Please select...",
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.comboBoxNo.Location = new System.Drawing.Point(363, 78);
            this.comboBoxNo.Name = "comboBoxNo";
            this.comboBoxNo.Size = new System.Drawing.Size(266, 24);
            this.comboBoxNo.TabIndex = 19;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family"});
            this.comboBoxType.Location = new System.Drawing.Point(59, 78);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(266, 24);
            this.comboBoxType.TabIndex = 19;
            // 
            // tabPageSearchreserv
            // 
            this.tabPageSearchreserv.Controls.Add(this.label8);
            this.tabPageSearchreserv.Controls.Add(this.label9);
            this.tabPageSearchreserv.Controls.Add(this.txtSearch);
            this.tabPageSearchreserv.Controls.Add(this.dataGridViewSearchRoom);
            this.tabPageSearchreserv.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchreserv.Name = "tabPageSearchreserv";
            this.tabPageSearchreserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchreserv.Size = new System.Drawing.Size(695, 402);
            this.tabPageSearchreserv.TabIndex = 1;
            this.tabPageSearchreserv.Text = "SearchReservation";
            this.tabPageSearchreserv.UseVisualStyleBackColor = true;
            this.tabPageSearchreserv.Enter += new System.EventHandler(this.tabPageSearchreserv_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search Resevation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "ClientID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(135, 117);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 32);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dataGridViewSearchRoom
            // 
            this.dataGridViewSearchRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchRoom.Location = new System.Drawing.Point(36, 172);
            this.dataGridViewSearchRoom.Name = "dataGridViewSearchRoom";
            this.dataGridViewSearchRoom.RowHeadersWidth = 51;
            this.dataGridViewSearchRoom.RowTemplate.Height = 24;
            this.dataGridViewSearchRoom.Size = new System.Drawing.Size(602, 198);
            this.dataGridViewSearchRoom.TabIndex = 20;
            this.dataGridViewSearchRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchRoom_CellClick);
            // 
            // tabPageUpdatereserv
            // 
            this.tabPageUpdatereserv.Controls.Add(this.btnDelete);
            this.tabPageUpdatereserv.Controls.Add(this.btnUpdate);
            this.tabPageUpdatereserv.Controls.Add(this.label13);
            this.tabPageUpdatereserv.Controls.Add(this.label5);
            this.tabPageUpdatereserv.Controls.Add(this.label6);
            this.tabPageUpdatereserv.Controls.Add(this.label7);
            this.tabPageUpdatereserv.Controls.Add(this.label11);
            this.tabPageUpdatereserv.Controls.Add(this.label12);
            this.tabPageUpdatereserv.Controls.Add(this.dateTimePickerOutUpdate);
            this.tabPageUpdatereserv.Controls.Add(this.dateTimePickerInUpdate);
            this.tabPageUpdatereserv.Controls.Add(this.textClientIDUpdate);
            this.tabPageUpdatereserv.Controls.Add(this.comboBoxNoUpdate);
            this.tabPageUpdatereserv.Controls.Add(this.comboBoxTypeUpdate);
            this.tabPageUpdatereserv.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdatereserv.Name = "tabPageUpdatereserv";
            this.tabPageUpdatereserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdatereserv.Size = new System.Drawing.Size(695, 402);
            this.tabPageUpdatereserv.TabIndex = 2;
            this.tabPageUpdatereserv.Text = "Update and Delete Reservation";
            this.tabPageUpdatereserv.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(181, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 37);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(75, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 37);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Update and Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Out :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "In :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "ClientID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(373, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Room No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Room Type";
            // 
            // dateTimePickerOutUpdate
            // 
            this.dateTimePickerOutUpdate.Location = new System.Drawing.Point(389, 273);
            this.dateTimePickerOutUpdate.Name = "dateTimePickerOutUpdate";
            this.dateTimePickerOutUpdate.Size = new System.Drawing.Size(266, 22);
            this.dateTimePickerOutUpdate.TabIndex = 28;
            // 
            // dateTimePickerInUpdate
            // 
            this.dateTimePickerInUpdate.Location = new System.Drawing.Point(51, 273);
            this.dateTimePickerInUpdate.Name = "dateTimePickerInUpdate";
            this.dateTimePickerInUpdate.Size = new System.Drawing.Size(266, 22);
            this.dateTimePickerInUpdate.TabIndex = 29;
            // 
            // textClientIDUpdate
            // 
            this.textClientIDUpdate.Location = new System.Drawing.Point(51, 181);
            this.textClientIDUpdate.Multiline = true;
            this.textClientIDUpdate.Name = "textClientIDUpdate";
            this.textClientIDUpdate.Size = new System.Drawing.Size(266, 32);
            this.textClientIDUpdate.TabIndex = 27;
            // 
            // comboBoxNoUpdate
            // 
            this.comboBoxNoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNoUpdate.FormattingEnabled = true;
            this.comboBoxNoUpdate.Items.AddRange(new object[] {
            "Please select...",
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.comboBoxNoUpdate.Location = new System.Drawing.Point(377, 87);
            this.comboBoxNoUpdate.Name = "comboBoxNoUpdate";
            this.comboBoxNoUpdate.Size = new System.Drawing.Size(266, 24);
            this.comboBoxNoUpdate.TabIndex = 25;
            // 
            // comboBoxTypeUpdate
            // 
            this.comboBoxTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTypeUpdate.FormattingEnabled = true;
            this.comboBoxTypeUpdate.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family"});
            this.comboBoxTypeUpdate.Location = new System.Drawing.Point(73, 87);
            this.comboBoxTypeUpdate.Name = "comboBoxTypeUpdate";
            this.comboBoxTypeUpdate.Size = new System.Drawing.Size(266, 24);
            this.comboBoxTypeUpdate.TabIndex = 26;
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(914, 580);
            this.tabControl1.ResumeLayout(false);
            this.tabPagereserv.ResumeLayout(false);
            this.tabPagereserv.PerformLayout();
            this.tabPageSearchreserv.ResumeLayout(false);
            this.tabPageSearchreserv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRoom)).EndInit();
            this.tabPageUpdatereserv.ResumeLayout(false);
            this.tabPageUpdatereserv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagereserv;
        private System.Windows.Forms.TabPage tabPageSearchreserv;
        private System.Windows.Forms.TabPage tabPageUpdatereserv;
        private System.Windows.Forms.ComboBox comboBoxNo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearchRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerInUpdate;
        private System.Windows.Forms.TextBox textClientIDUpdate;
        private System.Windows.Forms.ComboBox comboBoxNoUpdate;
        private System.Windows.Forms.ComboBox comboBoxTypeUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
