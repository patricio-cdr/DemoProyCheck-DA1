namespace ProyCheck_GUI
{
    partial class EmpresaMan01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dtgEmpresa = new System.Windows.Forms.DataGridView();
            this.codEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raz_soc_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Años_servicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajadores_Evaluados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el RUC:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(120, 33);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(234, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 442);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de registros:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(867, 439);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(58, 24);
            this.lblRegistros.TabIndex = 0;
            this.lblRegistros.Click += new System.EventHandler(this.lblRegistros_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(849, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(749, 483);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(652, 484);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgEmpresa
            // 
            this.dtgEmpresa.AllowUserToAddRows = false;
            this.dtgEmpresa.AllowUserToDeleteRows = false;
            this.dtgEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmpresa,
            this.Raz_soc_emp,
            this.Ruc_emp,
            this.Años_servicios,
            this.Estado_actual,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Trabajadores_Evaluados});
            this.dtgEmpresa.Location = new System.Drawing.Point(28, 85);
            this.dtgEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.dtgEmpresa.Name = "dtgEmpresa";
            this.dtgEmpresa.ReadOnly = true;
            this.dtgEmpresa.RowHeadersVisible = false;
            this.dtgEmpresa.RowHeadersWidth = 62;
            this.dtgEmpresa.RowTemplate.Height = 28;
            this.dtgEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpresa.Size = new System.Drawing.Size(914, 327);
            this.dtgEmpresa.TabIndex = 2;
            this.dtgEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpresa_CellContentClick);
            this.dtgEmpresa.DoubleClick += new System.EventHandler(this.dtgEmpresa_DoubleClick);
            // 
            // codEmpresa
            // 
            this.codEmpresa.DataPropertyName = "codEmpresa";
            this.codEmpresa.HeaderText = "Cod. Empresa";
            this.codEmpresa.Name = "codEmpresa";
            this.codEmpresa.ReadOnly = true;
            // 
            // Raz_soc_emp
            // 
            this.Raz_soc_emp.DataPropertyName = "Raz_soc_emp";
            this.Raz_soc_emp.HeaderText = "Razón Social";
            this.Raz_soc_emp.Name = "Raz_soc_emp";
            this.Raz_soc_emp.ReadOnly = true;
            // 
            // Ruc_emp
            // 
            this.Ruc_emp.DataPropertyName = "Ruc_emp";
            this.Ruc_emp.HeaderText = "RUC";
            this.Ruc_emp.Name = "Ruc_emp";
            this.Ruc_emp.ReadOnly = true;
            // 
            // Años_servicios
            // 
            this.Años_servicios.DataPropertyName = "Años_servicios";
            this.Años_servicios.HeaderText = "Años de servicio";
            this.Años_servicios.Name = "Años_servicios";
            this.Años_servicios.ReadOnly = true;
            // 
            // Estado_actual
            // 
            this.Estado_actual.DataPropertyName = "Estado_actual";
            this.Estado_actual.HeaderText = "Estado Actual";
            this.Estado_actual.Name = "Estado_actual";
            this.Estado_actual.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Trabajadores_Evaluados
            // 
            this.Trabajadores_Evaluados.DataPropertyName = "Trabajadores_Evaluados";
            this.Trabajadores_Evaluados.HeaderText = "Trabajadores Evaluados";
            this.Trabajadores_Evaluados.Name = "Trabajadores_Evaluados";
            this.Trabajadores_Evaluados.ReadOnly = true;
            // 
            // EmpresaMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 534);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgEmpresa);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmpresaMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Empresas";
            this.Load += new System.EventHandler(this.EmpresaMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raz_soc_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años_servicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajadores_Evaluados;
    }
}