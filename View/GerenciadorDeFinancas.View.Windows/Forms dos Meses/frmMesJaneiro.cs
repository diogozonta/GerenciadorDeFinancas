using GerenciadorDeFinancas.Model.Infra.Repositories;
using GerenciadorDeFinancas.View.Windows.Movimentacoes;

namespace GerenciadorDeFinancas.View.Windows.Forms_dos_Meses
{

    public partial class frmMesJaneiro : Form
    {
        public TrasacaoRepository _transacaoRepository = new TrasacaoRepository();

        public frmMesJaneiro()
        {
            InitializeComponent();
            dgvMesJaneiro.DataSource = _transacaoRepository.ObterTransacoes();         
        }

        private void btnAdicionarTransacao_Click(object sender, EventArgs e)
        {
            var form = new frmAdicionarTransacao();
            form.Show();
            this.Hide();
        }

        private void btnRemoverTransacao_Click(object sender, EventArgs e)
        {

        }
    }
}
