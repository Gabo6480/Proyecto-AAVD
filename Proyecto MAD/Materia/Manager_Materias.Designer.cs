namespace Proyecto_MAD
{
    partial class Manager_Materias
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_Clave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nUD_Nivel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.tB_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Alias = new System.Windows.Forms.TextBox();
            this.nUD_Horas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUD_Creditos = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_Descripcion = new System.Windows.Forms.TextBox();
            this.gB_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tB_Busqueda = new System.Windows.Forms.TextBox();
            this.dGV_Consulta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Creditos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gB_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Clave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nUD_Nivel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Registrar);
            this.groupBox1.Controls.Add(this.tB_Nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_Alias);
            this.groupBox1.Controls.Add(this.nUD_Horas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nUD_Creditos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta";
            // 
            // tB_Clave
            // 
            this.tB_Clave.Location = new System.Drawing.Point(58, 15);
            this.tB_Clave.MaxLength = 25;
            this.tB_Clave.Name = "tB_Clave";
            this.tB_Clave.Size = new System.Drawing.Size(81, 22);
            this.tB_Clave.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Clave";
            // 
            // nUD_Nivel
            // 
            this.nUD_Nivel.Location = new System.Drawing.Point(53, 44);
            this.nUD_Nivel.Name = "nUD_Nivel";
            this.nUD_Nivel.Size = new System.Drawing.Size(119, 22);
            this.nUD_Nivel.TabIndex = 32;
            this.nUD_Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre de la Materia";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(659, 15);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(110, 51);
            this.btn_Registrar.TabIndex = 31;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // tB_Nombre
            // 
            this.tB_Nombre.Location = new System.Drawing.Point(289, 15);
            this.tB_Nombre.MaxLength = 50;
            this.tB_Nombre.Name = "tB_Nombre";
            this.tB_Nombre.Size = new System.Drawing.Size(222, 22);
            this.tB_Nombre.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Medias horas por semana";
            // 
            // tB_Alias
            // 
            this.tB_Alias.Location = new System.Drawing.Point(561, 15);
            this.tB_Alias.MaxLength = 25;
            this.tB_Alias.Name = "tB_Alias";
            this.tB_Alias.Size = new System.Drawing.Size(81, 22);
            this.tB_Alias.TabIndex = 22;
            // 
            // nUD_Horas
            // 
            this.nUD_Horas.Location = new System.Drawing.Point(561, 44);
            this.nUD_Horas.Name = "nUD_Horas";
            this.nUD_Horas.Size = new System.Drawing.Size(81, 22);
            this.nUD_Horas.TabIndex = 29;
            this.nUD_Horas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Creditos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nivel";
            // 
            // nUD_Creditos
            // 
            this.nUD_Creditos.Location = new System.Drawing.Point(258, 44);
            this.nUD_Creditos.Name = "nUD_Creditos";
            this.nUD_Creditos.Size = new System.Drawing.Size(95, 22);
            this.nUD_Creditos.TabIndex = 27;
            this.nUD_Creditos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_Descripcion);
            this.groupBox2.Location = new System.Drawing.Point(5, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 88);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // tB_Descripcion
            // 
            this.tB_Descripcion.Location = new System.Drawing.Point(6, 21);
            this.tB_Descripcion.MaxLength = 255;
            this.tB_Descripcion.Multiline = true;
            this.tB_Descripcion.Name = "tB_Descripcion";
            this.tB_Descripcion.Size = new System.Drawing.Size(752, 60);
            this.tB_Descripcion.TabIndex = 3;
            // 
            // gB_Consulta
            // 
            this.gB_Consulta.Controls.Add(this.btn_Eliminar);
            this.gB_Consulta.Controls.Add(this.btn_Editar);
            this.gB_Consulta.Controls.Add(this.tB_Busqueda);
            this.gB_Consulta.Controls.Add(this.dGV_Consulta);
            this.gB_Consulta.Location = new System.Drawing.Point(13, 185);
            this.gB_Consulta.Name = "gB_Consulta";
            this.gB_Consulta.Size = new System.Drawing.Size(775, 253);
            this.gB_Consulta.TabIndex = 1;
            this.gB_Consulta.TabStop = false;
            this.gB_Consulta.Text = "Consulta";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(648, 213);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(121, 34);
            this.btn_Eliminar.TabIndex = 50;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(648, 133);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(121, 34);
            this.btn_Editar.TabIndex = 48;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // tB_Busqueda
            // 
            this.tB_Busqueda.Location = new System.Drawing.Point(648, 21);
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
            this.id});
            this.dGV_Consulta.Location = new System.Drawing.Point(6, 21);
            this.dGV_Consulta.Name = "dGV_Consulta";
            this.dGV_Consulta.ReadOnly = true;
            this.dGV_Consulta.RowTemplate.Height = 24;
            this.dGV_Consulta.Size = new System.Drawing.Size(636, 226);
            this.dGV_Consulta.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "uuid";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 64;
            // 
            // Manager_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 442);
            this.Controls.Add(this.gB_Consulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manager_Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Manager_Materias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Creditos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gB_Consulta.ResumeLayout(false);
            this.gB_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nUD_Nivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox tB_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Alias;
        private System.Windows.Forms.NumericUpDown nUD_Horas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUD_Creditos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_Descripcion;
        private System.Windows.Forms.GroupBox gB_Consulta;
        private System.Windows.Forms.DataGridView dGV_Consulta;
        private System.Windows.Forms.TextBox tB_Busqueda;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox tB_Clave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}