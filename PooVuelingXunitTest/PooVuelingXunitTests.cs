using PooVueling;
using Xunit;

namespace PooVuelingXunitTests
{
    public class CalculadoraIntegrationXunitTests
    {
        ICalculadora iCalculadora = new Calculadora();

        //[Fact]
        [Theory]
        [InlineData(2,5,7)]
        [InlineData(4,4,8)]
        public void SumaTest(int num1, int num2, int result)
        {
            Assert.True(iCalculadora.Suma(num1, num2) == result);
        }

        //[Fact]
        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(4, 1, 3)]
        public void RestaTest(int num1, int num2, int result)
        {
            Assert.True(iCalculadora.Resta(num1, num2) == result);
        }

        //[Fact]
        [Theory]
        [InlineData(12, 2, 6)]
        [InlineData(4, 4, 1)]
        public void DivisionTest(int num1, int num2, int result)
        {
            Assert.True(iCalculadora.Division(num1, num2) == result);
        }

        //[Fact]
        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(4, 4, 16)]
        public void MultiplicacionTest(int num1, int num2, int result)
        {
            Assert.True(iCalculadora.Multiplicacion(num1, num2) == result);
        }

    }
}