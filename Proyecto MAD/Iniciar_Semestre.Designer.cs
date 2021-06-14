namespace Proyecto_MAD
{
    partial class Iniciar_Semestre
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
            this.nUD_Minimo = new System.Windows.Forms.NumericUpDown();
            this.nUD_Maximo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gB_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tB_Busqueda = new System.Windows.Forms.TextBox();
            this.dGV_Consulta = new System.Windows.Forms.DataGridView();
            this.dTP_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTP_Final = new System.Windows.Forms.DateTimePicker();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Minimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Maximo)).BeginInit();
            this.gB_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD_Minimo
            // 
            this.nUD_Minimo.Location = new System.Drawing.Point(18, 87);
            this.nUD_Minimo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Minimo.Name = "nUD_Minimo";
            this.nUD_Minimo.Size = new System.Drawing.Size(120, 22);
            this.nUD_Minimo.TabIndex = 1;
            this.nUD_Minimo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUD_Maximo
            // 
            this.nUD_Maximo.Location = new System.Drawing.Point(158, 87);
            this.nUD_Maximo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Maximo.Name = "nUD_Maximo";
            this.nUD_Maximo.Size = new System.Drawing.Size(120, 22);
            this.nUD_Maximo.TabIndex = 1;
            this.nUD_Maximo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creditos Minimos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creditos Maximos";
            // 
            // gB_Consulta
            // 
            this.gB_Consulta.Controls.Add(this.btn_Eliminar);
            this.gB_Consulta.Controls.Add(this.btn_Editar);
            this.gB_Consulta.Controls.Add(this.tB_Busqueda);
            this.gB_Consulta.Controls.Add(this.dGV_Consulta);
            this.gB_Consulta.Location = new System.Drawing.Point(12, 121);
            this.gB_Consulta.Name = "gB_Consulta";
            this.gB_Consulta.Size = new System.Drawing.Size(554, 253);
            this.gB_Consulta.TabIndex = 49;
            this.gB_Consulta.TabStop = false;
            this.gB_Consulta.Text = "Consulta";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(427, 213);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(121, 34);
            this.btn_Eliminar.TabIndex = 50;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(427, 173);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(121, 34);
            this.btn_Editar.TabIndex = 48;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // tB_Busqueda
            // 
            this.tB_Busqueda.Location = new System.Drawing.Point(427, 21);
            this.tB_Busqueda.Name = "tB_Busqueda";
            this.tB_Busqueda.Size = new System.Drawing.Size(121, 22);
            this.tB_Busqueda.TabIndex = 47;
            this.tB_Busqueda.TextChanged += new System.EventHandler(this.tB_Busqueda_TextChanged);
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
            this.id,
            this.estado});
            this.dGV_Consulta.Location = new System.Drawing.Point(6, 21);
            this.dGV_Consulta.Name = "dGV_Consulta";
            this.dGV_Consulta.ReadOnly = true;
            this.dGV_Consulta.RowTemplate.Height = 24;
            this.dGV_Consulta.Size = new System.Drawing.Size(415, 226);
            this.dGV_Consulta.TabIndex = 2;
            // 
            // dTP_Inicio
            // 
            this.dTP_Inicio.Location = new System.Drawing.Point(15, 29);
            this.dTP_Inicio.Name = "dTP_Inicio";
            this.dTP_Inicio.Size = new System.Drawing.Size(272, 22);
            this.dTP_Inicio.TabIndex = 50;
            this.dTP_Inicio.ValueChanged += new System.EventHandler(this.dTP_Inicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha de Finalización:";
            // 
            // dTP_Final
            // 
            this.dTP_Final.Location = new System.Drawing.Point(293, 29);
            this.dTP_Final.Name = "dTP_Final";
            this.dTP_Final.Size = new System.Drawing.Size(273, 22);
            this.dTP_Final.TabIndex = 52;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(312, 80);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(254, 34);
            this.btn_Registrar.TabIndex = 51;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
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
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado.Width = 58;
            // 
            // Iniciar_Semestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTP_Final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTP_Inicio);
            this.Controls.Add(this.gB_Consulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUD_Maximo);
            this.Controls.Add(this.nUD_Minimo);
            this.Name = "Iniciar_Semestre";
            this.Text = "Iniciar_Semestre";
            this.Load += new System.EventHandler(this.Iniciar_Semestre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Minimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Maximo)).EndInit();
            this.gB_Consulta.ResumeLayout(false);
            this.gB_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD_Minimo;
        private System.Windows.Forms.NumericUpDown nUD_Maximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gB_Consulta;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox tB_Busqueda;
        private System.Windows.Forms.DataGridView dGV_Consulta;
        private System.Windows.Forms.DateTimePicker dTP_Inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTP_Final;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}