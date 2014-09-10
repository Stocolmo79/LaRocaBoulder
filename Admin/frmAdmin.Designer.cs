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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStreet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstNameClient = new System.Windows.Forms.TextBox();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtRUTCliente = new System.Windows.Forms.TextBox();
            this.tpNewEmp = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.tcAdmin.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpNewEmp.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFirstNameClient);
            this.groupBox2.Controls.Add(this.txtApellidosCliente);
            this.groupBox2.Controls.Add(this.txtRUTCliente);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 643);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txtStreet
            // 
            this.txtStreet.AutoSize = true;
            this.txtStreet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStreet.Location = new System.Drawing.Point(5, 172);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(96, 20);
            this.txtStreet.TabIndex = 18;
            this.txtStreet.Text = "Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 26);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Admin:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(413, 26);
            this.textBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellidos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(5, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numero:";
            // 
            // txtFirstNameClient
            // 
            this.txtFirstNameClient.Location = new System.Drawing.Point(114, 31);
            this.txtFirstNameClient.Name = "txtFirstNameClient";
            this.txtFirstNameClient.Size = new System.Drawing.Size(413, 26);
            this.txtFirstNameClient.TabIndex = 5;
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(114, 77);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(413, 26);
            this.txtApellidosCliente.TabIndex = 6;
            // 
            // txtRUTCliente
            // 
            this.txtRUTCliente.Location = new System.Drawing.Point(114, 123);
            this.txtRUTCliente.Name = "txtRUTCliente";
            this.txtRUTCliente.Size = new System.Drawing.Size(413, 26);
            this.txtRUTCliente.TabIndex = 7;
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
            this.groupBox1.Controls.Add(this.cmbUsuario);
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
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(116, 25);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(412, 28);
            this.cmbUsuario.TabIndex = 23;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
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
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoggedIn.Location = new System.Drawing.Point(1320, 5);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(0, 20);
            this.lblLoggedIn.TabIndex = 14;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpNewEmp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label txtStreet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstNameClient;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.TextBox txtRUTCliente;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.Label lblLoggedIn;
    }
}

