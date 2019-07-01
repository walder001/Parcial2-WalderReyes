using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_WaldeReyes.UI.Consulta
{
    public partial class cMaterias : Form
    {
        public cMaterias()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCriterio.Text);
            listar = BLL.GetList(i => i.InscripcionId == id);
        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCriterio_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
