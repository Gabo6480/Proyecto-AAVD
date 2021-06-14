namespace Proyecto_MAD
{
    partial class Kardex_Alumno
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
            this.dGV_Kardex = new System.Windows.Forms.DataGridView();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kardex)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Kardex
            // 
            this.dGV_Kardex.AllowUserToAddRows = false;
            this.dGV_Kardex.AllowUserToDeleteRows = false;
            this.dGV_Kardex.AllowUserToResizeColumns = false;
            this.dGV_Kardex.AllowUserToResizeRows = false;
            this.dGV_Kardex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Kardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Kardex.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Kardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dGV_Kardex.Location = new System.Drawing.Point(12, 12);
            this.dGV_Kardex.Name = "dGV_Kardex";
            this.dGV_Kardex.ReadOnly = true;
            this.dGV_Kardex.RowTemplate.Height = 24;
            this.dGV_Kardex.Size = new System.Drawing.Size(395, 379);
            this.dGV_Kardex.TabIndex = 3;
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(12, 404);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(395, 34);
            this.btn_Exportar.TabIndex = 49;
            this.btn_Exportar.Text = "Exportar a archivo de Texto";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
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
            // Kardex_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.dGV_Kardex);
            this.Name = "Kardex_Alumno";
            this.Text = "Kardex_Alumno";
            this.Load += new System.EventHandler(this.Kardex_Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kardex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Kardex;
        private System.Windows.Forms.Button btn_Exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}