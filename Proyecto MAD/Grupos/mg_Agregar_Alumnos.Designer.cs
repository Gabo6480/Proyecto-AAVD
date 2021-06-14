namespace Proyecto_MAD
{
    partial class mg_Agregar_Alumnos
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dGV_Alumnos = new System.Windows.Forms.DataGridView();
            this.tB_Busqueda = new System.Windows.Forms.TextBox();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(14, 389);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(461, 36);
            this.btn_Agregar.TabIndex = 56;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dGV_Alumnos
            // 
            this.dGV_Alumnos.AllowUserToAddRows = false;
            this.dGV_Alumnos.AllowUserToResizeColumns = false;
            this.dGV_Alumnos.AllowUserToResizeRows = false;
            this.dGV_Alumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.Matricula,
            this.Nombre});
            this.dGV_Alumnos.Location = new System.Drawing.Point(14, 52);
            this.dGV_Alumnos.Name = "dGV_Alumnos";
            this.dGV_Alumnos.RowTemplate.Height = 24;
            this.dGV_Alumnos.Size = new System.Drawing.Size(461, 331);
            this.dGV_Alumnos.TabIndex = 57;
            // 
            // tB_Busqueda
            // 
            this.tB_Busqueda.Location = new System.Drawing.Point(354, 24);
            this.tB_Busqueda.Name = "tB_Busqueda";
            this.tB_Busqueda.Size = new System.Drawing.Size(121, 22);
            this.tB_Busqueda.TabIndex = 59;
            this.tB_Busqueda.TextChanged += new System.EventHandler(this.tB_Busqueda_TextChanged);
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "Agregar";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 65;
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
            // mg_Agregar_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 438);
            this.Controls.Add(this.tB_Busqueda);
            this.Controls.Add(this.dGV_Alumnos);
            this.Controls.Add(this.btn_Agregar);
            this.Name = "mg_Agregar_Alumnos";
            this.Text = "mg_Agregar_Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dGV_Alumnos;
        private System.Windows.Forms.TextBox tB_Busqueda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}