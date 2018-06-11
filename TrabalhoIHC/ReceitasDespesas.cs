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
    public partial class ReceitasDespesas : Form
    {
        List<Despesas> despesas = new List<Despesas>();
        List<Receita> receitas = new List<Receita>();
        
        public ReceitasDespesas()
        {
            InitializeComponent();
        }

        private void button_LimparReceitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Apaga a lista de receitas", button_LimparReceitas);
        }

        private void button_CalculaReceita_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Calcula as receitas inseridas", button_CalculaReceita);
        }

        private void button_LimparReceitas_Click(object sender, EventArgs e)
        {
            textBox_Preco.Text = "";
            textBox_CategoriaReceitas.Text = "";
            listBox_Receitas.Items.Clear();
            label_ResultadoReceitas.Text = "R$ 0";
            chart_Balanco.Series.Clear();
            receitas.Clear();
        }

        private void button_CalculaReceita_Click(object sender, EventArgs e)
        {
            double soma = 0;

            foreach (Receita receita in receitas)
            {
                soma = soma + receita.preco;
            }

            label_ResultadoReceitas.Text = String.Format("R$ {0:F2}", soma.ToString());
                        
            chart_Balanco.Series["Receitas"].Points.AddXY("Receitas", soma);
        }

        private void button_LimparDespesas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Apaga os dados de todos os campos das despesas", button_LimparDespesas);
        }

        private void button_CalcularDespesas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Calcula as despesas", button_CalcularDespesas);
        }

        private void button_LimparDespesas_Click(object sender, EventArgs e)
        {
            textBox_PrecoDespesa.Text = "";
            textBox_CategoriaDespesas.Text = "";
            listBox_Despesas.Items.Clear();
            label_ResultadoDespesas.Text = "R$ 0";
            chart_Balanco.Series.Clear();
            despesas.Clear();            
        }

        private void button_CalcularDespesas_Click(object sender, EventArgs e)
        {
            double soma = 0;

            foreach (Despesas despesa in despesas)
            {
                soma = soma + despesa.preco;
            }

            label_ResultadoDespesas.Text = String.Format("R$ {0:F2}", soma.ToString());
            
            chart_Balanco.Series["Despesas"].Points.AddXY("Despesas", soma);
        }

        private void textBox_Preco_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Insira o preço da receita, em reais, sem vírgulas ou pontos.", textBox_Preco);
        }

        private void comboBox_CategoriaReceitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Digite a categoria da receita", textBox_CategoriaReceitas);
        }

        private void listBox_Receitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Lista receitas", listBox_Receitas);
        }

        private void button_AdicionarReceita_Click(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse((textBox_Preco.Text), out x) == true)
            {
                if (x <= 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero, sem vírgulas ou pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Preco.Clear();
                    textBox_Preco.BackColor = Color.LightCoral;
                }
                else if (textBox_CategoriaReceitas.Text == "")
                {
                    MessageBox.Show("Por favor, digite uma categoria", "Erro - Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Receita receita = new Receita();
                    receita.nome = textBox_CategoriaReceitas.Text.ToString();
                    receita.preco = x;
                    listBox_Receitas.Items.Add($"R$ {receita.preco} - {receita.nome}");
                    receitas.Add(receita);
                    textBox_Preco.BackColor = Color.PaleGreen;
                    textBox_CategoriaReceitas.Text = "";
                    textBox_Preco.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número real, sem vírgulas/pontos", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Preco.Clear();
                textBox_Preco.BackColor = Color.LightCoral;
            }
        }

        private void textBox_PrecoDespesa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Insira o preço da receita, em reais", textBox_Preco);
        }

        private void comboBox_CategoriaDespesa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Categoria de despesas", textBox_CategoriaReceitas);
        }

        private void listBox_Despesas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Lista receitas", listBox_Receitas);
        }

        private void button_AdicionarDespesa_Click(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse((textBox_PrecoDespesa.Text), out x) == true)
            {
                if (x <= 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_PrecoDespesa.Clear();
                    textBox_PrecoDespesa.BackColor = Color.LightCoral;
                }
                else if (textBox_CategoriaDespesas.Text == "")
                {
                    MessageBox.Show("Por favor, digite uma categoria", "Erro - Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Despesas despesa = new Despesas();
                    despesa.nome = textBox_CategoriaDespesas.Text.ToString();
                    despesa.preco = x;
                    listBox_Despesas.Items.Add($"R$ {despesa.preco} - {despesa.nome}");
                    despesas.Add(despesa);
                    textBox_PrecoDespesa.BackColor = Color.PaleGreen;
                    textBox_CategoriaDespesas.Text = "";
                    textBox_PrecoDespesa.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número real", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PrecoDespesa.Clear();
                textBox_PrecoDespesa.BackColor = Color.LightCoral;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 2000;
            toolTip.Show("Ajuda", button_AjudaRD);
        }

        private void button_AjudaRD_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"- Preencha o campo 'Preço', em R$ (somente o número) para informar o preço da Receita/Despesa.

- Digite a categoria da Receita/Despesa no campo 'Categoria'.

- Após preencher o preço e digitar a categoria, clique em 'Adicionar à Lista', para adicionar a Receita/Despesa à lista de Receitas/Despesas.

- Com ao menos um elemento na lista de Receitas/Despesas, clique em 'Calcular' para calcular as Receitas/Despesas listadas.

- Clique em 'Limpar' para apagar todos os dados.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
