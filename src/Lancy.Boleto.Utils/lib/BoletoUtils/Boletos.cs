using BoletoUtils.Models;
using BoletoUtils.Utils;


namespace BoletoUtils
{
    public class Boletos
    {
        /// <summary>
        /// Validar Código de Barras ou Linha Digitável com Digito Verificador
        /// </summary>
        /// <param name="codigo">Código de Barras ou Linha Digitável</param>
        /// <returns>Booleano Se Valido ou Não</returns>
        public bool ValidarCodigoComDigitoVerificador(string codigo)
        {
            TipoBoletoEnum tipoBoleto;

            var resultado = string.Empty;

            var tipoCodigo = IdentificarTipoCodigo(codigo);

            if (tipoCodigo == TipoCodigoEnum.linhaDigitavel)
            {
                tipoBoleto = IdentificarTipoBoleto(codigo);

                if (tipoBoleto == TipoBoletoEnum.Banco || tipoBoleto == TipoBoletoEnum.CartaoDeCredito)
                {
                    var bloco1 = codigo.Substring(0, 9) + CalculaMod10(codigo.Substring(0, 9));
                    var bloco2 = codigo.Substring(10, 10) + CalculaMod10(codigo.Substring(10, 10));
                    var bloco3 = codigo.Substring(21, 10) + CalculaMod10(codigo.Substring(21, 10));
                    var bloco4 = codigo.Substring(32, 1);
                    var bloco5 = codigo.Substring(33);

                    resultado = (bloco1 + bloco2 + bloco3 + bloco4 + bloco5).ToString();
                }
                else
                {
                    var identificacaoValorRealOuReferencia = IdentificarReferencia(codigo);
                    string bloco1 = string.Empty;
                    string bloco2 = string.Empty;
                    string bloco3 = string.Empty;
                    string bloco4 = string.Empty;

                    if (identificacaoValorRealOuReferencia.Mod == 10)
                    {
                        bloco1 = codigo.Substring(0, 11) + this.CalculaMod10(codigo.Substring(0, 11));
                        bloco2 = codigo.Substring(12, 11) + this.CalculaMod10(codigo.Substring(12, 11));
                        bloco3 = codigo.Substring(24, 11) + this.CalculaMod10(codigo.Substring(24, 11));
                        bloco4 = codigo.Substring(36, 11) + this.CalculaMod10(codigo.Substring(36, 11));
                    }
                    else if (identificacaoValorRealOuReferencia.Mod == 11)
                    {
                        bloco1 = codigo.Substring(0, 11);
                        bloco2 = codigo.Substring(12, 11);
                        bloco3 = codigo.Substring(24, 11);
                        bloco4 = codigo.Substring(36, 11);

                        var dv1 = codigo.Substring(11, 1);
                        var dv2 = codigo.Substring(23, 1);
                        var dv3 = codigo.Substring(35, 1);
                        var dv4 = codigo.Substring(47, 1);

                        var valid = (CalculaMod11(bloco1) == dv1 &&
                            CalculaMod11(bloco2) == dv2 &&
                            CalculaMod11(bloco3) == dv3 &&
                            CalculaMod11(bloco4) == dv4);

                        return valid;
                    }

                    resultado = (bloco1 + bloco2 + bloco3 + bloco4).ToString();
                }
            }
            else if (tipoCodigo == TipoCodigoEnum.codigoDeBarras)
            {
                tipoBoleto = IdentificarTipoBoleto(codigo);

                if (tipoBoleto == TipoBoletoEnum.Banco || tipoBoleto == TipoBoletoEnum.CartaoDeCredito)
                {
                    var DV = CalculaDVCodBarras(codigo, 4, 11);
                    resultado = codigo.Substring(0, 4) + DV + codigo.Substring(5);
                }
                else
                {
                    var identificacaoValorRealOuReferencia = IdentificarReferencia(codigo);

                    var codigoToList = codigo.ToCharArray().ToList();
                    codigoToList.RemoveAt(3);

                    resultado = string.Join("", codigoToList);

                    var DV = CalculaDVCodBarras(codigo, 3, identificacaoValorRealOuReferencia.Mod);
                    resultado = resultado.Substring(0, 3) + DV + resultado.Substring(3);
                }
            }

            return codigo == resultado;
        }

        private string CalculaDVCodBarras(string codigo, int posicaoCodigo, int mod)
        {
            var codigoToList = codigo.ToCharArray().ToList();
            codigoToList.RemoveAt(posicaoCodigo);

            var _codigo = string.Join("", codigoToList);

            if (mod == 10)
                return CalculaMod10(_codigo);
            else
                return CalculaMod11(_codigo);
        }

