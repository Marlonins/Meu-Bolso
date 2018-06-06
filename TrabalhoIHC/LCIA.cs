using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIHC
{
    public class LCIA
    {
        public double ValorAplicado { get; set; }
        public int MesesCorridos { get; set; }
        public double TaxaDI { get; set; }
        public double PercentualCDI { get; set; }
        public double PercentualLiquido { get; set; }
        public double ValorLiquido { get; set; }
        public double ValorTotal { get; set; }

        public LCIA()
        {
            
        }

        public void CalculaLCIA()
        {
            double taxas = (TaxaDI * 0.01) * (PercentualCDI * 0.01);
            PercentualLiquido = MesesCorridos * (taxas / 12);
            ValorLiquido = ValorAplicado * PercentualLiquido;
            ValorTotal = ValorAplicado + ValorLiquido;
        }
    }
}
