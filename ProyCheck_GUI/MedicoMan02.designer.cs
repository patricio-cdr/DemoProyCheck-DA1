
namespace ProyCheck_GUI
{
    partial class MedicoMan02
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNumColegiatura = new System.Windows.Forms.Label();
            this.mskColegiatura = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFecIngreso = new System.Windows.Forms.DateTimePicker();
            this.gbInsertarMedico = new System.Windows.Forms.GroupBox();
            this.gbInsertarMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(23, 26);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // mskDni
            // 
            this.mskDni.Location = new System.Drawing.Point(58, 22);
            this.mskDni.Mask = "00000000";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(59, 20);
            this.mskDni.TabIndex = 0;
            this.mskDni.Click += new System.EventHandler(this.mskDni_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellidos:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblNumColegiatura
            // 
            this.lblNumColegiatura.AutoSize = true;
            this.lblNumColegiatura.Location = new System.Drawing.Point(23, 140);
            this.lblNumColegiatura.Name = "lblNumColegiatura";
            this.lblNumColegiatura.Size = new System.Drawing.Size(91, 13);
            this.lblNumColegiatura.TabIndex = 2;
            this.lblNumColegiatura.Text = "Num. Colegiatura:";
            // 
            // mskColegiatura
            // 
            this.mskColegiatura.Location = new System.Drawing.Point(120, 136);
            this.mskColegiatura.Mask = "000000000";
            this.mskColegiatura.Name = "mskColegiatura";
            this.mskColegiatura.Size = new System.Drawing.Size(67, 20);
            this.mskColegiatura.TabIndex = 3;
            this.mskColegiatura.Click += new System.EventHandler(this.mskColegiatura_Click);
            // 
            // dtpFecNacimiento
            // 
            this.dtpFecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNacimiento.Location = new System.Drawing.Point(145, 175);
            this.dtpFecNacimiento.Name = "dtpFecNacimiento";
            this.dtpFecNacimiento.Size = new System.Drawing.Size(147, 20);
            this.dtpFecNacimiento.TabIndex = 4;
            // 
            // lblFechNacimiento
            // 
            this.lblFechNacimiento.AutoSize = true;
            this.lblFechNacimiento.Location = new System.Drawing.Point(23, 179);
            this.lblFechNacimiento.Name = "lblFechNacimiento";
            this.lblFechNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechNacimiento.TabIndex = 2;
            this.lblFechNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(334, 27);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(23, 294);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(78, 292);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(21, 259);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(94, 255);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cboEspecialidad.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(81, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(398, 23);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(419, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(514, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(315, 62);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(398, 58);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(191, 21);
            this.cboDepartamento.TabIndex = 9;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(338, 101);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 2;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(398, 97);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(191, 21);
            this.cboProvincia.TabIndex = 10;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(350, 140);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 2;
            this.lblDistrito.Text = "Distrito:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(398, 136);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(191, 21);
            this.cboDistrito.TabIndex = 11;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(315, 179);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(93, 13);
            this.lblFechaIngreso.TabIndex = 2;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // dtpFecIngreso
            // 
            this.dtpFecIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIngreso.Location = new System.Drawing.Point(417, 175);
            this.dtpFecIngreso.Name = "dtpFecIngreso";
            this.dtpFecIngreso.Size = new System.Drawing.Size(147, 20);
            this.dtpFecIngreso.TabIndex = 12;
            // 
            // gbInsertarMedico
            // 
            this.gbInsertarMedico.Controls.Add(this.btnSalir);
            this.gbInsertarMedico.Controls.Add(this.btnGuardar);
            this.gbInsertarMedico.Controls.Add(this.lblDNI);
            this.gbInsertarMedico.Controls.Add(this.cboDistrito);
            this.gbInsertarMedico.Controls.Add(this.mskDni);
            this.gbInsertarMedico.Controls.Add(this.cboProvincia);
            this.gbInsertarMedico.Controls.Add(this.mskColegiatura);
            this.gbInsertarMedico.Controls.Add(this.cboDepartamento);
            this.gbInsertarMedico.Controls.Add(this.lblNombre);
            this.gbInsertarMedico.Controls.Add(this.cboEspecialidad);
            this.gbInsertarMedico.Controls.Add(this.txtNombre);
            this.gbInsertarMedico.Controls.Add(this.chkActivo);
            this.gbInsertarMedico.Controls.Add(this.lblApellido);
            this.gbInsertarMedico.Controls.Add(this.dtpFecIngreso);
            this.gbInsertarMedico.Controls.Add(this.lblNumColegiatura);
            this.gbInsertarMedico.Controls.Add(this.dtpFecNacimiento);
            this.gbInsertarMedico.Controls.Add(this.lblEmail);
            this.gbInsertarMedico.Controls.Add(this.txtDireccion);
            this.gbInsertarMedico.Controls.Add(this.lblDireccion);
            this.gbInsertarMedico.Controls.Add(this.lblDistrito);
            this.gbInsertarMedico.Controls.Add(this.lblEstado);
            this.gbInsertarMedico.Controls.Add(this.txtApellido);
            this.gbInsertarMedico.Controls.Add(this.lblEspecialidad);
            this.gbInsertarMedico.Controls.Add(this.lblProvincia);
            this.gbInsertarMedico.Controls.Add(this.lblFechNacimiento);
            this.gbInsertarMedico.Controls.Add(this.txtEmail);
            this.gbInsertarMedico.Controls.Add(this.lblDepartamento);
            this.gbInsertarMedico.Controls.Add(this.lblFechaIngreso);
            this.gbInsertarMedico.Location = new System.Drawing.Point(12, 12);
            this.gbInsertarMedico.Name = "gbInsertarMedico";
            this.gbInsertarMedico.Size = new System.Drawing.Size(617, 332);
            this.gbInsertarMedico.TabIndex = 15;
            this.gbInsertarMedico.TabStop = false;
            this.gbInsertarMedico.Text = "Datos";
            // 
            // MedicoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 362);
            this.Controls.Add(this.gbInsertarMedico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicoMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Medico";
            this.Load += new System.EventHandler(this.MedicoMan02_Load);
            this.gbInsertarMedico.ResumeLayout(false);
            this.gbInsertarMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNumColegiatura;
        private System.Windows.Forms.MaskedTextBox mskColegiatura;
        private System.Windows.Forms.Label lblFechNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFecIngreso;
        internal System.Windows.Forms.DateTimePicker dtpFecNacimiento;
        private System.Windows.Forms.GroupBox gbInsertarMedico;
    }
}