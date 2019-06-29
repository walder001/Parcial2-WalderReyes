using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_WaldeReyes.BLL;
using Parcial2_WaldeReyes.DAL;
using Parcial2_WaldeReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_WaldeReyes.Entidades.Tests
{
    [TestClass()]
    public class EstudiantesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Estudiantes> repositorio;
            repositorio = new RepositorioBase<Estudiantes>(new Contexto());

            Assert.IsTrue(repositorio.Guardar(new Estudiantes()));
        }
      
    }
}