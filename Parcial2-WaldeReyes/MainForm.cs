using Parcial2_WaldeReyes.UI.Consulta;
using Parcial2_WaldeReyes.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_WaldeReyes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rEstudiantes asi = new rEstudiantes();
            asi.Show();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Asignatura asi = new Asignatura();
            asi.Show();
        }

        private void InscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rInscripcion asi = new rInscripcion();
            asi.Show();

        }

        private void EstudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEstudiante asi = new cEstudiante();
            asi.Show();

        }

        private void AsignaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cMaterias asi = new cMaterias();
            asi.Show();

        }

        private void InscripcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cInscripcion asi = new cInscripcion();
            asi.Show();
        }
    }
}