        /// <summary>
        /// Identificar Data de Vencimento
        /// </summary>
        /// <param name="codigo">Código de Barras ou Linha Digitável</param>
        /// <returns>Data de Vencimento</returns>
        public DateTime IdentificarDataVencimento(string codigo)
        {
            var tipoBoleto = IdentificarTipoBoleto(codigo);
            var tipoCodigo = IdentificarTipoCodigo(codigo);

            DateTime dataBoleto = new DateTime(1997, 10, 07, 20, 54, 59);
            //DateTime dataBoleto = DateTime.SpecifyKind(data, DateTimeKind.Utc);

            var fatorData = "0";

            if (tipoCodigo == TipoCodigoEnum.codigoDeBarras)
            {
                if (tipoBoleto == TipoBoletoEnum.Banco || tipoBoleto == TipoBoletoEnum.CartaoDeCredito)
                    fatorData = codigo.Substring(5, 4);
            }
            else if (tipoCodigo == TipoCodigoEnum.linhaDigitavel)
            {
                if (tipoBoleto == TipoBoletoEnum.Banco || tipoBoleto == TipoBoletoEnum.CartaoDeCredito)
                    fatorData = codigo.Substring(33, 4);
            }

            return dataBoleto.AddDays(Convert.ToDouble(fatorData));
        }

        /// <summary>
        /// Obter Valor do Título
        /// </summary>
        /// <param name="codigo">Código de Barras ou Linha Digitável</param>
        /// <returns>Valor do Tículo</returns>
        public string IdentificarValor(string codigo)
        {
            var tipoCodigo = IdentificarTipoCodigo(codigo);

            if (tipoCodigo == TipoCodigoEnum.codigoDeBarras)
            {
                codigo = CodigoParaLinha(codigo);
            }

            var valor = codigo.Substring(codigo.Length - 10);

            return $"{valor.Substring(0, 8)}.{valor.Substring(8)}";
        }

        /// <summary>
        /// Converter Linha Digitável Para Código de Barras
        /// </summary>
        /// <param name="linha">Linha Digitável</param>
        /// <returns>Código de barras</returns>
        public string LinhaParaCodigo(string linha)
        {
            var tipoBoleto = IdentificarTipoBoleto(linha);

            string resultado = string.Empty;

            if (tipoBoleto == TipoBoletoEnum.Banco || tipoBoleto == TipoBoletoEnum.CartaoDeCredito)
            {
                resultado = linha.Substring(0, 4) +
                    linha.Substring(32, 1) +
                    linha.Substring(33, 14) +
                    linha.Substring(4, 5) +
                    linha.Substring(10, 10) +
                    linha.Substring(21, 10);
            }
            else
            {
                linha.Remove(11, 1);
                linha.Remove(22, 1);
                linha.Remove(33, 1);
                linha.Remove(44, 1);

                resultado = linha;
            }

            return resultado;
        }

        /// <summary>
        ///  Converter Código de Barras Para Linhas Digitável  99
        /// </summary>
        /// <param name="barCode">Código de Barras</param>
        /// <param name="mascara">Formata string com mascara adicionando barras</param>
        /// <returns>Linha Digitável</returns>
        public string CodigoParaLinha(string barCode, bool mascara = true)
        {
            var tipoBoleto = IdentificarTipoBoleto(barCode);


            string resultado = string.Empty;

            if (tipoBoleto == TipoBoletoEnum.Banco || tipoBoleto == TipoBoletoEnum.CartaoDeCredito)
            {
                var novaLinha = $"{barCode.Substring(0, 4)}{barCode.Substring(19, 25)}{barCode.Substring(4, 1)}{barCode.Substring(5, 14)}";

                var bloco1 = novaLinha.Substring(0, 9) + CalculaMod10(novaLinha.Substring(0, 9));

                var bloco2 = novaLinha.Substring(9, 10) + CalculaMod10(novaLinha.Substring(9, 10));

                var bloco3 = novaLinha.Substring(19, 10) + CalculaMod10(novaLinha.Substring(19, 10));

                var bloco4 = novaLinha.Substring(29);

                resultado = $"{bloco1}{bloco2}{bloco3}{bloco4}";

                if (mascara)
                    resultado = $"{resultado.Substring(0, 5)}.{resultado.Substring(5, 5)} {resultado.Substring(10, 5)}.{resultado.Substring(15, 6)} {resultado.Substring(21, 5)}.{resultado.Substring(26, 6)} {resultado.Substring(32, 1)} {resultado.Substring(33)}";
            }
            else
            {
                var identificacaoValorRealOuReferencia = IdentificarReferencia(barCode);
                var bloco1 = string.Empty;
                var bloco2 = string.Empty;
                var bloco3 = string.Empty;
                var bloco4 = string.Empty;

                if (identificacaoValorRealOuReferencia?.Mod == 10)
                {
                    bloco1 = barCode.Substring(0, 11) + CalculaMod10(barCode.Substring(0, 11));
                    bloco2 = barCode.Substring(11, 11) + CalculaMod10(barCode.Substring(11, 11));
                    bloco3 = barCode.Substring(22, 11) + CalculaMod10(barCode.Substring(22, 11));
                    bloco4 = barCode.Substring(33, 11) + CalculaMod10(barCode.Substring(33, 11));
                }
                else if (identificacaoValorRealOuReferencia?.Mod == 11)
                {
                    bloco1 = barCode.Substring(0, 11) + CalculaMod11(barCode.Substring(0, 11));
                    bloco2 = barCode.Substring(11, 11) + CalculaMod11(barCode.Substring(11, 11));
                    bloco3 = barCode.Substring(22, 11) + CalculaMod11(barCode.Substring(22, 11));
                    bloco4 = barCode.Substring(33, 11) + CalculaMod11(barCode.Substring(33, 11));
                }

                resultado = $"{bloco1}{bloco2}{bloco3}{bloco4}";
            }

            return resultado;
        }

