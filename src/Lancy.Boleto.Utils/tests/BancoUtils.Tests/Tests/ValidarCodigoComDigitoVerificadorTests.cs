using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class ValidarCodigoComDigitoVerificadorTests
    {
        [Theory(DisplayName = "Validar Código de Barras, Linha Digitável e Dígito Verificador")]
        [InlineData("03391924500000898589201492000082528410550102")]
        [InlineData("03391924500000925249201551000371644280050102")]
        [InlineData("03399201595100037166953700501025192450000121787")]
        [InlineData("03399201595100035078872401901029192450000155126")]
        [InlineData("03399201595100033666227102701029192460000066896")]
        [InlineData("03399201595109000031909800201023192470000051314")]
        [InlineData("03391924700001243139201551000355305490170102")]
        [InlineData("03391924800000958079201551000370539230060102")]
        [InlineData("84680000005053600040100018184846041139560300")]
        [InlineData("846800000057053600040108001818484600411395603003")]

        public void Dado_CodigoValido_ValidarCodigoEDigitoVerificador(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.ValidarCodigoComDigitoVerificador(codigo);

            // Assert
            Assert.True(result);
        }
    }
}
