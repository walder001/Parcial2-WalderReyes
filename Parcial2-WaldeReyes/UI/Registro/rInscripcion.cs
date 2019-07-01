using Parcial2_WaldeReyes.BLL;
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
    public partial class rInscripcion : Form
    {
        List<InscripcionesDetalle> Detalle { get; set; }
        public rInscripcion()
        {
            InitializeComponent();
             Detalle = new List<InscripcionesDetalle>();
            LLenarComboBoxEstudiante();
            LLenarComboBoxAsignatura();

        }

        public void Clean()
        {
            InscripcionIdNumericUpDown.Value = 0;
            FechaDateTime.Value = DateTime.Now;
            EstudiantecomboBox.Text = string.Empty;
            AsignaturaComboBox.Text = string.Empty;
            PrecioCreditoNumericUpDown.Value = 0;
            MontoNumericUpDown.Value = 0;
            CreditoNumericUpDown.Value = 0;
            BalanceNumericUpDown.Value = 0;
            Detalle = new List<InscripcionesDetalle>();
            CargarGrid();
        }

        public void LLenarComboBoxEstudiante()
        {
            RepositorioBase<Estudiantes> estudiante = new RepositorioBase<Estudiantes>(new Contexto());
            EstudiantecomboBox.DataSource = estudiante.GetList(e => true);
            EstudiantecomboBox.ValueMember = "EstudianteId";
            EstudiantecomboBox.DisplayMember = "Nombres";
        }
        public void LLenarComboBoxAsignatura()
        {
            RepositorioBase<Asignaturas> asignatira = new RepositorioBase<Asignaturas>(new Contexto());
            AsignaturaComboBox.DataSource = asignatira.GetList(a => true);
            AsignaturaComboBox.ValueMember = "AsignaturaId";
            AsignaturaComboBox.DisplayMember = "Descripcion";

        }
        private Inscripciones LLenaClase()
        {
            Inscripciones incri = new Inscripciones();
            incri.InscripcionId = (int)InscripcionIdNumericUpDown.Value;
            incri.Fecha = FechaDateTime.Value ;
            incri.Monto = (int)MontoNumericUpDown.Value;
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                incri.AgregarDetalle(
                    ToInt(item.Cells["InscripcioneDetalleId"].Value),
                         ToInt(item.Cells["AsignaturaId"].Value),
                         ToInt(item.Cells["InscripcionId"].Value),
                         ToInt(item.Cells["EstudianteId"].Value),
                         ToInt(item.Cells["Balance"].Value)
                       );

            }
            return incri;
        }

        private int ToInt(object value)
        {
            int retorno = 0;

            int.TryParse(value.ToString(), out retorno);

            return retorno;
        }

        public void LLenaCampo(Inscripciones inscripciones)
        {
            InscripcionIdNumericUpDown.Value = inscripciones.InscripcionId;
            FechaDateTime.Value = inscripciones.Fecha;
            MontoNumericUpDown.Value = (int)inscripciones.Monto;
            dataGridView.DataSource = inscripciones.Detalle;
            dataGridView.Columns["InscripcioneDetalleId"].Visible = false;
            dataGridView.Columns["AsignaturaId"].Visible = false;

        }

        public bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();
            if (MontoNumericUpDown.Value > 0)
            {
                ErrorProvider.SetError(MontoNumericUpDown, "No puede existir credito menor que 0");
                MontoNumericUpDown.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(dataGridView.Text))
            {
                ErrorProvider.SetError(dataGridView,"No puede esta vacio");
                dataGridView.Focus();
                paso = false;

            }
            return paso;

        }
        public bool SiExiste()
        {
            Inscripciones incrip = BLL.IncripcionesBLL.Buscar((int)InscripcionIdNumericUpDown.Value);
            return (incrip != null);

        }

        public void CargarGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = Detalle;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Inscripciones incri;
            if (!Validar())
                return;
                incri = LLenaClase();
            
           
            if (InscripcionIdNumericUpDown.Value == 0)
            {
                paso = BLL.IncripcionesBLL.Guardar(incri);
                    
            }
            else
            {
                if (!SiExiste())
                {
                    MessageBox.Show("No se puede modificar una incripcioners que no esiste");
                }
                else
                {
                    var re = MessageBox.Show("Decea modificar", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (re == DialogResult.OK)
                    {
                        paso = BLL.IncripcionesBLL.Modificar(incri);

                    }
                }
            }
            if (paso)
            {
                MessageBox.Show("Guardo","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudu guardar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Inscripciones ints =  BLL.IncripcionesBLL.Buscar((int)InscripcionIdNumericUpDown.Value);
            if (ints != null)
            {
                LLenaCampo(ints);

            }
            else
            {
                MessageBox.Show("No se encotro la inscripcion");
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.IncripcionesBLL.Eliminar((int)InscripcionIdNumericUpDown.Value);

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede buscar");
            }

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            if (dataGridView.DataSource != null)
            {
                Detalle = (List<InscripcionesDetalle>) dataGridView.DataSource;
            }
            Detalle.Add(
                new InscripcionesDetalle(
                    inscripcioneDetalleId: 0,
                    asignaturaId: (int)AsignaturaComboBox.SelectedValue,
                    inscripcionId: (int)InscripcionIdNumericUpDown.Value,
                    estudianteId: (int)EstudiantecomboBox.SelectedValue,
                    balance: (decimal) BalanceNumericUpDown.Value

                    )
                );

            CargarGrid();
        }

        private void Inscripcion_Enter(object sender, EventArgs e)
        {

        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {

            if (dataGridView.Rows.Count > 0 && dataGridView.CurrentRow != null)
            {
                //convertir el grid en la lista
                List<InscripcionesDetalle> detalle = (List<InscripcionesDetalle>)dataGridView.DataSource;

                //remover la fila
                detalle.RemoveAt(dataGridView.CurrentRow.Index);

                // Cargar el detalle al Grid
                dataGridView.DataSource = null;
                dataGridView.DataSource = detalle;
            }

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void BalanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BalanceNumericUpDown.Value = MontoNumericUpDown.Value + (PrecioCreditoNumericUpDown.Value * CreditoNumericUpDown.Value);
        }
    }
}
