using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_WaldeReyes.Entidades
{
    public class InscripcionesDetalle
    {
        [Key]
        public int InscripcioneDetalleId { get; set; }
        public int EstudianteId { get; set; }
        public int InscripcionId { get; set; }

       /* [ForeignKey("EstudianteId")]
        //Permite indicar por cual campo se usara
        //la NAVIGATION PROPERTY
        public virtual Estudiantes Estudiantes { get; set; }*/
        public decimal Balance { get; set; }


        public InscripcionesDetalle(int inscripcioneDetalleId, int estudianteId, int inscripcionId, decimal balance)
        {
            InscripcioneDetalleId = inscripcioneDetalleId;
            EstudianteId = estudianteId;
            InscripcionId = inscripcionId;
            Balance = balance;
        }

        public InscripcionesDetalle()
        {
            InscripcioneDetalleId = 0;
            EstudianteId = 0;
            InscripcionId = 0;
            Balance = 0;
        }
       
    }
}
