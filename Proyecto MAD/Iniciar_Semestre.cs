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
    public partial class Iniciar_Semestre : Form
    {
        
        private Guid editar;
        private string strEstado;
        public Iniciar_Semestre()
        {
         
            InitializeComponent();
        }
        private void updateWindow()
        {
            editar = Guid.Empty;
            strEstado = "Por Venir";
            btn_Registrar.Text = "Registrar";
            dGV_Consulta.DataSource = Global.DBManager.allSemesterAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;

            nUD_Minimo.Value = 1;
            nUD_Maximo.Value = 2;
            dTP_Inicio.MinDate = DateTime.Today;
            dTP_Inicio.Value = DateTime.Today;
            dTP_Final.Enabled = false;
        }

        private void Iniciar_Semestre_Load(object sender, EventArgs e)
        {
            updateWindow();
        }

        private void dTP_Inicio_ValueChanged(object sender, EventArgs e)
        {
            dTP_Final.MinDate = dTP_Inicio.Value;
            dTP_Final.Enabled = true;
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Consulta.DataSource = Global.DBManager.allSemesterAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;
            Global.searchInDataGridView(dGV_Consulta, tB_Busqueda.Text);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;

            if (dGV_Consulta.Rows[row].Cells[estado.Name].Value.ToString().CompareTo("Finalizado") != 0) { 
                btn_Registrar.Text = "Guardar";
                editar = Guid.Parse(dGV_Consulta.Rows[row].Cells[id.Name].Value.ToString());

                var result = Global.DBManager.oneSemesterAll(editar);

                nUD_Minimo.Value = result.creditos_min;
                nUD_Maximo.Value = result.creditos_max;
                dTP_Inicio.Value = new DateTime(result.fecha_inicio.Year, result.fecha_inicio.Month, result.fecha_inicio.Day);
                dTP_Final.Value = new DateTime(result.fecha_fin.Year, result.fecha_fin.Month, result.fecha_fin.Day);
                strEstado = result.estado;
            }
            else
            {
                MessageBox.Show("No se pueden modificar semestres ya finalizados");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;
            if (dGV_Consulta.Rows[row].Cells[estado.Name].Value.ToString().CompareTo("Finalizado") != 0)
            {
                if (MessageBox.Show("Está a punto de eliminar PERMANENTEMENTE el Semestre: \"" + dGV_Consulta.Rows[row].Cells[0].Value.ToString() + "\", ¿Está seguro que desea continuar?",
                                     "Confirmar eliminacion del Semestre",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Global.DBManager.deleteSemester(Guid.Parse(dGV_Consulta.Rows[row].Cells[id.Name].Value.ToString()));
                    //if (delete.Count != 0)
                    //{
                    //    MessageBox.Show(delete.Rows[0].Field<string>("ERROR"));
                    //}
                }
            }
            else
            {
                MessageBox.Show("No se pueden eliminar semestres ya finalizados");
            }
            updateWindow();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (dTP_Final.Enabled)
            {
                Global.DBManager.insertSemester((short)nUD_Minimo.Value, (short)nUD_Maximo.Value, dTP_Inicio.Value, dTP_Final.Value, editar, strEstado);
                updateWindow();
            }
            else
            {
                MessageBox.Show("Error: Seleccione un rango de fechas");
            }
        }
    }
}
