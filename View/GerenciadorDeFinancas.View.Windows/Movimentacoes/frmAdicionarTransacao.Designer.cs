namespace GerenciadorDeFinancas.View.Windows.Movimentacoes
{
    partial class frmAdicionarTransacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTransacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoTransacao = new System.Windows.Forms.RichTextBox();
            this.txtValorTransacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarTrasacao = new System.Windows.Forms.Button();
            this.txtDataTransacao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da transação";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(6, 22);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(65, 19);
            this.rbEntrada.TabIndex = 1;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSaida);
            this.groupBox1.Controls.Add(this.rbEntrada);
            this.groupBox1.Location = new System.Drawing.Point(285, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da transação";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(6, 47);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(53, 19);
            this.rbSaida.TabIndex = 2;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saida";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data da transação";
            // 
            // txtNomeTransacao
            // 
            this.txtNomeTransacao.Location = new System.Drawing.Point(12, 41);
            this.txtNomeTransacao.Name = "txtNomeTransacao";
            this.txtNomeTransacao.Size = new System.Drawing.Size(147, 23);
            this.txtNomeTransacao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição da transação";
            // 
            // txtDescricaoTransacao
            // 
            this.txtDescricaoTransacao.Location = new System.Drawing.Point(12, 101);
            this.txtDescricaoTransacao.Name = "txtDescricaoTransacao";
            this.txtDescricaoTransacao.Size = new System.Drawing.Size(267, 57);
            this.txtDescricaoTransacao.TabIndex = 8;
            this.txtDescricaoTransacao.Text = "";
            // 
            // txtValorTransacao
            // 
            this.txtValorTransacao.Location = new System.Drawing.Point(276, 41);
            this.txtValorTransacao.Name = "txtValorTransacao";
            this.txtValorTransacao.Size = new System.Drawing.Size(116, 23);
            this.txtValorTransacao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor da transação";
            // 
            // btnAdicionarTrasacao
            // 
            this.btnAdicionarTrasacao.AutoSize = true;
            this.btnAdicionarTrasacao.Location = new System.Drawing.Point(134, 185);
            this.btnAdicionarTrasacao.Name = "btnAdicionarTrasacao";
            this.btnAdicionarTrasacao.Size = new System.Drawing.Size(122, 25);
            this.btnAdicionarTrasacao.TabIndex = 11;
            this.btnAdicionarTrasacao.Text = "Adicionar transação";
            this.btnAdicionarTrasacao.UseVisualStyleBackColor = true;
            this.btnAdicionarTrasacao.Click += new System.EventHandler(this.btnAdicionarTrasacao_Click);
            // 
            // txtDataTransacao
            // 
            this.txtDataTransacao.Location = new System.Drawing.Point(166, 41);
            this.txtDataTransacao.Mask = "##/##/####";
            this.txtDataTransacao.Name = "txtDataTransacao";
            this.txtDataTransacao.Size = new System.Drawing.Size(100, 23);
            this.txtDataTransacao.TabIndex = 3;
            // 
            // frmAdicionarTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 236);
            this.Controls.Add(this.txtDataTransacao);
            this.Controls.Add(this.btnAdicionarTrasacao);
            this.Controls.Add(this.txtValorTransacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricaoTransacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeTransacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAdicionarTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdicionarTransacao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rbEntrada;
        private GroupBox groupBox1;
        private RadioButton rbSaida;
        private Label label2;
        private TextBox txtNomeTransacao;
        private Label label3;
        private RichTextBox txtDescricaoTransacao;
        private TextBox txtValorTransacao;
        private Label label4;
        private Button btnAdicionarTrasacao;
        private MaskedTextBox txtDataTransacao;
    }
}