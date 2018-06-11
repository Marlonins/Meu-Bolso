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
    public partial class Investimentos : Form
    {
        Poupanca poupanca = new Poupanca();
        LCIA lcia = new LCIA();

        public Investimentos()
        {
            InitializeComponent();
            dateTimePicker_DataResgate.MinDate = dateTimePicker_DataAplicacao.Value.AddMonths(1);
            dateTimePicker_DataResgate_LCA.MinDate = dateTimePicker_DataAplicacao_LCA.Value.AddMonths(3);
        }

        private void textBox_ValorAplicadoPoupanca_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Digite o valor a ser aplicado.\nEx.: 500", textBox_ValorAplicadoPoupanca);
        }

        private void dateTimePicker_DataAplicacao_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Escolha a data da aplicação", dateTimePicker_DataAplicacao);
        }

        private void dateTimePicker_DataResgate_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Escolha a data de resgate da aplicação", dateTimePicker_DataResgate);
        }

        private void button_LimparPoupanca_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Limpa todos os dados inseridos", button_LimparPoupanca);
        }

        private void button_Calcular_CDB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Calcula a Poupança", button_Calcular_CDB);
        }

        private void textBox_ValorAplicadoPoupanca_Leave(object sender, EventArgs e)
        {
            double aux;

            if (Double.TryParse((textBox_ValorAplicadoPoupanca.Text), out aux) == true || textBox_ValorAplicadoPoupanca.Text == "")
            {
                if (aux < 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_ValorAplicadoPoupanca.Clear();
                    textBox_ValorAplicadoPoupanca.BackColor = Color.LightCoral;
                }
                else
                {
                    textBox_ValorAplicadoPoupanca.BackColor = Color.PaleGreen;
                    poupanca.ValorInicial = aux;
                }
            }

            else
            {
                MessageBox.Show("Por favor, digite um número real, sem vírguls ou pontos.", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ValorAplicadoPoupanca.Clear();
                textBox_ValorAplicadoPoupanca.BackColor = Color.LightCoral;
            }
        }

        private void dateTimePicker_DataAplicacao_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTimePicker_DataAplicacao.Value.AddMonths(1);
            dateTimePicker_DataResgate.MinDate = dataInicial;           
        }

        private void dateTimePicker_DataResgate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan timeSpan = dateTimePicker_DataResgate.Value - dateTimePicker_DataAplicacao.Value;
            int meses = timeSpan.Days / 30;
            label_DiasCorridosPoupanca.Text = meses.ToString();
            poupanca.DiasCorridos = meses;
        }

        private void button_LimparPoupanca_Click(object sender, EventArgs e)
        {
            label_ResultValorLiquidoAplicacaoPoupanca.BackColor = Color.White;

            textBox_ValorAplicadoPoupanca.Text = "R$";
            dateTimePicker_DataAplicacao.Value = DateTime.Today;
            dateTimePicker_DataResgate.Value = DateTime.Today.AddMonths(1);
            label_DiasCorridosPoupanca.Text = "1";
            label_ResultAplicacaoAtualizadaPoupanca.Text = "R$ 0";
            label_ResultValorLiquidoAplicacaoPoupanca.Text = "R$ 0";

            poupanca.DiasCorridos = 1;
            poupanca.ValorInicial = 0;
            poupanca.ValorLiquido = 0;
            poupanca.ValorTotal = 0;

            chart_Investimentos.Series["Poupança"].Points.Clear();
        }

        private void button_Calcular_CDB_Click(object sender, EventArgs e)
        {
            if (textBox_ValorAplicadoPoupanca.Text == "")
                poupanca.ValorInicial = 0;

            poupanca.CalculaPoupanca();
            label_ResultAplicacaoAtualizadaPoupanca.Text = String.Format("R$ {0:F2}", poupanca.ValorTotal);
            label_ResultValorLiquidoAplicacaoPoupanca.Text = String.Format("R$ {0:F2}", poupanca.ValorLiquido);

            chart_Investimentos.Series["Poupança"].Points.Clear();
            chart_Investimentos.Series["Poupança"].Points.AddXY("Valor Total Poupança", poupanca.ValorTotal);
            chart_Investimentos.Series["Poupança"].Points.AddXY("Valor LÍquido Poupança", poupanca.ValorLiquido);
        }

        private void textBox_ValorAplicadoLCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Digite o valor a ser aplicado.\nEx.: 5000", textBox_ValorAplicadoLCA);
        }

        private void dateTimePicker_DataAplicacao_LCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Escolha a data de aplicação", dateTimePicker_DataAplicacao_LCA);
        }

        private void dateTimePicker_DataResgate_LCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Escolha a data de resgate da aplicação", dateTimePicker_DataResgate_LCA);
        }

        private void textBox_TaxaDI_LCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Digite o valor da Taxa DI anual.\nEx.: 14", textBox_TaxaDI_LCA);
        }

        private void textBox_PercentualCDI_LCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Digite o valor do Percentual do CDI.\nEx.: 95", textBox_PercentualCDI_LCA);
        }

        private void textBox_ValorAplicadoLCA_Leave(object sender, EventArgs e)
        {
            double aux;

            if (Double.TryParse((textBox_ValorAplicadoLCA.Text), out aux) == true || textBox_ValorAplicadoLCA.Text == "")
            {
                if (aux < 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_ValorAplicadoLCA.Clear();
                    textBox_ValorAplicadoLCA.BackColor = Color.LightCoral;
                }
                else
                {
                    textBox_ValorAplicadoLCA.BackColor = Color.PaleGreen;
                    lcia.ValorAplicado = aux;
                }
            }

            else
            {
                MessageBox.Show("Por favor, digite um número real, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ValorAplicadoLCA.Clear();
                textBox_ValorAplicadoLCA.BackColor = Color.LightCoral;
            }
        }

        private void dateTimePicker_DataAplicacao_LCA_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTimePicker_DataAplicacao_LCA.Value.AddMonths(3);
            dateTimePicker_DataResgate_LCA.MinDate = dataInicial;
        }

        private void dateTimePicker_DataResgate_LCA_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan timeSpan = dateTimePicker_DataResgate_LCA.Value - dateTimePicker_DataAplicacao_LCA.Value;
            int meses = timeSpan.Days / 30;
            label_ResultadoMeses_LCA.Text = meses.ToString();
            lcia.MesesCorridos = meses;
        }

        private void textBox_TaxaDI_LCA_Leave(object sender, EventArgs e)
        {
            double aux;

            if (Double.TryParse((textBox_TaxaDI_LCA.Text), out aux) == true || textBox_TaxaDI_LCA.Text == "")
            {
                if (aux < 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_TaxaDI_LCA.Clear();
                    textBox_TaxaDI_LCA.BackColor = Color.LightCoral;
                }
                else
                {
                    textBox_TaxaDI_LCA.BackColor = Color.PaleGreen;
                    lcia.TaxaDI = aux;
                }
            }

            else
            {
                MessageBox.Show("Por favor, digite um número real, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_TaxaDI_LCA.Clear();
                textBox_TaxaDI_LCA.BackColor = Color.LightCoral;
            }
        }

        private void textBox_PercentualCDI_LCA_Leave(object sender, EventArgs e)
        {
            double aux;

            if (Double.TryParse((textBox_PercentualCDI_LCA.Text), out aux) == true || textBox_PercentualCDI_LCA.Text == "")
            {
                if (aux < 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_PercentualCDI_LCA.Clear();
                    textBox_PercentualCDI_LCA.BackColor = Color.LightCoral;
                }
                else
                {
                    textBox_PercentualCDI_LCA.BackColor = Color.PaleGreen;
                    lcia.PercentualCDI = aux;
                }
            }

            else
            {
                MessageBox.Show("Por favor, digite um número real, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PercentualCDI_LCA.Clear();
                textBox_PercentualCDI_LCA.BackColor = Color.LightCoral;
            }
        }

        private void button_LimparLCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Limpa todos os dados inseridos", button_LimparLCA);
        }

        private void button_Calcular_LCA_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Calcula o LCI/LCA", button_Calcular_LCA);
        }

        private void button_LimparLCA_Click(object sender, EventArgs e)
        {
            textBox_ValorAplicadoLCA.BackColor = Color.White;
            dateTimePicker_DataAplicacao_LCA.BackColor = Color.White;
            dateTimePicker_DataResgate_LCA.BackColor = Color.White;
            label_ResultadoMeses_LCA.BackColor = Color.White;
            textBox_TaxaDI_LCA.BackColor = Color.White;
            textBox_PercentualCDI_LCA.BackColor = Color.White;

            textBox_ValorAplicadoLCA.Text = "R$";
            dateTimePicker_DataAplicacao_LCA.Value = DateTime.Today;
            dateTimePicker_DataResgate_LCA.Value = DateTime.Today.AddMonths(3);
            label_ResultadoMeses_LCA.Text = "3";
            textBox_TaxaDI_LCA.Text = "R$";
            textBox_PercentualCDI_LCA.Text = "R$";

            lcia.MesesCorridos = 3;
            lcia.PercentualCDI = 0;
            lcia.PercentualLiquido = 0;
            lcia.ValorAplicado = 0;
            lcia.ValorLiquido = 0;
            lcia.ValorTotal = 0;

            chart_Investimentos.Series["LCI/LCA"].Points.Clear();
        }

        private void button_Calcular_LCA_Click(object sender, EventArgs e)
        {
            if (textBox_ValorAplicadoPoupanca.Text == "")
                lcia.ValorAplicado = 0;
            if (textBox_TaxaDI_LCA.Text == "")
                lcia.TaxaDI = 0;
            if (textBox_PercentualCDI_LCA.Text == "")
                lcia.PercentualCDI = 0;

            lcia.CalculaLCIA();
            label_ResultadoAplicacaoAtualizada_LCA.Text = String.Format("R$ {0:F2}", lcia.ValorTotal);
            label_ResultadoValorRendimentoLiquido_LCA.Text = String.Format("R$ {0:F2}", lcia.ValorLiquido);

            chart_Investimentos.Series["LCI/LCA"].Points.Clear();
            chart_Investimentos.Series["LCI/LCA"].Points.AddXY("Valor Total LCI/LCA", lcia.ValorTotal);
            chart_Investimentos.Series["LCI/LCA"].Points.AddXY("Valor Líquido LCI/LCA", lcia.ValorLiquido);
        }

        private void textBox_ValorAplicadoPoupanca_Enter(object sender, EventArgs e)
        {
            textBox_ValorAplicadoPoupanca.Clear();
        }

        private void textBox_ValorAplicadoLCA_Enter(object sender, EventArgs e)
        {
            textBox_ValorAplicadoLCA.Clear();
        }

        private void textBox_TaxaDI_LCA_Enter(object sender, EventArgs e)
        {
            textBox_TaxaDI_LCA.Clear();
        }

        private void textBox_PercentualCDI_LCA_Enter(object sender, EventArgs e)
        {
            textBox_PercentualCDI_LCA.Clear();
        }

        private void button_AjudaPou_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Ajuda", button_AjudaPou);
        }

        private void button_AjudaLC_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Ajuda", button_AjudaLC);
        }

        private void button_AjudaPou_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"- Preencha o campo 'Valor Aplicado', em R$, sem vírgulas ou pontos, para informar o valor aplicado na Poupança.

- Escolha a data em que o valor foi aplicado em 'Data da Aplicação'.

- Escolha a data em que se pretende resgatar o dinheiro em 'Data do Resgate'

- Clicando em 'Simular', o sistema irá simular os valores da aplicação, mostrados em 'Aplicação Atualização' e 'Valor do Rendimento'.

- Clique em 'Limpar' para apagar todos os dados.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button_AjudaLC_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"- Preencha o campo 'Valor Aplicado', em R$, sem vírgulas ou pontos, para informar o valor aplicado no LCI/LCA.

- Escolha a data em que o valor foi aplicado em 'Data da Aplicação'.

- Escolha a data em que se pretende resgatar o dinheiro em 'Data do Resgate'.

- Preencha o campo 'Taxa DI', em % e sem vírgulas ou pontos, para informar a Taxa DI ao ano para a simulação.

- Preencha o campo 'Percentual do CDI', em % e sem vírgulas ou pontos, para informar o Percentual do CDI para a simulação. 

- Clicando em 'Simular', o sistema irá simular os valores da aplicação, mostrados em 'Aplicação Atualização' e 'Valor do Rendimento'.

- Clique em 'Limpar' para apagar todos os dados.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
