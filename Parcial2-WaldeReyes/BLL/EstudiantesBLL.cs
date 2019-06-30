using Parcial2_WaldeReyes.DAL;
using Parcial2_WaldeReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_WaldeReyes.BLL
{
    public class EstudiantesBLL
    {
        public bool static Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {


            }
            catch(Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
    }
}
