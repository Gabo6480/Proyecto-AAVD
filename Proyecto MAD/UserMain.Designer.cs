namespace Proyecto_MAD
{
    partial class UserMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeEvaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.gruposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirAlumnoToolStripMenuItem,
            this.kardexDeAlumnoToolStripMenuItem,
            this.consultaDeEvaluacionToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // inscribirAlumnoToolStripMenuItem
            // 
            this.inscribirAlumnoToolStripMenuItem.Name = "inscribirAlumnoToolStripMenuItem";
            this.inscribirAlumnoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.inscribirAlumnoToolStripMenuItem.Text = "Inscribir Alumno";
            this.inscribirAlumnoToolStripMenuItem.Click += new System.EventHandler(this.inscribirAlumnoToolStripMenuItem_Click);
            // 
            // kardexDeAlumnoToolStripMenuItem
            // 
            this.kardexDeAlumnoToolStripMenuItem.Name = "kardexDeAlumnoToolStripMenuItem";
            this.kardexDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.kardexDeAlumnoToolStripMenuItem.Text = "Kardex de Alumno";
            this.kardexDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.kardexDeAlumnoToolStripMenuItem_Click);
            // 
            // consultaDeEvaluacionToolStripMenuItem
            // 
            this.consultaDeEvaluacionToolStripMenuItem.Name = "consultaDeEvaluacionToolStripMenuItem";
            this.consultaDeEvaluacionToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.consultaDeEvaluacionToolStripMenuItem.Text = "Consulta de Evaluacion";
            this.consultaDeEvaluacionToolStripMenuItem.Click += new System.EventHandler(this.consultaDeEvaluacionToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.inscripcionesToolStripMenuItem});
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeEvaluacionToolStripMenuItem;
    }
}