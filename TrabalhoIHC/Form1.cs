using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoIHC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ReceitasDespesas_Click(object sender, EventArgs e)
        {
            ReceitasDespesas janelaReceitasDespesas = new ReceitasDespesas();
            janelaReceitasDespesas.Show();
        }

        private void button_Investimentos_Click(object sender, EventArgs e)
        {
            Investimentos investimentos = new Investimentos();
            investimentos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metas metas = new Metas();
            metas.Show();
        }
    }
}
