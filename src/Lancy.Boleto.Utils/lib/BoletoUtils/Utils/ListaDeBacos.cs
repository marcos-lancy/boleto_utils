using BoletoUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoUtils.Utils
{
    /// <summary>
    /// Lista de bancos
    /// </summary>
    public static class ListaDeBacos
    {
        public static IEnumerable<BancoEmissor> Lista()
        {
            IEnumerable<BancoEmissor> listaDeBancos = new List<BancoEmissor>()
            {
                new BancoEmissor(
                codigo: "001",
                banco: "BANCO DO BRASIL S.A (BB)",
                iSPB: "00000000"
                ),
                new BancoEmissor(
                codigo: "237",
                banco: "BRADESCO S.A",
                iSPB: "60746948"
                ),
                new BancoEmissor(
                codigo: "335",
                banco: "Banco Digio S.A",
                iSPB: "27098060"
                ),
                new BancoEmissor(
                codigo: "260",
                banco: "NU PAGAMENTOS S.A (NUBANK)",
                iSPB: "18236120"
                ),
                new BancoEmissor(
                codigo: "290",
                banco: "Pagseguro Internet S.A (PagBank)",
                iSPB: "08561701"
                ),
                new BancoEmissor(
                codigo: "380",
                banco: "PicPay Servicos S.A.",
                iSPB: "22896431"
                ),
                new BancoEmissor(
                codigo: "323",
                banco: "Mercado Pago – conta do Mercado Livre",
                iSPB: "10573521"
                ),
                new BancoEmissor(
                codigo: "237",
                banco: "NEXT BANK (Mesmo código do Bradesco)",
                iSPB: "60746948"
                ),
                new BancoEmissor(
                codigo: "637",
                banco: "BANCO SOFISA S.A (SOFISA DIRETO)",
                iSPB: "60889128"
                ),
                new BancoEmissor(
                codigo: "077",
                banco: "BANCO INTER S.A",
                iSPB: "00416968"
                ),
                new BancoEmissor(
                codigo: "341",
                banco: "ITAÚ UNIBANCO S.A",
                iSPB: "60701190"
                ),
                new BancoEmissor(
                codigo: "104",
                banco: "CAIXA ECONÔMICA FEDERAL (CEF)",
                iSPB: "00360305"
                ),
                new BancoEmissor(
                codigo: "033",
                banco: "BANCO SANTANDER BRASIL S.A",
                iSPB: "90400888"
                ),
                new BancoEmissor(
                codigo: "212",
                banco: "BANCO ORIGINAL S.A",
                iSPB: "92894922"
                ),
                new BancoEmissor(
                codigo: "756",
                banco: "BANCOOB (BANCO COOPERATIVO DO BRASIL)",
                iSPB: "02038232"
                ),
                new BancoEmissor(
                codigo: "655",
                banco: "BANCO VOTORANTIM S.A | NEON PAGAMENTOS S.A",
                iSPB: "59588111"
                ),
                new BancoEmissor(
                codigo: "041",
                banco: "BANRISUL – BANCO DO ESTADO DO RIO GRANDE DO SUL S.A",
                iSPB: "92702067"
                ),
                new BancoEmissor(
                codigo: "389",
                banco: "BANCO MERCANTIL DO BRASIL S.A",
                iSPB: "17184037"
                ),
                new BancoEmissor(
                codigo: "422",
                banco: "BANCO SAFRA S.A",
                iSPB: "58160789"
                ),
                new BancoEmissor(
                codigo: "070",
                banco: "BANCO DE BRASÍLIA (BRB)",
                iSPB: "00000208"
                ),
                new BancoEmissor(
                codigo: "136",
                banco: "UNICRED COOPERATIVA",
                iSPB: "00315557"
                ),
                new BancoEmissor(
                codigo: "741",
                banco: "BANCO RIBEIRÃO PRETO",
                iSPB: "00517645"
                ),
                new BancoEmissor(
                codigo: "739",
                banco: "BANCO CETELEM S.A",
                iSPB: "00558456"
                ),
                new BancoEmissor(
                codigo: "743",
                banco: "BANCO SEMEAR S.A",
                iSPB: "00795423"
                ),
                new BancoEmissor(
                codigo: "100",
                banco: "PLANNER CORRETORA DE VALORES S.A",
                iSPB: "00806535"
                ),
                new BancoEmissor(
                codigo: "096",
                banco: "BANCO B3 S.A",
                iSPB: "00997185"
                ),
                new BancoEmissor(
                codigo: "747",
                banco: "Banco RABOBANK INTERNACIONAL DO BRASIL S.A",
                iSPB: "01023570"
                ),
                new BancoEmissor(
                codigo: "748",
                banco: "SICREDI S.A",
                iSPB: "01181521"
                ),
                new BancoEmissor(
                codigo: "752",
                banco: "BNP PARIBAS BRASIL S.A",
                iSPB: "01522368"
                ),
                new BancoEmissor(
                codigo: "091",
                banco: "UNICRED CENTRAL RS",
                iSPB: "01634601"
                ),
                new BancoEmissor(
                codigo: "399",
                banco: "KIRTON BANK",
                iSPB: "01701201"
                ),
                new BancoEmissor(
                codigo: "108",
                banco: "PORTOCRED S.A",
                iSPB: "01800019"
                ),
                new BancoEmissor(
                codigo: "757",
                banco: "BANCO KEB HANA DO BRASIL S.A",
                iSPB: "02318507"
                ),
                new BancoEmissor(
                codigo: "102",
                banco: "XP INVESTIMENTOS S.A",
                iSPB: "02332886"
                ),
                new BancoEmissor(
                codigo: "348",
                banco: "BANCO XP S/A",
                iSPB: "33264668"
                ),
                new BancoEmissor(
                codigo: "340",
                banco: "SUPER PAGAMENTOS S/A (SUPERDITAL)",
                iSPB: "09554480"
                ),
                new BancoEmissor(
                codigo: "364",
                banco: "GERENCIANET PAGAMENTOS DO BRASIL",
                iSPB: "09089356"
                ),
                new BancoEmissor(
                codigo: "084",
                banco: "UNIPRIME NORTE DO PARANÁ",
                iSPB: "02398976"
                ),
                new BancoEmissor(
                codigo: "180",
                banco: "CM CAPITAL MARKETS CCTVM LTDA",
                iSPB: "02685483"
                ),
                new BancoEmissor(
                codigo: "066",
                banco: "BANCO MORGAN STANLEY S.A",
                iSPB: "02801938"
                ),
                new BancoEmissor(
                codigo: "015",
                banco: "UBS BRASIL CCTVM S.A",
                iSPB: "02819125"
                ),
                new BancoEmissor(
                codigo: "143",
                banco: "TREVISO CC S.A",
                iSPB: "02992317"
                ),
                new BancoEmissor(
                codigo: "062",
                banco: "HIPERCARD BM S.A",
                iSPB: "03012230"
                ),
                new BancoEmissor(
                codigo: "074",
                banco: "BCO. J.SAFRA S.A",
                iSPB: "03017677"
                ),
                new BancoEmissor(
                codigo: "099",
                banco: "UNIPRIME CENTRAL CCC LTDA",
                iSPB: "03046391"
                ),
                new BancoEmissor(
                codigo: "025",
                banco: "BANCO ALFA S.A.",
                iSPB: "03323840"
                ),
                new BancoEmissor(
                codigo: "075",
                banco: "BCO ABN AMRO S.A",
                iSPB: "03532415"
                ),
                new BancoEmissor(
                codigo: "040",
                banco: "BANCO CARGILL S.A",
                iSPB: "03609817"
                ),
                new BancoEmissor(
                codigo: "190",
                banco: "SERVICOOP",
                iSPB: "03973814"
                ),
                new BancoEmissor(
                codigo: "063",
                banco: "BANCO BRADESCARD",
                iSPB: "04184779"
                ),
                new BancoEmissor(
                codigo: "191",
                banco: "NOVA FUTURA CTVM LTDA",
                iSPB: "04257795"
                ),
                new BancoEmissor(
                codigo: "064",
                banco: "GOLDMAN SACHS DO BRASIL BM S.A",
                iSPB: "04332281"
                ),
                new BancoEmissor(
                codigo: "097",
                banco: "CCC NOROESTE BRASILEIRO LTDA",
                iSPB: "04632856"
                ),
                new BancoEmissor(
                codigo: "016",
                banco: "CCM DESP TRÂNS SC E RS",
                iSPB: "04715685"
                ),
                new BancoEmissor(
                codigo: "012",
                banco: "BANCO INBURSA",
                iSPB: "04866275"
                ),
                new BancoEmissor(
                codigo: "003",
                banco: "BANCO DA AMAZONIA S.A",
                iSPB: "04902979"
                ),
                new BancoEmissor(
                codigo: "060",
                banco: "CONFIDENCE CC S.A",
                iSPB: "04913129"
                ),
                new BancoEmissor(
                codigo: "037",
                banco: "BANCO DO ESTADO DO PARÁ S.A",
                iSPB: "04913711"
                ),
                new BancoEmissor(
                codigo: "159",
                banco: "CASA CREDITO S.A",
                iSPB: "05442029"
                ),
                new BancoEmissor(
                codigo: "172",
                banco: "ALBATROSS CCV S.A",
                iSPB: "05452073"
                ),
                new BancoEmissor(
                codigo: "085",
                banco: "COOP CENTRAL AILOS",
                iSPB: "05463212"
                ),
                new BancoEmissor(
                codigo: "114",
                banco: "CENTRAL COOPERATIVA DE CRÉDITO NO ESTADO DO ESPÍRITO SANTO",
                iSPB: "05790149"
                ),
                new BancoEmissor(
                codigo: "036",
                banco: "BANCO BBI S.A",
                iSPB: "06271464"
                ),
                new BancoEmissor(
                codigo: "394",
                banco: "BANCO BRADESCO FINANCIAMENTOS S.A",
                iSPB: "07207996"
                ),
                new BancoEmissor(
                codigo: "004",
                banco: "BANCO DO NORDESTE DO BRASIL S.A.",
                iSPB: "07237373"
                ),
                new BancoEmissor(
                codigo: "320",
                banco: "BANCO CCB BRASIL S.A",
                iSPB: "07450604"
                ),
                new BancoEmissor(
                codigo: "189",
                banco: "HS FINANCEIRA",
                iSPB: "07512441"
                ),
                new BancoEmissor(
                codigo: "105",
                banco: "LECCA CFI S.A",
                iSPB: "07652226"
                ),
                new BancoEmissor(
                codigo: "076",
                banco: "BANCO KDB BRASIL S.A.",
                iSPB: "07656500"
                ),
                new BancoEmissor(
                codigo: "082",
                banco: "BANCO TOPÁZIO S.A",
                iSPB: "07679404"
                ),
                new BancoEmissor(
                codigo: "286",
                banco: "CCR DE OURO",
                iSPB: "07853842"
                ),
                new BancoEmissor(
                codigo: "093",
                banco: "PÓLOCRED SCMEPP LTDA",
                iSPB: "07945233"
                ),
                new BancoEmissor(
                codigo: "273",
                banco: "CCR DE SÃO MIGUEL DO OESTE",
                iSPB: "08253539"
                ),
                new BancoEmissor(
                codigo: "157",
                banco: "ICAP DO BRASIL CTVM LTDA",
                iSPB: "09105360"
                ),
                new BancoEmissor(
                codigo: "183",
                banco: "SOCRED S.A",
                iSPB: "09210106"
                ),
                new BancoEmissor(
                codigo: "014",
                banco: "NATIXIS BRASIL S.A",
                iSPB: "09274232"
                ),
                new BancoEmissor(
                codigo: "130",
                banco: "CARUANA SCFI",
                iSPB: "09313766"
                ),
                new BancoEmissor(
                codigo: "127",
                banco: "CODEPE CVC S.A",
                iSPB: "09512542"
                ),
                new BancoEmissor(
                codigo: "079",
                banco: "BANCO ORIGINAL DO AGRONEGÓCIO S.A",
                iSPB: "09516419"
                ),
                new BancoEmissor(
                codigo: "081",
                banco: "BBN BANCO BRASILEIRO DE NEGOCIOS S.A",
                iSPB: "10264663"
                ),
                new BancoEmissor(
                codigo: "118",
                banco: "STANDARD CHARTERED BI S.A",
                iSPB: "11932017"
                ),
                new BancoEmissor(
                codigo: "133",
                banco: "CRESOL CONFEDERAÇÃO",
                iSPB: "10398952"
                ),
                new BancoEmissor(
                codigo: "121",
                banco: "BANCO AGIBANK S.A",
                iSPB: "10664513"
                ),
                new BancoEmissor(
                codigo: "083",
                banco: "BANCO DA CHINA BRASIL S.A",
                iSPB: "10690848"
                ),
                new BancoEmissor(
                codigo: "138",
                banco: "GET MONEY CC LTDA",
                iSPB: "10853017"
                ),
                new BancoEmissor(
                codigo: "024",
                banco: "BCO BANDEPE S.A",
                iSPB: "10866788"
                ),
                new BancoEmissor(
                codigo: "095",
                banco: "BANCO CONFIDENCE DE CÂMBIO S.A",
                iSPB: "11703662"
                ),
                new BancoEmissor(
                codigo: "094",
                banco: "BANCO FINAXIS",
                iSPB: "11758741"
                ),
                new BancoEmissor(
                codigo: "276",
                banco: "SENFF S.A",
                iSPB: "11970623"
                ),
                new BancoEmissor(
                codigo: "137",
                banco: "MULTIMONEY CC LTDA",
                iSPB: "12586596"
                ),
                new BancoEmissor(
                codigo: "092",
                banco: "BRK S.A",
                iSPB: "12865507"
                ),
                new BancoEmissor(
                codigo: "047",
                banco: "BANCO BCO DO ESTADO DE SERGIPE S.A",
                iSPB: "13009717"
                ),
                new BancoEmissor(
                codigo: "144",
                banco: "BEXS BANCO DE CAMBIO S.A.",
                iSPB: "13059145"
                ),
                new BancoEmissor(
                codigo: "126",
                banco: "BR PARTNERS BI",
                iSPB: "13220493"
                ),
                new BancoEmissor(
                codigo: "301",
                banco: "BPP INSTITUIÇÃO DE PAGAMENTOS S.A",
                iSPB: "13370835"
                ),
                new BancoEmissor(
                codigo: "173",
                banco: "BRL TRUST DTVM SA",
                iSPB: "13486793"
                ),
                new BancoEmissor(
                codigo: "119",
                banco: "BANCO WESTERN UNION",
                iSPB: "13720915"
                ),
                new BancoEmissor(
                codigo: "254",
                banco: "PARANA BANCO S.A",
                iSPB: "14388334"
                ),
                new BancoEmissor(
                codigo: "268",
                banco: "BARIGUI CH",
                iSPB: "14511781"
                ),
                new BancoEmissor(
                codigo: "107",
                banco: "BANCO BOCOM BBM S.A",
                iSPB: "15114366"
                ),
                new BancoEmissor(
                codigo: "412",
                banco: "BANCO CAPITAL S.A",
                iSPB: "15173776"
                ),
                new BancoEmissor(
                codigo: "124",
                banco: "BANCO WOORI BANK DO BRASIL S.A",
                iSPB: "15357060"
                ),
                new BancoEmissor(
                codigo: "149",
                banco: "FACTA S.A. CFI",
                iSPB: "15581638"
                ),
                new BancoEmissor(
                codigo: "197",
                banco: "STONE PAGAMENTOS S.A",
                iSPB: "16501555"
                ),
                new BancoEmissor(
                codigo: "142",
                banco: "BROKER BRASIL CC LTDA",
                iSPB: "16944141"
                ),
                new BancoEmissor(
                codigo: "389",
                banco: "BANCO MERCANTIL DO BRASIL S.A.",
                iSPB: "17184037"
                ),
                new BancoEmissor(
                codigo: "184",
                banco: "BANCO ITAÚ BBA S.A",
                iSPB: "17298092"
                ),
                new BancoEmissor(
                codigo: "634",
                banco: "BANCO TRIANGULO S.A (BANCO TRIÂNGULO)",
                iSPB: "17351180"
                ),
                new BancoEmissor(
                codigo: "545",
                banco: "SENSO CCVM S.A",
                iSPB: "17352220"
                ),
                new BancoEmissor(
                codigo: "132",
                banco: "ICBC DO BRASIL BM S.A",
                iSPB: "17453575"
                ),
                new BancoEmissor(
                codigo: "298",
                banco: "VIPS CC LTDA",
                iSPB: "17772370"
                ),
                new BancoEmissor(
                codigo: "129",
                banco: "UBS BRASIL BI S.A",
                iSPB: "18520834"
                ),
                new BancoEmissor(
                codigo: "128",
                banco: "MS BANK S.A BANCO DE CÂMBIO",
                iSPB: "19307785"
                ),
                new BancoEmissor(
                codigo: "194",
                banco: "PARMETAL DTVM LTDA",
                iSPB: "20155248"
                ),
                new BancoEmissor(
                codigo: "310",
                banco: "VORTX DTVM LTDA",
                iSPB: "22610500"
                ),
                new BancoEmissor(
                codigo: "163",
                banco: "COMMERZBANK BRASIL S.A BANCO MÚLTIPLO",
                iSPB: "23522214"
                ),
                new BancoEmissor(
                codigo: "280",
                banco: "AVISTA S.A",
                iSPB: "23862762"
                ),
                new BancoEmissor(
                codigo: "146",
                banco: "GUITTA CC LTDA",
                iSPB: "24074692"
                ),
                new BancoEmissor(
                codigo: "279",
                banco: "CCR DE PRIMAVERA DO LESTE",
                iSPB: "26563270"
                ),
                new BancoEmissor(
                codigo: "182",
                banco: "DACASA FINANCEIRA S/A",
                iSPB: "27406222"
                ),
                new BancoEmissor(
                codigo: "278",
                banco: "GENIAL INVESTIMENTOS CVM S.A",
                iSPB: "27652684"
                ),
                new BancoEmissor(
                codigo: "271",
                banco: "IB CCTVM LTDA",
                iSPB: "27842177"
                ),
                new BancoEmissor(
                codigo: "021",
                banco: "BANCO BANESTES S.A",
                iSPB: "28127603"
                ),
                new BancoEmissor(
                codigo: "246",
                banco: "BANCO ABC BRASIL S.A",
                iSPB: "28195667"
                ),
                new BancoEmissor(
                codigo: "751",
                banco: "SCOTIABANK BRASIL",
                iSPB: "29030467"
                ),
                new BancoEmissor(
                codigo: "208",
                banco: "BANCO BTG PACTUAL S.A",
                iSPB: "30306294"
                ),
                new BancoEmissor(
                codigo: "746",
                banco: "BANCO MODAL S.A",
                iSPB: "30723886"
                ),
                new BancoEmissor(
                codigo: "241",
                banco: "BANCO CLASSICO S.A",
                iSPB: "31597552"
                ),
                new BancoEmissor(
                codigo: "612",
                banco: "BANCO GUANABARA S.A",
                iSPB: "31880826"
                ),
                new BancoEmissor(
                codigo: "604",
                banco: "BANCO INDUSTRIAL DO BRASIL S.A",
                iSPB: "31895683"
                ),
                new BancoEmissor(
                codigo: "505",
                banco: "BANCO CREDIT SUISSE (BRL) S.A",
                iSPB: "32062580"
                ),
                new BancoEmissor(
                codigo: "196",
                banco: "BANCO FAIR CC S.A",
                iSPB: "32648370"
                ),
                new BancoEmissor(
                codigo: "300",
                banco: "BANCO LA NACION ARGENTINA",
                iSPB: "33042151"
                ),
                new BancoEmissor(
                codigo: "477",
                banco: "CITIBANK N.A",
                iSPB: "33042953"
                ),
                new BancoEmissor(
                codigo: "266",
                banco: "BANCO CEDULA S.A",
                iSPB: "33132044"
                ),
                new BancoEmissor(
                codigo: "122",
                banco: "BANCO BRADESCO BERJ S.A",
                iSPB: "33147315"
                ),
                new BancoEmissor(
                codigo: "376",
                banco: "BANCO J.P. MORGAN S.A",
                iSPB: "33172537"
                ),
                new BancoEmissor(
                codigo: "473",
                banco: "BANCO CAIXA GERAL BRASIL S.A",
                iSPB: "33466988"
                ),
                new BancoEmissor(
                codigo: "745",
                banco: "BANCO CITIBANK S.A",
                iSPB: "33479023"
                ),
                new BancoEmissor(
                codigo: "120",
                banco: "BANCO RODOBENS S.A",
                iSPB: "33603457"
                ),
                new BancoEmissor(
                codigo: "265",
                banco: "BANCO FATOR S.A",
                iSPB: "33644196"
                ),
                new BancoEmissor(
                codigo: "007",
                banco: "BNDES (Banco Nacional do Desenvolvimento Social)",
                iSPB: "33657248"
                ),
                new BancoEmissor(
                codigo: "188",
                banco: "ATIVA S.A INVESTIMENTOS",
                iSPB: "33775974"
                ),
                new BancoEmissor(
                codigo: "134",
                banco: "BGC LIQUIDEZ DTVM LTDA",
                iSPB: "33862244"
                ),
                new BancoEmissor(
                codigo: "641",
                banco: "BANCO ALVORADA S.A",
                iSPB: "33870163"
                ),
                new BancoEmissor(
                codigo: "029",
                banco: "BANCO ITAÚ CONSIGNADO S.A",
                iSPB: "33885724"
                ),
                new BancoEmissor(
                codigo: "243",
                banco: "BANCO MÁXIMA S.A",
                iSPB: "33923798"
                ),
                new BancoEmissor(
                codigo: "078",
                banco: "HAITONG BI DO BRASIL S.A",
                iSPB: "34111187"
                ),
                new BancoEmissor(
                codigo: "111",
                banco: "BANCO OLIVEIRA TRUST DTVM S.A",
                iSPB: "36113876"
                ),
                new BancoEmissor(
                codigo: "017",
                banco: "BNY MELLON BANCO S.A",
                iSPB: "42272526"
                ),
                new BancoEmissor(
                codigo: "174",
                banco: "PERNAMBUCANAS FINANC S.A",
                iSPB: "PERNAMBUCANAS FINANC S.A"
                ),
                new BancoEmissor(
                codigo: "495",
                banco: "LA PROVINCIA BUENOS AIRES BANCO",
                iSPB: "44189447"
                ),
                new BancoEmissor(
                codigo: "125",
                banco: "BRASIL PLURAL S.A BANCO",
                iSPB: "45246410"
                ),
                new BancoEmissor(
                codigo: "488",
                banco: "JPMORGAN CHASE BANK",
                iSPB: "46518205"
                ),
                new BancoEmissor(
                codigo: "065",
                banco: "BANCO ANDBANK S.A",
                iSPB: "48795256"
                ),
                new BancoEmissor(
                codigo: "492",
                banco: "ING BANK N.V",
                iSPB: "49336860"
                ),
                new BancoEmissor(
                codigo: "250",
                banco: "BANCO BCV",
                iSPB: "50585090"
                ),
                new BancoEmissor(
                codigo: "145",
                banco: "LEVYCAM CCV LTDA",
                iSPB: "50579044"
                ),
                new BancoEmissor(
                codigo: "494",
                banco: "BANCO REP ORIENTAL URUGUAY",
                iSPB: "51938876"
                ),
                new BancoEmissor(
                codigo: "253",
                banco: "BEXS CC S.A",
                iSPB: "52937216"
                ),
                new BancoEmissor(
                codigo: "269",
                banco: "HSBC BANCO DE INVESTIMENTO",
                iSPB: "53518684"
                ),
                new BancoEmissor(
                codigo: "213",
                banco: "BCO ARBI S.A",
                iSPB: "54403563"
                ),
                new BancoEmissor(
                codigo: "139",
                banco: "INTESA SANPAOLO BRASIL S.A",
                iSPB: "55230916"
                ),
                new BancoEmissor(
                codigo: "018",
                banco: "BANCO TRICURY S.A",
                iSPB: "57839805"
                ),
                new BancoEmissor(
                codigo: "630",
                banco: "BANCO INTERCAP S.A",
                iSPB: "58497702"
                ),
                new BancoEmissor(
                codigo: "224",
                banco: "BANCO FIBRA S.A",
                iSPB: "58616418"
                ),
                new BancoEmissor(
                codigo: "600",
                banco: "BANCO LUSO BRASILEIRO S.A",
                iSPB: "59118133"
                ),
                new BancoEmissor(
                codigo: "623",
                banco: "BANCO PAN",
                iSPB: "59285411"
                ),
                new BancoEmissor(
                codigo: "204",
                banco: "BANCO BRADESCO CARTOES S.A",
                iSPB: "59438325"
                ),
                new BancoEmissor(
                codigo: "479",
                banco: "BANCO ITAUBANK S.A",
                iSPB: "60394079"
                ),
                new BancoEmissor(
                codigo: "456",
                banco: "BANCO MUFG BRASIL S.A",
                iSPB: "60498557"
                ),
                new BancoEmissor(
                codigo: "464",
                banco: "BANCO SUMITOMO MITSUI BRASIL S.A",
                iSPB: "60518222"
                ),
                new BancoEmissor(
                codigo: "613",
                banco: "OMNI BANCO S.A",
                iSPB: "60850229"
                ),
                new BancoEmissor(
                codigo: "652",
                banco: "ITAÚ UNIBANCO HOLDING BM S.A",
                iSPB: "60872504"
                ),
                new BancoEmissor(
                codigo: "653",
                banco: "BANCO INDUSVAL S.A",
                iSPB: "61024352"
                ),
                new BancoEmissor(
                codigo: "069",
                banco: "BANCO CREFISA S.A",
                iSPB: "61033106"
                ),
                new BancoEmissor(
                codigo: "370",
                banco: "BANCO MIZUHO S.A",
                iSPB: "61088183"
                ),
                new BancoEmissor(
                codigo: "249",
                banco: "BANCO INVESTCRED UNIBANCO S.A",
                iSPB: "61182408"
                ),
                new BancoEmissor(
                codigo: "318",
                banco: "BANCO BMG S.A",
                iSPB: "61186680"
                ),
                new BancoEmissor(
                codigo: "626",
                banco: "BANCO FICSA S.A",
                iSPB: "61348538"
                ),
                new BancoEmissor(
                codigo: "270",
                banco: "SAGITUR CC LTDA",
                iSPB: "61444949"
                ),
                new BancoEmissor(
                codigo: "366",
                banco: "BANCO SOCIETE GENERALE BRASIL",
                iSPB: "61533584"
                ),
                new BancoEmissor(
                codigo: "113",
                banco: "MAGLIANO S.A",
                iSPB: "61723847"
                ),
                new BancoEmissor(
                codigo: "131",
                banco: "TULLETT PREBON BRASIL CVC LTDA",
                iSPB: "61747085"
                ),
                new BancoEmissor(
                codigo: "011",
                banco: "C.SUISSE HEDGING-GRIFFO CV S.A (Credit Suisse)",
                iSPB: "61809182"
                ),
                new BancoEmissor(
                codigo: "611",
                banco: "BANCO PAULISTA",
                iSPB: "61820817"
                ),
                new BancoEmissor(
                codigo: "755",
                banco: "BOFA MERRILL LYNCH BM S.A",
                iSPB: "62073200"
                ),
                new BancoEmissor(
                codigo: "089",
                banco: "CCR REG MOGIANA",
                iSPB: "62109566"
                ),
                new BancoEmissor(
                codigo: "643",
                banco: "BANCO PINE S.A",
                iSPB: "62144175"
                ),
                new BancoEmissor(
                codigo: "140",
                banco: "EASYNVEST – TÍTULO CV S.A",
                iSPB: "62169875"
                ),
                new BancoEmissor(
                codigo: "707",
                banco: "BANCO DAYCOVAL S.A",
                iSPB: "62232889"
                ),
                new BancoEmissor(
                codigo: "288",
                banco: "CAROL DTVM LTDA",
                iSPB: "62237649"
                ),
                new BancoEmissor(
                codigo: "101",
                banco: "RENASCENCA DTVM LTDA",
                iSPB: "62287735"
                ),
                new BancoEmissor(
                codigo: "487",
                banco: "DEUTSCHE BANK S.A BANCO ALEMÃO",
                iSPB: "62331228"
                ),
                new BancoEmissor(
                codigo: "233",
                banco: "BANCO CIFRA",
                iSPB: "62421979"
                ),
                new BancoEmissor(
                codigo: "177",
                banco: "GUIDE",
                iSPB: "65913436"
                ),
                new BancoEmissor(
                codigo: "633",
                banco: "BANCO RENDIMENTO S.A",
                iSPB: "68900810"
                ),
                new BancoEmissor(
                codigo: "218",
                banco: "BANCO BS2 S.A",
                iSPB: "71027866"
                ),
                new BancoEmissor(
                codigo: "292",
                banco: "BS2 DISTRIBUIDORA DE TÍTULOS E INVESTIMENTOS",
                iSPB: "28650236"
                ),
                new BancoEmissor(
                codigo: "169",
                banco: "BANCO OLÉ BONSUCESSO CONSIGNADO S.A",
                iSPB: "71371686"
                ),
                new BancoEmissor(
                codigo: "293",
                banco: "LASTRO RDV DTVM LTDA",
                iSPB: "71590442"
                ),
                new BancoEmissor(
                codigo: "285",
                banco: "FRENTE CC LTDA",
                iSPB: "71677850"
                ),
                new BancoEmissor(
                codigo: "080",
                banco: "B&T CC LTDA",
                iSPB: "73622748"
                ),
                new BancoEmissor(
                codigo: "753",
                banco: "NOVO BANCO CONTINENTAL S.A BM",
                iSPB: "74828799"
                ),
                new BancoEmissor(
                codigo: "222",
                banco: "BANCO CRÉDIT AGRICOLE BR S.A",
                iSPB: "75647891"
                ),
                new BancoEmissor(
                codigo: "754",
                banco: "BANCO SISTEMA",
                iSPB: "76543115"
                ),
                new BancoEmissor(
                codigo: "098",
                banco: "CREDIALIANÇA CCR",
                iSPB: "78157146"
                ),
                new BancoEmissor(
                codigo: "610",
                banco: "BANCO VR S.A",
                iSPB: "78626983"
                ),
                new BancoEmissor(
                codigo: "712",
                banco: "BANCO OURINVEST S.A",
                iSPB: "78632767"
                ),
                new BancoEmissor(
                codigo: "010",
                banco: "CREDICOAMO",
                iSPB: "81723108"
                ),
                new BancoEmissor(
                codigo: "283",
                banco: "RB CAPITAL INVESTIMENTOS DTVM LTDA",
                iSPB: "89960090"
                ),
                new BancoEmissor(
                codigo: "217",
                banco: "BANCO JOHN DEERE S.A",
                iSPB: "91884981"
                ),
                new BancoEmissor(
                codigo: "117",
                banco: "ADVANCED CC LTDA",
                iSPB: "92856905"
                ),
                new BancoEmissor(
                codigo: "336",
                banco: "BANCO C6 S.A – C6 BANK",
                iSPB: "28326000"
                ),
                new BancoEmissor(
                codigo: "654",
                banco: "BANCO DIGIMAIS S.A",
                iSPB: "92874270"
                )

            };

            return listaDeBancos;
        }
    }
}
