using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoletoUtils.Models
{
    public class Referencia
    {
        public int Mod { get; private set; } 
        public bool Efetivo { get; private set; }

        public Referencia(int mod, bool efetivo)
        {
            Mod = mod;
            Efetivo = efetivo;
        }
    }
}
