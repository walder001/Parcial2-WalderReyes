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

namespace Parcial2_WalderReyes.UI.Registro
{
    public partial class rAsignatura : Form
    {
        public rAsignatura()
        {
            InitializeComponent();
        }


        void Clean()
        {
            AsignaturaId.Value = 0;
            Descripcion.Text = string.Empty;
            Credito.Value = 0;

        }
        private Asignaturas LLenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = (int)AsignaturaId.Value;
            asignatura.Descripcion = Descripcion.Text;
            asignatura.Creditos = (int)Credito.Value;
            return asignatura;
        }
        public void LLenaCampo(Asignaturas asignaturas)
        {
            AsignaturaId.Value = asignaturas.AsignaturaId;
            Descripcion.Text = asignaturas.Descripcion;
            Credito.Value = asignaturas.Creditos;

        }
        public bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();

            if (Descripcion.Text == string.Empty)
            {
                ErrorProvider.SetError(Descripcion, "El campo descroipcion no puede esta vacio");
                Descripcion.Focus();
                paso = false;

            }
            if (Credito.Value < 0)
            {
                ErrorProvider.SetError(Credito, "No puede existir credito menor que 0");
                Credito.Focus();
                paso = false;
            }
            return paso;

        }
        public bool SiExiste()
        {
            Parcial2_WaldeReyes.BLL.RepositorioBase<Asignaturas> AsigignaturaBLL = new Parcial2_WaldeReyes.BLL.RepositorioBase<Asignaturas>(new Contexto());
            Asignaturas asignaturas = AsigignaturaBLL.Buscar((int)AsignaturaId.Value);
            return (asignaturas != null);

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Credito_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AsignaturaId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (!SiExiste())
            {
                MessageBox.Show("No se puede eliminar una asignatura que no existe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var res = MessageBox.Show("Realmente Decea eliminar la asignatura", "Infromation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    Parcial2_WaldeReyes.BLL.RepositorioBase<Asignaturas> AsiganturaBLL = new BLL.RepositorioBase<Asignaturas>(new Contexto());
                    AsiganturaBLL.Eliminar((int)AsignaturaId.Value);

                }
            }

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Parcial2_WaldeReyes.BLL.RepositorioBase<Asignaturas> AsignaturaBLL = new Parcial2_WaldeReyes.BLL.RepositorioBase<Asignaturas>(new Contexto());
            bool paso = false;
            if (!Validar())
                return;
            Asignaturas a = LLenaClase();
            if (AsignaturaId.Value == 0)
            {
                paso = AsignaturaBLL.Guardar(a);

            }
            else
            {
                if (!SiExiste())
                {
                    MessageBox.Show("No se puede modificar una signatura que no existe", "Fallo", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Decea modificar", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    paso = AsignaturaBLL.Modificar(a);

                }
            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Infromacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se puedo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Parcial2_WaldeReyes.BLL.RepositorioBase<Asignaturas> AsignaturasBLL = new BLL.RepositorioBase<Asignaturas>(new Contexto());
            Asignaturas a = new Asignaturas();
            a = AsignaturasBLL.Buscar((int)AsignaturaId.Value);
            if (a != null)
            {
                LLenaCampo(a);
            }
            else
            {
                MessageBox.Show("No se encontro");
            }

        }
    }
}
