namespace TrabalhoIHC
{
    partial class Investimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Investimentos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Poupanca = new System.Windows.Forms.TabPage();
            this.button_AjudaPou = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_LimparPoupanca = new System.Windows.Forms.Button();
            this.button_Calcular_CDB = new System.Windows.Forms.Button();
            this.groupBox_Resultados = new System.Windows.Forms.GroupBox();
            this.label_ResultValorLiquidoAplicacaoPoupanca = new System.Windows.Forms.Label();
            this.label_ResultAplicacaoAtualizadaPoupanca = new System.Windows.Forms.Label();
            this.label_VlLiqAplicPoupanca = new System.Windows.Forms.Label();
            this.label_AplicacaoAtualizadaPoupanca = new System.Windows.Forms.Label();
            this.groupBox_Preencher = new System.Windows.Forms.GroupBox();
            this.label_DiasCorridosPoupanca = new System.Windows.Forms.Label();
            this.label_MesesPoupanca = new System.Windows.Forms.Label();
            this.dateTimePicker_DataResgate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DataAplicacao = new System.Windows.Forms.DateTimePicker();
            this.textBox_ValorAplicadoPoupanca = new System.Windows.Forms.TextBox();
            this.label_DataResgate = new System.Windows.Forms.Label();
            this.label_ValorAplicado = new System.Windows.Forms.Label();
            this.label_DataAplicacao = new System.Windows.Forms.Label();
            this.tabPage_LCILCA = new System.Windows.Forms.TabPage();
            this.button_AjudaLC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LimparLCA = new System.Windows.Forms.Button();
            this.button_Calcular_LCA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ResultadoValorRendimentoLiquido_LCA = new System.Windows.Forms.Label();
            this.label_ResultadoAplicacaoAtualizada_LCA = new System.Windows.Forms.Label();
            this.label_ValorRendimentoLiquido_LCA = new System.Windows.Forms.Label();
            this.label_AplicacaoAtualizada_LCA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_PercentualCDI_LCA = new System.Windows.Forms.TextBox();
            this.label_PercentualCDI_LCA = new System.Windows.Forms.Label();
            this.textBox_TaxaDI_LCA = new System.Windows.Forms.TextBox();
            this.label_TaxaDI_LCA = new System.Windows.Forms.Label();
            this.label_ResultadoMeses_LCA = new System.Windows.Forms.Label();
            this.label_MesesCorridos_LCA = new System.Windows.Forms.Label();
            this.dateTimePicker_DataResgate_LCA = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DataAplicacao_LCA = new System.Windows.Forms.DateTimePicker();
            this.textBox_ValorAplicadoLCA = new System.Windows.Forms.TextBox();
            this.label_DataResgate_LCA = new System.Windows.Forms.Label();
            this.label_ValorAplicadoLCA = new System.Windows.Forms.Label();
            this.label_DataAplicacao_LCA = new System.Windows.Forms.Label();
            this.chart_Investimentos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage_Poupanca.SuspendLayout();
            this.groupBox_Resultados.SuspendLayout();
            this.groupBox_Preencher.SuspendLayout();
            this.tabPage_LCILCA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Investimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Poupanca);
            this.tabControl1.Controls.Add(this.tabPage_LCILCA);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 658);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_Poupanca
            // 
            this.tabPage_Poupanca.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_Poupanca.Controls.Add(this.button_AjudaPou);
            this.tabPage_Poupanca.Controls.Add(this.label1);
            this.tabPage_Poupanca.Controls.Add(this.button_LimparPoupanca);
            this.tabPage_Poupanca.Controls.Add(this.button_Calcular_CDB);
            this.tabPage_Poupanca.Controls.Add(this.groupBox_Resultados);
            this.tabPage_Poupanca.Controls.Add(this.groupBox_Preencher);
            this.tabPage_Poupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Poupanca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage_Poupanca.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Poupanca.Name = "tabPage_Poupanca";
            this.tabPage_Poupanca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Poupanca.Size = new System.Drawing.Size(502, 629);
            this.tabPage_Poupanca.TabIndex = 0;
            this.tabPage_Poupanca.Text = "Poupança";
            // 
            // button_AjudaPou
            // 
            this.button_AjudaPou.Image = global::TrabalhoIHC.Properties.Resources.if_164_QuestionMark_183285;
            this.button_AjudaPou.Location = new System.Drawing.Point(444, 587);
            this.button_AjudaPou.Name = "button_AjudaPou";
            this.button_AjudaPou.Size = new System.Drawing.Size(52, 36);
            this.button_AjudaPou.TabIndex = 14;
            this.button_AjudaPou.UseVisualStyleBackColor = true;
            this.button_AjudaPou.Click += new System.EventHandler(this.button_AjudaPou_Click);
            this.button_AjudaPou.MouseHover += new System.EventHandler(this.button_AjudaPou_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(-3, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Campos vazios terão valor 0 ";
            // 
            // button_LimparPoupanca
            // 
            this.button_LimparPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LimparPoupanca.Location = new System.Drawing.Point(202, 533);
            this.button_LimparPoupanca.Name = "button_LimparPoupanca";
            this.button_LimparPoupanca.Size = new System.Drawing.Size(122, 37);
            this.button_LimparPoupanca.TabIndex = 7;
            this.button_LimparPoupanca.Text = "Limpar";
            this.button_LimparPoupanca.UseVisualStyleBackColor = true;
            this.button_LimparPoupanca.Click += new System.EventHandler(this.button_LimparPoupanca_Click);
            this.button_LimparPoupanca.MouseHover += new System.EventHandler(this.button_LimparPoupanca_MouseHover);
            // 
            // button_Calcular_CDB
            // 
            this.button_Calcular_CDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular_CDB.Location = new System.Drawing.Point(202, 284);
            this.button_Calcular_CDB.Name = "button_Calcular_CDB";
            this.button_Calcular_CDB.Size = new System.Drawing.Size(122, 37);
            this.button_Calcular_CDB.TabIndex = 6;
            this.button_Calcular_CDB.Text = "Simular";
            this.button_Calcular_CDB.UseVisualStyleBackColor = true;
            this.button_Calcular_CDB.Click += new System.EventHandler(this.button_Calcular_CDB_Click);
            this.button_Calcular_CDB.MouseHover += new System.EventHandler(this.button_Calcular_CDB_MouseHover);
            // 
            // groupBox_Resultados
            // 
            this.groupBox_Resultados.Controls.Add(this.label_ResultValorLiquidoAplicacaoPoupanca);
            this.groupBox_Resultados.Controls.Add(this.label_ResultAplicacaoAtualizadaPoupanca);
            this.groupBox_Resultados.Controls.Add(this.label_VlLiqAplicPoupanca);
            this.groupBox_Resultados.Controls.Add(this.label_AplicacaoAtualizadaPoupanca);
            this.groupBox_Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Resultados.Location = new System.Drawing.Point(6, 353);
            this.groupBox_Resultados.Name = "groupBox_Resultados";
            this.groupBox_Resultados.Size = new System.Drawing.Size(504, 157);
            this.groupBox_Resultados.TabIndex = 5;
            this.groupBox_Resultados.TabStop = false;
            this.groupBox_Resultados.Text = "Resultados";
            // 
            // label_ResultValorLiquidoAplicacaoPoupanca
            // 
            this.label_ResultValorLiquidoAplicacaoPoupanca.AutoSize = true;
            this.label_ResultValorLiquidoAplicacaoPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultValorLiquidoAplicacaoPoupanca.Location = new System.Drawing.Point(341, 105);
            this.label_ResultValorLiquidoAplicacaoPoupanca.Name = "label_ResultValorLiquidoAplicacaoPoupanca";
            this.label_ResultValorLiquidoAplicacaoPoupanca.Size = new System.Drawing.Size(44, 20);
            this.label_ResultValorLiquidoAplicacaoPoupanca.TabIndex = 6;
            this.label_ResultValorLiquidoAplicacaoPoupanca.Text = "R$ 0";
            // 
            // label_ResultAplicacaoAtualizadaPoupanca
            // 
            this.label_ResultAplicacaoAtualizadaPoupanca.AutoSize = true;
            this.label_ResultAplicacaoAtualizadaPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultAplicacaoAtualizadaPoupanca.Location = new System.Drawing.Point(341, 57);
            this.label_ResultAplicacaoAtualizadaPoupanca.Name = "label_ResultAplicacaoAtualizadaPoupanca";
            this.label_ResultAplicacaoAtualizadaPoupanca.Size = new System.Drawing.Size(44, 20);
            this.label_ResultAplicacaoAtualizadaPoupanca.TabIndex = 4;
            this.label_ResultAplicacaoAtualizadaPoupanca.Text = "R$ 0";
            // 
            // label_VlLiqAplicPoupanca
            // 
            this.label_VlLiqAplicPoupanca.AutoSize = true;
            this.label_VlLiqAplicPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VlLiqAplicPoupanca.Location = new System.Drawing.Point(18, 100);
            this.label_VlLiqAplicPoupanca.Name = "label_VlLiqAplicPoupanca";
            this.label_VlLiqAplicPoupanca.Size = new System.Drawing.Size(194, 25);
            this.label_VlLiqAplicPoupanca.TabIndex = 2;
            this.label_VlLiqAplicPoupanca.Text = "Valor do Rendimento";
            // 
            // label_AplicacaoAtualizadaPoupanca
            // 
            this.label_AplicacaoAtualizadaPoupanca.AutoSize = true;
            this.label_AplicacaoAtualizadaPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AplicacaoAtualizadaPoupanca.Location = new System.Drawing.Point(18, 50);
            this.label_AplicacaoAtualizadaPoupanca.Name = "label_AplicacaoAtualizadaPoupanca";
            this.label_AplicacaoAtualizadaPoupanca.Size = new System.Drawing.Size(195, 25);
            this.label_AplicacaoAtualizadaPoupanca.TabIndex = 0;
            this.label_AplicacaoAtualizadaPoupanca.Text = "Aplicação Atualizada";
            // 
            // groupBox_Preencher
            // 
            this.groupBox_Preencher.Controls.Add(this.label_DiasCorridosPoupanca);
            this.groupBox_Preencher.Controls.Add(this.label_MesesPoupanca);
            this.groupBox_Preencher.Controls.Add(this.dateTimePicker_DataResgate);
            this.groupBox_Preencher.Controls.Add(this.dateTimePicker_DataAplicacao);
            this.groupBox_Preencher.Controls.Add(this.textBox_ValorAplicadoPoupanca);
            this.groupBox_Preencher.Controls.Add(this.label_DataResgate);
            this.groupBox_Preencher.Controls.Add(this.label_ValorAplicado);
            this.groupBox_Preencher.Controls.Add(this.label_DataAplicacao);
            this.groupBox_Preencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Preencher.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Preencher.Name = "groupBox_Preencher";
            this.groupBox_Preencher.Size = new System.Drawing.Size(486, 272);
            this.groupBox_Preencher.TabIndex = 4;
            this.groupBox_Preencher.TabStop = false;
            this.groupBox_Preencher.Text = "Dados da Simulação";
            // 
            // label_DiasCorridosPoupanca
            // 
            this.label_DiasCorridosPoupanca.AutoSize = true;
            this.label_DiasCorridosPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiasCorridosPoupanca.Location = new System.Drawing.Point(414, 219);
            this.label_DiasCorridosPoupanca.Name = "label_DiasCorridosPoupanca";
            this.label_DiasCorridosPoupanca.Size = new System.Drawing.Size(18, 20);
            this.label_DiasCorridosPoupanca.TabIndex = 7;
            this.label_DiasCorridosPoupanca.Text = "0";
            // 
            // label_MesesPoupanca
            // 
            this.label_MesesPoupanca.AutoSize = true;
            this.label_MesesPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MesesPoupanca.Location = new System.Drawing.Point(16, 214);
            this.label_MesesPoupanca.Name = "label_MesesPoupanca";
            this.label_MesesPoupanca.Size = new System.Drawing.Size(150, 25);
            this.label_MesesPoupanca.TabIndex = 6;
            this.label_MesesPoupanca.Text = "Meses Corridos";
            // 
            // dateTimePicker_DataResgate
            // 
            this.dateTimePicker_DataResgate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DataResgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DataResgate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataResgate.Location = new System.Drawing.Point(289, 154);
            this.dateTimePicker_DataResgate.MinDate = new System.DateTime(1880, 3, 25, 0, 0, 0, 0);
            this.dateTimePicker_DataResgate.Name = "dateTimePicker_DataResgate";
            this.dateTimePicker_DataResgate.Size = new System.Drawing.Size(189, 27);
            this.dateTimePicker_DataResgate.TabIndex = 5;
            this.dateTimePicker_DataResgate.ValueChanged += new System.EventHandler(this.dateTimePicker_DataResgate_ValueChanged);
            this.dateTimePicker_DataResgate.MouseHover += new System.EventHandler(this.dateTimePicker_DataResgate_MouseHover);
            // 
            // dateTimePicker_DataAplicacao
            // 
            this.dateTimePicker_DataAplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DataAplicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataAplicacao.Location = new System.Drawing.Point(289, 98);
            this.dateTimePicker_DataAplicacao.Name = "dateTimePicker_DataAplicacao";
            this.dateTimePicker_DataAplicacao.Size = new System.Drawing.Size(189, 27);
            this.dateTimePicker_DataAplicacao.TabIndex = 4;
            this.dateTimePicker_DataAplicacao.ValueChanged += new System.EventHandler(this.dateTimePicker_DataAplicacao_ValueChanged);
            this.dateTimePicker_DataAplicacao.MouseHover += new System.EventHandler(this.dateTimePicker_DataAplicacao_MouseHover);
            // 
            // textBox_ValorAplicadoPoupanca
            // 
            this.textBox_ValorAplicadoPoupanca.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorAplicadoPoupanca.Location = new System.Drawing.Point(325, 47);
            this.textBox_ValorAplicadoPoupanca.Name = "textBox_ValorAplicadoPoupanca";
            this.textBox_ValorAplicadoPoupanca.Size = new System.Drawing.Size(153, 28);
            this.textBox_ValorAplicadoPoupanca.TabIndex = 1;
            this.textBox_ValorAplicadoPoupanca.Enter += new System.EventHandler(this.textBox_ValorAplicadoPoupanca_Enter);
            this.textBox_ValorAplicadoPoupanca.Leave += new System.EventHandler(this.textBox_ValorAplicadoPoupanca_Leave);
            this.textBox_ValorAplicadoPoupanca.MouseHover += new System.EventHandler(this.textBox_ValorAplicadoPoupanca_MouseHover);
            // 
            // label_DataResgate
            // 
            this.label_DataResgate.AutoSize = true;
            this.label_DataResgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataResgate.Location = new System.Drawing.Point(16, 156);
            this.label_DataResgate.Name = "label_DataResgate";
            this.label_DataResgate.Size = new System.Drawing.Size(157, 25);
            this.label_DataResgate.TabIndex = 3;
            this.label_DataResgate.Text = "Data do Resgate";
            // 
            // label_ValorAplicado
            // 
            this.label_ValorAplicado.AutoSize = true;
            this.label_ValorAplicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorAplicado.Location = new System.Drawing.Point(16, 50);
            this.label_ValorAplicado.Name = "label_ValorAplicado";
            this.label_ValorAplicado.Size = new System.Drawing.Size(214, 25);
            this.label_ValorAplicado.TabIndex = 0;
            this.label_ValorAplicado.Text = "Valor Aplicado (em R$)";
            // 
            // label_DataAplicacao
            // 
            this.label_DataAplicacao.AutoSize = true;
            this.label_DataAplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataAplicacao.Location = new System.Drawing.Point(16, 100);
            this.label_DataAplicacao.Name = "label_DataAplicacao";
            this.label_DataAplicacao.Size = new System.Drawing.Size(171, 25);
            this.label_DataAplicacao.TabIndex = 2;
            this.label_DataAplicacao.Text = "Data da Aplicação";
            // 
            // tabPage_LCILCA
            // 
            this.tabPage_LCILCA.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_LCILCA.Controls.Add(this.button_AjudaLC);
            this.tabPage_LCILCA.Controls.Add(this.label2);
            this.tabPage_LCILCA.Controls.Add(this.button_LimparLCA);
            this.tabPage_LCILCA.Controls.Add(this.button_Calcular_LCA);
            this.tabPage_LCILCA.Controls.Add(this.groupBox1);
            this.tabPage_LCILCA.Controls.Add(this.groupBox2);
            this.tabPage_LCILCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_LCILCA.Location = new System.Drawing.Point(4, 25);
            this.tabPage_LCILCA.Name = "tabPage_LCILCA";
            this.tabPage_LCILCA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LCILCA.Size = new System.Drawing.Size(502, 629);
            this.tabPage_LCILCA.TabIndex = 1;
            this.tabPage_LCILCA.Text = "LCI/LCA";
            // 
            // button_AjudaLC
            // 
            this.button_AjudaLC.Image = global::TrabalhoIHC.Properties.Resources.if_164_QuestionMark_183285;
            this.button_AjudaLC.Location = new System.Drawing.Point(445, 587);
            this.button_AjudaLC.Name = "button_AjudaLC";
            this.button_AjudaLC.Size = new System.Drawing.Size(51, 36);
            this.button_AjudaLC.TabIndex = 15;
            this.button_AjudaLC.UseVisualStyleBackColor = true;
            this.button_AjudaLC.Click += new System.EventHandler(this.button_AjudaLC_Click);
            this.button_AjudaLC.MouseHover += new System.EventHandler(this.button_AjudaLC_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(3, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "*Campos vazios terão valor 0 ";
            // 
            // button_LimparLCA
            // 
            this.button_LimparLCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LimparLCA.Location = new System.Drawing.Point(198, 575);
            this.button_LimparLCA.Name = "button_LimparLCA";
            this.button_LimparLCA.Size = new System.Drawing.Size(122, 37);
            this.button_LimparLCA.TabIndex = 9;
            this.button_LimparLCA.Text = "Limpar";
            this.button_LimparLCA.UseVisualStyleBackColor = true;
            this.button_LimparLCA.Click += new System.EventHandler(this.button_LimparLCA_Click);
            this.button_LimparLCA.MouseHover += new System.EventHandler(this.button_LimparLCA_MouseHover);
            // 
            // button_Calcular_LCA
            // 
            this.button_Calcular_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular_LCA.Location = new System.Drawing.Point(198, 394);
            this.button_Calcular_LCA.Name = "button_Calcular_LCA";
            this.button_Calcular_LCA.Size = new System.Drawing.Size(122, 37);
            this.button_Calcular_LCA.TabIndex = 8;
            this.button_Calcular_LCA.Text = "Simular";
            this.button_Calcular_LCA.UseVisualStyleBackColor = true;
            this.button_Calcular_LCA.Click += new System.EventHandler(this.button_Calcular_LCA_Click);
            this.button_Calcular_LCA.MouseHover += new System.EventHandler(this.button_Calcular_LCA_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ResultadoValorRendimentoLiquido_LCA);
            this.groupBox1.Controls.Add(this.label_ResultadoAplicacaoAtualizada_LCA);
            this.groupBox1.Controls.Add(this.label_ValorRendimentoLiquido_LCA);
            this.groupBox1.Controls.Add(this.label_AplicacaoAtualizada_LCA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // label_ResultadoValorRendimentoLiquido_LCA
            // 
            this.label_ResultadoValorRendimentoLiquido_LCA.AutoSize = true;
            this.label_ResultadoValorRendimentoLiquido_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultadoValorRendimentoLiquido_LCA.Location = new System.Drawing.Point(341, 104);
            this.label_ResultadoValorRendimentoLiquido_LCA.Name = "label_ResultadoValorRendimentoLiquido_LCA";
            this.label_ResultadoValorRendimentoLiquido_LCA.Size = new System.Drawing.Size(44, 20);
            this.label_ResultadoValorRendimentoLiquido_LCA.TabIndex = 7;
            this.label_ResultadoValorRendimentoLiquido_LCA.Text = "R$ 0";
            // 
            // label_ResultadoAplicacaoAtualizada_LCA
            // 
            this.label_ResultadoAplicacaoAtualizada_LCA.AutoSize = true;
            this.label_ResultadoAplicacaoAtualizada_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultadoAplicacaoAtualizada_LCA.Location = new System.Drawing.Point(341, 57);
            this.label_ResultadoAplicacaoAtualizada_LCA.Name = "label_ResultadoAplicacaoAtualizada_LCA";
            this.label_ResultadoAplicacaoAtualizada_LCA.Size = new System.Drawing.Size(44, 20);
            this.label_ResultadoAplicacaoAtualizada_LCA.TabIndex = 4;
            this.label_ResultadoAplicacaoAtualizada_LCA.Text = "R$ 0";
            // 
            // label_ValorRendimentoLiquido_LCA
            // 
            this.label_ValorRendimentoLiquido_LCA.AutoSize = true;
            this.label_ValorRendimentoLiquido_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorRendimentoLiquido_LCA.Location = new System.Drawing.Point(18, 100);
            this.label_ValorRendimentoLiquido_LCA.Name = "label_ValorRendimentoLiquido_LCA";
            this.label_ValorRendimentoLiquido_LCA.Size = new System.Drawing.Size(194, 25);
            this.label_ValorRendimentoLiquido_LCA.TabIndex = 3;
            this.label_ValorRendimentoLiquido_LCA.Text = "Valor do Rendimento";
            // 
            // label_AplicacaoAtualizada_LCA
            // 
            this.label_AplicacaoAtualizada_LCA.AutoSize = true;
            this.label_AplicacaoAtualizada_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AplicacaoAtualizada_LCA.Location = new System.Drawing.Point(18, 50);
            this.label_AplicacaoAtualizada_LCA.Name = "label_AplicacaoAtualizada_LCA";
            this.label_AplicacaoAtualizada_LCA.Size = new System.Drawing.Size(195, 25);
            this.label_AplicacaoAtualizada_LCA.TabIndex = 0;
            this.label_AplicacaoAtualizada_LCA.Text = "Aplicação Atualizada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_PercentualCDI_LCA);
            this.groupBox2.Controls.Add(this.label_PercentualCDI_LCA);
            this.groupBox2.Controls.Add(this.textBox_TaxaDI_LCA);
            this.groupBox2.Controls.Add(this.label_TaxaDI_LCA);
            this.groupBox2.Controls.Add(this.label_ResultadoMeses_LCA);
            this.groupBox2.Controls.Add(this.label_MesesCorridos_LCA);
            this.groupBox2.Controls.Add(this.dateTimePicker_DataResgate_LCA);
            this.groupBox2.Controls.Add(this.dateTimePicker_DataAplicacao_LCA);
            this.groupBox2.Controls.Add(this.textBox_ValorAplicadoLCA);
            this.groupBox2.Controls.Add(this.label_DataResgate_LCA);
            this.groupBox2.Controls.Add(this.label_ValorAplicadoLCA);
            this.groupBox2.Controls.Add(this.label_DataAplicacao_LCA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 362);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Simulação";
            // 
            // textBox_PercentualCDI_LCA
            // 
            this.textBox_PercentualCDI_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PercentualCDI_LCA.Location = new System.Drawing.Point(325, 328);
            this.textBox_PercentualCDI_LCA.Name = "textBox_PercentualCDI_LCA";
            this.textBox_PercentualCDI_LCA.Size = new System.Drawing.Size(153, 27);
            this.textBox_PercentualCDI_LCA.TabIndex = 11;
            this.textBox_PercentualCDI_LCA.Enter += new System.EventHandler(this.textBox_PercentualCDI_LCA_Enter);
            this.textBox_PercentualCDI_LCA.Leave += new System.EventHandler(this.textBox_PercentualCDI_LCA_Leave);
            this.textBox_PercentualCDI_LCA.MouseHover += new System.EventHandler(this.textBox_PercentualCDI_LCA_MouseHover);
            // 
            // label_PercentualCDI_LCA
            // 
            this.label_PercentualCDI_LCA.AutoSize = true;
            this.label_PercentualCDI_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PercentualCDI_LCA.Location = new System.Drawing.Point(16, 330);
            this.label_PercentualCDI_LCA.Name = "label_PercentualCDI_LCA";
            this.label_PercentualCDI_LCA.Size = new System.Drawing.Size(240, 25);
            this.label_PercentualCDI_LCA.TabIndex = 10;
            this.label_PercentualCDI_LCA.Text = "Percentual do CDI (em %)";
            // 
            // textBox_TaxaDI_LCA
            // 
            this.textBox_TaxaDI_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TaxaDI_LCA.Location = new System.Drawing.Point(325, 267);
            this.textBox_TaxaDI_LCA.Name = "textBox_TaxaDI_LCA";
            this.textBox_TaxaDI_LCA.Size = new System.Drawing.Size(153, 27);
            this.textBox_TaxaDI_LCA.TabIndex = 9;
            this.textBox_TaxaDI_LCA.Enter += new System.EventHandler(this.textBox_TaxaDI_LCA_Enter);
            this.textBox_TaxaDI_LCA.Leave += new System.EventHandler(this.textBox_TaxaDI_LCA_Leave);
            this.textBox_TaxaDI_LCA.MouseHover += new System.EventHandler(this.textBox_TaxaDI_LCA_MouseHover);
            // 
            // label_TaxaDI_LCA
            // 
            this.label_TaxaDI_LCA.AutoSize = true;
            this.label_TaxaDI_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaxaDI_LCA.Location = new System.Drawing.Point(16, 269);
            this.label_TaxaDI_LCA.Name = "label_TaxaDI_LCA";
            this.label_TaxaDI_LCA.Size = new System.Drawing.Size(220, 25);
            this.label_TaxaDI_LCA.TabIndex = 8;
            this.label_TaxaDI_LCA.Text = "Taxa DI (ao ano, em %)";
            // 
            // label_ResultadoMeses_LCA
            // 
            this.label_ResultadoMeses_LCA.AutoSize = true;
            this.label_ResultadoMeses_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultadoMeses_LCA.Location = new System.Drawing.Point(414, 219);
            this.label_ResultadoMeses_LCA.Name = "label_ResultadoMeses_LCA";
            this.label_ResultadoMeses_LCA.Size = new System.Drawing.Size(18, 20);
            this.label_ResultadoMeses_LCA.TabIndex = 7;
            this.label_ResultadoMeses_LCA.Text = "0";
            // 
            // label_MesesCorridos_LCA
            // 
            this.label_MesesCorridos_LCA.AutoSize = true;
            this.label_MesesCorridos_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MesesCorridos_LCA.Location = new System.Drawing.Point(16, 214);
            this.label_MesesCorridos_LCA.Name = "label_MesesCorridos_LCA";
            this.label_MesesCorridos_LCA.Size = new System.Drawing.Size(150, 25);
            this.label_MesesCorridos_LCA.TabIndex = 6;
            this.label_MesesCorridos_LCA.Text = "Meses Corridos";
            // 
            // dateTimePicker_DataResgate_LCA
            // 
            this.dateTimePicker_DataResgate_LCA.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DataResgate_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DataResgate_LCA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataResgate_LCA.Location = new System.Drawing.Point(278, 154);
            this.dateTimePicker_DataResgate_LCA.MinDate = new System.DateTime(1880, 3, 25, 0, 0, 0, 0);
            this.dateTimePicker_DataResgate_LCA.Name = "dateTimePicker_DataResgate_LCA";
            this.dateTimePicker_DataResgate_LCA.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_DataResgate_LCA.TabIndex = 5;
            this.dateTimePicker_DataResgate_LCA.ValueChanged += new System.EventHandler(this.dateTimePicker_DataResgate_LCA_ValueChanged);
            this.dateTimePicker_DataResgate_LCA.MouseHover += new System.EventHandler(this.dateTimePicker_DataResgate_LCA_MouseHover);
            // 
            // dateTimePicker_DataAplicacao_LCA
            // 
            this.dateTimePicker_DataAplicacao_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DataAplicacao_LCA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataAplicacao_LCA.Location = new System.Drawing.Point(278, 98);
            this.dateTimePicker_DataAplicacao_LCA.Name = "dateTimePicker_DataAplicacao_LCA";
            this.dateTimePicker_DataAplicacao_LCA.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_DataAplicacao_LCA.TabIndex = 4;
            this.dateTimePicker_DataAplicacao_LCA.ValueChanged += new System.EventHandler(this.dateTimePicker_DataAplicacao_LCA_ValueChanged);
            this.dateTimePicker_DataAplicacao_LCA.MouseHover += new System.EventHandler(this.dateTimePicker_DataAplicacao_LCA_MouseHover);
            // 
            // textBox_ValorAplicadoLCA
            // 
            this.textBox_ValorAplicadoLCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorAplicadoLCA.Location = new System.Drawing.Point(325, 47);
            this.textBox_ValorAplicadoLCA.Name = "textBox_ValorAplicadoLCA";
            this.textBox_ValorAplicadoLCA.Size = new System.Drawing.Size(153, 28);
            this.textBox_ValorAplicadoLCA.TabIndex = 1;
            this.textBox_ValorAplicadoLCA.Enter += new System.EventHandler(this.textBox_ValorAplicadoLCA_Enter);
            this.textBox_ValorAplicadoLCA.Leave += new System.EventHandler(this.textBox_ValorAplicadoLCA_Leave);
            this.textBox_ValorAplicadoLCA.MouseHover += new System.EventHandler(this.textBox_ValorAplicadoLCA_MouseHover);
            // 
            // label_DataResgate_LCA
            // 
            this.label_DataResgate_LCA.AutoSize = true;
            this.label_DataResgate_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataResgate_LCA.Location = new System.Drawing.Point(16, 156);
            this.label_DataResgate_LCA.Name = "label_DataResgate_LCA";
            this.label_DataResgate_LCA.Size = new System.Drawing.Size(157, 25);
            this.label_DataResgate_LCA.TabIndex = 3;
            this.label_DataResgate_LCA.Text = "Data do Resgate";
            // 
            // label_ValorAplicadoLCA
            // 
            this.label_ValorAplicadoLCA.AutoSize = true;
            this.label_ValorAplicadoLCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorAplicadoLCA.Location = new System.Drawing.Point(16, 50);
            this.label_ValorAplicadoLCA.Name = "label_ValorAplicadoLCA";
            this.label_ValorAplicadoLCA.Size = new System.Drawing.Size(214, 25);
            this.label_ValorAplicadoLCA.TabIndex = 0;
            this.label_ValorAplicadoLCA.Text = "Valor Aplicado (em R$)";
            // 
            // label_DataAplicacao_LCA
            // 
            this.label_DataAplicacao_LCA.AutoSize = true;
            this.label_DataAplicacao_LCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataAplicacao_LCA.Location = new System.Drawing.Point(16, 100);
            this.label_DataAplicacao_LCA.Name = "label_DataAplicacao_LCA";
            this.label_DataAplicacao_LCA.Size = new System.Drawing.Size(171, 25);
            this.label_DataAplicacao_LCA.TabIndex = 2;
            this.label_DataAplicacao_LCA.Text = "Data da Aplicação";
            // 
            // chart_Investimentos
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Investimentos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Investimentos.Legends.Add(legend1);
            this.chart_Investimentos.Location = new System.Drawing.Point(532, 37);
            this.chart_Investimentos.Name = "chart_Investimentos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Poupança";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "LCI/LCA";
            this.chart_Investimentos.Series.Add(series1);
            this.chart_Investimentos.Series.Add(series2);
            this.chart_Investimentos.Size = new System.Drawing.Size(468, 629);
            this.chart_Investimentos.TabIndex = 2;
            this.chart_Investimentos.Text = "Investimentos";
            title1.Name = "Comparação de Investimentos";
            title1.Text = "Comparação de Investimentos";
            this.chart_Investimentos.Titles.Add(title1);
            // 
            // Investimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 675);
            this.Controls.Add(this.chart_Investimentos);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Investimentos";
            this.Text = "Investimentos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Poupanca.ResumeLayout(false);
            this.tabPage_Poupanca.PerformLayout();
            this.groupBox_Resultados.ResumeLayout(false);
            this.groupBox_Resultados.PerformLayout();
            this.groupBox_Preencher.ResumeLayout(false);
            this.groupBox_Preencher.PerformLayout();
            this.tabPage_LCILCA.ResumeLayout(false);
            this.tabPage_LCILCA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Investimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Poupanca;
        private System.Windows.Forms.Button button_LimparPoupanca;
        private System.Windows.Forms.Button button_Calcular_CDB;
        private System.Windows.Forms.GroupBox groupBox_Resultados;
        private System.Windows.Forms.Label label_ResultValorLiquidoAplicacaoPoupanca;
        private System.Windows.Forms.Label label_ResultAplicacaoAtualizadaPoupanca;
        private System.Windows.Forms.Label label_VlLiqAplicPoupanca;
        private System.Windows.Forms.Label label_AplicacaoAtualizadaPoupanca;
        private System.Windows.Forms.GroupBox groupBox_Preencher;
        private System.Windows.Forms.Label label_DiasCorridosPoupanca;
        private System.Windows.Forms.Label label_MesesPoupanca;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataResgate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataAplicacao;
        private System.Windows.Forms.TextBox textBox_ValorAplicadoPoupanca;
        private System.Windows.Forms.Label label_DataResgate;
        private System.Windows.Forms.Label label_ValorAplicado;
        private System.Windows.Forms.Label label_DataAplicacao;
        private System.Windows.Forms.TabPage tabPage_LCILCA;
        private System.Windows.Forms.Button button_LimparLCA;
        private System.Windows.Forms.Button button_Calcular_LCA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ResultadoValorRendimentoLiquido_LCA;
        private System.Windows.Forms.Label label_ResultadoAplicacaoAtualizada_LCA;
        private System.Windows.Forms.Label label_ValorRendimentoLiquido_LCA;
        private System.Windows.Forms.Label label_AplicacaoAtualizada_LCA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_PercentualCDI_LCA;
        private System.Windows.Forms.Label label_PercentualCDI_LCA;
        private System.Windows.Forms.TextBox textBox_TaxaDI_LCA;
        private System.Windows.Forms.Label label_TaxaDI_LCA;
        private System.Windows.Forms.Label label_ResultadoMeses_LCA;
        private System.Windows.Forms.Label label_MesesCorridos_LCA;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataResgate_LCA;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataAplicacao_LCA;
        private System.Windows.Forms.TextBox textBox_ValorAplicadoLCA;
        private System.Windows.Forms.Label label_DataResgate_LCA;
        private System.Windows.Forms.Label label_ValorAplicadoLCA;
        private System.Windows.Forms.Label label_DataAplicacao_LCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AjudaPou;
        private System.Windows.Forms.Button button_AjudaLC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Investimentos;
    }
}