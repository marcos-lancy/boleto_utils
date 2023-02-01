using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class IdentificarDataVencimentoTEsts
    {
        [Theory(DisplayName = "Data de Vencimento")]
        [InlineData("00191924500000311190000002176489000486992717")]
        public void Dato_CodigoDeBarras_IdentificarDataVencimento_EntaoSucesso(string barra)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarDataVencimento(barra);

            // Assert
            Assert.Equal("29/01/2023", result.ToShortDateString());
        }

        [Theory(DisplayName = "Data de Vencimento")]
        [InlineData("00190000090282802600101015132176692500000106250")]
        public void Dato_LinhaDigitavel_IdentificarDataVencimento_EntaoSucesso(string linha)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarDataVencimento(linha);

            // Assert
            Assert.Equal("03/02/2023", result.ToShortDateString());
        }
    }
}