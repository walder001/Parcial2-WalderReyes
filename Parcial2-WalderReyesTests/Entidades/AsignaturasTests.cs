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
    public class AsignaturasTests
    {
        [TestMethod()]
       public void Guardar()
        {
            RepositorioBase<Asignaturas> repositorio;
            repositorio = new RepositorioBase<Asignaturas>(new Contexto());

            Assert.IsTrue(repositorio.Guardar(new Asignaturas()));
        }
        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Asignaturas> repositorio;
            repositorio = new RepositorioBase<Asignaturas>(new Contexto());
            Assert.IsNotNull(repositorio.Buscar(1));

        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Asignaturas> repositorio;
            repositorio = new RepositorioBase<Asignaturas>(new Contexto());
            Assert.IsNotNull(repositorio.GetList(a => true));

        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Asignaturas> repositorio;
            repositorio = new RepositorioBase<Asignaturas>(new Contexto());
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = 1;
            asignaturas.Descripcion = "Walder";
            asignaturas.Creditos = 1;

            Assert.IsTrue(repositorio.Modificar(asignaturas));
        }
        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Asignaturas> repositorio;
            repositorio = new RepositorioBase<Asignaturas>(new Contexto());
            Assert.IsNotNull(repositorio.Eliminar(1));

        }


    }
}