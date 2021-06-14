namespace Proyecto_MAD
{
    partial class Dar_Alta_Coordinadores
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
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.tB_Usuario = new System.Windows.Forms.TextBox();
            this.tB_Contraseña = new System.Windows.Forms.TextBox();
            this.tB_ConVericicacion = new System.Windows.Forms.TextBox();
            this.tB_Nombre = new System.Windows.Forms.TextBox();
            this.tB_ApPaterno = new System.Windows.Forms.TextBox();
            this.tB_ApMaterno = new System.Windows.Forms.TextBox();
            this.cB_Carrera = new System.Windows.Forms.ComboBox();
            this.dTP_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.tB_Nomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gB_Usuario = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rB_Hombre = new System.Windows.Forms.RadioButton();
            this.rB_Mujer = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gB_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tB_Busqueda = new System.Windows.Forms.TextBox();
            this.dGV_Consulta = new System.Windows.Forms.DataGridView();
            this.gB_Usuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gB_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(469, 121);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(236, 45);
            this.btn_Registrar.TabIndex = 0;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // tB_Usuario
            // 
            this.tB_Usuario.Location = new System.Drawing.Point(128, 15);
            this.tB_Usuario.MaxLength = 50;
            this.tB_Usuario.Name = "tB_Usuario";
            this.tB_Usuario.Size = new System.Drawing.Size(100, 22);
            this.tB_Usuario.TabIndex = 1;
            // 
            // tB_Contraseña
            // 
            this.tB_Contraseña.Location = new System.Drawing.Point(128, 43);
            this.tB_Contraseña.MaxLength = 50;
            this.tB_Contraseña.Name = "tB_Contraseña";
            this.tB_Contraseña.PasswordChar = '*';
            this.tB_Contraseña.Size = new System.Drawing.Size(100, 22);
            this.tB_Contraseña.TabIndex = 2;
            this.tB_Contraseña.TextChanged += new System.EventHandler(this.tB_Contraseña_TextChanged);
            // 
            // tB_ConVericicacion
            // 
            this.tB_ConVericicacion.Location = new System.Drawing.Point(128, 71);
            this.tB_ConVericicacion.MaxLength = 50;
            this.tB_ConVericicacion.Name = "tB_ConVericicacion";
            this.tB_ConVericicacion.PasswordChar = '*';
            this.tB_ConVericicacion.Size = new System.Drawing.Size(100, 22);
            this.tB_ConVericicacion.TabIndex = 3;
            // 
            // tB_Nombre
            // 
            this.tB_Nombre.Location = new System.Drawing.Point(13, 29);
            this.tB_Nombre.MaxLength = 25;
            this.tB_Nombre.Name = "tB_Nombre";
            this.tB_Nombre.Size = new System.Drawing.Size(146, 22);
            this.tB_Nombre.TabIndex = 4;
            // 
            // tB_ApPaterno
            // 
            this.tB_ApPaterno.Location = new System.Drawing.Point(165, 29);
            this.tB_ApPaterno.MaxLength = 25;
            this.tB_ApPaterno.Name = "tB_ApPaterno";
            this.tB_ApPaterno.Size = new System.Drawing.Size(146, 22);
            this.tB_ApPaterno.TabIndex = 5;
            // 
            // tB_ApMaterno
            // 
            this.tB_ApMaterno.Location = new System.Drawing.Point(317, 29);
            this.tB_ApMaterno.MaxLength = 25;
            this.tB_ApMaterno.Name = "tB_ApMaterno";
            this.tB_ApMaterno.Size = new System.Drawing.Size(146, 22);
            this.tB_ApMaterno.TabIndex = 6;
            // 
            // cB_Carrera
            // 
            this.cB_Carrera.FormattingEnabled = true;
            this.cB_Carrera.Location = new System.Drawing.Point(177, 85);
            this.cB_Carrera.Name = "cB_Carrera";
            this.cB_Carrera.Size = new System.Drawing.Size(191, 24);
            this.cB_Carrera.TabIndex = 7;
            // 
            // dTP_Nacimiento
            // 
            this.dTP_Nacimiento.Location = new System.Drawing.Point(158, 116);
            this.dTP_Nacimiento.Name = "dTP_Nacimiento";
            this.dTP_Nacimiento.Size = new System.Drawing.Size(210, 22);
            this.dTP_Nacimiento.TabIndex = 8;
            // 
            // tB_Nomina
            // 
            this.tB_Nomina.Location = new System.Drawing.Point(149, 57);
            this.tB_Nomina.MaxLength = 25;
            this.tB_Nomina.Name = "tB_Nomina";
            this.tB_Nomina.Size = new System.Drawing.Size(219, 22);
            this.tB_Nomina.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clave de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // tB_Titulo
            // 
            this.tB_Titulo.Location = new System.Drawing.Point(142, 144);
            this.tB_Titulo.MaxLength = 50;
            this.tB_Titulo.Name = "tB_Titulo";
            this.tB_Titulo.Size = new System.Drawing.Size(321, 22);
            this.tB_Titulo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Verificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre/s                       Apellido Paterno           Apellido Materno";
            // 
            // gB_Usuario
            // 
            this.gB_Usuario.Controls.Add(this.tB_ConVericicacion);
            this.gB_Usuario.Controls.Add(this.tB_Usuario);
            this.gB_Usuario.Controls.Add(this.label3);
            this.gB_Usuario.Controls.Add(this.tB_Contraseña);
            this.gB_Usuario.Controls.Add(this.label1);
            this.gB_Usuario.Controls.Add(this.label2);
            this.gB_Usuario.Location = new System.Drawing.Point(469, 12);
            this.gB_Usuario.Name = "gB_Usuario";
            this.gB_Usuario.Size = new System.Drawing.Size(236, 103);
            this.gB_Usuario.TabIndex = 1;
            this.gB_Usuario.TabStop = false;
            this.gB_Usuario.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Número de Nómina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Carrera que Coordinará";
            // 
            // rB_Hombre
            // 
            this.rB_Hombre.AutoSize = true;
            this.rB_Hombre.Location = new System.Drawing.Point(6, 21);
            this.rB_Hombre.Name = "rB_Hombre";
            this.rB_Hombre.Size = new System.Drawing.Size(79, 21);
            this.rB_Hombre.TabIndex = 21;
            this.rB_Hombre.TabStop = true;
            this.rB_Hombre.Text = "Hombre";
            this.rB_Hombre.UseVisualStyleBackColor = true;
            // 
            // rB_Mujer
            // 
            this.rB_Mujer.AutoSize = true;
            this.rB_Mujer.Location = new System.Drawing.Point(6, 58);
            this.rB_Mujer.Name = "rB_Mujer";
            this.rB_Mujer.Size = new System.Drawing.Size(64, 21);
            this.rB_Mujer.TabIndex = 22;
            this.rB_Mujer.TabStop = true;
            this.rB_Mujer.Text = "Mujer";
            this.rB_Mujer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rB_Mujer);
            this.groupBox2.Controls.Add(this.rB_Hombre);
            this.groupBox2.Location = new System.Drawing.Point(373, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 85);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Título universitario";
            // 
            // gB_Consulta
            // 
            this.gB_Consulta.Controls.Add(this.btn_Eliminar);
            this.gB_Consulta.Controls.Add(this.btn_Editar);
            this.gB_Consulta.Controls.Add(this.tB_Busqueda);
            this.gB_Consulta.Controls.Add(this.dGV_Consulta);
            this.gB_Consulta.Location = new System.Drawing.Point(16, 172);
            this.gB_Consulta.Name = "gB_Consulta";
            this.gB_Consulta.Size = new System.Drawing.Size(689, 253);
            this.gB_Consulta.TabIndex = 38;
            this.gB_Consulta.TabStop = false;
            this.gB_Consulta.Text = "Consulta";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(560, 213);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(121, 34);
            this.btn_Eliminar.TabIndex = 50;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(560, 133);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(121, 34);
            this.btn_Editar.TabIndex = 48;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // tB_Busqueda
            // 
            this.tB_Busqueda.Location = new System.Drawing.Point(560, 21);
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
            this.dGV_Consulta.Location = new System.Drawing.Point(6, 21);
            this.dGV_Consulta.Name = "dGV_Consulta";
            this.dGV_Consulta.ReadOnly = true;
            this.dGV_Consulta.RowTemplate.Height = 24;
            this.dGV_Consulta.Size = new System.Drawing.Size(548, 226);
            this.dGV_Consulta.TabIndex = 2;
            // 
            // Dar_Alta_Coordinadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 428);
            this.Controls.Add(this.gB_Consulta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gB_Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_Titulo);
            this.Controls.Add(this.tB_Nomina);
            this.Controls.Add(this.dTP_Nacimiento);
            this.Controls.Add(this.cB_Carrera);
            this.Controls.Add(this.tB_ApMaterno);
            this.Controls.Add(this.tB_ApPaterno);
            this.Controls.Add(this.tB_Nombre);
            this.Controls.Add(this.btn_Registrar);
            this.Name = "Dar_Alta_Coordinadores";
            this.Text = "Dar de alta a Coordinador";
            this.Load += new System.EventHandler(this.Dar_Alta_Coordinadores_Load);
            this.gB_Usuario.ResumeLayout(false);
            this.gB_Usuario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gB_Consulta.ResumeLayout(false);
            this.gB_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox tB_Usuario;
        private System.Windows.Forms.TextBox tB_Contraseña;
        private System.Windows.Forms.TextBox tB_ConVericicacion;
        private System.Windows.Forms.TextBox tB_Nombre;
        private System.Windows.Forms.TextBox tB_ApPaterno;
        private System.Windows.Forms.TextBox tB_ApMaterno;
        private System.Windows.Forms.ComboBox cB_Carrera;
        private System.Windows.Forms.DateTimePicker dTP_Nacimiento;
        private System.Windows.Forms.TextBox tB_Nomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gB_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rB_Hombre;
        private System.Windows.Forms.RadioButton rB_Mujer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gB_Consulta;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox tB_Busqueda;
        private System.Windows.Forms.DataGridView dGV_Consulta;
    }
}