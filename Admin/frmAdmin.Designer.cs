namespace Admin
{
    partial class frmAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbClientsFound = new System.Windows.Forms.ComboBox();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhoneClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstNameClient = new System.Windows.Forms.TextBox();
            this.txtLastNameClient = new System.Windows.Forms.TextBox();
            this.tpNewEmp = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblLastNames = new System.Windows.Forms.Label();
            this.lblEmpNumber = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb10Tickets = new System.Windows.Forms.RadioButton();
            this.rb25Tickets = new System.Windows.Forms.RadioButton();
            this.rbMonthlyTicket = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txt10Tickets = new System.Windows.Forms.TextBox();
            this.txt25Tickets = new System.Windows.Forms.TextBox();
            this.txtMonthlyStart = new System.Windows.Forms.TextBox();
            this.txtMonthlyEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tcAdmin.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpNewEmp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAdmin.Controls.Add(this.tpCustomer);
            this.tcAdmin.Controls.Add(this.tpNewEmp);
            this.tcAdmin.Location = new System.Drawing.Point(2, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1786, 864);
            this.tcAdmin.TabIndex = 0;
            this.tcAdmin.SelectedIndexChanged += new System.EventHandler(this.tcAdmin_SelectedIndexChanged);
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.groupBox3);
            this.tpCustomer.Controls.Add(this.groupBox2);
            this.tpCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpCustomer.Location = new System.Drawing.Point(4, 29);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(1778, 831);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Cliente";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbClientsFound);
            this.groupBox3.Controls.Add(this.lblNotFound);
            this.groupBox3.Controls.Add(this.txtSearchClient);
            this.groupBox3.Controls.Add(this.txtSearchBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 138);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // cmbClientsFound
            // 
            this.cmbClientsFound.FormattingEnabled = true;
            this.cmbClientsFound.Location = new System.Drawing.Point(12, 75);
            this.cmbClientsFound.Name = "cmbClientsFound";
            this.cmbClientsFound.Size = new System.Drawing.Size(384, 28);
            this.cmbClientsFound.TabIndex = 18;
            this.cmbClientsFound.Visible = false;
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(6, 72);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(329, 32);
            this.lblNotFound.TabIndex = 17;
            this.lblNotFound.Text = "No se encontro usuario";
            this.lblNotFound.Visible = false;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(402, 72);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(130, 43);
            this.txtSearchClient.TabIndex = 16;
            this.txtSearchClient.Text = "Buscar";
            this.txtSearchClient.UseVisualStyleBackColor = true;
            this.txtSearchClient.Click += new System.EventHandler(this.txtSearchClient_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(6, 29);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(526, 26);
            this.txtSearchBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCardNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtPhoneClient);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSaveClient);
            this.groupBox2.Controls.Add(this.txtEmailClient);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFirstNameClient);
            this.groupBox2.Controls.Add(this.txtLastNameClient);
            this.groupBox2.Location = new System.Drawing.Point(6, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 575);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.Location = new System.Drawing.Point(124, 142);
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.Size = new System.Drawing.Size(413, 26);
            this.txtPhoneClient.TabIndex = 20;
            this.txtPhoneClient.Leave += new System.EventHandler(this.txtPhoneClient_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(16, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fono:";
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Location = new System.Drawing.Point(868, 526);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(130, 43);
            this.btnSaveClient.TabIndex = 16;
            this.btnSaveClient.Text = "Guardar";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(124, 188);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(413, 26);
            this.txtEmailClient.TabIndex = 14;
            this.txtEmailClient.Leave += new System.EventHandler(this.txtEmailClient_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellidos:";
            // 
            // txtFirstNameClient
            // 
            this.txtFirstNameClient.Location = new System.Drawing.Point(124, 50);
            this.txtFirstNameClient.Name = "txtFirstNameClient";
            this.txtFirstNameClient.Size = new System.Drawing.Size(413, 26);
            this.txtFirstNameClient.TabIndex = 5;
            this.txtFirstNameClient.Leave += new System.EventHandler(this.txtFirstNameClient_Leave);
            // 
            // txtLastNameClient
            // 
            this.txtLastNameClient.Location = new System.Drawing.Point(124, 96);
            this.txtLastNameClient.Name = "txtLastNameClient";
            this.txtLastNameClient.Size = new System.Drawing.Size(413, 26);
            this.txtLastNameClient.TabIndex = 6;
            this.txtLastNameClient.Leave += new System.EventHandler(this.txtLastNameClient_Leave);
            // 
            // tpNewEmp
            // 
            this.tpNewEmp.Controls.Add(this.groupBox1);
            this.tpNewEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpNewEmp.Location = new System.Drawing.Point(4, 29);
            this.tpNewEmp.Name = "tpNewEmp";
            this.tpNewEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewEmp.Size = new System.Drawing.Size(1778, 831);
            this.tpNewEmp.TabIndex = 2;
            this.tpNewEmp.Text = "Empleado";
            this.tpNewEmp.UseVisualStyleBackColor = true;
            this.tpNewEmp.Click += new System.EventHandler(this.tpNewEmp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRUT);
            this.groupBox1.Controls.Add(this.cmbUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbInstructor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Controls.Add(this.chkAdmin);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtNick);
            this.groupBox1.Controls.Add(this.lblNick);
            this.groupBox1.Controls.Add(this.lblNames);
            this.groupBox1.Controls.Add(this.lblLastNames);
            this.groupBox1.Controls.Add(this.lblEmpNumber);
            this.groupBox1.Controls.Add(this.txtNames);
            this.groupBox1.Controls.Add(this.txtLastNames);
            this.groupBox1.Controls.Add(this.txtEmpNumber);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 643);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "RUT:";
            // 
            // txtRUT
            // 
            this.txtRUT.Location = new System.Drawing.Point(116, 225);
            this.txtRUT.Name = "txtRUT";
            this.txtRUT.Size = new System.Drawing.Size(412, 26);
            this.txtRUT.TabIndex = 25;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(116, 25);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(412, 28);
            this.cmbUser.TabIndex = 23;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Usuario:";
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(116, 274);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(412, 28);
            this.cmbInstructor.TabIndex = 21;
            this.cmbInstructor.SelectedIndexChanged += new System.EventHandler(this.cmbInstructor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tipo de profe:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(10, 393);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 20);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 378);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(412, 26);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdmin.Location = new System.Drawing.Point(10, 484);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(58, 20);
            this.lblAdmin.TabIndex = 17;
            this.lblAdmin.Text = "Admin:";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(116, 483);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(22, 21);
            this.chkAdmin.TabIndex = 15;
            this.chkAdmin.UseVisualStyleBackColor = true;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(116, 429);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(412, 26);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhone.Location = new System.Drawing.Point(10, 436);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Fono:";
            // 
            // txtNick
            // 
            this.txtNick.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNick.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNick.Location = new System.Drawing.Point(116, 78);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(412, 26);
            this.txtNick.TabIndex = 3;
            this.txtNick.Leave += new System.EventHandler(this.txtNick_Leave);
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNick.Location = new System.Drawing.Point(10, 81);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(60, 20);
            this.lblNick.TabIndex = 12;
            this.lblNick.Text = "Apodo:";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNames.Location = new System.Drawing.Point(10, 132);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(77, 20);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Nombres:";
            // 
            // lblLastNames
            // 
            this.lblLastNames.AutoSize = true;
            this.lblLastNames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLastNames.Location = new System.Drawing.Point(10, 180);
            this.lblLastNames.Name = "lblLastNames";
            this.lblLastNames.Size = new System.Drawing.Size(77, 20);
            this.lblLastNames.TabIndex = 1;
            this.lblLastNames.Text = "Apellidos:";
            // 
            // lblEmpNumber
            // 
            this.lblEmpNumber.AutoSize = true;
            this.lblEmpNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpNumber.Location = new System.Drawing.Point(10, 345);
            this.lblEmpNumber.Name = "lblEmpNumber";
            this.lblEmpNumber.Size = new System.Drawing.Size(69, 20);
            this.lblEmpNumber.TabIndex = 2;
            this.lblEmpNumber.Text = "Numero:";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(116, 129);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(412, 26);
            this.txtNames.TabIndex = 5;
            this.txtNames.Leave += new System.EventHandler(this.txtNames_Leave);
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(116, 180);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(412, 26);
            this.txtLastNames.TabIndex = 6;
            this.txtLastNames.Leave += new System.EventHandler(this.txtLastNames_Leave);
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Location = new System.Drawing.Point(116, 327);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(412, 26);
            this.txtEmpNumber.TabIndex = 7;
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoggedIn.Location = new System.Drawing.Point(1320, 5);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(0, 20);
            this.lblLoggedIn.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtMonthlyEnd);
            this.groupBox4.Controls.Add(this.txtMonthlyStart);
            this.groupBox4.Controls.Add(this.txt25Tickets);
            this.groupBox4.Controls.Add(this.txt10Tickets);
            this.groupBox4.Controls.Add(this.rbMonthlyTicket);
            this.groupBox4.Controls.Add(this.rb25Tickets);
            this.groupBox4.Controls.Add(this.rb10Tickets);
            this.groupBox4.Location = new System.Drawing.Point(12, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 200);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // rb10Tickets
            // 
            this.rb10Tickets.AutoSize = true;
            this.rb10Tickets.Location = new System.Drawing.Point(6, 25);
            this.rb10Tickets.Name = "rb10Tickets";
            this.rb10Tickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb10Tickets.Size = new System.Drawing.Size(106, 24);
            this.rb10Tickets.TabIndex = 0;
            this.rb10Tickets.Text = "Tickets 10";
            this.rb10Tickets.UseVisualStyleBackColor = true;
            // 
            // rb25Tickets
            // 
            this.rb25Tickets.AutoSize = true;
            this.rb25Tickets.Location = new System.Drawing.Point(131, 25);
            this.rb25Tickets.Name = "rb25Tickets";
            this.rb25Tickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb25Tickets.Size = new System.Drawing.Size(106, 24);
            this.rb25Tickets.TabIndex = 1;
            this.rb25Tickets.Text = "Tickets 25";
            this.rb25Tickets.UseVisualStyleBackColor = true;
            // 
            // rbMonthlyTicket
            // 
            this.rbMonthlyTicket.AutoSize = true;
            this.rbMonthlyTicket.Checked = true;
            this.rbMonthlyTicket.Location = new System.Drawing.Point(258, 25);
            this.rbMonthlyTicket.Name = "rbMonthlyTicket";
            this.rbMonthlyTicket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbMonthlyTicket.Size = new System.Drawing.Size(124, 24);
            this.rbMonthlyTicket.TabIndex = 2;
            this.rbMonthlyTicket.TabStop = true;
            this.rbMonthlyTicket.Text = "Mensualidad";
            this.rbMonthlyTicket.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nro tarjeta:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Location = new System.Drawing.Point(124, 236);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(413, 26);
            this.txtCardNumber.TabIndex = 23;
            // 
            // txt10Tickets
            // 
            this.txt10Tickets.Enabled = false;
            this.txt10Tickets.Location = new System.Drawing.Point(6, 55);
            this.txt10Tickets.Name = "txt10Tickets";
            this.txt10Tickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt10Tickets.Size = new System.Drawing.Size(104, 26);
            this.txt10Tickets.TabIndex = 24;
            this.txt10Tickets.Text = "10";
            // 
            // txt25Tickets
            // 
            this.txt25Tickets.Enabled = false;
            this.txt25Tickets.Location = new System.Drawing.Point(131, 55);
            this.txt25Tickets.Name = "txt25Tickets";
            this.txt25Tickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt25Tickets.Size = new System.Drawing.Size(104, 26);
            this.txt25Tickets.TabIndex = 25;
            this.txt25Tickets.Text = "25";
            // 
            // txtMonthlyStart
            // 
            this.txtMonthlyStart.Location = new System.Drawing.Point(258, 55);
            this.txtMonthlyStart.Name = "txtMonthlyStart";
            this.txtMonthlyStart.Size = new System.Drawing.Size(104, 26);
            this.txtMonthlyStart.TabIndex = 26;
            // 
            // txtMonthlyEnd
            // 
            this.txtMonthlyEnd.Location = new System.Drawing.Point(389, 55);
            this.txtMonthlyEnd.Name = "txtMonthlyEnd";
            this.txtMonthlyEnd.Size = new System.Drawing.Size(104, 26);
            this.txtMonthlyEnd.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "-";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 874);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.tcAdmin);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "frmAdmin";
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpNewEmp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tpNewEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblLastNames;
        private System.Windows.Forms.Label lblEmpNumber;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstNameClient;
        private System.Windows.Forms.TextBox txtLastNameClient;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.TextBox txtPhoneClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtSearchClient;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.ComboBox cmbClientsFound;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonthlyEnd;
        private System.Windows.Forms.TextBox txtMonthlyStart;
        private System.Windows.Forms.TextBox txt25Tickets;
        private System.Windows.Forms.TextBox txt10Tickets;
        private System.Windows.Forms.RadioButton rbMonthlyTicket;
        private System.Windows.Forms.RadioButton rb25Tickets;
        private System.Windows.Forms.RadioButton rb10Tickets;
    }
}

