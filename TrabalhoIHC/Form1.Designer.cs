namespace TrabalhoIHC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button_Investimentos = new System.Windows.Forms.Button();
            this.button_ReceitasDespesas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = global::TrabalhoIHC.Properties.Resources.if_money_box_2639868;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(26, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Metas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Investimentos
            // 
            this.button_Investimentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Investimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Investimentos.Image = global::TrabalhoIHC.Properties.Resources.if_Investment_2639841;
            this.button_Investimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Investimentos.Location = new System.Drawing.Point(26, 118);
            this.button_Investimentos.Name = "button_Investimentos";
            this.button_Investimentos.Size = new System.Drawing.Size(280, 58);
            this.button_Investimentos.TabIndex = 1;
            this.button_Investimentos.Text = "Investimentos";
            this.button_Investimentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Investimentos.UseVisualStyleBackColor = true;
            this.button_Investimentos.Click += new System.EventHandler(this.button_Investimentos_Click);
            // 
            // button_ReceitasDespesas
            // 
            this.button_ReceitasDespesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ReceitasDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_ReceitasDespesas.Image = global::TrabalhoIHC.Properties.Resources.if_money_bag_2_322466;
            this.button_ReceitasDespesas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ReceitasDespesas.Location = new System.Drawing.Point(26, 24);
            this.button_ReceitasDespesas.Name = "button_ReceitasDespesas";
            this.button_ReceitasDespesas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_ReceitasDespesas.Size = new System.Drawing.Size(280, 58);
            this.button_ReceitasDespesas.TabIndex = 0;
            this.button_ReceitasDespesas.Text = "Receitas e Despesas";
            this.button_ReceitasDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ReceitasDespesas.UseVisualStyleBackColor = true;
            this.button_ReceitasDespesas.Click += new System.EventHandler(this.button_ReceitasDespesas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 310);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Investimentos);
            this.Controls.Add(this.button_ReceitasDespesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meu Bolso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ReceitasDespesas;
        private System.Windows.Forms.Button button_Investimentos;
        private System.Windows.Forms.Button button2;
    }
}

