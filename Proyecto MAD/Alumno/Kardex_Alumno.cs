using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MAD
{
    public partial class Kardex_Alumno : Form
    {
        private int alumno;
        private bool _kardex;
        
        public Kardex_Alumno(int matricula, bool kardex = false)
        {
            alumno = matricula;
            _kardex = kardex;
         
            InitializeComponent();
        }

        private void Kardex_Alumno_Load(object sender, EventArgs e)
        {
            if (_kardex)
            {
                this.Text = "Kardex de " + alumno.ToString();
                dGV_Kardex.DataSource = Global.DBManager.studentKardex(alumno);
            }
            else
            {
                this.Text = "Forma de Evaluacion de " + alumno.ToString();
                dGV_Kardex.DataSource = Global.DBManager.studentKardex(alumno, Global.DBManager.thisSemester());
            }
            dGV_Kardex.Enabled = dGV_Kardex.Rows.Count != 0;
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory().ToString() + "\\Output\\Kardex" + alumno.ToString() + ".txt"))
            {
                file.WriteLine(dGV_Kardex.Rows[1].Cells[1].Value.ToString());
                for (int i = 2; i < dGV_Kardex.ColumnCount; i++)
                {
                   
                    file.Write(dGV_Kardex.Columns[i].Name + "\t\t");
                }
                file.WriteLine("");
                foreach (DataGridViewRow row in dGV_Kardex.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && i != 1)
                            file.Write(row.Cells[i].Value.ToString() + "\t");
                    }
                    file.WriteLine("");
                }
            }
            MessageBox.Show("Kardex exportado exitosamente");

        }
    }
}
