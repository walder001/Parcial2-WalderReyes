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
    public partial class cInscripcion : Form
    {
        public cInscripcion()
        {
            InitializeComponent();
        }
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var listar = new List<Inscripciones>();
            BLL.RepositorioBase<Inscripciones> BLL = new BLL.RepositorioBase<Inscripciones>(new Contexto());
            if (txtCriterio.Text.Trim().Length > 0 )
            {
                switch (cbFiltro.SelectedItem)
                {
                    case 0:
                        BLL.GetList(i => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(txtCriterio.Text);
                       listar =  BLL.GetList(i=> i.InscripcionId == id);
                        break;

                    case 2:
                        int es = Convert.ToInt32(txtCriterio.Text);
                        listar = BLL.GetList(i => i.EstudianteId == es); break;
                    case 3://Descripcion
                        double mo = Convert.ToDouble(txtCriterio.Text);
                        listar = BLL.GetList(i => i.Monto == mo); break;

                }
                listar = listar.Where(c => c.Fecha.Date >= dtpDesde.Value.Date && c.Fecha.Date <= dtpHasta.Value.Date).ToList();

            }
            else
            {
                listar = BLL.GetList(i => true);
            }
            dgvConsulta.DataSource = null;
            dgvConsulta.DataSource = listar;

        }
    }
}
