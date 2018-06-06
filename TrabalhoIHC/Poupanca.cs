using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIHC
{
    public class Poupanca
    {
        public double ValorInicial { get; set; }
        public double ValorLiquido { get; set; }
        public int DiasCorridos { get; set; }
        public double ValorTotal { get; set; }

        public Poupanca() { }

        public void CalculaPoupanca()
        {
            ValorTotal = ValorInicial;
            for (int i = 1; i <= DiasCorridos; i++)
            {
                ValorTotal = ValorTotal + (ValorTotal * 0.005);
            }

            ValorLiquido = ValorTotal - ValorInicial;
        }
    }
}
