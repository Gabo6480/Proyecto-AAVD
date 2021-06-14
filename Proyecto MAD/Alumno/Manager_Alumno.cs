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
    public partial class Dar_Alta_Alumno : Form
    {
        
        private int editar;
        private int lastMatr = 100000;
        public Dar_Alta_Alumno()
        {
            editar = 0;
         
            InitializeComponent();
        }

        private void updateWindow()
        {
            editar = 0;
            btn_Registrar.Text = "Registrar";
            dGV_Consulta.DataSource = Global.DBManager.allStudentAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;
            foreach (alumno alumno in Global.DBManager.allStudentAll())
            {
                lastMatr = alumno.matricula >= lastMatr ? alumno.matricula + 1 : lastMatr;
            }

            tB_Nombre.Text = "";
            tB_ApPaterno.Text = "";
            tB_ApMaterno.Text = "";
            rB_Hombre.Checked = false;
            rB_Mujer.Checked = false;
            dTP_Nacimiento.Value = DateTime.Today;
            cB_Carrera.SelectedIndex = -1;
            cB_Pais.SelectedIndex = -1;
        }

        private void Dar_Alta_Alumno_Load(object sender, EventArgs e)
        {
            dTP_Nacimiento.MaxDate = DateTime.Today;
            cB_Carrera.ValueMember = "id";
            cB_Carrera.DisplayMember = "nombre";
            cB_Carrera.DataSource = Global.DBManager.allCareersAll();

            //Aquí se tiene que cargar la lista de paises
            cB_Pais.DisplayMember = "nombre";
            cB_Pais.DataSource = Global.DBManager.allCountryNames();

            if (cB_Carrera.Items.Count == 0)
            {
                MessageBox.Show("No hay registros de Carreras en la base de datos");
                this.Close();
            }
            if(cB_Pais.Items.Count == 0)
            {
                MessageBox.Show("No hay registros de Paises en la base de datos");
                this.Close();
            }
            updateWindow();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (cB_Pais.Text.ToString().Length != 0)
            {
                if (cB_Carrera.Text.ToString().Length != 0)
                {
                    if (rB_Hombre.Checked || rB_Mujer.Checked)
                    {
                        if (!Global.DBManager.insertStudent(tB_Nombre.Text.Trim(), tB_ApPaterno.Text.Trim(), tB_ApMaterno.Text.Trim(), dTP_Nacimiento.Value, cB_Carrera.Text.Trim(), cB_Pais.Text.Trim(), editar != 0 ? editar : lastMatr, editar != 0, rB_Hombre.Checked))
                        {
                            MessageBox.Show("Error: UvU");
                        }
                        else
                        {
                            updateWindow();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Seleccione un Genero");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Seleccione una Carrera");
                }
            }
            else
            {
                MessageBox.Show("Error: Seleccione un Pais");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Registrar.Text = "Guardar";

            int row = dGV_Consulta.CurrentCell.RowIndex;
            editar = (int)dGV_Consulta.Rows[row].Cells[0].Value;

            var result = Global.DBManager.oneStudentAll(editar);

            tB_Nombre.Text = result.nombre;
            tB_ApPaterno.Text = result.apellido_pat;
            tB_ApMaterno.Text = result.apellido_mat;
            rB_Hombre.Checked = result.genero;
            rB_Mujer.Checked = !rB_Hombre.Checked;
            dTP_Nacimiento.Value = new DateTime(result.fecha_naci.Year, result.fecha_naci.Month, result.fecha_naci.Day);
            cB_Carrera.SelectedIndex = cB_Carrera.FindStringExact(result.carrera);
            if(cB_Carrera.SelectedIndex < 0)
            {
                cB_Carrera.Text = result.carrera;
            }
            cB_Pais.SelectedIndex = cB_Pais.FindStringExact(result.pais);
            if (cB_Pais.SelectedIndex < 0)
            {
                cB_Pais.Text = result.pais;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;

            if (MessageBox.Show("Está a punto de eliminar PERMANENTEMENTE al Alumno: \"" + dGV_Consulta.Rows[row].Cells[1].Value.ToString() + "\", ¿Está seguro que desea continuar?",
                                     "Confirmar eliminacion de Alumno",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.DBManager.deleteStudent((int)dGV_Consulta.Rows[row].Cells[0].Value);
            }
            updateWindow();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Consulta.DataSource = Global.DBManager.allStudentAll();
            btn_Editar.Enabled = dGV_Consulta.RowCount != 0;
            btn_Eliminar.Enabled = dGV_Consulta.RowCount != 0;
            Global.searchInDataGridView(dGV_Consulta, tB_Busqueda.Text);
        }
    }
}
