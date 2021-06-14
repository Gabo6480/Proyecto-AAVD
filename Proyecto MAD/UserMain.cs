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
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void inscribirAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dar_Alta_Alumno().ShowDialog();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dar_Alta_Grupo().ShowDialog();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Inscripcion_Grupos().ShowDialog();
        }

        private void kardexDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CdE_Alumno_Select(true).ShowDialog();
        }

        private void consultaDeEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CdE_Alumno_Select().ShowDialog();
        }
    }
}
