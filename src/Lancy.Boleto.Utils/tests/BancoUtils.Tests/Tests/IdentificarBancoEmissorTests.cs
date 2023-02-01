using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class IdentificarBancoEmissorTests
    {
        [Theory(DisplayName = "Identificar Banco Emissor")]
        [InlineData("03391924500000693389201551000340632570250102")]
        public void Dado_Codigo_Valido_RetornarBancoEsperado_Entao_Sucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarBancoEmissor(codigo);

            // Assert
            Assert.Equal("033", result.Codigo);
            Assert.Equal("BANCO SANTANDER BRASIL S.A", result.Banco, ignoreCase: true);
            Assert.Equal("90400888", result.ISPB);
        }
    }
}