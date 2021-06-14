namespace Proyecto_MAD
{
    partial class Dar_Alta_Carrera
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
            this.tB_Nombre = new System.Windows.Forms.TextBox();
            this.tB_Alias = new System.Windows.Forms.TextBox();
            this.tB_Descripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.gB_Materias = new System.Windows.Forms.GroupBox();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dGV_Materias = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB_BusquedaMat = new System.Windows.Forms.TextBox();
            this.gB_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Materias = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tB_BusquedaCarr = new System.Windows.Forms.TextBox();
            this.dGV_Consulta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Clave = new System.Windows.Forms.TextBox();
            this.uuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gB_Materias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Materias)).BeginInit();
            this.gB_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_Nombre
            // 
            this.tB_Nombre.Location = new System.Drawing.Point(282, 12);
            this.tB_Nombre.MaxLength = 50;
            this.tB_Nombre.Name = "tB_Nombre";
            this.tB_Nombre.Size = new System.Drawing.Size(254, 22);
            this.tB_Nombre.TabIndex = 0;
            // 
            // tB_Alias
            // 
            this.tB_Alias.Location = new System.Drawing.Point(586, 12);
            this.tB_Alias.MaxLength = 25;
            this.tB_Alias.Name = "tB_Alias";
            this.tB_Alias.Size = new System.Drawing.Size(69, 22);
            this.tB_Alias.TabIndex = 1;
            // 
            // tB_Descripcion
            // 
            this.tB_Descripcion.Location = new System.Drawing.Point(6, 21);
            this.tB_Descripcion.MaxLength = 255;
            this.tB_Descripcion.Multiline = true;
            this.tB_Descripcion.Name = "tB_Descripcion";
            this.tB_Descripcion.Size = new System.Drawing.Size(443, 55);
            this.tB_Descripcion.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Descripcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de la Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alias";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(485, 61);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(170, 55);
            this.btn_Registrar.TabIndex = 8;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // gB_Materias
            // 
            this.gB_Materias.Controls.Add(this.btn_Remover);
            this.gB_Materias.Controls.Add(this.btn_Agregar);
            this.gB_Materias.Controls.Add(this.dGV_Materias);
            this.gB_Materias.Controls.Add(this.tB_BusquedaMat);
            this.gB_Materias.Location = new System.Drawing.Point(661, 12);
            this.gB_Materias.Name = "gB_Materias";
            this.gB_Materias.Size = new System.Drawing.Size(485, 373);
            this.gB_Materias.TabIndex = 9;
            this.gB_Materias.TabStop = false;
            this.gB_Materias.Text = "Materias";
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(151, 17);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(138, 34);
            this.btn_Remover.TabIndex = 52;
            this.btn_Remover.Text = "Remover Materias";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(18, 17);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(131, 34);
            this.btn_Agregar.TabIndex = 51;
            this.btn_Agregar.Text = "Agregar Materias";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dGV_Materias
            // 
            this.dGV_Materias.AllowUserToAddRows = false;
            this.dGV_Materias.AllowUserToResizeColumns = false;
            this.dGV_Materias.AllowUserToResizeRows = false;
            this.dGV_Materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre});
            this.dGV_Materias.Location = new System.Drawing.Point(18, 57);
            this.dGV_Materias.Name = "dGV_Materias";
            this.dGV_Materias.RowTemplate.Height = 24;
            this.dGV_Materias.Size = new System.Drawing.Size(461, 310);
            this.dGV_Materias.TabIndex = 46;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 72;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 87;
            // 
            // tB_BusquedaMat
            // 
            this.tB_BusquedaMat.Location = new System.Drawing.Point(295, 23);
            this.tB_BusquedaMat.Name = "tB_BusquedaMat";
            this.tB_BusquedaMat.Size = new System.Drawing.Size(184, 22);
            this.tB_BusquedaMat.TabIndex = 45;
            this.tB_BusquedaMat.TextChanged += new System.EventHandler(this.tB_BusquedaMat_TextChanged);
            // 
            // gB_Consulta
            // 
            this.gB_Consulta.Controls.Add(this.btn_Eliminar);
            this.gB_Consulta.Controls.Add(this.btn_Materias);
            this.gB_Consulta.Controls.Add(this.btn_Editar);
            this.gB_Consulta.Controls.Add(this.tB_BusquedaCarr);
            this.gB_Consulta.Controls.Add(this.dGV_Consulta);
            this.gB_Consulta.Location = new System.Drawing.Point(12, 132);
            this.gB_Consulta.Name = "gB_Consulta";
            this.gB_Consulta.Size = new System.Drawing.Size(643, 253);
            this.gB_Consulta.TabIndex = 46;
            this.gB_Consulta.TabStop = false;
            this.gB_Consulta.Text = "Consulta";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(516, 213);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(121, 34);
            this.btn_Eliminar.TabIndex = 50;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Materias
            // 
            this.btn_Materias.Location = new System.Drawing.Point(516, 173);
            this.btn_Materias.Name = "btn_Materias";
            this.btn_Materias.Size = new System.Drawing.Size(121, 34);
            this.btn_Materias.TabIndex = 49;
            this.btn_Materias.Text = "Ver Materias";
            this.btn_Materias.UseVisualStyleBackColor = true;
            this.btn_Materias.Click += new System.EventHandler(this.btn_Materias_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(516, 133);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(121, 34);
            this.btn_Editar.TabIndex = 48;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // tB_BusquedaCarr
            // 
            this.tB_BusquedaCarr.Location = new System.Drawing.Point(516, 21);
            this.tB_BusquedaCarr.Name = "tB_BusquedaCarr";
            this.tB_BusquedaCarr.Size = new System.Drawing.Size(121, 22);
            this.tB_BusquedaCarr.TabIndex = 47;
            this.tB_BusquedaCarr.TextChanged += new System.EventHandler(this.tB_BusquedaCarr_TextChanged);
            // 
            // dGV_Consulta
            // 
            this.dGV_Consulta.AllowUserToAddRows = false;
            this.dGV_Consulta.AllowUserToDeleteRows = false;
            this.dGV_Consulta.AllowUserToResizeColumns = false;
            this.dGV_Consulta.AllowUserToResizeRows = false;
            this.dGV_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uuid});
            this.dGV_Consulta.Location = new System.Drawing.Point(6, 21);
            this.dGV_Consulta.Name = "dGV_Consulta";
            this.dGV_Consulta.ReadOnly = true;
            this.dGV_Consulta.RowTemplate.Height = 24;
            this.dGV_Consulta.Size = new System.Drawing.Size(504, 226);
            this.dGV_Consulta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Clave";
            // 
            // tB_Clave
            // 
            this.tB_Clave.Location = new System.Drawing.Point(61, 12);
            this.tB_Clave.MaxLength = 25;
            this.tB_Clave.Name = "tB_Clave";
            this.tB_Clave.Size = new System.Drawing.Size(64, 22);
            this.tB_Clave.TabIndex = 47;
            // 
            // uuid
            // 
            this.uuid.DataPropertyName = "id";
            this.uuid.HeaderText = "uuid";
            this.uuid.Name = "uuid";
            this.uuid.ReadOnly = true;
            this.uuid.Visible = false;
            this.uuid.Width = 64;
            // 
            // Dar_Alta_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_Clave);
            this.Controls.Add(this.gB_Consulta);
            this.Controls.Add(this.gB_Materias);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tB_Alias);
            this.Controls.Add(this.tB_Nombre);
            this.Name = "Dar_Alta_Carrera";
            this.Text = "Dar_Alta_Carrera";
            this.Load += new System.EventHandler(this.Dar_Alta_Carrera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gB_Materias.ResumeLayout(false);
            this.gB_Materias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Materias)).EndInit();
            this.gB_Consulta.ResumeLayout(false);
            this.gB_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Nombre;
        private System.Windows.Forms.TextBox tB_Alias;
        private System.Windows.Forms.TextBox tB_Descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.GroupBox gB_Materias;
        private System.Windows.Forms.DataGridView dGV_Materias;
        private System.Windows.Forms.TextBox tB_BusquedaMat;
        private System.Windows.Forms.GroupBox gB_Consulta;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Materias;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox tB_BusquedaCarr;
        private System.Windows.Forms.DataGridView dGV_Consulta;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuid;
    }
}