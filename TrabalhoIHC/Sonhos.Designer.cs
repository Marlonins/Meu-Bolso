namespace TrabalhoIHC
{
    partial class Metas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metas));
            this.label_NomeMeta = new System.Windows.Forms.Label();
            this.textBox_NomeMeta = new System.Windows.Forms.TextBox();
            this.label_DataInicio = new System.Windows.Forms.Label();
            this.label_DataFim = new System.Windows.Forms.Label();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Fim = new System.Windows.Forms.DateTimePicker();
            this.label_Valor = new System.Windows.Forms.Label();
            this.textBox_Valor = new System.Windows.Forms.TextBox();
            this.label_PoupancaMensal = new System.Windows.Forms.Label();
            this.label_ResultPoupancaMensal = new System.Windows.Forms.Label();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AjudaMetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NomeMeta
            // 
            this.label_NomeMeta.AutoSize = true;
            this.label_NomeMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomeMeta.Location = new System.Drawing.Point(9, 24);
            this.label_NomeMeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NomeMeta.Name = "label_NomeMeta";
            this.label_NomeMeta.Size = new System.Drawing.Size(113, 20);
            this.label_NomeMeta.TabIndex = 0;
            this.label_NomeMeta.Text = "Nome da Meta";
            // 
            // textBox_NomeMeta
            // 
            this.textBox_NomeMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NomeMeta.Location = new System.Drawing.Point(160, 24);
            this.textBox_NomeMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NomeMeta.Name = "textBox_NomeMeta";
            this.textBox_NomeMeta.Size = new System.Drawing.Size(151, 24);
            this.textBox_NomeMeta.TabIndex = 1;
            this.textBox_NomeMeta.TextChanged += new System.EventHandler(this.textBox_NomeMeta_TextChanged);
            this.textBox_NomeMeta.Leave += new System.EventHandler(this.textBox_NomeMeta_Leave);
            this.textBox_NomeMeta.MouseHover += new System.EventHandler(this.textBox_NomeMeta_MouseHover);
            // 
            // label_DataInicio
            // 
            this.label_DataInicio.AutoSize = true;
            this.label_DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataInicio.Location = new System.Drawing.Point(8, 63);
            this.label_DataInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DataInicio.Name = "label_DataInicio";
            this.label_DataInicio.Size = new System.Drawing.Size(161, 20);
            this.label_DataInicio.TabIndex = 2;
            this.label_DataInicio.Text = "Começa a poupar em";
            // 
            // label_DataFim
            // 
            this.label_DataFim.AutoSize = true;
            this.label_DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataFim.Location = new System.Drawing.Point(9, 106);
            this.label_DataFim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DataFim.Name = "label_DataFim";
            this.label_DataFim.Size = new System.Drawing.Size(167, 20);
            this.label_DataFim.TabIndex = 3;
            this.label_DataFim.Text = "Pretende realizá-lo em";
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(198, 66);
            this.dateTimePicker_Inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker_Inicio.TabIndex = 4;
            this.dateTimePicker_Inicio.ValueChanged += new System.EventHandler(this.dateTimePicker_Inicio_ValueChanged);
            this.dateTimePicker_Inicio.MouseHover += new System.EventHandler(this.dateTimePicker_Inicio_MouseHover);
            // 
            // dateTimePicker_Fim
            // 
            this.dateTimePicker_Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Fim.Location = new System.Drawing.Point(198, 108);
            this.dateTimePicker_Fim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_Fim.Name = "dateTimePicker_Fim";
            this.dateTimePicker_Fim.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker_Fim.TabIndex = 5;
            this.dateTimePicker_Fim.ValueChanged += new System.EventHandler(this.dateTimePicker_Fim_ValueChanged);
            this.dateTimePicker_Fim.MouseHover += new System.EventHandler(this.dateTimePicker_Fim_MouseHover);
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
            this.label_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valor.Location = new System.Drawing.Point(14, 148);
            this.label_Valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(169, 20);
            this.label_Valor.TabIndex = 6;
            this.label_Valor.Text = "Valor da Meta (em R$)";
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Valor.Location = new System.Drawing.Point(236, 148);
            this.textBox_Valor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(76, 24);
            this.textBox_Valor.TabIndex = 7;
            this.textBox_Valor.Enter += new System.EventHandler(this.textBox_Valor_Enter);
            this.textBox_Valor.Leave += new System.EventHandler(this.textBox_Valor_Leave);
            this.textBox_Valor.MouseHover += new System.EventHandler(this.textBox_Valor_MouseHover);
            // 
            // label_PoupancaMensal
            // 
            this.label_PoupancaMensal.AutoSize = true;
            this.label_PoupancaMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PoupancaMensal.Location = new System.Drawing.Point(14, 228);
            this.label_PoupancaMensal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PoupancaMensal.Name = "label_PoupancaMensal";
            this.label_PoupancaMensal.Size = new System.Drawing.Size(136, 20);
            this.label_PoupancaMensal.TabIndex = 8;
            this.label_PoupancaMensal.Text = "Poupança Mensal";
            // 
            // label_ResultPoupancaMensal
            // 
            this.label_ResultPoupancaMensal.AutoSize = true;
            this.label_ResultPoupancaMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultPoupancaMensal.Location = new System.Drawing.Point(217, 228);
            this.label_ResultPoupancaMensal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ResultPoupancaMensal.Name = "label_ResultPoupancaMensal";
            this.label_ResultPoupancaMensal.Size = new System.Drawing.Size(43, 20);
            this.label_ResultPoupancaMensal.TabIndex = 9;
            this.label_ResultPoupancaMensal.Text = "R$ 0";
            // 
            // button_Limpar
            // 
            this.button_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpar.Location = new System.Drawing.Point(132, 260);
            this.button_Limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(75, 26);
            this.button_Limpar.TabIndex = 10;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            this.button_Limpar.MouseHover += new System.EventHandler(this.button_Limpar_MouseHover);
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(132, 183);
            this.button_Calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(75, 26);
            this.button_Calcular.TabIndex = 11;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            this.button_Calcular.MouseHover += new System.EventHandler(this.button_Calcular_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*Campos vazios terão valor 0 ";
            // 
            // button_AjudaMetas
            // 
            this.button_AjudaMetas.Image = global::TrabalhoIHC.Properties.Resources.if_164_QuestionMark_183285;
            this.button_AjudaMetas.Location = new System.Drawing.Point(274, 278);
            this.button_AjudaMetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AjudaMetas.Name = "button_AjudaMetas";
            this.button_AjudaMetas.Size = new System.Drawing.Size(37, 26);
            this.button_AjudaMetas.TabIndex = 15;
            this.button_AjudaMetas.UseVisualStyleBackColor = true;
            this.button_AjudaMetas.Click += new System.EventHandler(this.button_AjudaMetas_Click);
            // 
            // Metas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 314);
            this.Controls.Add(this.button_AjudaMetas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.label_ResultPoupancaMensal);
            this.Controls.Add(this.label_PoupancaMensal);
            this.Controls.Add(this.textBox_Valor);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.dateTimePicker_Fim);
            this.Controls.Add(this.dateTimePicker_Inicio);
            this.Controls.Add(this.label_DataFim);
            this.Controls.Add(this.label_DataInicio);
            this.Controls.Add(this.textBox_NomeMeta);
            this.Controls.Add(this.label_NomeMeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Metas";
            this.Text = "Metas";
            this.Load += new System.EventHandler(this.Metas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NomeMeta;
        private System.Windows.Forms.TextBox textBox_NomeMeta;
        private System.Windows.Forms.Label label_DataInicio;
        private System.Windows.Forms.Label label_DataFim;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fim;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.TextBox textBox_Valor;
        private System.Windows.Forms.Label label_PoupancaMensal;
        private System.Windows.Forms.Label label_ResultPoupancaMensal;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AjudaMetas;
    }
}