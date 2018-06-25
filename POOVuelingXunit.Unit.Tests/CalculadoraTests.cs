using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOVueling;

namespace POOVuelingXunit.Unit.Tests
{

    public class CalculadoraTests
    {
        ICalculadora calculadora = new Calculadora();

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(18, 2, 9)]
        public void DivisionTest(int num1, int num2, int expected)
        {
            //var calculadora = new Calculadora();
            var result = calculadora.Division(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(18, 2, 36)]
        public void MultiplicacionTest(int num1, int num2, int expected)
        {
            //var calculadora = new Calculadora();
            var result = calculadora.Multiplicacion(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(18, 2, 16)]
        public void RestaTest(int num1, int num2, int expected)
        {
            var result = calculadora.Resta(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 2, 6)]
        [InlineData(18, 2, 20)]
        public void SumaTest(int num1, int num2, int expected)
        {
            var result = calculadora.Suma(num1, num2);
            Assert.Equal(expected, result);
        }
    }
}
