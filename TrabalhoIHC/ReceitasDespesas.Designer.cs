namespace TrabalhoIHC
{
    partial class ReceitasDespesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceitasDespesas));
            this.tabControl_ReceitasDespesas = new System.Windows.Forms.TabControl();
            this.tab_Receitas = new System.Windows.Forms.TabPage();
            this.button_AdicionarReceita = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Preco = new System.Windows.Forms.TextBox();
            this.listBox_Receitas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CalculaReceita = new System.Windows.Forms.Button();
            this.button_LimparReceitas = new System.Windows.Forms.Button();
            this.label_ResultadoReceitas = new System.Windows.Forms.Label();
            this.label_TotalReceitas = new System.Windows.Forms.Label();
            this.tab_Despesas = new System.Windows.Forms.TabPage();
            this.button_AdicionarDespesa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PrecoDespesa = new System.Windows.Forms.TextBox();
            this.listBox_Despesas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CalcularDespesas = new System.Windows.Forms.Button();
            this.button_LimparDespesas = new System.Windows.Forms.Button();
            this.label_ResultadoDespesas = new System.Windows.Forms.Label();
            this.label_TotalDespesas = new System.Windows.Forms.Label();
            this.button_AjudaRD = new System.Windows.Forms.Button();
            this.chart_Balanco = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_CategoriaReceitas = new System.Windows.Forms.TextBox();
            this.textBox_CategoriaDespesas = new System.Windows.Forms.TextBox();
            this.tabControl_ReceitasDespesas.SuspendLayout();
            this.tab_Receitas.SuspendLayout();
            this.tab_Despesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Balanco)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_ReceitasDespesas
            // 
            this.tabControl_ReceitasDespesas.Controls.Add(this.tab_Receitas);
            this.tabControl_ReceitasDespesas.Controls.Add(this.tab_Despesas);
            this.tabControl_ReceitasDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl_ReceitasDespesas.Location = new System.Drawing.Point(12, 12);
            this.tabControl_ReceitasDespesas.Name = "tabControl_ReceitasDespesas";
            this.tabControl_ReceitasDespesas.SelectedIndex = 0;
            this.tabControl_ReceitasDespesas.Size = new System.Drawing.Size(347, 483);
            this.tabControl_ReceitasDespesas.TabIndex = 0;
            // 
            // tab_Receitas
            // 
            this.tab_Receitas.BackColor = System.Drawing.Color.Gainsboro;
            this.tab_Receitas.Controls.Add(this.textBox_CategoriaReceitas);
            this.tab_Receitas.Controls.Add(this.button_AdicionarReceita);
            this.tab_Receitas.Controls.Add(this.label4);
            this.tab_Receitas.Controls.Add(this.label3);
            this.tab_Receitas.Controls.Add(this.textBox_Preco);
            this.tab_Receitas.Controls.Add(this.listBox_Receitas);
            this.tab_Receitas.Controls.Add(this.label2);
            this.tab_Receitas.Controls.Add(this.button_CalculaReceita);
            this.tab_Receitas.Controls.Add(this.button_LimparReceitas);
            this.tab_Receitas.Controls.Add(this.label_ResultadoReceitas);
            this.tab_Receitas.Controls.Add(this.label_TotalReceitas);
            this.tab_Receitas.Location = new System.Drawing.Point(4, 29);
            this.tab_Receitas.Name = "tab_Receitas";
            this.tab_Receitas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Receitas.Size = new System.Drawing.Size(339, 450);
            this.tab_Receitas.TabIndex = 0;
            this.tab_Receitas.Text = "Receitas";
            // 
            // button_AdicionarReceita
            // 
            this.button_AdicionarReceita.Location = new System.Drawing.Point(123, 110);
            this.button_AdicionarReceita.Name = "button_AdicionarReceita";
            this.button_AdicionarReceita.Size = new System.Drawing.Size(100, 53);
            this.button_AdicionarReceita.TabIndex = 20;
            this.button_AdicionarReceita.Text = "Adicionar à Lista";
            this.button_AdicionarReceita.UseVisualStyleBackColor = true;
            this.button_AdicionarReceita.Click += new System.EventHandler(this.button_AdicionarReceita_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preço (em R$)";
            // 
            // textBox_Preco
            // 
            this.textBox_Preco.Location = new System.Drawing.Point(10, 50);
            this.textBox_Preco.Name = "textBox_Preco";
            this.textBox_Preco.Size = new System.Drawing.Size(115, 26);
            this.textBox_Preco.TabIndex = 16;
            this.textBox_Preco.MouseHover += new System.EventHandler(this.textBox_Preco_MouseHover);
            // 
            // listBox_Receitas
            // 
            this.listBox_Receitas.FormattingEnabled = true;
            this.listBox_Receitas.ItemHeight = 20;
            this.listBox_Receitas.Location = new System.Drawing.Point(7, 179);
            this.listBox_Receitas.Name = "listBox_Receitas";
            this.listBox_Receitas.Size = new System.Drawing.Size(316, 84);
            this.listBox_Receitas.TabIndex = 15;
            this.listBox_Receitas.MouseHover += new System.EventHandler(this.listBox_Receitas_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(4, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "*Campos vazios terão valor 0 ";
            // 
            // button_CalculaReceita
            // 
            this.button_CalculaReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CalculaReceita.Location = new System.Drawing.Point(123, 282);
            this.button_CalculaReceita.Name = "button_CalculaReceita";
            this.button_CalculaReceita.Size = new System.Drawing.Size(100, 31);
            this.button_CalculaReceita.TabIndex = 13;
            this.button_CalculaReceita.Text = "Calcular";
            this.button_CalculaReceita.UseVisualStyleBackColor = true;
            this.button_CalculaReceita.Click += new System.EventHandler(this.button_CalculaReceita_Click);
            this.button_CalculaReceita.MouseHover += new System.EventHandler(this.button_CalculaReceita_MouseHover);
            // 
            // button_LimparReceitas
            // 
            this.button_LimparReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_LimparReceitas.Location = new System.Drawing.Point(123, 381);
            this.button_LimparReceitas.Name = "button_LimparReceitas";
            this.button_LimparReceitas.Size = new System.Drawing.Size(100, 31);
            this.button_LimparReceitas.TabIndex = 12;
            this.button_LimparReceitas.Text = "Limpar";
            this.button_LimparReceitas.UseVisualStyleBackColor = true;
            this.button_LimparReceitas.Click += new System.EventHandler(this.button_LimparReceitas_Click);
            this.button_LimparReceitas.MouseHover += new System.EventHandler(this.button_LimparReceitas_MouseHover);
            // 
            // label_ResultadoReceitas
            // 
            this.label_ResultadoReceitas.AutoSize = true;
            this.label_ResultadoReceitas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultadoReceitas.Location = new System.Drawing.Point(227, 339);
            this.label_ResultadoReceitas.Name = "label_ResultadoReceitas";
            this.label_ResultadoReceitas.Size = new System.Drawing.Size(52, 23);
            this.label_ResultadoReceitas.TabIndex = 6;
            this.label_ResultadoReceitas.Text = "R$ 0";
            // 
            // label_TotalReceitas
            // 
            this.label_TotalReceitas.AutoSize = true;
            this.label_TotalReceitas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalReceitas.Location = new System.Drawing.Point(15, 339);
            this.label_TotalReceitas.Name = "label_TotalReceitas";
            this.label_TotalReceitas.Size = new System.Drawing.Size(58, 23);
            this.label_TotalReceitas.TabIndex = 5;
            this.label_TotalReceitas.Text = "Total:";
            // 
            // tab_Despesas
            // 
            this.tab_Despesas.BackColor = System.Drawing.Color.Gainsboro;
            this.tab_Despesas.Controls.Add(this.textBox_CategoriaDespesas);
            this.tab_Despesas.Controls.Add(this.button_AdicionarDespesa);
            this.tab_Despesas.Controls.Add(this.label5);
            this.tab_Despesas.Controls.Add(this.label6);
            this.tab_Despesas.Controls.Add(this.textBox_PrecoDespesa);
            this.tab_Despesas.Controls.Add(this.listBox_Despesas);
            this.tab_Despesas.Controls.Add(this.label1);
            this.tab_Despesas.Controls.Add(this.button_CalcularDespesas);
            this.tab_Despesas.Controls.Add(this.button_LimparDespesas);
            this.tab_Despesas.Controls.Add(this.label_ResultadoDespesas);
            this.tab_Despesas.Controls.Add(this.label_TotalDespesas);
            this.tab_Despesas.Location = new System.Drawing.Point(4, 29);
            this.tab_Despesas.Name = "tab_Despesas";
            this.tab_Despesas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Despesas.Size = new System.Drawing.Size(339, 450);
            this.tab_Despesas.TabIndex = 1;
            this.tab_Despesas.Text = "Despesas";
            // 
            // button_AdicionarDespesa
            // 
            this.button_AdicionarDespesa.Location = new System.Drawing.Point(124, 106);
            this.button_AdicionarDespesa.Name = "button_AdicionarDespesa";
            this.button_AdicionarDespesa.Size = new System.Drawing.Size(100, 53);
            this.button_AdicionarDespesa.TabIndex = 31;
            this.button_AdicionarDespesa.Text = "Adicionar à Lista";
            this.button_AdicionarDespesa.UseVisualStyleBackColor = true;
            this.button_AdicionarDespesa.Click += new System.EventHandler(this.button_AdicionarDespesa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Preço (em R$)";
            // 
            // textBox_PrecoDespesa
            // 
            this.textBox_PrecoDespesa.Location = new System.Drawing.Point(8, 46);
            this.textBox_PrecoDespesa.Name = "textBox_PrecoDespesa";
            this.textBox_PrecoDespesa.Size = new System.Drawing.Size(117, 26);
            this.textBox_PrecoDespesa.TabIndex = 27;
            this.textBox_PrecoDespesa.MouseHover += new System.EventHandler(this.textBox_PrecoDespesa_MouseHover);
            // 
            // listBox_Despesas
            // 
            this.listBox_Despesas.FormattingEnabled = true;
            this.listBox_Despesas.ItemHeight = 20;
            this.listBox_Despesas.Location = new System.Drawing.Point(8, 175);
            this.listBox_Despesas.Name = "listBox_Despesas";
            this.listBox_Despesas.Size = new System.Drawing.Size(316, 84);
            this.listBox_Despesas.TabIndex = 26;
            this.listBox_Despesas.MouseHover += new System.EventHandler(this.listBox_Despesas_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(2, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "*Campos vazios terão valor 0 ";
            // 
            // button_CalcularDespesas
            // 
            this.button_CalcularDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CalcularDespesas.Location = new System.Drawing.Point(124, 279);
            this.button_CalcularDespesas.Name = "button_CalcularDespesas";
            this.button_CalcularDespesas.Size = new System.Drawing.Size(100, 31);
            this.button_CalcularDespesas.TabIndex = 25;
            this.button_CalcularDespesas.Text = "Calcular";
            this.button_CalcularDespesas.UseVisualStyleBackColor = true;
            this.button_CalcularDespesas.Click += new System.EventHandler(this.button_CalcularDespesas_Click);
            this.button_CalcularDespesas.MouseHover += new System.EventHandler(this.button_CalcularDespesas_MouseHover);
            // 
            // button_LimparDespesas
            // 
            this.button_LimparDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_LimparDespesas.Location = new System.Drawing.Point(124, 364);
            this.button_LimparDespesas.Name = "button_LimparDespesas";
            this.button_LimparDespesas.Size = new System.Drawing.Size(100, 31);
            this.button_LimparDespesas.TabIndex = 24;
            this.button_LimparDespesas.Text = "Limpar";
            this.button_LimparDespesas.UseVisualStyleBackColor = true;
            this.button_LimparDespesas.Click += new System.EventHandler(this.button_LimparDespesas_Click);
            this.button_LimparDespesas.MouseHover += new System.EventHandler(this.button_LimparDespesas_MouseHover);
            // 
            // label_ResultadoDespesas
            // 
            this.label_ResultadoDespesas.AutoSize = true;
            this.label_ResultadoDespesas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultadoDespesas.Location = new System.Drawing.Point(246, 324);
            this.label_ResultadoDespesas.Name = "label_ResultadoDespesas";
            this.label_ResultadoDespesas.Size = new System.Drawing.Size(52, 23);
            this.label_ResultadoDespesas.TabIndex = 18;
            this.label_ResultadoDespesas.Text = "R$ 0";
            // 
            // label_TotalDespesas
            // 
            this.label_TotalDespesas.AutoSize = true;
            this.label_TotalDespesas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalDespesas.Location = new System.Drawing.Point(1, 324);
            this.label_TotalDespesas.Name = "label_TotalDespesas";
            this.label_TotalDespesas.Size = new System.Drawing.Size(58, 23);
            this.label_TotalDespesas.TabIndex = 17;
            this.label_TotalDespesas.Text = "Total:";
            // 
            // button_AjudaRD
            // 
            this.button_AjudaRD.Image = global::TrabalhoIHC.Properties.Resources.if_164_QuestionMark_183285;
            this.button_AjudaRD.Location = new System.Drawing.Point(720, 497);
            this.button_AjudaRD.Name = "button_AjudaRD";
            this.button_AjudaRD.Size = new System.Drawing.Size(67, 40);
            this.button_AjudaRD.TabIndex = 21;
            this.button_AjudaRD.UseVisualStyleBackColor = true;
            this.button_AjudaRD.Click += new System.EventHandler(this.button_AjudaRD_Click);
            this.button_AjudaRD.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // chart_Balanco
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Balanco.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Balanco.Legends.Add(legend1);
            this.chart_Balanco.Location = new System.Drawing.Point(365, 41);
            this.chart_Balanco.Name = "chart_Balanco";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Receitas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Despesas";
            this.chart_Balanco.Series.Add(series1);
            this.chart_Balanco.Series.Add(series2);
            this.chart_Balanco.Size = new System.Drawing.Size(422, 450);
            this.chart_Balanco.TabIndex = 22;
            this.chart_Balanco.Text = "Receitas";
            title1.Name = "Title_Balanco";
            title1.Text = "Balanço Financeiro";
            this.chart_Balanco.Titles.Add(title1);
            // 
            // textBox_CategoriaReceitas
            // 
            this.textBox_CategoriaReceitas.Location = new System.Drawing.Point(158, 53);
            this.textBox_CategoriaReceitas.Name = "textBox_CategoriaReceitas";
            this.textBox_CategoriaReceitas.Size = new System.Drawing.Size(165, 26);
            this.textBox_CategoriaReceitas.TabIndex = 21;
            // 
            // textBox_CategoriaDespesas
            // 
            this.textBox_CategoriaDespesas.Location = new System.Drawing.Point(152, 49);
            this.textBox_CategoriaDespesas.Name = "textBox_CategoriaDespesas";
            this.textBox_CategoriaDespesas.Size = new System.Drawing.Size(172, 26);
            this.textBox_CategoriaDespesas.TabIndex = 32;
            // 
            // ReceitasDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 541);
            this.Controls.Add(this.chart_Balanco);
            this.Controls.Add(this.button_AjudaRD);
            this.Controls.Add(this.tabControl_ReceitasDespesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceitasDespesas";
            this.Text = "Receitas e Despesas";
            this.tabControl_ReceitasDespesas.ResumeLayout(false);
            this.tab_Receitas.ResumeLayout(false);
            this.tab_Receitas.PerformLayout();
            this.tab_Despesas.ResumeLayout(false);
            this.tab_Despesas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Balanco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_ReceitasDespesas;
        private System.Windows.Forms.TabPage tab_Receitas;
        private System.Windows.Forms.Label label_ResultadoReceitas;
        private System.Windows.Forms.Label label_TotalReceitas;
        private System.Windows.Forms.TabPage tab_Despesas;
        private System.Windows.Forms.Label label_ResultadoDespesas;
        private System.Windows.Forms.Label label_TotalDespesas;
        private System.Windows.Forms.Button button_LimparReceitas;
        private System.Windows.Forms.Button button_CalculaReceita;
        private System.Windows.Forms.Button button_CalcularDespesas;
        private System.Windows.Forms.Button button_LimparDespesas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AdicionarReceita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Preco;
        private System.Windows.Forms.ListBox listBox_Receitas;
        private System.Windows.Forms.Button button_AdicionarDespesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_PrecoDespesa;
        private System.Windows.Forms.ListBox listBox_Despesas;
        private System.Windows.Forms.Button button_AjudaRD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Balanco;
        private System.Windows.Forms.TextBox textBox_CategoriaReceitas;
        private System.Windows.Forms.TextBox textBox_CategoriaDespesas;
    }
}