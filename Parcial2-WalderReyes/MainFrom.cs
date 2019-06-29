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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
