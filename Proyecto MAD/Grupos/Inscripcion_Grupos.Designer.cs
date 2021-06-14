namespace Proyecto_MAD
{
    partial class Inscripcion_Grupos
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
            this.dGV_Grupos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_Grupos = new System.Windows.Forms.GroupBox();
            this.btn_Lista = new System.Windows.Forms.Button();
            this.tB_Busqueda = new System.Windows.Forms.TextBox();
            this.gB_Alumnos = new System.Windows.Forms.GroupBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dGV_Alumnos = new System.Windows.Forms.DataGridView();
            this.tB_BusquedaAlu = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grupos)).BeginInit();
            this.gB_Grupos.SuspendLayout();
            this.gB_Alumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Grupos
            // 
            this.dGV_Grupos.AllowUserToAddRows = false;
            this.dGV_Grupos.AllowUserToDeleteRows = false;
            this.dGV_Grupos.AllowUserToResizeColumns = false;
            this.dGV_Grupos.AllowUserToResizeRows = false;
            this.dGV_Grupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Grupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Grupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dGV_Grupos.Location = new System.Drawing.Point(6, 62);
            this.dGV_Grupos.Name = "dGV_Grupos";
            this.dGV_Grupos.ReadOnly = true;
            this.dGV_Grupos.RowTemplate.Height = 24;
            this.dGV_Grupos.Size = new System.Drawing.Size(537, 358);
            this.dGV_Grupos.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 48;
            // 
            // gB_Grupos
            // 
            this.gB_Grupos.Controls.Add(this.btn_Lista);
            this.gB_Grupos.Controls.Add(this.tB_Busqueda);
            this.gB_Grupos.Controls.Add(this.dGV_Grupos);
            this.gB_Grupos.Location = new System.Drawing.Point(12, 12);
            this.gB_Grupos.Name = "gB_Grupos";
            this.gB_Grupos.Size = new System.Drawing.Size(549, 426);
            this.gB_Grupos.TabIndex = 40;
            this.gB_Grupos.TabStop = false;
            this.gB_Grupos.Text = "Grupos";
            // 
            // btn_Lista
            // 
            this.btn_Lista.Location = new System.Drawing.Point(6, 22);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(121, 34);
            this.btn_Lista.TabIndex = 48;
            this.btn_Lista.Text = "Ver Lista";
            this.btn_Lista.UseVisualStyleBackColor = true;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // tB_Busqueda
            // 
            this.tB_Busqueda.Location = new System.Drawing.Point(422, 28);
            this.tB_Busqueda.Name = "tB_Busqueda";
            this.tB_Busqueda.Size = new System.Drawing.Size(121, 22);
            this.tB_Busqueda.TabIndex = 47;
            this.tB_Busqueda.TextChanged += new System.EventHandler(this.tB_Busqueda_TextChanged);
            // 
            // gB_Alumnos
            // 
            this.gB_Alumnos.Controls.Add(this.btn_Actualizar);
            this.gB_Alumnos.Controls.Add(this.btn_Remover);
            this.gB_Alumnos.Controls.Add(this.btn_Agregar);
            this.gB_Alumnos.Controls.Add(this.dGV_Alumnos);
            this.gB_Alumnos.Controls.Add(this.tB_BusquedaAlu);
            this.gB_Alumnos.Location = new System.Drawing.Point(567, 12);
            this.gB_Alumnos.Name = "gB_Alumnos";
            this.gB_Alumnos.Size = new System.Drawing.Size(473, 426);
            this.gB_Alumnos.TabIndex = 41;
            this.gB_Alumnos.TabStop = false;
            this.gB_Alumnos.Text = "Alumnos";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(283, 389);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(184, 34);
            this.btn_Actualizar.TabIndex = 53;
            this.btn_Actualizar.Text = "Actualizar Calificaciones";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(139, 17);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(138, 34);
            this.btn_Remover.TabIndex = 52;
            this.btn_Remover.Text = "Remover Alumnos";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(6, 17);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(131, 34);
            this.btn_Agregar.TabIndex = 51;
            this.btn_Agregar.Text = "Agregar Alumnos";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dGV_Alumnos
            // 
            this.dGV_Alumnos.AllowUserToAddRows = false;
            this.dGV_Alumnos.AllowUserToDeleteRows = false;
            this.dGV_Alumnos.AllowUserToResizeColumns = false;
            this.dGV_Alumnos.AllowUserToResizeRows = false;
            this.dGV_Alumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre,
            this.Calificacion});
            this.dGV_Alumnos.Location = new System.Drawing.Point(6, 57);
            this.dGV_Alumnos.Name = "dGV_Alumnos";
            this.dGV_Alumnos.RowTemplate.Height = 24;
            this.dGV_Alumnos.Size = new System.Drawing.Size(461, 329);
            this.dGV_Alumnos.TabIndex = 46;
            this.dGV_Alumnos.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dGV_Alumnos_CellParsing);
            // 
            // tB_BusquedaAlu
            // 
            this.tB_BusquedaAlu.Location = new System.Drawing.Point(283, 23);
            this.tB_BusquedaAlu.Name = "tB_BusquedaAlu";
            this.tB_BusquedaAlu.Size = new System.Drawing.Size(184, 22);
            this.tB_BusquedaAlu.TabIndex = 45;
            this.tB_BusquedaAlu.TextChanged += new System.EventHandler(this.tB_BusquedaAlu_TextChanged);
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 94;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 87;
            // 
            // Calificacion
            // 
            this.Calificacion.DataPropertyName = "calificacion";
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Calificacion.Width = 108;
            // 
            // Inscripcion_Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 440);
            this.Controls.Add(this.gB_Alumnos);
            this.Controls.Add(this.gB_Grupos);
            this.Name = "Inscripcion_Grupos";
            this.Text = "Inscripcion_Grupos";
            this.Load += new System.EventHandler(this.Inscripcion_Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grupos)).EndInit();
            this.gB_Grupos.ResumeLayout(false);
            this.gB_Grupos.PerformLayout();
            this.gB_Alumnos.ResumeLayout(false);
            this.gB_Alumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Grupos;
        private System.Windows.Forms.GroupBox gB_Grupos;
        private System.Windows.Forms.Button btn_Lista;
        private System.Windows.Forms.TextBox tB_Busqueda;
        private System.Windows.Forms.GroupBox gB_Alumnos;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dGV_Alumnos;
        private System.Windows.Forms.TextBox tB_BusquedaAlu;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
    }
}