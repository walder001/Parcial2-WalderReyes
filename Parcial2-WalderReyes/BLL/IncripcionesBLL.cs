using Parcial2_WaldeReyes.DAL;
using Parcial2_WaldeReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_WaldeReyes.BLL
{
    public class IncripcionesBLL
    {
        /// <summary>
        /// Permite guardar una entidad en la base de datos
        /// </summary>
        /// <param name="inscripciones">Una instancia de visita</param>
        /// <returns>Retorna True si guardo o Falso si falló </returns>
        public static bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Inscripciones.Add(inscripciones) != null)
                {
                    foreach (var item in inscripciones.Detalle)
                    {
                        contexto.Estudiantes.Find(item.EstudianteId).Balance += (double)item.Balance;
                    }

                    contexto.SaveChanges(); //Guardar los cambios
                    paso = true;
                }
                //siempre hay que cerrar la conexion
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Modificar una entidad en la base de datos 
        /// </summary>
        /// <param name="inscripciones">Una instancia de visita</param>
        /// <returns>Retorna True si Modifico o Falso si falló </returns>
        public static bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                //todo: buscar las entidades que no estan para removerlas
                var visitaant = IncripcionesBLL.Buscar(inscripciones.InscripcionId);
                
                foreach (var item in inscripciones.Detalle)//recorrer el detalle aterior
                {
                    //restar todas las visitas
                     contexto.Estudiantes.Find(item.EstudianteId).Balance -= (double)item.Balance;

                    //determinar si el item no esta en el detalle actual
                    if (!inscripciones.Detalle.ToList().Exists(v => v.EstudianteId == item.EstudianteId))
                    {
                        contexto.Estudiantes.Find(item.EstudianteId).Balance -= (double)item.Balance;
                        //item.Balance  = ; //quitar la ciudad para que EF no intente hacerle nada
                        contexto.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    }
                }

                //recorrer el detalle
                foreach (var item in inscripciones.Detalle)
                {
                    //Sumar todas las visitas
                    contexto.Estudiantes.Find(item.EstudianteId).Balance += (double)item.Balance;

                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.EstudianteId > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }
                
                //Idicar que se esta modificando el encabezado
                contexto.Entry(inscripciones).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Eliminar una entidad en la base de datos
        /// </summary>
        ///<param name="id">El Id de la visita que se desea eliminar </param>
        /// <returns>Retorna True si Eliminó o Falso si falló </returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Inscripciones inscripciones = contexto.Inscripciones.Find(id);

                foreach (var item in inscripciones.Detalle)
                {
                    var balance = contexto.Estudiantes.Find(item.EstudianteId);
                    balance.Balance -= (double)item.Balance;
                }

                contexto.Inscripciones.Remove(inscripciones);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Buscar una entidad en la base de datos
        /// </summary>
        ///<param name="id">El Id de la visita que se desea encontrar </param>
        /// <returns>Retorna la visita encontrada </returns>
        public static Inscripciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inscripciones inscripcion = new Inscripciones();
            try
            {
                inscripcion = contexto.Inscripciones.Find(id);
                if (inscripcion != null) { 
                //Cargar la lista en este punto porque
                //luego de hacer Dispose() el Contexto 
                //no sera posible leer la lista
                inscripcion.Detalle.Count();

                //Cargar los nombres de las ciudades
                foreach (var item in inscripcion.Detalle)
                {
                    //forzando la ciudad a cargarse
                    double s = item.estudiante.Balance;
                }
}
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return inscripcion;
        }

        /// <summary>
        /// Permite extraer una lista de Visitas de la base de datos
        /// </summary> 
        ///<param name="expression">Expression Lambda conteniendo los filtros de busqueda </param>
        /// <returns>Retorna una lista de Visitas</returns>
        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> inscripcion = new List<Inscripciones>();
            Contexto contexto = new Contexto();
            try
            {
                inscripcion = contexto.Inscripciones.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return inscripcion;
        }
    }
}
