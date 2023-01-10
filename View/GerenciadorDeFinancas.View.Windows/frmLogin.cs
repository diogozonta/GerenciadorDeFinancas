using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFinancas.View.Windows
{
    public partial class frmLogin : Form
    {

        public static string nomeUsuario = "";
        public static string usuarioUm = "DIOGO";
        public static string senhaUsuarioUm = "12345";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToUpper() != usuarioUm & txtSenha.Text != senhaUsuarioUm)
            {
                MessageBox.Show("Usuário e senha incorretos");
                return;
            }

            else if (txtNome.Text.ToUpper() != usuarioUm) 
            {
                errorProvider1.SetError(txtNome, "Usuário incorreto");
                return;
            }
            
            else if (txtSenha.Text != senhaUsuarioUm)
            {
                errorProvider1.SetError(txtSenha, "Senha incorreta");
                txtSenha.Clear();
                return;
            }

            nomeUsuario = txtNome.Text.ToUpper() + "!";

            var form = new frmTelaPrincipal();
            this.Hide();
            form.Show();
        }
    }
}
