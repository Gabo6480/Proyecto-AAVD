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
    public partial class mg_Agregar_Alumnos : Form
    {
        
        private Guid agregar;
        private bool remover;
        private string materiaG;
        private string semestreG;
        public mg_Agregar_Alumnos(Guid add, string materia, string semestre, bool remove)
        {
         
            agregar = add;
            remover = remove;
            materiaG = materia;
            semestreG = semestre;
            InitializeComponent();
            if (remove)
            {
                btn_Agregar.Text = "Remover";
                dGV_Alumnos.Columns[0].HeaderText = "Remover";
                this.Text = "Remover Alumnos";
                dGV_Alumnos.DataSource = Global.DBManager.groupStudents(add);
            }
            else
            {

                dGV_Alumnos.AutoGenerateColumns = false;
                var alumnos = Global.DBManager.allStudentAll().ToList();

                var source = Global.DBManager.groupStudents(add);

                if (source != null && alumnos != null)
                {
                    for (int R = alumnos.Count - 1; R >= 0; R--)
                    {
                        foreach (grupo_alumno alumno in source)
                        {
                            if (alumnos[R].matricula == alumno.matricula)
                            {
                                alumnos.Remove(alumnos[R]);
                                break;
                            }
                        }
                    }
                }

                dGV_Alumnos.DataSource = alumnos;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_Alumnos.Rows)
            {
                if (row.Cells[CheckBox.Name] != null && row.Cells[CheckBox.Name].Value != null)
                {
                    if ((bool)row.Cells[CheckBox.Name].Value)
                    {
                        switch (Global.DBManager.enrollStudentToGroup(agregar, (int)row.Cells[Matricula.Name].Value, row.Cells[Nombre.Name].Value.ToString(),0.0f, materiaG, semestreG, remover))
                        {
                            case -1:
                                MessageBox.Show("Error: No se puede inscribir al alumno " + row.Cells[Nombre.Name].Value.ToString() + " porque exedería el cupo del aula");
                                break;
                            case -2:
                                MessageBox.Show("Error: No se puede inscribir al alumno " + row.Cells[Nombre.Name].Value.ToString() + " porque exedería el maximo de creditos");
                                break;
                            default:
                                break;
                        }
                        
                    }
                }
            }
            this.Close();
        }

        private void tB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            if (remover)
            {
                dGV_Alumnos.DataSource = Global.DBManager.groupStudents(agregar);
            }
            else
            {

                dGV_Alumnos.AutoGenerateColumns = false;
                var alumnos = Global.DBManager.allStudentAll().ToList();

                var source = Global.DBManager.groupStudents(agregar);

                if (source != null && alumnos != null)
                {
                    for (int R = alumnos.Count - 1; R >= 0; R--)
                    {
                        foreach (grupo_alumno alumno in source)
                        {
                            if (alumnos[R].matricula == alumno.matricula)
                            {
                                alumnos.Remove(alumnos[R]);
                                break;
                            }
                        }
                    }
                }

                dGV_Alumnos.DataSource = alumnos;
            }
            Global.searchInDataGridView(dGV_Alumnos, tB_Busqueda.Text);
        }
    }
}
