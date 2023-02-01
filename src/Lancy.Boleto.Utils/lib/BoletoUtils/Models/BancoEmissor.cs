using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoUtils.Models
{
    public class BancoEmissor
    {
        public string Codigo { get; private set; }
        public string Banco { get; private set; }
        public string ISPB { get; private set; }
        public string PDF { get; private set; } = "https://www.bcb.gov.br/pom/spb/estatistica/port/ASTR003.pdf";

        public BancoEmissor(string codigo, string banco, string iSPB)
        {
            Codigo = codigo;
            Banco = banco;
            ISPB = iSPB;
        }
    }
}
