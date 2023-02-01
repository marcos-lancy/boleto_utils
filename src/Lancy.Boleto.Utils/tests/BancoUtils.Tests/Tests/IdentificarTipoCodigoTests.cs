using BoletoUtils;
using BoletoUtils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class IdentificarTipoCodigoTests
    {
        [Theory(DisplayName = "Identificar Tipo de Código")]
        [InlineData("00000000000000000000000000000000000000000000")]
        public void Dado_CodigoDeBarrasValido_Identifica_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoCodigo(codigo);

            // Assert
            Assert.Equal(TipoCodigoEnum.codigoDeBarras, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Código")]
        [InlineData("0000000000000000000000000000000000000000000")]
        public void Dado_CodigoDeBarrasIvalido_Identifica_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoCodigo(codigo);

            // Assert
            Assert.Equal(TipoCodigoEnum.invalido, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Código")]
        [InlineData("0000000000000000000000000000000000000000000000")]
        [InlineData("00000000000000000000000000000000000000000000000")]
        [InlineData("000000000000000000000000000000000000000000000000")]
        public void Dado_LinhaDigitavelValido_Identifica_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoCodigo(codigo);

            // Assert
            Assert.Equal(TipoCodigoEnum.linhaDigitavel, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Código")]
        [InlineData("000000000000000000000000000000000000000000000")]
        [InlineData("0000000000000000000000000000000000000000000000000")]
        public void Dado_LinhaDigitavelIvalido_Identifica_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoCodigo(codigo);

            // Assert
            Assert.Equal(TipoCodigoEnum.invalido, result);
        }
    }
}
