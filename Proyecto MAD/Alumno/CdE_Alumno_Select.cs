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
    public partial class CdE_Alumno_Select : Form
    {
        
        private bool _kardex;
        public CdE_Alumno_Select(bool kardex = false)
        {
         
            _kardex = kardex;
            InitializeComponent();
        }

        private void CdE_Alumno_Select_Load(object sender, EventArgs e)
        {
            dGV_Alumnos.AutoGenerateColumns = false;
            dGV_Alumnos.DataSource = Global.DBManager.allStudentAll();
            dGV_Alumnos.Enabled = dGV_Alumnos.Rows.Count != 0;
            if (!dGV_Alumnos.Enabled)
            {
                MessageBox.Show("No hay alumnos en la base de datos");
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            int row = dGV_Alumnos.CurrentCell.RowIndex;
            int select = (int)dGV_Alumnos.Rows[row].Cells[Matricula.Name].Value;
           
            new Kardex_Alumno(select,_kardex).ShowDialog();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Alumnos.AutoGenerateColumns = false;
            dGV_Alumnos.DataSource = Global.DBManager.allStudentAll();
            dGV_Alumnos.Enabled = dGV_Alumnos.RowCount != 0;
            Global.searchInDataGridView(dGV_Alumnos, tB_Busqueda.Text);
        }
    }
}
