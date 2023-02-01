using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class LinhaParaCodigoTests
    {
        [Theory(DisplayName = "Converter Linha Digitável Para Codigo De Barras")]
        [InlineData("75691306980112782587341149410015792430000006347")]
        public void Dato_LinhaDigitavelCoreta_ConverterParaCodigoDeBarras_EntaoSucesso(string linha)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.LinhaParaCodigo(linha);

            // Assert
            Assert.Equal("75697924300000063471306901127825874114941001", result);
        }
    }
}
