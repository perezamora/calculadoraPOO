using PooVueling;
using Xunit;

namespace PooVuelingXunitTests
{
    public class CalculadoraIntegrationXunitTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void SumaTest()
        {
            Assert.True(iCalculadora.Suma(7, 3) == 10);
        }

        [Fact]
        public void RestaTest()
        {
            Assert.True(iCalculadora.Resta(2, 1) == 1);
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.True(iCalculadora.Division(10, 2) == 5);
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.True(iCalculadora.Multiplicacion(11, 2) == 22);
        }

    }
}