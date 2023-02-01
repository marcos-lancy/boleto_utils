using BoletoUtils;

namespace BancoUtils.Tests.Tests
{
    public class CalculosModsTests
    {
        [Theory(DisplayName = "Calculos Mod 10")]
        [InlineData("001900000")]
        public void Dado_ValoresValidos_CalcularMod10_Entao_Sucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.CalculaMod10(codigo);

            // Assert
            Assert.Equal("9", result);
        }

        [Theory(DisplayName = "Calculos Mod 10")]
        [InlineData("0339924500000925249201551000371644280050102")]
        public void Dado_ValoresValidos_CalcularMod11_Entao_Sucesso(string codigo)
        {
            // Arrange
            var boleto = new Boletos();

            // Act
            var result = boleto.CalculaMod11(codigo);

            // Assert
            Assert.Equal("1", result);
        }
    }
}
