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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void nuevoMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dar_Alta_Maestro().ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Manager_Materias().ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dar_Alta_Carrera().ShowDialog();
        }

        private void coordinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dar_Alta_Coordinadores().ShowDialog();
        }

        private void iniciarSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = Global.DBManager.startNextSemester();
            if (result.Contains("ERROR"))
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("¡Bienvenido al semestre " + result + "!");
            }
        }

        private void terminarSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Global.DBManager.endThisSemester();
            if (result.Contains("ERROR"))
            {
                if (result.Contains("Administrador"))
                {
                    if (MessageBox.Show(result,
                                     "Terminar semestre sin alumnado",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Global.DBManager.endThisSemester(true);
                    }
                }
                else
                {
                    MessageBox.Show(result);
                }
                
            }
            else
            {
                MessageBox.Show("El semestre " + result + " ha sido finalizado");
            }
        }

        private void declararSemestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Iniciar_Semestre().ShowDialog();
        }
    }
}
