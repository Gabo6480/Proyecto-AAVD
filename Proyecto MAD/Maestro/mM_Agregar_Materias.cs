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
    public partial class mM_Agregar_Materias : Form
    {
        
        private int agregar;
        private bool remover;
        public mM_Agregar_Materias(int add, bool remove)
        {
         
            agregar = add;
            remover = remove;
            InitializeComponent();
            if (remove)
            {
                btn_Agregar.Text = "Remover";
                dGV_Materias.Columns[0].HeaderText = "Remover";
                this.Text = "Remover Materias";
                var source = Global.DBManager.teacherSubjects(add);
                dGV_Materias.DataSource = source != null ? source.ToList() : null;
            }
            else
            {
                dGV_Materias.AutoGenerateColumns = false;
                var materias = Global.DBManager.allSubjectsAll().ToList();

                var source = Global.DBManager.teacherSubjects(add);

                if (source != null && materias != null)
                {
                    for (int R = materias.Count - 1; R >= 0; R--)
                    {
                        foreach (rMateria materia in source)
                        {
                            if (materias[R].clave == materia.clave && materias[R].alias.ToString().CompareTo(materia.alias) == 0)
                            {
                                materias.Remove(materias[R]);
                                break;
                            }
                        }
                    }
                }

                dGV_Materias.DataSource = materias;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_Materias.Rows)
            {
                if (row.Cells[CheckBox.Name] != null && row.Cells[CheckBox.Name].Value != null)
                {
                    if ((bool)row.Cells[CheckBox.Name].Value)
                    {
                        if(Global.DBManager.teacherSubjects(agregar, (int)row.Cells[Clave.Name].Value, row.Cells[Nombre.Name].Value.ToString(), row.Cells[Alias.Name].Value.ToString(), remover))
                        {
                            MessageBox.Show("Error: No se puede eliminar esta relacion porque existen grupos en los que este profesor imparte esta materia");
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
