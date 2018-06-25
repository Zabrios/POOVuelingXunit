using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOVueling;

namespace POOVuelingXunit.Integration.Tests
{
    public class CalculadoraTest
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void DivisionTest()
        {
            var result = iCalculadora.Division(4, 2);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MultiplicacionTest()
        {
            var result = iCalculadora.Multiplicacion(4, 2);
            Assert.Equal(8, result);
        }

        [Fact]
        public void SumaTest()
        {
            var result = iCalculadora.Suma(4, 2);
            Assert.Equal(6, result);
        }

        [Fact]
        public void RestaTest()
        {
            var result = iCalculadora.Resta(4, 2);
            Assert.Equal(2, result);
        }
    }
}
