using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestMethod()]
        public void DivisionIntegrationTest()
        {
            Assert.IsTrue(iCalculadora.Division(8,2) == 4);
        }

        [TestMethod()]
        public void MultiplicacionIntegrationTest()
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(2, 5) == 10);
        }

        [TestMethod()]
        public void RestaIntegrationTest()
        {
            Assert.IsTrue(iCalculadora.Resta(4, 1) == 3);
        }

        [TestMethod()]
        public void SumaIntegrationTest()
        {
            Assert.IsTrue(iCalculadora.Suma(2, 2) == 4);
        }

    }
}