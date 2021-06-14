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
    public partial class Dar_Alta_Maestro : Form
    {
        private int editar;
        private int maestro;
        private int lastMatr = 10000;
        
        public Dar_Alta_Maestro()
        {
         
            InitializeComponent();
        }

        private void updateWindow()
        {
            dGV_Consulta.AutoGenerateColumns = false;
            dGV_Consulta.DataSource = Global.DBManager.allTeachersAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;
            foreach (maestro maestro in Global.DBManager.allTeachersAll())
            {
                lastMatr = maestro.matricula >= lastMatr ? maestro.matricula + 1 : lastMatr;
            }
            editar = 0;

            btn_Registrar.Text = "Registrar";

            tB_Nombre.Text = "";
            tB_ApPaterno.Text = "";
            tB_ApMaterno.Text = "";
            rB_Hombre.Checked = false;
            rB_Mujer.Checked = false;
            dTP_Nacimiento.Value = DateTime.Today;
            tB_Nomina.Text = "";
            tB_Titulo.Text = "";

            dGV_Materias.DataSource = null;
            dGV_Materias.Rows.Clear();
            gB_Materias.Text = "Materias";
            gB_Materias.Enabled = false;
            maestro = 0;
        }

        private void Dar_Alta_Maestro_Load(object sender, EventArgs e)
        {
            dTP_Nacimiento.MaxDate = DateTime.Today;
            updateWindow();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (rB_Hombre.Checked || rB_Mujer.Checked)
            {
                //Checamos primero si hay algo checado
                Global.DBManager.insertTeacher(tB_Nombre.Text.Trim(), tB_ApPaterno.Text.Trim(), tB_ApMaterno.Text.Trim(), dTP_Nacimiento.Value,tB_Nomina.Text.Trim(),tB_Titulo.Text.Trim(), rB_Hombre.Checked,editar,lastMatr);
                updateWindow();
                
            }
            else
            {
                MessageBox.Show("Error: Seleccione un genero");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Registrar.Text = "Guardar";

            int row = dGV_Consulta.CurrentCell.RowIndex;
            editar = (int)dGV_Consulta.Rows[row].Cells[0].Value;

            var result = Global.DBManager.oneTeacherAll(editar);

            tB_Nombre.Text = result.nombre;
            tB_ApPaterno.Text = result.apellido_pat;
            tB_ApMaterno.Text = result.apellido_mat;
            dTP_Nacimiento.Value = new DateTime(result.fecha_naci.Year, result.fecha_naci.Month, result.fecha_naci.Day);
            rB_Hombre.Checked = result.genero;
            rB_Mujer.Checked = !rB_Hombre.Checked;
            tB_Nomina.Text = result.num_nomina;
            tB_Titulo.Text = result.titulo;
        }

        private void btn_Materias_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;
            gB_Materias.Text = "Materias que enseña " + dGV_Consulta.Rows[row].Cells[0].Value.ToString();
            maestro = (int)dGV_Consulta.Rows[row].Cells[0].Value;
            var source = Global.DBManager.teacherSubjects(maestro);
            dGV_Materias.DataSource = source != null ? source.ToList() : null;
            gB_Materias.Enabled = true;
            btn_Remover.Enabled = dGV_Materias.RowCount != 0;
            tB_BusquedaMat.Enabled = dGV_Materias.RowCount != 0;
            dGV_Materias.Enabled = dGV_Materias.RowCount != 0;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;

            if (MessageBox.Show("Está a punto de eliminar PERMANENTEMENTE al Maestro: \"" + dGV_Consulta.Rows[row].Cells[1].Value.ToString() + "\", ¿Está seguro que desea continuar?",
                                     "Confirmar eliminacion de Maestro",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.DBManager.deleteTeacher((int)dGV_Consulta.Rows[row].Cells[0].Value);
                //if(result.Rows.Count != 0)
                //{
                //    MessageBox.Show(result.Rows[0].Field<string>("ERROR"));
                //}
            }
            updateWindow();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            new mM_Agregar_Materias(maestro,false).ShowDialog();
            updateWindow();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            new mM_Agregar_Materias(maestro, true).ShowDialog();
            updateWindow();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Consulta.DataSource = Global.DBManager.allTeachersAll();
            btn_Editar.Enabled = dGV_Consulta.RowCount != 0;
            btn_Eliminar.Enabled = dGV_Consulta.RowCount != 0;
            btn_Materias.Enabled = dGV_Consulta.RowCount != 0;
            Global.searchInDataGridView(dGV_Consulta, tB_Busqueda.Text);
        }

        private void tB_BusquedaMat_TextChanged(object sender, EventArgs e)
        {
            dGV_Materias.DataSource = Global.DBManager.teacherSubjects( maestro);
            Global.searchInDataGridView(dGV_Materias, tB_BusquedaMat.Text);
        }
    }
}
