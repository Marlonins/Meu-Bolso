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
        List<Metas> Metas = new List<Metas>();

        List<Receita> salarios = new List<Receita>();
        List<Receita> bonus = new List<Receita>();
        List<Receita> juros = new List<Receita>();
        List<Receita> honorarios = new List<Receita>();
        List<Receita> outrasReceitas = new List<Receita>();

        List<Despesas> aluguel = new List<Despesas>();
        List<Despesas> servicosFinanceiros = new List<Despesas>();
        List<Despesas> alimentacao = new List<Despesas>();
        List<Despesas> transporte = new List<Despesas>();
        List<Despesas> outrasDespesas = new List<Despesas>();
        
        public ReceitasDespesas()
        {
            InitializeComponent();

            comboBox_CategoriaReceitas.Items.Add("Salário");
            comboBox_CategoriaReceitas.Items.Add("Bônus");
            comboBox_CategoriaReceitas.Items.Add("Juros");
            comboBox_CategoriaReceitas.Items.Add("Honorários");
            comboBox_CategoriaReceitas.Items.Add("Outras Receitas");

            comboBox_CategoriaDespesa.Items.Add("Aluguel");
            comboBox_CategoriaDespesa.Items.Add("Serviços Financeiros");
            comboBox_CategoriaDespesa.Items.Add("Alimentação");
            comboBox_CategoriaDespesa.Items.Add("Transporte");
            comboBox_CategoriaDespesa.Items.Add("Outras Despesas");
        }

        private void button_LimparReceitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Apaga a lista de receitas", button_LimparReceitas);
        }

        private void button_CalculaReceita_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Calcula as receitas inseridas", button_CalculaReceita);
        }

        private void button_LimparReceitas_Click(object sender, EventArgs e)
        {
            textBox_Preco.Text = "";
            comboBox_CategoriaReceitas.Text = "";
            listBox_Receitas.Items.Clear();
            label_ResultadoReceitas.Text = "R$ 0";
            chart_Balanco.Series.Clear();
            receitas.Clear();
            salarios.Clear();
            bonus.Clear();
            juros.Clear();
            honorarios.Clear();
            outrasReceitas.Clear();
        }

        private void button_CalculaReceita_Click(object sender, EventArgs e)
        {
            double soma = 0;
            double somaSalarios = 0, somaBonus = 0, somaJuros = 0, somaHonorarios = 0, somaOutrasReceitas = 0; 

            foreach (Receita receita in receitas)
            {
                soma = soma + receita.preco;
            }

            label_ResultadoReceitas.Text = String.Format("R$ {0:F2}", soma.ToString());

            foreach (Receita salario in salarios)
            {
                somaSalarios = somaSalarios + salario.preco;
            }

            foreach (Receita bonu in bonus)
            {
                somaBonus = somaBonus + bonu.preco;
            }

            foreach (Receita juro in juros)
            {
                somaJuros = somaJuros + juro.preco;
            }

            foreach (Receita honorario in honorarios)
            {
                somaHonorarios = somaHonorarios + honorario.preco;
            }

            foreach (Receita outra in outrasReceitas)
            {
                somaOutrasReceitas = somaOutrasReceitas + outra.preco;
            }

            chart_Balanco.Series["Receitas"].Points.AddXY("Salário", somaSalarios);
            chart_Balanco.Series["Receitas"].Points.AddXY("Bônus", somaBonus);
            chart_Balanco.Series["Receitas"].Points.AddXY("Juros", somaJuros);
            chart_Balanco.Series["Receitas"].Points.AddXY("Honorários", somaHonorarios);
            chart_Balanco.Series["Receitas"].Points.AddXY("Outras Receitas", somaOutrasReceitas);
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
            toolTip.Show("Apaga os dados de todos os campos das despesas", button_CalcularDespesas);
        }

        private void button_LimparDespesas_Click(object sender, EventArgs e)
        {
            textBox_PrecoDespesa.Text = "";
            comboBox_CategoriaDespesa.Text = "";
            listBox_Despesas.Items.Clear();
            label_ResultadoDespesas.Text = "R$ 0";
            chart_Balanco.Series.Clear();
            despesas.Clear();
            aluguel.Clear();
            servicosFinanceiros.Clear();
            alimentacao.Clear();
            transporte.Clear();
            outrasDespesas.Clear();
        }

        private void button_CalcularDespesas_Click(object sender, EventArgs e)
        {
            double soma = 0;
            double somaAluguel = 0, somaServicos = 0, somaAlimentacao = 0, somaTransporte = 0, somaOutrasDespesas = 0;

            foreach (Despesas despesa in despesas)
            {
                soma = soma + despesa.preco;
            }

            label_ResultadoDespesas.Text = String.Format("R$ {0:F2}", soma.ToString());

            foreach (Despesas alug in aluguel)
            {
                somaAluguel = somaAluguel + alug.preco;
            }

            foreach (Despesas servico in servicosFinanceiros)
            {
                somaServicos = somaServicos + servico.preco;
            }

            foreach (Despesas alimento in alimentacao)
            {
                somaAlimentacao = somaAlimentacao + alimento.preco;
            }

            foreach (Despesas trans in transporte)
            {
                somaTransporte = somaTransporte + trans.preco;
            }

            foreach (Despesas outra in outrasDespesas)
            {
                somaOutrasDespesas = somaOutrasDespesas + outra.preco;
            }

            chart_Balanco.Series["Despesas"].Points.AddXY("Aluguel", somaAluguel);
            chart_Balanco.Series["Despesas"].Points.AddXY("Serviços", somaServicos);
            chart_Balanco.Series["Despesas"].Points.AddXY("Alimentação", somaAlimentacao);
            chart_Balanco.Series["Despesas"].Points.AddXY("Transporte", somaTransporte);
            chart_Balanco.Series["Despesas"].Points.AddXY("Outras Despesas", somaOutrasDespesas);
        }

        private void textBox_Preco_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Insira o preço da receita, em reais", textBox_Preco);
        }

        private void comboBox_CategoriaReceitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Lista de categoria de receitas", comboBox_CategoriaReceitas);
        }

        private void listBox_Receitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Lista receitas", listBox_Receitas);
        }

        private void button_AdicionarReceita_Click(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse((textBox_Preco.Text), out x) == true)
            {
                if (x <= 0)
                {
                    MessageBox.Show("Por favor, digite um número maior que zero", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Preco.Clear();
                    textBox_Preco.BackColor = Color.LightCoral;
                }
                else if (comboBox_CategoriaReceitas.Text == "")
                {
                    MessageBox.Show("Por favor, selecione uma categoria", "Erro - Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Receita receita = new Receita();
                    receita.nome = comboBox_CategoriaReceitas.SelectedItem.ToString();
                    receita.preco = x;
                    listBox_Receitas.Items.Add($"R$ {receita.preco} - {receita.nome}");
                    receitas.Add(receita);
                    textBox_Preco.BackColor = Color.PaleGreen;

                    if (receita.nome == "Salário")
                        salarios.Add(receita);
                    else if (receita.nome == "Bônus")
                        bonus.Add(receita);
                    else if (receita.nome == "Juros")
                        juros.Add(receita);
                    else if (receita.nome == "Honorários")
                        honorarios.Add(receita);
                    else
                        outrasReceitas.Add(receita);
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número real", "Erro - Valor Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Preco.Clear();
                textBox_Preco.BackColor = Color.LightCoral;
            }
        }

        private void textBox_PrecoDespesa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Insira o preço da receita, em reais", textBox_Preco);
        }

        private void comboBox_CategoriaDespesa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
            toolTip.Show("Lista de categoria de receitas", comboBox_CategoriaReceitas);
        }

        private void listBox_Despesas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 3000;
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
                else if (comboBox_CategoriaDespesa.Text == "")
                {
                    MessageBox.Show("Por favor, selecione uma categoria", "Erro - Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Despesas despesa = new Despesas();
                    despesa.nome = comboBox_CategoriaDespesa.SelectedItem.ToString();
                    despesa.preco = x;
                    listBox_Despesas.Items.Add($"R$ {despesa.preco} - {despesa.nome}");
                    despesas.Add(despesa);
                    textBox_PrecoDespesa.BackColor = Color.PaleGreen;

                    if (despesa.nome == "Aluguel")
                        aluguel.Add(despesa);
                    else if (despesa.nome == "Serviços Financeiros")
                        servicosFinanceiros.Add(despesa);
                    else if (despesa.nome == "Alimentação")
                        alimentacao.Add(despesa);
                    else if (despesa.nome == "Transporte")
                        transporte.Add(despesa);
                    else
                        outrasDespesas.Add(despesa);
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
            toolTip.InitialDelay = 3000;
            toolTip.Show("Ajuda", button_AjudaRD);
        }

        private void button_AjudaRD_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"- Preencha o campo 'Preço', em R$ (somente o número) para informar o preço da Receita/Despesa.

- Escolha a categoria da Receita/Despesa no campo 'Categoria'.

- Após preencher o preço e escolher a categoria, clique em 'Adicionar à Lista', para adicionar a Receita/Despesa à lista de Receitas/Despesas.

- Com ao menos um elemento na lista de Receitas/Despesas, clique em 'Calcular' para calcular as Receitas/Despesas listadas.

- Clique em 'Limpar' para apagar todos os dados.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox_Preco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
