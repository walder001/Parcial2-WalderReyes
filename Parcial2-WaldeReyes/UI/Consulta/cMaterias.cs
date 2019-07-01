using Parcial2_WaldeReyes.DAL;
using Parcial2_WaldeReyes.Entidades;
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
            var listar = new List<Asignaturas>();
            BLL.RepositorioBase<Asignaturas> BLL = new BLL.RepositorioBase<Asignaturas>(new Contexto());
            if (txtCriterio.Text.Trim().Length > 0)
            {
                switch (cbFiltro.SelectedItem)
                {
                    case 0:
                        BLL.GetList(i => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(txtCriterio.Text);
                        listar = BLL.GetList(i => i.AsignaturaId == id);
                        break;

                    case 2:
                        int es = Convert.ToInt32(txtCriterio.Text);
                        listar = BLL.GetList(i => i.Descripcion.Contains(txtCriterio.Text)); break;
                    case 3://Descripcion
                        double mo = Convert.ToDouble(txtCriterio.Text);
                        listar = BLL.GetList(i => i.Creditos == mo); break;

                }

            }
            else
            {
                listar = BLL.GetList(i => true);
            }
            dgvConsulta.DataSource = null;
            dgvConsulta.DataSource = listar;
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
