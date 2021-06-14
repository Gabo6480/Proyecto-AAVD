namespace Proyecto_MAD
{
    partial class CdE_Alumno_Select
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
            this.tB_Busqueda = new System.Windows.Forms.TextBox();
            this.dGV_Alumnos = new System.Windows.Forms.DataGridView();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_Busqueda
            // 
            this.tB_Busqueda.Location = new System.Drawing.Point(353, 12);
            this.tB_Busqueda.Name = "tB_Busqueda";
            this.tB_Busqueda.Size = new System.Drawing.Size(121, 22);
            this.tB_Busqueda.TabIndex = 63;
            this.tB_Busqueda.TextChanged += new System.EventHandler(this.tB_Busqueda_TextChanged);
            // 
            // dGV_Alumnos
            // 
            this.dGV_Alumnos.AllowUserToAddRows = false;
            this.dGV_Alumnos.AllowUserToResizeColumns = false;
            this.dGV_Alumnos.AllowUserToResizeRows = false;
            this.dGV_Alumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre});
            this.dGV_Alumnos.Location = new System.Drawing.Point(13, 40);
            this.dGV_Alumnos.Name = "dGV_Alumnos";
            this.dGV_Alumnos.RowTemplate.Height = 24;
            this.dGV_Alumnos.Size = new System.Drawing.Size(461, 331);
            this.dGV_Alumnos.TabIndex = 61;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(13, 377);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(461, 36);
            this.btn_Seleccionar.TabIndex = 60;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
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
            // CdE_Alumno_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 420);
            this.Controls.Add(this.tB_Busqueda);
            this.Controls.Add(this.dGV_Alumnos);
            this.Controls.Add(this.btn_Seleccionar);
            this.Name = "CdE_Alumno_Select";
            this.Text = "CdE_Alumno_Select";
            this.Load += new System.EventHandler(this.CdE_Alumno_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_Busqueda;
        private System.Windows.Forms.DataGridView dGV_Alumnos;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}