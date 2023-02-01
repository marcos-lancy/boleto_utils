using BoletoUtils;
using BoletoUtils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtils.Tests.Tests
{
    public class IdentificarTipoBoletoTests
    {
        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("655900000200337500292723549 35008300000000000000")]
        [InlineData("65590000020033750029272354935008300000000000000")]
        [InlineData("21290001190110002250600274272152400000000000000")]
        [InlineData("21290001190110002250600376066833900000000000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_CartaoDeCredito_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.CartaoDeCredito, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("81090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_ArrecadacaoPrefeitura_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ArrecadacaoPrefeitura, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("82090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_ConvenioSaneamento_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ConvenioSaneamento, result);
        }


        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("83090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_ConvenioEnergiaEletricaGas_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ConvenioEnergiaEletricaGas, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("84090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_ConvenioTelecomunicacao_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ConvenioTelecomunicacao, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("85090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_ArrecadacaoOrgaosGovernamentais_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ArrecadacaoOrgaosGovernamentais, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("86090072140911206054722100000029293680200000000")]
        [InlineData("89090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_IdentificarBoleto_Outros_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.Outros, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("87090072140911206054722100000029293680200000000")]
        public void Dado_CodigoDeBarrasValido_ArrecadacaoTaxasDeTransito_Outros_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ArrecadacaoTaxasDeTransito, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("81051211423004937520101231226000005000001019")]
        [InlineData("81401049818824620021230401035200110090000000")]
        [InlineData("81401049923251830001000460000434080899218000")]
        [InlineData("81401049221193982201000480033465876069222000")]
        public void Dado_CodigoDeBarrasValido_ArrecadacaoPrefeitura_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ArrecadacaoPrefeitura, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("82051211423004937520101231226000005000001019")]
        [InlineData("82401049818824620021230401035200110090000000")]
        [InlineData("82401049923251830001000460000434080899218000")]
        [InlineData("82401049221193982201000480033465876069222000")]
        public void Dado_CodigoDeBarrasValido_ConvenioSaneamento_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ConvenioSaneamento, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("83051211423004937520101231226000005000001019")]
        [InlineData("83401049818824620021230401035200110090000000")]
        [InlineData("83401049923251830001000460000434080899218000")]
        [InlineData("83401049221193982201000480033465876069222000")]
        public void Dado_CodigoDeBarrasValido_ConvenioEnergiaEletricaGas_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ConvenioEnergiaEletricaGas, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("84680000005053600040100018184846041139560300")]
        [InlineData("84690000008221105040100018204260041110681000")]
        [InlineData("84640000001349000820899994680208161475232499")]
        [InlineData("84640000038168001090110048716969600114486569")]
        public void Dado_CodigoDeBarrasValido_ConvenioTelecomunicacao_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ConvenioTelecomunicacao, result);
        }

        [Theory(DisplayName = "Identificar Tipo de Boleto")]
        [InlineData("85680000005053600040100018184846041139560300")]
        [InlineData("85690000008221105040100018204260041110681000")]
        [InlineData("85640000001349000820899994680208161475232499")]
        [InlineData("85640000038168001090110048716969600114486569")]
        public void Dado_CodigoDeBarrasValido_ArrecadacaoOrgaosGovernamentais_Com_Sucesso(string codigo)
        {
            // Arrange
            var banco = new Boletos();

            // Act
            var result = banco.IdentificarTipoBoleto(codigo);

            // Assert
            Assert.Equal(TipoBoletoEnum.ArrecadacaoOrgaosGovernamentais, result);
        }
    }
}