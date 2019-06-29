using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_WaldeReyes.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }


        public virtual List<InscripcionesDetalle> Detalle { get; set; }

        public Inscripciones()
        {

            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0.0;
            this.Detalle = new List<InscripcionesDetalle>();
        }

        public Inscripciones(int inscripcionId, DateTime fecha, double monto)
        {
            InscripcionId = inscripcionId;
            Fecha = fecha;
            Monto = monto;
            this.Detalle = new List<InscripcionesDetalle>();

        }

        public void AgregarDetalle(int inscripcioneDetalleId, int estudianteId, int inscripcionId, decimal balance)
        {
            this.Detalle.Add(new InscripcionesDetalle(inscripcionId,estudianteId,inscripcionId,balance));


        }
    }
}
