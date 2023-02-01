using BoletoUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class IdentificarReferenciaTests
    {
        [Theory(DisplayName = "Identificar Referencia")]
        [InlineData("39695924500005958140001100000002100000784279")]
        public void Dado_RefenciaValida_IdentificarReferencia_6_EntaoSucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarReferencia(codigo);

            // Assert
            Assert.Equal(10, result.Mod);
            Assert.True(result.Efetivo);
        }

        [Theory(DisplayName = "Identificar Referencia")]
        [InlineData("39795924500005958140001100000002100000784279")]
        public void Dado_RefenciaValida_IdentificarReferencia_7_EntaoSucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarReferencia(codigo);

            // Assert
            Assert.Equal(10, result.Mod);
            Assert.False(result.Efetivo);
        }

        [Theory(DisplayName = "Identificar Referencia")]
        [InlineData("39895924500005958140001100000002100000784279")]
        public void Dado_RefenciaValida_IdentificarReferencia_8_EntaoSucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarReferencia(codigo);

            // Assert
            Assert.Equal(11, result.Mod);
            Assert.True(result.Efetivo);
        }

        [Theory(DisplayName = "Identificar Referencia")]
        [InlineData("39995924500005958140001100000002100000784279")]
        public void Dado_RefenciaValida_IdentificarReferencia_9_EntaoSucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.IdentificarReferencia(codigo);

            // Assert
            Assert.Equal(11, result.Mod);
            Assert.False(result.Efetivo);
        }
    }
}
