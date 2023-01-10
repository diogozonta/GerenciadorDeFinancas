using GerenciadorDeFinancas.View.Windows.Forms_dos_Meses;
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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
            lblNomeUsuario.Text = frmLogin.nomeUsuario;
            #region Meses ComboBox

            List <string> mesesDoAno = new List<string>();
            mesesDoAno.Add("Janeiro");
            mesesDoAno.Add("Fevereiro");
            mesesDoAno.Add("Março");
            mesesDoAno.Add("Abril");
            mesesDoAno.Add("Maio");
            mesesDoAno.Add("Junho");
            mesesDoAno.Add("Julho");
            mesesDoAno.Add("Agosto");
            mesesDoAno.Add("Setembro");
            mesesDoAno.Add("Outubro");
            mesesDoAno.Add("Novembro");
            mesesDoAno.Add("Dezembro");

            cmbMesReferencia.DataSource = mesesDoAno;
            cmbMesReferencia.SelectedIndex = 0;

            #endregion
        }

        private void cmbMesReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbMesReferencia.SelectedIndex) 
            {
                case 0:
                    this.pnlPrincipal.Controls.Clear();
                    Forms_dos_Meses.frmMesJaneiro frmMesJaneiro = new frmMesJaneiro { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmMesJaneiro.FormBorderStyle = FormBorderStyle.None;
                    this.pnlPrincipal.Controls.Add(frmMesJaneiro);
                    frmMesJaneiro.Show();
                    break;
                case 1:
                    this.pnlPrincipal.Controls.Clear();
                    Forms_dos_Meses.frmMesFevereiro frmMesFevereiro = new frmMesFevereiro { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmMesFevereiro.FormBorderStyle = FormBorderStyle.None;
                    this.pnlPrincipal.Controls.Add(frmMesFevereiro);
                    frmMesFevereiro.Show();
                    break;
                case 2:
                    this.pnlPrincipal.Controls.Clear();
                    Forms_dos_Meses.frmMesMarco frmMesMarco = new frmMesMarco { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmMesMarco.FormBorderStyle = FormBorderStyle.None;
                    this.pnlPrincipal.Controls.Add(frmMesMarco);
                    frmMesMarco.Show();
                    break;
            }
        }
    }
}