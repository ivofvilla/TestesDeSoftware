using System;
using Xunit;
using Demo;

namespace Demo.Testes
{
    public class CalcularadoTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(2, 2);

            //assert
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        public void Calculadora_Somar_RetornarValoresSomaCOrretos(double v1, double v2, double total)
        {
            //arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(v1, v2);

            //assert
            Assert.Equal(total, resultado);
        }
    }
}
