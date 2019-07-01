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
    public partial class cEstudiante : Form
    {
        public cEstudiante()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var listar = new List<Estudiantes>();
            BLL.RepositorioBase<Estudiantes> BLL = new BLL.RepositorioBase<Estudiantes>(new Contexto());
            if (txtCriterio.Text.Trim().Length > 0)
            {
                switch (cbFiltro.SelectedItem)
                {
                    case 0:
                        BLL.GetList(i => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(txtCriterio.Text);
                        listar = BLL.GetList(i => i.EstudianteId == id);
                        break;

                    case 2://Nombres
                        listar = BLL.GetList(p => p.Nombres.Contains(txtCriterio.Text));
                        break;
                    case 3://Descripcion
                        listar = BLL.GetList(p => p.Nombres.Contains(txtCriterio.Text));
                        break;

                }
                listar = listar.Where(c => c.FechaIngreso.Date >= dtpDesde.Value.Date && c.FechaIngreso.Date <= dtpHasta.Value.Date).ToList();

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
