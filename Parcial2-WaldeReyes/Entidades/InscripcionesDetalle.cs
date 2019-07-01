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
        public int AsignaturaId { get; set; }
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public decimal Balance { get; set; }


        public InscripcionesDetalle(int inscripcioneDetalleId, int asignaturaId, int inscripcionId, int estudianteId, decimal balance)
        {
            InscripcioneDetalleId = inscripcioneDetalleId;
            AsignaturaId = asignaturaId;
            InscripcionId = inscripcionId;
            EstudianteId = estudianteId;
            Balance = balance;
        }

        public InscripcionesDetalle()
        {
            InscripcioneDetalleId = 0;
            AsignaturaId = 0;
            InscripcionId = 0;
            EstudianteId =0;
            Balance = 0;
        }
       
    }
}
