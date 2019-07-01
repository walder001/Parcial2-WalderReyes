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

namespace Parcial2_WaldeReyes.UI.Registro
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo que limpia los datos en el formulario
        /// </summary>
        public void Clean()
        {
            EstudianteIdNumericUpDown.Value = 0;
            FechaIngresoDateTime.Value = DateTime.Now;
            NombreTextBox.Text = string.Empty;
            BalanceNumericUpDown.Value = 0;

        }
        /// <summary>
        /// Metodo encargado de llenar la clase con los datos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Estudiantes LLenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = (int)EstudianteIdNumericUpDown.Value;
            estudiante.FechaIngreso = FechaIngresoDateTime.Value;
            estudiante.Nombres = NombreTextBox.Text;
            estudiante.Balance = (int)BalanceNumericUpDown.Value;
            return estudiante;
        }
        /// <summary>
        /// Mentodo encargad0 de llenar los campos dell formulario
        /// </summary>
        /// <param name="estudiante"></param>

        public void LLenaCampo(Estudiantes estudiante)
        {
            EstudianteIdNumericUpDown.Value = estudiante.EstudianteId;
            FechaIngresoDateTime.Value = estudiante.FechaIngreso;
            NombreTextBox.Text = estudiante.Nombres;
            BalanceNumericUpDown.Value = (decimal)estudiante.Balance;
        }

        /// <summary>
        /// Metodo encargado de verifica si esxiste en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Existe()
        {
            Parcial2_WaldeReyes.BLL.RepositorioBase<Estudiantes> BLL = new BLL.RepositorioBase<Estudiantes>(new Contexto());
            Estudiantes estudiante = BLL.Buscar((int)EstudianteIdNumericUpDown.Value);
            return (estudiante != null);

        }

        /// <summary>
        /// Metodo encargado de validar los campos del formulario
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                ErrorProvider.SetError(NombreTextBox,"No puede haber espacio en blanco");
                NombreTextBox.Focus();
                paso = false;

            }
            if(NombreTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(NombreTextBox,"El campo no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Parcial2_WaldeReyes.BLL.RepositorioBase<Estudiantes> BLL = new BLL.RepositorioBase<Estudiantes>(new Contexto());
            Estudiantes estudiantes = new Estudiantes();
            estudiantes = BLL.Buscar((int)EstudianteIdNumericUpDown.Value);
            if (estudiantes != null)
            {
                LLenaCampo(estudiantes);

            }
            else
            {
                MessageBox.Show("No se encontro el esudiante");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Parcial2_WaldeReyes.BLL.RepositorioBase<Estudiantes> BLL = new BLL.RepositorioBase<Estudiantes>(new Contexto());
            bool paso = false;
           
            if (!Validar())
                return;

               Estudiantes estudiante = LLenaClase();
            
                if (EstudianteIdNumericUpDown.Value== 0)
                {
                    paso = BLL.Guardar(estudiante);
                }
                else
                {
                    if (!Existe())
                    {
                        MessageBox.Show("No se puede modifica un estudainte que no existe");
                    }
                    else
                    {
                       var resultado =  MessageBox.Show("Decea modificar el estudiante","Question",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (resultado == DialogResult.OK)
                        {
                            paso = BLL.Modificar(estudiante);

                        }
                    }
                }
                if (paso)
                {
                    MessageBox.Show("Guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se guardao", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (!Existe())
            {
                MessageBox.Show("No puese eliminar un usiario que no existe","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Parcial2_WaldeReyes.BLL.RepositorioBase<Estudiantes> BLL = new BLL.RepositorioBase<Estudiantes>(new Contexto());
                var re = MessageBox.Show("Real mente decea modificar", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (re == DialogResult.OK)
                {
                    BLL.Eliminar((int)EstudianteIdNumericUpDown.Value);
                    Clean();

                }
                else
                {
                    MessageBox.Show("No se puedo eliminar");
                    Clean();
                }
            }

           
        }
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {

                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsSeparator(e.KeyChar))
                {

                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

       
        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);

        }
    }
}
