﻿using System;
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
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public virtual List<InscripcionesDetalle> Detalle { get; set; }

        public Inscripciones()
        {

            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0.0;
            EstudianteId = 0;
            this.Detalle = new List<InscripcionesDetalle>();
        }

        public Inscripciones(int inscripcionId, DateTime fecha, double monto, double montoCredito, int estudianteId)
        {
            InscripcionId = inscripcionId;
            Fecha = fecha;
            Monto = monto;
            EstudianteId = estudianteId;
            this.Detalle = new List<InscripcionesDetalle>();

        }

        public void AgregarDetalle(int inscripcioneDetalleId, int asignaturaId, int inscripcionId, int estudiante,decimal balance)
        {
            this.Detalle.Add(new InscripcionesDetalle(inscripcioneDetalleId, inscripcionId, asignaturaId, estudiante, balance));


        }

        public void CalcularBalance()
        {
            double balance = 0.0;
            foreach (var item in Detalle)
            {
                balance += (double)item.Balance;
                Monto = balance;

            }

        }
    }
}
