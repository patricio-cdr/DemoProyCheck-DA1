namespace ProyCheck_GUI
{
    partial class PacienteMan03
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
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.optMujer = new System.Windows.Forms.RadioButton();
            this.optHombre = new System.Windows.Forms.RadioButton();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.cboTipoPaci = new System.Windows.Forms.ComboBox();
            this.cboSangre = new System.Windows.Forms.ComboBox();
            this.dtpFecIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFecNaci = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(96, 174);
            this.mskDNI.Margin = new System.Windows.Forms.Padding(2);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(62, 20);
            this.mskDNI.TabIndex = 3;
            this.mskDNI.Click += new System.EventHandler(this.mskDNI_Click);
            // 
            // cboDistrito
            // 
            this.cboDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(435, 208);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(230, 21);
            this.cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            this.cboProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(435, 174);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(230, 21);
            this.cboProvincia.TabIndex = 15;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(435, 141);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(230, 21);
            this.cboDepartamento.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(545, 402);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(454, 402);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(99, 351);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(190, 20);
            this.txtTel.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 280);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(435, 106);
            this.txtDirec.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(223, 20);
            this.txtDirec.TabIndex = 6;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(99, 102);
            this.txtApe.Margin = new System.Windows.Forms.Padding(2);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(190, 20);
            this.txtApe.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(99, 66);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(190, 20);
            this.txtNom.TabIndex = 0;
            // 
            // optMujer
            // 
            this.optMujer.AutoSize = true;
            this.optMujer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optMujer.Location = new System.Drawing.Point(163, 210);
            this.optMujer.Margin = new System.Windows.Forms.Padding(2);
            this.optMujer.Name = "optMujer";
            this.optMujer.Size = new System.Drawing.Size(57, 18);
            this.optMujer.TabIndex = 5;
            this.optMujer.TabStop = true;
            this.optMujer.Text = "Mujer";
            this.optMujer.UseVisualStyleBackColor = true;
            // 
            // optHombre
            // 
            this.optHombre.AutoSize = true;
            this.optHombre.Location = new System.Drawing.Point(99, 210);
            this.optHombre.Margin = new System.Windows.Forms.Padding(2);
            this.optHombre.Name = "optHombre";
            this.optHombre.Size = new System.Drawing.Size(62, 17);
            this.optHombre.TabIndex = 4;
            this.optHombre.TabStop = true;
            this.optHombre.Text = "Hombre";
            this.optHombre.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(99, 391);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.cboEmpresa.Location = new System.Drawing.Point(435, 68);
            this.cboEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(230, 21);
            this.cboEmpresa.TabIndex = 13;
            // 
            // cboTipoPaci
            // 
            this.cboTipoPaci.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoPaci.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoPaci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPaci.FormattingEnabled = true;
            this.cboTipoPaci.Items.AddRange(new object[] {
            "Gerente",
            "Administrativo",
            "Operacional"});
            this.cboTipoPaci.Location = new System.Drawing.Point(435, 33);
            this.cboTipoPaci.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPaci.Name = "cboTipoPaci";
            this.cboTipoPaci.Size = new System.Drawing.Size(115, 21);
            this.cboTipoPaci.TabIndex = 12;
            // 
            // cboSangre
            // 
            this.cboSangre.AutoCompleteCustomSource.AddRange(new string[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.cboSangre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboSangre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSangre.FormattingEnabled = true;
            this.cboSangre.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.cboSangre.Location = new System.Drawing.Point(99, 244);
            this.cboSangre.Margin = new System.Windows.Forms.Padding(2);
            this.cboSangre.Name = "cboSangre";
            this.cboSangre.Size = new System.Drawing.Size(82, 21);
            this.cboSangre.TabIndex = 7;
            // 
            // dtpFecIngreso
            // 
            this.dtpFecIngreso.Enabled = false;
            this.dtpFecIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIngreso.Location = new System.Drawing.Point(99, 314);
            this.dtpFecIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecIngreso.Name = "dtpFecIngreso";
            this.dtpFecIngreso.Size = new System.Drawing.Size(135, 20);
            this.dtpFecIngreso.TabIndex = 9;
            // 
            // dtpFecNaci
            // 
            this.dtpFecNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNaci.Location = new System.Drawing.Point(154, 137);
            this.dtpFecNaci.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecNaci.Name = "dtpFecNaci";
            this.dtpFecNaci.Size = new System.Drawing.Size(135, 20);
            this.dtpFecNaci.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 353);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(370, 210);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Distrito:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 176);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Provincia:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Departamento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Empresa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tipo de Paciente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 391);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sangre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DNI:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 317);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "F. Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblCod);
            this.grpDatos.Controls.Add(this.mskDNI);
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.cboDepartamento);
            this.grpDatos.Controls.Add(this.btnSalir);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.txtDirec);
            this.grpDatos.Controls.Add(this.txtApe);
            this.grpDatos.Controls.Add(this.txtNom);
            this.grpDatos.Controls.Add(this.optMujer);
            this.grpDatos.Controls.Add(this.optHombre);
            this.grpDatos.Controls.Add(this.chkActivo);
            this.grpDatos.Controls.Add(this.cboEmpresa);
            this.grpDatos.Controls.Add(this.cboTipoPaci);
            this.grpDatos.Controls.Add(this.cboSangre);
            this.grpDatos.Controls.Add(this.dtpFecIngreso);
            this.grpDatos.Controls.Add(this.dtpFecNaci);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.label16);
            this.grpDatos.Controls.Add(this.label15);
            this.grpDatos.Controls.Add(this.label14);
            this.grpDatos.Controls.Add(this.label12);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label13);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label17);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(33, 16);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatos.Size = new System.Drawing.Size(695, 452);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCod.Location = new System.Drawing.Point(99, 32);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(87, 18);
            this.lblCod.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 33);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Codigo:";
            // 
            // PacienteMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.grpDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PacienteMan03";
            this.Text = "Actualizar Paciente";
            this.Load += new System.EventHandler(this.PacienteMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.RadioButton optMujer;
        private System.Windows.Forms.RadioButton optHombre;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.ComboBox cboTipoPaci;
        private System.Windows.Forms.ComboBox cboSangre;
        private System.Windows.Forms.DateTimePicker dtpFecIngreso;
        internal System.Windows.Forms.DateTimePicker dtpFecNaci;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCod;
    }
}