using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class DigitoVerificadorTests
    {
        [Theory(DisplayName = "Digito Verificador")]
        [InlineData("84680000005053600040100018184846041139560300")]
        public void Dado_CodigoValido_IdentificarDigitoVerificador_Mod10_EntaoSucesso(string barra)
        {
            //Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.DigitoVerificadorCodigoDeBarras(barra);

            // Assert
            Assert.Equal("8", result);
        }


        [Theory(DisplayName = "Digito Verificador")]
        [InlineData("03391924700001243139201551000355305490170102")]
        public void Dado_CodigoValido_IdentificarDigitoVerificador_Mod11_EntaoSucesso(string barra)
        {
            //Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.DigitoVerificadorCodigoDeBarras(barra);

            // Assert
            Assert.Equal("1", result);
        }
    }
}
