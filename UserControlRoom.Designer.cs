namespace Hotel_Management_System
{
    partial class UserControlRoom
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdNoUpdate = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhonerm = new System.Windows.Forms.TextBox();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchRoom = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTypeUpdate = new System.Windows.Forms.ComboBox();
            this.rbNoUpdate = new System.Windows.Forms.RadioButton();
            this.rbYesUpdate = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneUpdate = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRoom)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPageAddRoom);
            this.tabControl.Controls.Add(this.tabPageSearchRoom);
            this.tabControl.Controls.Add(this.tabPageUpdate);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(135, 113);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(668, 365);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.label10);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.btnAdd);
            this.tabPageAddRoom.Controls.Add(this.rdNoUpdate);
            this.tabPageAddRoom.Controls.Add(this.rdYes);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Controls.Add(this.txtPhonerm);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(660, 332);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add Room";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Add Room";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.comboBoxType.Location = new System.Drawing.Point(25, 80);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(266, 28);
            this.comboBoxType.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(41, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdNoUpdate
            // 
            this.rdNoUpdate.AutoSize = true;
            this.rdNoUpdate.Location = new System.Drawing.Point(108, 162);
            this.rdNoUpdate.Name = "rdNoUpdate";
            this.rdNoUpdate.Size = new System.Drawing.Size(51, 24);
            this.rdNoUpdate.TabIndex = 16;
            this.rdNoUpdate.TabStop = true;
            this.rdNoUpdate.Text = "No";
            this.rdNoUpdate.UseVisualStyleBackColor = true;
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.Location = new System.Drawing.Point(108, 132);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(58, 24);
            this.rdYes.TabIndex = 16;
            this.rdYes.TabStop = true;
            this.rdYes.Text = "Yes";
            this.rdYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Free";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type";
            // 
            // txtPhonerm
            // 
            this.txtPhonerm.Location = new System.Drawing.Point(328, 76);
            this.txtPhonerm.Multiline = true;
            this.txtPhonerm.Name = "txtPhonerm";
            this.txtPhonerm.Size = new System.Drawing.Size(266, 32);
            this.txtPhonerm.TabIndex = 13;
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.label8);
            this.tabPageSearchRoom.Controls.Add(this.label9);
            this.tabPageSearchRoom.Controls.Add(this.txtPhoneSearch);
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewSearchRoom);
            this.tabPageSearchRoom.Controls.Add(this.label7);
            this.tabPageSearchRoom.Controls.Add(this.txtSearch);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(660, 332);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search Room";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Click += new System.EventHandler(this.tabPageSearchRoom_Click);
            this.tabPageSearchRoom.Enter += new System.EventHandler(this.tabPageSearchRoom_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone";
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(126, 64);
            this.txtPhoneSearch.Multiline = true;
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(266, 32);
            this.txtPhoneSearch.TabIndex = 18;
            this.txtPhoneSearch.TextChanged += new System.EventHandler(this.txtPhoneSearch_TextChanged);
            // 
            // dataGridViewSearchRoom
            // 
            this.dataGridViewSearchRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchRoom.Location = new System.Drawing.Point(27, 119);
            this.dataGridViewSearchRoom.Name = "dataGridViewSearchRoom";
            this.dataGridViewSearchRoom.RowHeadersWidth = 51;
            this.dataGridViewSearchRoom.RowTemplate.Height = 24;
            this.dataGridViewSearchRoom.Size = new System.Drawing.Size(602, 198);
            this.dataGridViewSearchRoom.TabIndex = 17;
            this.dataGridViewSearchRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchRoom_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, -73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, -15);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 12);
            this.txtSearch.TabIndex = 15;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.label11);
            this.tabPageUpdate.Controls.Add(this.button2);
            this.tabPageUpdate.Controls.Add(this.button1);
            this.tabPageUpdate.Controls.Add(this.cbTypeUpdate);
            this.tabPageUpdate.Controls.Add(this.rbNoUpdate);
            this.tabPageUpdate.Controls.Add(this.rbYesUpdate);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.txtPhoneUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(660, 332);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update and Delete Room";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Update and Delete Room";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(178, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(72, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTypeUpdate
            // 
            this.cbTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypeUpdate.FormattingEnabled = true;
            this.cbTypeUpdate.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cbTypeUpdate.Location = new System.Drawing.Point(37, 92);
            this.cbTypeUpdate.Name = "cbTypeUpdate";
            this.cbTypeUpdate.Size = new System.Drawing.Size(266, 28);
            this.cbTypeUpdate.TabIndex = 25;
            // 
            // rbNoUpdate
            // 
            this.rbNoUpdate.AutoSize = true;
            this.rbNoUpdate.Location = new System.Drawing.Point(120, 174);
            this.rbNoUpdate.Name = "rbNoUpdate";
            this.rbNoUpdate.Size = new System.Drawing.Size(51, 24);
            this.rbNoUpdate.TabIndex = 23;
            this.rbNoUpdate.TabStop = true;
            this.rbNoUpdate.Text = "No";
            this.rbNoUpdate.UseVisualStyleBackColor = true;
            // 
            // rbYesUpdate
            // 
            this.rbYesUpdate.AutoSize = true;
            this.rbYesUpdate.Location = new System.Drawing.Point(120, 144);
            this.rbYesUpdate.Name = "rbYesUpdate";
            this.rbYesUpdate.Size = new System.Drawing.Size(58, 24);
            this.rbYesUpdate.TabIndex = 24;
            this.rbYesUpdate.TabStop = true;
            this.rbYesUpdate.Text = "Yes";
            this.rbYesUpdate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Free";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Type";
            // 
            // txtPhoneUpdate
            // 
            this.txtPhoneUpdate.Location = new System.Drawing.Point(340, 88);
            this.txtPhoneUpdate.Multiline = true;
            this.txtPhoneUpdate.Name = "txtPhoneUpdate";
            this.txtPhoneUpdate.Size = new System.Drawing.Size(266, 32);
            this.txtPhoneUpdate.TabIndex = 19;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(914, 580);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRoom)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhonerm;
        private System.Windows.Forms.RadioButton rdNoUpdate;
        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTypeUpdate;
        private System.Windows.Forms.RadioButton rbNoUpdate;
        private System.Windows.Forms.RadioButton rbYesUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSearchRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.Label label11;
    }
}
