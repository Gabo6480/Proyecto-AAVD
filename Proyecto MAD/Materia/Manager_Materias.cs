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
    public partial class Manager_Materias : Form
    {
        
        private Guid editar;
        public Manager_Materias()
        {
            InitializeComponent();
            editar = Guid.Empty;
         
        }

        private void updateWindow()
        {
            btn_Registrar.Text = "Registrar";
            tB_Nombre.Text = "";
            tB_Alias.Text = "";
            tB_Descripcion.Text = "";
            tB_Clave.Text = "";
            nUD_Creditos.Value = 0;
            nUD_Horas.Value = 0;
            nUD_Nivel.Value = 0;
            editar = Guid.Empty;

            dGV_Consulta.DataSource = Global.DBManager.allSubjectsAll();
            gB_Consulta.Enabled = dGV_Consulta.RowCount != 0;
        }

        private void Manager_Materias_Load(object sender, EventArgs e)
        {
            updateWindow();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (editar == Guid.Empty)
            {
                if (!Global.DBManager.insertSubject(tB_Nombre.Text.Trim(), tB_Alias.Text.Trim(), tB_Descripcion.Text.Trim(), (short)nUD_Creditos.Value, (short)nUD_Horas.Value, (sbyte)nUD_Nivel.Value,int.Parse(tB_Clave.Text.Trim())))
                {
                    MessageBox.Show("Nombre o Alias repetidos");
                }
                else
                {
                    updateWindow();
                }
            }
            else
            {
                switch (Global.DBManager.updateSubject(editar,tB_Nombre.Text.Trim(), tB_Alias.Text.Trim(), tB_Descripcion.Text.Trim(), (short)nUD_Creditos.Value, (short)nUD_Horas.Value, (sbyte)nUD_Nivel.Value, int.Parse(tB_Clave.Text.Trim())))
                {
                    case true:
                        updateWindow();
                        break;
                    case false:
                        MessageBox.Show("Nombre o Alias repetidos");
                        break;
                    //case -1:
                    //    MessageBox.Show("No puede modificar una Materia con un semestre en curso");
                    //    updateWindow();
                    //    break;
                    default:
                        break;
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Registrar.Text = "Guardar";

            int row = dGV_Consulta.CurrentCell.RowIndex;
            editar = Guid.Parse(dGV_Consulta.Rows[row].Cells[0].Value.ToString());

            var result = Global.DBManager.oneSubjectAll(editar);

            tB_Clave.Text = result.clave.ToString();

            tB_Nombre.Text = result.nombre;           //Nombre

            tB_Alias.Text = result.alias;                      //Alias
           
            tB_Descripcion.Text = result.descripcion;                      //Descripcion 
           
            nUD_Horas.Value = result.medias_horas_sem;    //Medias Horas
            
            nUD_Creditos.Value = result.creditos;    //Creditos
          
            nUD_Nivel.Value = result.nivel;    //Nivel
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int row = dGV_Consulta.CurrentCell.RowIndex;

            if (MessageBox.Show("Está a punto de eliminar PERMANENTEMENTE la Materia: \""+ dGV_Consulta.Rows[row].Cells[1].Value.ToString() + "\", ¿Está seguro que desea continuar?",
                                     "Confirmar eliminacion de Materia",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.DBManager.deleteSubject(Guid.Parse(dGV_Consulta.Rows[row].Cells[0].Value.ToString()));
            }
            updateWindow();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            dGV_Consulta.DataSource = Global.DBManager.allSubjectsAll();
            btn_Editar.Enabled = dGV_Consulta.RowCount != 0;
            btn_Eliminar.Enabled = dGV_Consulta.RowCount != 0;
            Global.searchInDataGridView(dGV_Consulta, tB_Busqueda.Text);
        }
    }
}
