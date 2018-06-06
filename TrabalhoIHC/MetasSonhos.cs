using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIHC
{
    public class MetasSonhos
    {
        public string Descricao { get; set; }
        public int Meses { get; set; }
        public double ValorMeta { get; set; }
        public double Poupanca { get; set; }

        public MetasSonhos() { }

        public void CalculaMeta()
        {
            Poupanca = ValorMeta / Meses;
        }
    }
}
