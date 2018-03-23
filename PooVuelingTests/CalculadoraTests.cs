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

        //[TestMethod()]
        [DataRow(4,2,2)]
        [DataRow(9,3,3)]
        [DataTestMethod]
        public void DivisionIntegrationTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1,num2) == resultado);
        }

        //[TestMethod()]
        [DataRow(4,2,8)]
        [DataRow(6,3,18)]
        [DataTestMethod]
        public void MultiplicacionIntegrationTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        //[TestMethod()]
        [DataRow(4, 2, 2)]
        [DataRow(6, 3, 3)]
        [DataTestMethod]
        public void RestaIntegrationTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        //[TestMethod()]
        [DataRow(4,1,5)]
        [DataTestMethod]
        public void SumaIntegrationTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }

    }
}