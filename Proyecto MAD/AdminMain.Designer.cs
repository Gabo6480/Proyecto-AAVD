namespace Proyecto_MAD
{
    partial class AdminMain
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
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declararSemestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSemestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSemestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMaestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semestreToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // semestreToolStripMenuItem
            // 
            this.semestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.declararSemestresToolStripMenuItem,
            this.iniciarSemestreToolStripMenuItem,
            this.terminarSemestreToolStripMenuItem});
            this.semestreToolStripMenuItem.Name = "semestreToolStripMenuItem";
            this.semestreToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.semestreToolStripMenuItem.Text = "Semestre";
            // 
            // declararSemestresToolStripMenuItem
            // 
            this.declararSemestresToolStripMenuItem.Name = "declararSemestresToolStripMenuItem";
            this.declararSemestresToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.declararSemestresToolStripMenuItem.Text = "Declarar Semestres";
            this.declararSemestresToolStripMenuItem.Click += new System.EventHandler(this.declararSemestresToolStripMenuItem_Click);
            // 
            // iniciarSemestreToolStripMenuItem
            // 
            this.iniciarSemestreToolStripMenuItem.Name = "iniciarSemestreToolStripMenuItem";
            this.iniciarSemestreToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.iniciarSemestreToolStripMenuItem.Text = "Iniciar Proximo Semestre";
            this.iniciarSemestreToolStripMenuItem.Click += new System.EventHandler(this.iniciarSemestreToolStripMenuItem_Click);
            // 
            // terminarSemestreToolStripMenuItem
            // 
            this.terminarSemestreToolStripMenuItem.Name = "terminarSemestreToolStripMenuItem";
            this.terminarSemestreToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.terminarSemestreToolStripMenuItem.Text = "Terminar Semestre";
            this.terminarSemestreToolStripMenuItem.Click += new System.EventHandler(this.terminarSemestreToolStripMenuItem_Click);
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem,
            this.carrerasToolStripMenuItem});
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.carreraToolStripMenuItem.Text = "Carrera";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.materiasToolStripMenuItem.Text = "Materias...";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.carrerasToolStripMenuItem.Text = "Carreras...";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinadoresToolStripMenuItem,
            this.maestrosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.usuariosToolStripMenuItem.Text = "Subordinados";
            // 
            // coordinadoresToolStripMenuItem
            // 
            this.coordinadoresToolStripMenuItem.Name = "coordinadoresToolStripMenuItem";
            this.coordinadoresToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.coordinadoresToolStripMenuItem.Text = "Coordinadores...";
            this.coordinadoresToolStripMenuItem.Click += new System.EventHandler(this.coordinadoresToolStripMenuItem_Click);
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoMaestroToolStripMenuItem});
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.maestrosToolStripMenuItem.Text = "Maestros...";
            // 
            // nuevoMaestroToolStripMenuItem
            // 
            this.nuevoMaestroToolStripMenuItem.Name = "nuevoMaestroToolStripMenuItem";
            this.nuevoMaestroToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.nuevoMaestroToolStripMenuItem.Text = "Nuevo Maestro";
            this.nuevoMaestroToolStripMenuItem.Click += new System.EventHandler(this.nuevoMaestroToolStripMenuItem_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMaestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSemestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSemestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declararSemestresToolStripMenuItem;
    }
}