        /// <summary>
        /// Identifica Banco Emissor Através do Código de Barras
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public BancoEmissor IdentificarBancoEmissor(string codigo)
        {
            string numeroBancoEmissor;

            var tipoCosigo = IdentificarTipoCodigo(codigo);
            BancoEmissor? bancoEmissor = null;

            if (tipoCosigo != TipoCodigoEnum.invalido)
            {
                numeroBancoEmissor = codigo.Substring(0, 3);
                bancoEmissor = ListaDeBacos.Lista().Where(c => c.Codigo.Equals(numeroBancoEmissor)).FirstOrDefault();
            }

            return bancoEmissor;
        }

        /// <summary>
        /// Identifica o Tipo de Código
        /// </summary>
        /// <param name="codigo">Código</param>
        /// <returns>Tipo do Código</returns>
        public TipoCodigoEnum IdentificarTipoCodigo(string codigo)
        {
            if (codigo.Length == 44)
            {
                return TipoCodigoEnum.codigoDeBarras;
            }
            else if (codigo.Length >= 46 && codigo.Length <= 48)
            {
                return TipoCodigoEnum.linhaDigitavel;
            }

            return TipoCodigoEnum.invalido;
        }

        public TipoBoletoEnum IdentificarTipoBoleto(string codigo)
        {
            var reverse = codigo.Reverse().ToArray();

            var _codigoReverse = string.Join("", reverse);

            if (_codigoReverse.Substring(0, 14) == "00000000000000" || _codigoReverse.Substring(5, 19) == "00000000000000")
            {
                return TipoBoletoEnum.CartaoDeCredito;
            }
            else if (codigo.Substring(0, 1) == "8")
            {
                if (codigo.Substring(1, 1) == "1")
                {
                    return TipoBoletoEnum.ArrecadacaoPrefeitura;
                }
                else if (codigo.Substring(1, 1) == "2")
                {
                    return TipoBoletoEnum.ConvenioSaneamento;
                }
                else if (codigo.Substring(1, 1) == "3")
                {
                    return TipoBoletoEnum.ConvenioEnergiaEletricaGas;
                }
                else if (codigo.Substring(1, 1) == "4")
                {
                    return TipoBoletoEnum.ConvenioTelecomunicacao;
                }
                else if (codigo.Substring(1, 1) == "5")
                {
                    return TipoBoletoEnum.ArrecadacaoOrgaosGovernamentais;
                }
                else if (codigo.Substring(1, 1) == "6" ||
                    codigo.Substring(1, 1) == "9")
                {
                    return TipoBoletoEnum.Outros;
                }
                else if (codigo.Substring(1, 1) == "7")
                {
                    return TipoBoletoEnum.ArrecadacaoTaxasDeTransito;
                }
            }

            return TipoBoletoEnum.Banco;
        }

        public Referencia IdentificarReferencia(string codigo)
        {
            var referencia = codigo.Substring(2, 1);

            switch (referencia)
            {
                case "6":
                    return new Referencia(10, true);
                case "7":
                    return new Referencia(10, false);
                case "8":
                    return new Referencia(11, true);
                case "9":
                    return new Referencia(11, false);
                default:
                    break;
            }
            return null;
        }

        /// <summary>
        /// Realiza o cálculo Módulo 10 do número inserido
        /// </summary>
        /// <param name="numero">numero</param>
        /// <returns>Módulo</returns>
        public string CalculaMod10(string numero)
        {
            var mult = 2;
            var soma = 0;
            var s = "";

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                var total = (mult * (int)Char.GetNumericValue(numero[i]));
                s = $"{total}{s}";

                if (--mult < 1)
                {
                    mult = 2;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                soma = soma + (int)Char.GetNumericValue(s[i]);
            }
            soma = soma % 10;
            if (soma != 0)
            {
                soma = 10 - soma;
            }
            return soma.ToString();
        }

        /// <summary>
        /// Realiza o cálculo Módulo 11 do número inserido
        /// </summary>
        /// <param name="numero">numero</param>
        /// <returns>Módulo</returns>
        public string CalculaMod11(string numero)
        {

            var reverse = numero.Reverse();
            var numeroReverso = string.Join("", reverse);

            int soma = 0;
            int peso = 2;
            int _base = 9;

            int digito = 0;

            for (int i = 0; i < numeroReverso.Length; i++)
            {
                int c = (int)Char.GetNumericValue(numeroReverso[i]);

                soma += c * peso;
                if (peso < _base)
                {
                    peso++;
                }
                else
                {
                    peso = 2;
                }
            }
            digito = (soma % 11);

            if (digito < 2)
            {
                digito = 1;
            }
            else if (digito >= 2)
            {
                digito = 11 - digito;
            }

            return digito.ToString();
        }
    }
}