namespace WindowsFormsAppGym
{
    partial class Coach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBoxCoachID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCoachView = new System.Windows.Forms.Button();
            this.btnCoachSearch = new System.Windows.Forms.Button();
            this.btnCoachRefresh = new System.Windows.Forms.Button();
            this.btnCoachDelete = new System.Windows.Forms.Button();
            this.btnCoachEdit = new System.Windows.Forms.Button();
            this.btnCoachSave = new System.Windows.Forms.Button();
            this.dataGridViewCoach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.cBoxCoachGender = new System.Windows.Forms.ComboBox();
            this.txtCoachPassword = new System.Windows.Forms.TextBox();
            this.txtCoachAddress = new System.Windows.Forms.TextBox();
            this.txtCoachExperience = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeCoachDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCoachPhone = new System.Windows.Forms.TextBox();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBilling = new System.Windows.Forms.Label();
            this.labelRecep = new System.Windows.Forms.Label();
            this.labelMembership = new System.Windows.Forms.Label();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoach)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-3, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 523);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.cBoxCoachID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCoachView);
            this.panel2.Controls.Add(this.btnCoachSearch);
            this.panel2.Controls.Add(this.btnCoachRefresh);
            this.panel2.Controls.Add(this.btnCoachDelete);
            this.panel2.Controls.Add(this.btnCoachEdit);
            this.panel2.Controls.Add(this.btnCoachSave);
            this.panel2.Controls.Add(this.dataGridViewCoach);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cBoxCoachGender);
            this.panel2.Controls.Add(this.txtCoachPassword);
            this.panel2.Controls.Add(this.txtCoachAddress);
            this.panel2.Controls.Add(this.txtCoachExperience);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimeCoachDOB);
            this.panel2.Controls.Add(this.txtCoachPhone);
            this.panel2.Controls.Add(this.txtCoachName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(43, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 458);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cBoxCoachID
            // 
            this.cBoxCoachID.FormattingEnabled = true;
            this.cBoxCoachID.Location = new System.Drawing.Point(643, 56);
            this.cBoxCoachID.Name = "cBoxCoachID";
            this.cBoxCoachID.Size = new System.Drawing.Size(142, 21);
            this.cBoxCoachID.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Coach ID";
            // 
            // btnCoachView
            // 
            this.btnCoachView.BackColor = System.Drawing.Color.Silver;
            this.btnCoachView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachView.Location = new System.Drawing.Point(409, 353);
            this.btnCoachView.Name = "btnCoachView";
            this.btnCoachView.Size = new System.Drawing.Size(59, 23);
            this.btnCoachView.TabIndex = 91;
            this.btnCoachView.Text = "View";
            this.btnCoachView.UseVisualStyleBackColor = false;
            this.btnCoachView.Click += new System.EventHandler(this.btnCoachView_Click);
            // 
            // btnCoachSearch
            // 
            this.btnCoachSearch.BackColor = System.Drawing.Color.Silver;
            this.btnCoachSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachSearch.Location = new System.Drawing.Point(909, 56);
            this.btnCoachSearch.Name = "btnCoachSearch";
            this.btnCoachSearch.Size = new System.Drawing.Size(59, 23);
            this.btnCoachSearch.TabIndex = 90;
            this.btnCoachSearch.Text = "Search";
            this.btnCoachSearch.UseVisualStyleBackColor = false;
            this.btnCoachSearch.Click += new System.EventHandler(this.btnCoachSearch_Click);
            // 
            // btnCoachRefresh
            // 
            this.btnCoachRefresh.BackColor = System.Drawing.Color.Silver;
            this.btnCoachRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachRefresh.Location = new System.Drawing.Point(319, 353);
            this.btnCoachRefresh.Name = "btnCoachRefresh";
            this.btnCoachRefresh.Size = new System.Drawing.Size(59, 23);
            this.btnCoachRefresh.TabIndex = 89;
            this.btnCoachRefresh.Text = "Refresh";
            this.btnCoachRefresh.UseVisualStyleBackColor = false;
            this.btnCoachRefresh.Click += new System.EventHandler(this.btnCoachRefresh_Click);
            // 
            // btnCoachDelete
            // 
            this.btnCoachDelete.BackColor = System.Drawing.Color.Silver;
            this.btnCoachDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachDelete.Location = new System.Drawing.Point(1089, 56);
            this.btnCoachDelete.Name = "btnCoachDelete";
            this.btnCoachDelete.Size = new System.Drawing.Size(59, 23);
            this.btnCoachDelete.TabIndex = 88;
            this.btnCoachDelete.Text = "Delete";
            this.btnCoachDelete.UseVisualStyleBackColor = false;
            this.btnCoachDelete.Click += new System.EventHandler(this.btnCoachDelete_Click);
            // 
            // btnCoachEdit
            // 
            this.btnCoachEdit.BackColor = System.Drawing.Color.Silver;
            this.btnCoachEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachEdit.Location = new System.Drawing.Point(995, 56);
            this.btnCoachEdit.Name = "btnCoachEdit";
            this.btnCoachEdit.Size = new System.Drawing.Size(59, 23);
            this.btnCoachEdit.TabIndex = 87;
            this.btnCoachEdit.Text = "Edit";
            this.btnCoachEdit.UseVisualStyleBackColor = false;
            this.btnCoachEdit.Click += new System.EventHandler(this.btnCoachEdit_Click);
            // 
            // btnCoachSave
            // 
            this.btnCoachSave.BackColor = System.Drawing.Color.Silver;
            this.btnCoachSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachSave.Location = new System.Drawing.Point(227, 353);
            this.btnCoachSave.Name = "btnCoachSave";
            this.btnCoachSave.Size = new System.Drawing.Size(59, 23);
            this.btnCoachSave.TabIndex = 86;
            this.btnCoachSave.Text = "Save";
            this.btnCoachSave.UseVisualStyleBackColor = false;
            this.btnCoachSave.Click += new System.EventHandler(this.btnCoachSave_Click);
            // 
            // dataGridViewCoach
            // 
            this.dataGridViewCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewCoach.Location = new System.Drawing.Point(546, 89);
            this.dataGridViewCoach.Name = "dataGridViewCoach";
            this.dataGridViewCoach.Size = new System.Drawing.Size(644, 342);
            this.dataGridViewCoach.TabIndex = 28;
            this.dataGridViewCoach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Coach ID";
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
            this.Column6.HeaderText = "Experience";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Address";
            this.Column7.Name = "Column7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(788, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Coachs List";
            // 
            // cBoxCoachGender
            // 
            this.cBoxCoachGender.FormattingEnabled = true;
            this.cBoxCoachGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cBoxCoachGender.Location = new System.Drawing.Point(303, 96);
            this.cBoxCoachGender.Name = "cBoxCoachGender";
            this.cBoxCoachGender.Size = new System.Drawing.Size(205, 21);
            this.cBoxCoachGender.TabIndex = 24;
            // 
            // txtCoachPassword
            // 
            this.txtCoachPassword.Location = new System.Drawing.Point(303, 278);
            this.txtCoachPassword.Name = "txtCoachPassword";
            this.txtCoachPassword.Size = new System.Drawing.Size(205, 20);
            this.txtCoachPassword.TabIndex = 17;
            this.txtCoachPassword.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtCoachAddress
            // 
            this.txtCoachAddress.Location = new System.Drawing.Point(303, 238);
            this.txtCoachAddress.Name = "txtCoachAddress";
            this.txtCoachAddress.Size = new System.Drawing.Size(205, 20);
            this.txtCoachAddress.TabIndex = 16;
            this.txtCoachAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtCoachExperience
            // 
            this.txtCoachExperience.Location = new System.Drawing.Point(303, 208);
            this.txtCoachExperience.Name = "txtCoachExperience";
            this.txtCoachExperience.Size = new System.Drawing.Size(205, 20);
            this.txtCoachExperience.TabIndex = 15;
            this.txtCoachExperience.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(219, 279);
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
            this.label13.Location = new System.Drawing.Point(219, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.labelLogout);
            this.panel4.Location = new System.Drawing.Point(0, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 41);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.Color.White;
            this.labelLogout.Location = new System.Drawing.Point(55, 12);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(54, 16);
            this.labelLogout.TabIndex = 1;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Experience";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date of Birth";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimeCoachDOB
            // 
            this.dateTimeCoachDOB.Location = new System.Drawing.Point(303, 136);
            this.dateTimeCoachDOB.Name = "dateTimeCoachDOB";
            this.dateTimeCoachDOB.Size = new System.Drawing.Size(205, 20);
            this.dateTimeCoachDOB.TabIndex = 6;
            this.dateTimeCoachDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtCoachPhone
            // 
            this.txtCoachPhone.Location = new System.Drawing.Point(303, 175);
            this.txtCoachPhone.Name = "txtCoachPhone";
            this.txtCoachPhone.Size = new System.Drawing.Size(205, 20);
            this.txtCoachPhone.TabIndex = 4;
            this.txtCoachPhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(303, 59);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(205, 20);
            this.txtCoachName.TabIndex = 3;
            this.txtCoachName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 64);
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
            this.label5.Location = new System.Drawing.Point(330, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Manage Coachs";
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
            this.panel3.Size = new System.Drawing.Size(161, 458);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "DashBoard";
            // 
            // labelBilling
            // 
            this.labelBilling.AutoSize = true;
            this.labelBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.Location = new System.Drawing.Point(53, 282);
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
            this.labelRecep.Location = new System.Drawing.Point(31, 246);
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
            this.labelMembership.Location = new System.Drawing.Point(33, 212);
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
            this.labelMember.Location = new System.Drawing.Point(47, 179);
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
            this.labelCoach.Location = new System.Drawing.Point(53, 140);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(51, 16);
            this.labelCoach.TabIndex = 6;
            this.labelCoach.Text = "Coach";
            this.labelCoach.Click += new System.EventHandler(this.labelCoach_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 79);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppGym.Properties.Resources._1699927413699;
            this.pictureBox1.Location = new System.Drawing.Point(56, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1255, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Coach";
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.Coach_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoach)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeCoachDOB;
        private System.Windows.Forms.TextBox txtCoachPhone;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCoachPassword;
        private System.Windows.Forms.TextBox txtCoachAddress;
        private System.Windows.Forms.TextBox txtCoachExperience;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cBoxCoachGender;
        private System.Windows.Forms.DataGridView dataGridViewCoach;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelBilling;
        private System.Windows.Forms.Label labelRecep;
        private System.Windows.Forms.Label labelMembership;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Button btnCoachView;
        private System.Windows.Forms.Button btnCoachSearch;
        private System.Windows.Forms.Button btnCoachRefresh;
        private System.Windows.Forms.Button btnCoachDelete;
        private System.Windows.Forms.Button btnCoachEdit;
        private System.Windows.Forms.Button btnCoachSave;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cBoxCoachID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}