

# Biblioteca com funcionalidades úteis para Código de Barras e ou Linha Digitável

###  1. Recursos
- [x] Validar boleto
- [x] Identificar banco emissor do boleto
- [x] Código de barras para linha digitável
- [x] Linha digitável para código de barras
- [x] Identificar tipo de boleto
- [x] Identificar tipo de código
- [x] Identificar valor do boleto
- [x] Identificar data de vencimento
- [x] Cálculo digito verificador módulo 10
- [x] Cálculo digito verificador módulo 11
## 2. Métodos
Métodos | Definição
--- | ---
`bool ValidarCodigoComDigitoVerificador({required String codigo, required TipoCodigo tipoCodigo})` | Calcula o dígito verificador de toda a numeração do código de barras. Retorno `true` para numeração válida e `false` para inválida.
`String calculaDVCodBarras({required String codigo,required int posicaoCodigo, required int mod})` | Verifica a numeração do código de barras, extrai o DV (dígito verificador) presente na posição indicada, realiza o cálculo do dígito utilizando o módulo indicado e retorna o dígito verificador. Serve para validar o código de barras. Requer numeração completa (com ou sem formatação), caracteres numéricos que representam a posição do dígito verificador no código de barras e caracteres numéricos que representam o módulo a ser usado (valores aceitos: 10 ou 11).
`DateTime identificarDataVencimento({required String codigo, required TipoCodigo tipoCodigo}` | Verifica a numeração, o tipo de código inserido e o tipo de boleto e retorna a data de vencimento. Requer numeração completa (com ou sem formatação) e tipo de código que está sendo inserido (TipoCodigo.codigoDeBarra ou TipoCodigo.linhaDigitavel).
`double identificarValor(String codigo)` | Verifica a numeração, o tipo de código inserido e o tipo de boleto e retorna o valor do título. Requer numeração completa (com ou sem formatação).
`String linhaParaCodigo(String codigo)` | Transforma a numeração no formato linha digitável em código de barras. Requer numeração completa (com ou sem formatação).
`String codigoParaLinha({required String barcode, bool formatada = false})` | Transforma a numeração no formato de código de barras em linha digitável. Requer numeração completa (com ou sem formatação) e valor `true` ou `false` que representam a forma em que o código convertido será exibido. Com (true) ou sem (false) formatação.
`BancoEmissor identificarBancoEmissor(String codigo)` | Verifica a numeração dos três primeiros digitos e retorna o BancoEmissor com número, nome do banco, ISPB, PDF com lista atualizada diariamente pelo Banco Central.
`TipoCodigo identificarTipoCodigo(String codigo)` | Verifica a numeração e retorna o tipo do código inserido. TipoCodigo.codigoDeBarra, TipoCodigo.linhaDigitavel ou TipoCodigo.invalido. Requer numeração completa (com ou sem formatação).
`TipoBoleto? identificarTipoBoleto(String codigo)` | Verifica a numeração e retorna o tipo do boleto inserido. Se boleto bancário, convênio ou arrecadação. Requer numeração completa (com ou sem formatação).
`String calculaMod10(String numero)` | Realiza o cálculo Módulo 10 do número inserido.
`String calculaMod11(String numero)` | Realiza o cálculo Módulo 11 do número inserido.

---
Agradecimentos ao colega de trabalho [Philippe](https://github.com/Philippenau-Dev) pelo apoio.
