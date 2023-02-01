using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class IdentificarValorTests
    {
        [Theory(DisplayName = "Obter Falores Título")]
        [InlineData("00191924500000311190000002176489000486992717")]
        public void Dado_CodigoDeBarrasValido_ObterValorTitulo_EntaoSucesso(string codigo)
        {
            // Arange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarValor(codigo);

            // Assert
            Assert.Equal("311.19", result.TrimStart('0'));
        }

        [Theory(DisplayName = "Obter Falores Título")]
        [InlineData("00190000090306173200800008455172692450005006456")]
        public void Dado_LinhaDigitavelValido_ObterValorTitulo_EntaoSucesso(string codigo)
        {
            // Arange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarValor(codigo);

            // Assert
            Assert.Equal("50064.56", result.TrimStart('0'));
        }
    }
}
