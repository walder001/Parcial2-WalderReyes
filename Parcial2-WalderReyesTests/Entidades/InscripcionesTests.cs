using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_WaldeReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_WaldeReyes.Entidades.Tests
{
    [TestClass()]
    public class InscripcionesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            Assert.IsTrue(BLL.IncripcionesBLL.Guardar(new Inscripciones()));
        }

    }
}