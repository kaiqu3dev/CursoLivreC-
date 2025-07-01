using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Padaria
{
    public partial class FrmGerenciaFuncionarios : Form
    {
        public FrmGerenciaFuncionarios()
        {
            InitializeComponent();
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            mskTelefone.Enabled = false;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;

            txtNome.Focus();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            mskCEP.Text = "";
            mskCPF.Text = "";
            mskTelefone.Text = "";

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("")||
                txtEmail.Text.Equals("")||
                txtEndereco.Text.Equals("")||
                txtNumero.Text.Equals("")||
                txtCidade.Text.Equals("")||
                txtComplemento.Text.Equals("")||
                cbbEstado.Text.Equals("")||
                mskCEP.Text.Equals("     -") ||
                mskCPF.Text.Equals("   .   .   -")||
                mskTelefone.Text.Equals("(  )      -"))
            {
                MessageBox.Show("Favor Preencher os Campos!!!");
            }
            else
            {
                MessageBox.Show("Cadastrado com Sucesso!!!");
                desabilitarCampos();
                LimparCampos();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir?",
                "Mensagem do Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Excluido com Sucesso!!!",
                "Mensagem do Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                LimparCampos();
            }
            else
            {
                txtNome.Focus ();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com Sucesso!!!",
               "Mensagem do Sistema",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            desabilitarCampos ();
            LimparCampos();
        }
    }
}
