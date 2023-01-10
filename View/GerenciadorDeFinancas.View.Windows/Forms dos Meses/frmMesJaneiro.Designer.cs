namespace GerenciadorDeFinancas.View.Windows.Forms_dos_Meses
{
    partial class frmMesJaneiro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesJaneiro));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMesJaneiro = new System.Windows.Forms.DataGridView();
            this.btnAdicionarTransacao = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemoverTransacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesJaneiro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você está vendo as transações do mês de Janeiro";
            // 
            // dgvMesJaneiro
            // 
            this.dgvMesJaneiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesJaneiro.Location = new System.Drawing.Point(12, 90);
            this.dgvMesJaneiro.Name = "dgvMesJaneiro";
            this.dgvMesJaneiro.RowTemplate.Height = 25;
            this.dgvMesJaneiro.Size = new System.Drawing.Size(639, 399);
            this.dgvMesJaneiro.TabIndex = 1;
            // 
            // btnAdicionarTransacao
            // 
            this.btnAdicionarTransacao.AutoSize = true;
            this.btnAdicionarTransacao.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarTransacao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarTransacao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarTransacao.Image")));
            this.btnAdicionarTransacao.Location = new System.Drawing.Point(12, 54);
            this.btnAdicionarTransacao.Name = "btnAdicionarTransacao";
            this.btnAdicionarTransacao.Size = new System.Drawing.Size(31, 30);
            this.btnAdicionarTransacao.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAdicionarTransacao, "Adicionar transação");
            this.btnAdicionarTransacao.UseVisualStyleBackColor = false;
            this.btnAdicionarTransacao.Click += new System.EventHandler(this.btnAdicionarTransacao_Click);
            // 
            // btnRemoverTransacao
            // 
            this.btnRemoverTransacao.AutoSize = true;
            this.btnRemoverTransacao.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoverTransacao.FlatAppearance.BorderSize = 0;
            this.btnRemoverTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverTransacao.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverTransacao.Image")));
            this.btnRemoverTransacao.Location = new System.Drawing.Point(49, 54);
            this.btnRemoverTransacao.Name = "btnRemoverTransacao";
            this.btnRemoverTransacao.Size = new System.Drawing.Size(31, 30);
            this.btnRemoverTransacao.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoverTransacao, "Remover transação");
            this.btnRemoverTransacao.UseVisualStyleBackColor = false;
            this.btnRemoverTransacao.Click += new System.EventHandler(this.btnRemoverTransacao_Click);
            // 
            // frmMesJaneiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 498);
            this.Controls.Add(this.btnRemoverTransacao);
            this.Controls.Add(this.btnAdicionarTransacao);
            this.Controls.Add(this.dgvMesJaneiro);
            this.Controls.Add(this.label1);
            this.Name = "frmMesJaneiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMesJaneiro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesJaneiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvMesJaneiro;
        private Button btnAdicionarTransacao;
        private ToolTip toolTip1;
        private Button btnRemoverTransacao;
    }
}