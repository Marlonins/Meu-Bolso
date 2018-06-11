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
    public partial class Metas : Form
    {
        MetasSonhos meta = new MetasSonhos();
        List<MetasSonhos> metas = new List<MetasSonhos>();

        public Metas()
        {
            InitializeComponent();
            dateTimePicker_Fim.MinDate = dateTimePicker_Inicio.Value.AddMonths(1);
        }

        private void textBox_NomeMeta_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Digite o nome da meta a ser atingida.\nEx.: Viagem", textBox_NomeMeta);
        }

        private void dateTimePicker_Inicio_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Escolha a data em que começará a poupar.", dateTimePicker_Inicio);
        }

        private void dateTimePicker_Fim_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Escolha a data em que pretende realizar a meta.", dateTimePicker_Fim);
        }

        private void textBox_Valor_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Digite o valor dessa meta.\nEx.: 3000", textBox_Valor);
        }

        private void button_Limpar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Limpa todos os campos preenchidos.", button_Limpar);
        }

        private void button_Calcular_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Calcula o valor a ser poupado para atingir a meta.", button_Calcular);
        }

        private void textBox_NomeMeta_Leave(object sender, EventArgs e)
        {
            meta.Descricao = textBox_NomeMeta.Text;
        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTimePicker_Inicio.Value.AddMonths(1);
            dateTimePicker_Fim.MinDate = dataInicial;
        }

        private void dateTimePicker_Fim_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan timeSpan = dateTimePicker_Fim.Value - dateTimePicker_Inicio.Value;
            int meses = timeSpan.Days / 30;
            meta.Meses = meses;
        }

        private void textBox_Valor_Leave(object sender, EventArgs e)
        {
            double aux;

            if (Double.TryParse((textBox_Valor.Text), out aux) == true || textBox_Valor.Text == "")
            {
                if (aux < 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Valor.Clear();
                    textBox_Valor.BackColor = Color.LightCoral;
                }
                else
                {
                    textBox_Valor.BackColor = Color.PaleGreen;
                    meta.ValorMeta = aux;
                }
            }

            else
            {
                MessageBox.Show("Por favor, digite um número real", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Valor.Clear();
                textBox_Valor.BackColor = Color.LightCoral;
            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_NomeMeta.BackColor = Color.White;
            textBox_Valor.BackColor = Color.White;

            textBox_NomeMeta.Text = "";
            textBox_Valor.Text = "R$";
            dateTimePicker_Inicio.Value = DateTime.Today;
            dateTimePicker_Fim.Value = DateTime.Today.AddMonths(1);
            label_ResultPoupancaMensal.Text = "R$ 0";

            meta.Descricao = "";
            meta.Meses = 0;
            meta.Poupanca = 0;
            meta.ValorMeta = 0;
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            if (textBox_Valor.Text == "")
                meta.ValorMeta = 0;

            meta.CalculaMeta();
            label_ResultPoupancaMensal.Text = String.Format("R$ {0:F2}", meta.Poupanca);
        }

        private void textBox_Valor_Enter(object sender, EventArgs e)
        {
            textBox_Valor.Clear();
        }

        private void button_AjudaMetas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"- Preencha o campo 'Nome da Meta' para informar qual o nome da meta a ser simulada.

- Escolha a data em que o valor foi aplicado em 'Começar a poupar em'.

- Escolha a data em que se pretende realizar a meta em 'Pretende realizá-lo em'.

- Preencha o campo 'Valor da Meta', em R$ (somente o número) para informar o preço da Meta.

- Clique em 'Limpar' para apagar todos os dados.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
