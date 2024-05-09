namespace WindowsFormsAppGym
{
    partial class Receptionists
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
            this.txtRecepPassword = new System.Windows.Forms.TextBox();
            this.txtRecepAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dTimeRecepDOB = new System.Windows.Forms.DateTimePicker();
            this.txtRecepPhone = new System.Windows.Forms.TextBox();
            this.txtRecepName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBilling = new System.Windows.Forms.Label();
            this.labelRecep = new System.Windows.Forms.Label();
            this.labelMembership = new System.Windows.Forms.Label();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBoxRecepId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecepPrevious = new System.Windows.Forms.Button();
            this.btnRecepNext = new System.Windows.Forms.Button();
            this.btnRecepView = new System.Windows.Forms.Button();
            this.btnRecepSearch = new System.Windows.Forms.Button();
            this.btnRecepRefresh = new System.Windows.Forms.Button();
            this.btnRecepDelete = new System.Windows.Forms.Button();
            this.btnRecepEdit = new System.Windows.Forms.Button();
            this.btnRecepSave = new System.Windows.Forms.Button();
            this.dataGridViewRecep = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxRecepGender = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecepPassword
            // 
            this.txtRecepPassword.Location = new System.Drawing.Point(297, 273);
            this.txtRecepPassword.Name = "txtRecepPassword";
            this.txtRecepPassword.Size = new System.Drawing.Size(199, 20);
            this.txtRecepPassword.TabIndex = 17;
            this.txtRecepPassword.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtRecepAddress
            // 
            this.txtRecepAddress.Location = new System.Drawing.Point(297, 233);
            this.txtRecepAddress.Name = "txtRecepAddress";
            this.txtRecepAddress.Size = new System.Drawing.Size(199, 20);
            this.txtRecepAddress.TabIndex = 16;
            this.txtRecepAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(207, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Paassword";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(209, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 76);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppGym.Properties.Resources._1699927413699;
            this.pictureBox1.Location = new System.Drawing.Point(50, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.labelLogout);
            this.panel4.Location = new System.Drawing.Point(0, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 45);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.Color.White;
            this.labelLogout.Location = new System.Drawing.Point(51, 14);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(54, 16);
            this.labelLogout.TabIndex = 1;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dTimeRecepDOB
            // 
            this.dTimeRecepDOB.Location = new System.Drawing.Point(297, 153);
            this.dTimeRecepDOB.Name = "dTimeRecepDOB";
            this.dTimeRecepDOB.Size = new System.Drawing.Size(199, 20);
            this.dTimeRecepDOB.TabIndex = 6;
            this.dTimeRecepDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtRecepPhone
            // 
            this.txtRecepPhone.Location = new System.Drawing.Point(297, 196);
            this.txtRecepPhone.Name = "txtRecepPhone";
            this.txtRecepPhone.Size = new System.Drawing.Size(199, 20);
            this.txtRecepPhone.TabIndex = 4;
            this.txtRecepPhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRecepName
            // 
            this.txtRecepName.Location = new System.Drawing.Point(297, 71);
            this.txtRecepName.Name = "txtRecepName";
            this.txtRecepName.Size = new System.Drawing.Size(199, 20);
            this.txtRecepName.TabIndex = 3;
            this.txtRecepName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Manage Receptionists";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelBilling);
            this.panel3.Controls.Add(this.labelRecep);
            this.panel3.Controls.Add(this.labelMembership);
            this.panel3.Controls.Add(this.labelMember);
            this.panel3.Controls.Add(this.labelCoach);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 461);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "DashBoard";
            // 
            // labelBilling
            // 
            this.labelBilling.AutoSize = true;
            this.labelBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.Location = new System.Drawing.Point(53, 267);
            this.labelBilling.Name = "labelBilling";
            this.labelBilling.Size = new System.Drawing.Size(50, 16);
            this.labelBilling.TabIndex = 10;
            this.labelBilling.Text = "Billing";
            this.labelBilling.Click += new System.EventHandler(this.labelBilling_Click);
            // 
            // labelRecep
            // 
            this.labelRecep.AutoSize = true;
            this.labelRecep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecep.Location = new System.Drawing.Point(34, 238);
            this.labelRecep.Name = "labelRecep";
            this.labelRecep.Size = new System.Drawing.Size(102, 16);
            this.labelRecep.TabIndex = 9;
            this.labelRecep.Text = "Receptionists";
            this.labelRecep.Click += new System.EventHandler(this.labelRecep_Click);
            // 
            // labelMembership
            // 
            this.labelMembership.AutoSize = true;
            this.labelMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembership.Location = new System.Drawing.Point(34, 203);
            this.labelMembership.Name = "labelMembership";
            this.labelMembership.Size = new System.Drawing.Size(100, 16);
            this.labelMembership.TabIndex = 8;
            this.labelMembership.Text = "Memberships";
            this.labelMembership.Click += new System.EventHandler(this.labelMembership_Click);
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember.Location = new System.Drawing.Point(49, 163);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(71, 16);
            this.labelMember.TabIndex = 7;
            this.labelMember.Text = "Members";
            this.labelMember.Click += new System.EventHandler(this.labelMember_Click);
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoach.Location = new System.Drawing.Point(53, 134);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(51, 16);
            this.labelCoach.TabIndex = 6;
            this.labelCoach.Text = "Coach";
            this.labelCoach.Click += new System.EventHandler(this.labelCoach_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 507);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date of Birth";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.cBoxRecepId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRecepPrevious);
            this.panel2.Controls.Add(this.btnRecepNext);
            this.panel2.Controls.Add(this.btnRecepView);
            this.panel2.Controls.Add(this.btnRecepSearch);
            this.panel2.Controls.Add(this.btnRecepRefresh);
            this.panel2.Controls.Add(this.btnRecepDelete);
            this.panel2.Controls.Add(this.btnRecepEdit);
            this.panel2.Controls.Add(this.btnRecepSave);
            this.panel2.Controls.Add(this.dataGridViewRecep);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cBoxRecepGender);
            this.panel2.Controls.Add(this.txtRecepPassword);
            this.panel2.Controls.Add(this.txtRecepAddress);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dTimeRecepDOB);
            this.panel2.Controls.Add(this.txtRecepPhone);
            this.panel2.Controls.Add(this.txtRecepName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(46, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 461);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cBoxRecepId
            // 
            this.cBoxRecepId.FormattingEnabled = true;
            this.cBoxRecepId.Location = new System.Drawing.Point(658, 59);
            this.cBoxRecepId.Name = "cBoxRecepId";
            this.cBoxRecepId.Size = new System.Drawing.Size(121, 21);
            this.cBoxRecepId.TabIndex = 40;
            this.cBoxRecepId.SelectedIndexChanged += new System.EventHandler(this.cBoxRecepId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Reception ID";
            // 
            // btnRecepPrevious
            // 
            this.btnRecepPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecepPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepPrevious.ForeColor = System.Drawing.Color.White;
            this.btnRecepPrevious.Location = new System.Drawing.Point(227, 381);
            this.btnRecepPrevious.Name = "btnRecepPrevious";
            this.btnRecepPrevious.Size = new System.Drawing.Size(72, 31);
            this.btnRecepPrevious.TabIndex = 38;
            this.btnRecepPrevious.Text = "Back";
            this.btnRecepPrevious.UseVisualStyleBackColor = false;
            this.btnRecepPrevious.Click += new System.EventHandler(this.btnRecepPrevious_Click_1);
            // 
            // btnRecepNext
            // 
            this.btnRecepNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecepNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepNext.ForeColor = System.Drawing.Color.White;
            this.btnRecepNext.Location = new System.Drawing.Point(357, 381);
            this.btnRecepNext.Name = "btnRecepNext";
            this.btnRecepNext.Size = new System.Drawing.Size(80, 31);
            this.btnRecepNext.TabIndex = 37;
            this.btnRecepNext.Text = "Next";
            this.btnRecepNext.UseVisualStyleBackColor = false;
            this.btnRecepNext.Click += new System.EventHandler(this.btnRecepNext_Click_1);
            // 
            // btnRecepView
            // 
            this.btnRecepView.BackColor = System.Drawing.Color.Silver;
            this.btnRecepView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepView.Location = new System.Drawing.Point(378, 333);
            this.btnRecepView.Name = "btnRecepView";
            this.btnRecepView.Size = new System.Drawing.Size(59, 23);
            this.btnRecepView.TabIndex = 36;
            this.btnRecepView.Text = "View";
            this.btnRecepView.UseVisualStyleBackColor = false;
            this.btnRecepView.Click += new System.EventHandler(this.btnRecepView_Click);
            // 
            // btnRecepSearch
            // 
            this.btnRecepSearch.BackColor = System.Drawing.Color.Silver;
            this.btnRecepSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepSearch.Location = new System.Drawing.Point(826, 57);
            this.btnRecepSearch.Name = "btnRecepSearch";
            this.btnRecepSearch.Size = new System.Drawing.Size(59, 23);
            this.btnRecepSearch.TabIndex = 35;
            this.btnRecepSearch.Text = "Search";
            this.btnRecepSearch.UseVisualStyleBackColor = false;
            this.btnRecepSearch.Click += new System.EventHandler(this.btnRecepSearch_Click);
            // 
            // btnRecepRefresh
            // 
            this.btnRecepRefresh.BackColor = System.Drawing.Color.Silver;
            this.btnRecepRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepRefresh.Location = new System.Drawing.Point(297, 333);
            this.btnRecepRefresh.Name = "btnRecepRefresh";
            this.btnRecepRefresh.Size = new System.Drawing.Size(59, 23);
            this.btnRecepRefresh.TabIndex = 34;
            this.btnRecepRefresh.Text = "Refresh";
            this.btnRecepRefresh.UseVisualStyleBackColor = false;
            this.btnRecepRefresh.Click += new System.EventHandler(this.btnRecepRefresh_Click);
            // 
            // btnRecepDelete
            // 
            this.btnRecepDelete.BackColor = System.Drawing.Color.Silver;
            this.btnRecepDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepDelete.Location = new System.Drawing.Point(993, 57);
            this.btnRecepDelete.Name = "btnRecepDelete";
            this.btnRecepDelete.Size = new System.Drawing.Size(59, 23);
            this.btnRecepDelete.TabIndex = 33;
            this.btnRecepDelete.Text = "Delete";
            this.btnRecepDelete.UseVisualStyleBackColor = false;
            this.btnRecepDelete.Click += new System.EventHandler(this.btnRecepDelete_Click);
            // 
            // btnRecepEdit
            // 
            this.btnRecepEdit.BackColor = System.Drawing.Color.Silver;
            this.btnRecepEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepEdit.Location = new System.Drawing.Point(914, 59);
            this.btnRecepEdit.Name = "btnRecepEdit";
            this.btnRecepEdit.Size = new System.Drawing.Size(59, 23);
            this.btnRecepEdit.TabIndex = 32;
            this.btnRecepEdit.Text = "Edit";
            this.btnRecepEdit.UseVisualStyleBackColor = false;
            this.btnRecepEdit.Click += new System.EventHandler(this.btnRecepEdit_Click);
            // 
            // btnRecepSave
            // 
            this.btnRecepSave.BackColor = System.Drawing.Color.Silver;
            this.btnRecepSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepSave.Location = new System.Drawing.Point(210, 333);
            this.btnRecepSave.Name = "btnRecepSave";
            this.btnRecepSave.Size = new System.Drawing.Size(59, 23);
            this.btnRecepSave.TabIndex = 31;
            this.btnRecepSave.Text = "Save";
            this.btnRecepSave.UseVisualStyleBackColor = false;
            this.btnRecepSave.Click += new System.EventHandler(this.btnRecepSave_Click);
            // 
            // dataGridViewRecep
            // 
            this.dataGridViewRecep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewRecep.Location = new System.Drawing.Point(574, 94);
            this.dataGridViewRecep.Name = "dataGridViewRecep";
            this.dataGridViewRecep.Size = new System.Drawing.Size(539, 327);
            this.dataGridViewRecep.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reception ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DOB";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(773, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Receptionists List";
            // 
            // cBoxRecepGender
            // 
            this.cBoxRecepGender.FormattingEnabled = true;
            this.cBoxRecepGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cBoxRecepGender.Location = new System.Drawing.Point(297, 110);
            this.cBoxRecepGender.Name = "cBoxRecepGender";
            this.cBoxRecepGender.Size = new System.Drawing.Size(199, 21);
            this.cBoxRecepGender.TabIndex = 24;
            // 
            // Receptionists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1254, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receptionists";
            this.Text = "Receptionists";
            this.Load += new System.EventHandler(this.Receptionists_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRecepPassword;
        private System.Windows.Forms.TextBox txtRecepAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTimeRecepDOB;
        private System.Windows.Forms.TextBox txtRecepPhone;
        private System.Windows.Forms.TextBox txtRecepName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cBoxRecepGender;
        private System.Windows.Forms.DataGridView dataGridViewRecep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRecepPrevious;
        private System.Windows.Forms.Button btnRecepNext;
        private System.Windows.Forms.Button btnRecepView;
        private System.Windows.Forms.Button btnRecepSearch;
        private System.Windows.Forms.Button btnRecepRefresh;
        private System.Windows.Forms.Button btnRecepDelete;
        private System.Windows.Forms.Button btnRecepEdit;
        private System.Windows.Forms.Button btnRecepSave;
        private System.Windows.Forms.Label labelBilling;
        private System.Windows.Forms.Label labelRecep;
        private System.Windows.Forms.Label labelMembership;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cBoxRecepId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}