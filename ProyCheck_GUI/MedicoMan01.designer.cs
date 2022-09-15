
namespace ProyCheck_GUI
{
    partial class MedicoMan01
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
            this.dtgMedico = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTotalRegistro = new System.Windows.Forms.Label();
            this.lblRegistroCount = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.codMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Ubigeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedico)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMedico
            // 
            this.dtgMedico.AllowUserToAddRows = false;
            this.dtgMedico.AllowUserToDeleteRows = false;
            this.dtgMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMedico,
            this.dniMedic,
            this.nomMedico,
            this.apeMedico,
            this.fechaNacimiento,
            this.emailMedico,
            this.Id_Ubigeo,
            this.direcMedico,
            this.estado});
            this.dtgMedico.Location = new System.Drawing.Point(28, 103);
            this.dtgMedico.Name = "dtgMedico";
            this.dtgMedico.ReadOnly = true;
            this.dtgMedico.RowHeadersVisible = false;
            this.dtgMedico.RowHeadersWidth = 62;
            this.dtgMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedico.Size = new System.Drawing.Size(905, 322);
            this.dtgMedico.TabIndex = 0;
            this.dtgMedico.DoubleClick += new System.EventHandler(this.dtgMedico_DoubleClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(657, 478);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(759, 478);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(37, 34);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(78, 30);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 4;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(224, 34);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(274, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblTotalRegistro
            // 
            this.lblTotalRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRegistro.AutoSize = true;
            this.lblTotalRegistro.Location = new System.Drawing.Point(787, 445);
            this.lblTotalRegistro.Name = "lblTotalRegistro";
            this.lblTotalRegistro.Size = new System.Drawing.Size(88, 13);
            this.lblTotalRegistro.TabIndex = 5;
            this.lblTotalRegistro.Text = "Total de Registro";
            // 
            // lblRegistroCount
            // 
            this.lblRegistroCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistroCount.BackColor = System.Drawing.Color.White;
            this.lblRegistroCount.Location = new System.Drawing.Point(879, 439);
            this.lblRegistroCount.Name = "lblRegistroCount";
            this.lblRegistroCount.Size = new System.Drawing.Size(54, 25);
            this.lblRegistroCount.TabIndex = 6;
            this.lblRegistroCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.txtDni);
            this.gbBusqueda.Controls.Add(this.lblDni);
            this.gbBusqueda.Controls.Add(this.txtApellido);
            this.gbBusqueda.Controls.Add(this.lblApellido);
            this.gbBusqueda.Location = new System.Drawing.Point(28, 21);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(821, 66);
            this.gbBusqueda.TabIndex = 7;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de Médico";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(859, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // codMedico
            // 
            this.codMedico.DataPropertyName = "codMedico";
            this.codMedico.Frozen = true;
            this.codMedico.HeaderText = "Codigo";
            this.codMedico.Name = "codMedico";
            this.codMedico.ReadOnly = true;
            // 
            // dniMedic
            // 
            this.dniMedic.DataPropertyName = "dniMedic";
            this.dniMedic.HeaderText = "DNI";
            this.dniMedic.Name = "dniMedic";
            this.dniMedic.ReadOnly = true;
            // 
            // nomMedico
            // 
            this.nomMedico.DataPropertyName = "nomMedico";
            this.nomMedico.HeaderText = "Nombre";
            this.nomMedico.Name = "nomMedico";
            this.nomMedico.ReadOnly = true;
            // 
            // apeMedico
            // 
            this.apeMedico.DataPropertyName = "apeMedico";
            this.apeMedico.HeaderText = "Apellido";
            this.apeMedico.Name = "apeMedico";
            this.apeMedico.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // emailMedico
            // 
            this.emailMedico.DataPropertyName = "emailMedico";
            this.emailMedico.HeaderText = "Email";
            this.emailMedico.Name = "emailMedico";
            this.emailMedico.ReadOnly = true;
            // 
            // Id_Ubigeo
            // 
            this.Id_Ubigeo.DataPropertyName = "Id_Ubigeo";
            this.Id_Ubigeo.HeaderText = "Ubigeo";
            this.Id_Ubigeo.Name = "Id_Ubigeo";
            this.Id_Ubigeo.ReadOnly = true;
            // 
            // direcMedico
            // 
            this.direcMedico.DataPropertyName = "direcMedico";
            this.direcMedico.HeaderText = "Dirección";
            this.direcMedico.Name = "direcMedico";
            this.direcMedico.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // MedicoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 513);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.lblRegistroCount);
            this.Controls.Add(this.lblTotalRegistro);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgMedico);
            this.Name = "MedicoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Medicos";
            this.Load += new System.EventHandler(this.MedicoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedico)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMedico;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTotalRegistro;
        private System.Windows.Forms.Label lblRegistroCount;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ubigeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}