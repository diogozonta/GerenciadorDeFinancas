using GerenciadorDeFinancas.View.Windows.Forms_dos_Meses;
using GerenciadorDeSenhas.Controller;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFinancas.View.Windows.Movimentacoes
{
    public partial class frmAdicionarTransacao : Form
    {
        private TransacaoController _transacaoController = new TransacaoController();

        public frmAdicionarTransacao()
        {
            InitializeComponent();
        }

        private void btnAdicionarTrasacao_Click(object sender, EventArgs e)
        {
            var tipoEntrada = string.Empty;

            if (rbEntrada.Checked) 
            {
                tipoEntrada = rbEntrada.Text.ToUpper();
            }            
            else
            {
                tipoEntrada = rbSaida.Text.ToUpper();
            }

            //decimal valorTransacao = Convert.ToDecimal(txtValorTransacao.Text);
            decimal valorTransacao = Convert.ToDecimal(txtValorTransacao.Text, CultureInfo.CurrentCulture);

            var cadastrou = _transacaoController.InserirTransacao(txtNomeTransacao.Text, tipoEntrada, Convert.ToDateTime(txtDataTransacao.Text), txtDescricaoTransacao.Text, valorTransacao);

            if (cadastrou)
            {
                MessageBox.Show("Transação cadastrada com sucesso");
                this.Hide();
            }

            else
            {
                MessageBox.Show("Não foi possível cadastrar sua transação");
            }

        }
    }
}
