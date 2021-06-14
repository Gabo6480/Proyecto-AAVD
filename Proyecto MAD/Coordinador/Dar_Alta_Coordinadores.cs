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
    public partial class Dar_Alta_Coordinadores : Form
    {
        
        private string editar;
        public Dar_Alta_Coordinadores()
        {
         
            editar = "";
            InitializeComponent();
        }

        private void updateWindow()
        {
            tB_Usuario.Text = "";
            tB_Contraseña.Text = "";
            tB_ConVericicacion.Text = "";

            tB_Nombre.Text = "";
            tB_ApPaterno.Text = "";
            tB_ApMaterno.Text = "";
            rB_Hombre.Checked = false;
            rB_Mujer.Checked = false;
            dTP_Nacimiento.Value = DateTime.Today;
            tB_Nomina.Text = "";
            tB_Titulo.Text = "";

            editar = "";
            tB_ConVericicacion.Enabled = false;

            cB_Carrera.DataSource = Global.DBManager.allCareersAll();
            cB_Carrera.DisplayMember = "nombre";
            cB_Carrera.Enabled = cB_Carrera.Items.Count != 0;
            cB_Carrera.Text = "";

            dGV_Consulta.DataSource = Global.DBManager.allCoordsAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;
            btn_Registrar.Text = "Registrar";

            gB_Usuario.Enabled = true;
        }

        private void tB_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (tB_Contraseña.TextLength != 0)
            {
                tB_ConVericicacion.Enabled = true;
            }
            else
            {
                tB_ConVericicacion.Enabled = false;
            }
        }

        private void Dar_Alta_Coordinadores_Load(object sender, EventArgs e)
        {
            dTP_Nacimiento.MaxDate = DateTime.Today;
            tB_ConVericicacion.Enabled = false;
            updateWindow();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if(tB_Contraseña.ToString().CompareTo(tB_ConVericicacion.ToString()) != 0)
            {
                MessageBox.Show("Error: Las contraseñas no coinciden");
            }
            else
            {
                if (cB_Carrera.Text.ToString().Length != 0)
                {
                    if (rB_Hombre.Checked || rB_Mujer.Checked)
                    {
                        if (!Global.DBManager.insertCoordinator(tB_Nombre.Text.Trim(), tB_ApPaterno.Text.Trim(), tB_ApMaterno.Text.Trim(), dTP_Nacimiento.Value, cB_Carrera.Text.Trim(), tB_Nomina.Text.Trim(), tB_Usuario.Text.Trim(), tB_Contraseña.Text.Trim(), tB_Titulo.Text.Trim(), rB_Hombre.Checked,editar.Length > 0))
                        {
                            MessageBox.Show("Error: Nombre de usuaro ya existe");
                        }
                        else
                        {
                            updateWindow();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Seleccione un genero");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Seleccione una carrera");
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Registrar.Text = "Guardar";

            int row = dGV_Consulta.CurrentCell.RowIndex;
            editar = dGV_Consulta.Rows[row].Cells[0].Value.ToString();
            gB_Usuario.Enabled = false;
            var result = Global.DBManager.oneCoordAll(editar);

            
            tB_Usuario.Text = result.clave_usuario;
            tB_Contraseña.Text = result.contrasena;
            tB_ConVericicacion.Text = result.contrasena;

            tB_Nombre.Text = result.nombre;
            tB_ApPaterno.Text = result.apellido_pat;
            tB_ApMaterno.Text = result.apellido_mat;
            rB_Hombre.Checked = result.genero;
            rB_Mujer.Checked = !rB_Hombre.Checked;
            dTP_Nacimiento.Value = new DateTime(result.fecha_naci.Year, result.fecha_naci.Month, result.fecha_naci.Day);
            cB_Carrera.Text = result.carrera;
            cB_Carrera.Enabled = false;
            tB_Nomina.Text = result.num_nomina;
            tB_Titulo.Text = result.titulo;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;

            if (MessageBox.Show("Está a punto de eliminar PERMANENTEMENTE al Coordinador: \"" + dGV_Consulta.Rows[row].Cells[1].Value.ToString() + "\", ¿Está seguro que desea continuar?",
                                     "Confirmar eliminacion de Coordinador",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.DBManager.deleteCoord(dGV_Consulta.Rows[row].Cells[0].Value.ToString());
            }
            updateWindow();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Consulta.DataSource = Global.DBManager.allCoordsAll();
            btn_Editar.Enabled = dGV_Consulta.RowCount != 0;
            btn_Eliminar.Enabled = dGV_Consulta.RowCount != 0;
            Global.searchInDataGridView(dGV_Consulta, tB_Busqueda.Text);
        }
    }
}
