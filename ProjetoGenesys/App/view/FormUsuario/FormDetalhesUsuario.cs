using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGenesys.App.controller;
using ProjetoGenesys.App.model;

namespace ProjetoGenesys.App.view
{
    public partial class FormDetalhesUsuario : Form
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        PojoUsuario pojoUsuario = new PojoUsuario();
        PojoFuncionario pojoFcn = new PojoFuncionario();
        PojoPessoaFisica pojoPf = new PojoPessoaFisica();
        PojoPessoaJuridica pojoPj = new PojoPessoaJuridica();
        string idUsuario, tipoUsuario;

        public FormDetalhesUsuario(string idUsuarioParam, string tipoUsuarioParam)
        {
            InitializeComponent();
            BloquearControles();
            CustomizarAparencia();

            idUsuario = idUsuarioParam; 
            tipoUsuario = tipoUsuarioParam;

            usuarioDao.ListarDetalhesUsuario(idUsuario, tipoUsuario, pojoUsuario, pojoPf, pojoPj, pojoFcn);

            // O formulário recebe um parâmetro com o tipo de usuário que será inserido no sistema e exibe o painél especializado

            switch (tipoUsuario)
            {
                case "PF":
                    ExibirPainelEspecializacao(pnlPF, "PF");
                    break;
                case "PJ":
                    ExibirPainelEspecializacao(pnlPJ, "PJ");
                    break;
                case "FCN":
                    ExibirPainelEspecializacao(pnlCargo, "FCN");
                    break;
            }

            CarregarDadosUsuario();
        }
        #region Lógica de ocultar Painéis

        private void CustomizarAparencia()
        {
            //Inicialmente todos os painéis são setados para ter a visibilidade false através deste método que é carregado junto com o form atual

            pnlPF.Visible = false;
            pnlPJ.Visible = false;
            pnlCargo.Visible = false;
        }
        private void EsconderPainelEspecializacao()
        {

            //É verificado se os painés estão visíveis e caso seja true, os mesmos são setados para false

            if (pnlPF.Visible)
            {
                pnlPF.Visible = false;
            }
            if (pnlCargo.Visible)
            {
                pnlCargo.Visible = false;
            }
            if (pnlPJ.Visible)
            {
                pnlPJ.Visible = false;
            }
        }
        private void ExibirPainelEspecializacao(Panel especializacaoPanel, string tipo)
        {
            //É passado como parâmetro o painel que ficará visível e o tipo de usuário através deste método, deixando todos os demais painéis invisíveis.

            if (especializacaoPanel.Visible == false)
            {
                EsconderPainelEspecializacao();
                especializacaoPanel.Visible = true;
                tipoUsuario = tipo;
            }
            else
            {
                especializacaoPanel.Visible = false;
            }
        }
        #endregion
        private void BloquearControles()
        {
            //Botão Atualizar
            btnAtualizar.Enabled    = false;

            //Botão Atualizar
            btnEditar.Enabled       = true;
            
            //Usuário
            txtNome.Enabled         = false;     txtNome.BackColor         = Color.LightGray;
            txtEmail.Enabled        = false;     txtEmail.BackColor        = Color.LightGray;
            mskSenha.Enabled        = false;     mskSenha.BackColor        = Color.LightGray;
            txtLogradouro.Enabled   = false;     txtLogradouro.BackColor   = Color.LightGray;
            txtNumero.Enabled       = false;     txtNumero.BackColor       = Color.LightGray;
            mskCep.Enabled          = false;     mskCep.BackColor          = Color.LightGray;
            txtBairro.Enabled       = false;     txtBairro.BackColor       = Color.LightGray;
            txtCidade.Enabled       = false;     txtCidade.BackColor       = Color.LightGray;
            txtUf.Enabled           = false;     txtUf.BackColor           = Color.LightGray;
            txtPais.Enabled         = false;     txtPais.BackColor         = Color.LightGray;

            //Pessoa Física
            mskCpf.Enabled          = false;     mskCpf.BackColor          = Color.LightGray;
            mskDataNasc.Enabled     = false;     mskDataNasc.BackColor     = Color.LightGray;

            //Pessoa Jurídica
            mskCnpj.Enabled         = false;    mskCnpj.BackColor          = Color.LightGray;
            mskInscEst.Enabled      = false;    mskInscEst.BackColor       = Color.LightGray;
            txtRazaoSocial.Enabled  = false;    txtRazaoSocial.BackColor   = Color.LightGray;
            txtNomeFantasia.Enabled = false;    txtNomeFantasia.BackColor  = Color.LightGray;

            //Funcionário
            txtCargo.Enabled        = false;    txtCargo.BackColor         = Color.LightGray;
            txtSetor.Enabled        = false;    txtSetor.BackColor         = Color.LightGray;
            txtTurno.Enabled        = false;    txtTurno.BackColor         = Color.LightGray;

        }
        private void DesbloquearControles()
        {
            //Botão Atualizar
            btnAtualizar.Enabled    = true;

            //Botão Editar
            btnEditar.Enabled       = false;
            
            //Usuário
            txtNome.Enabled         = true;    txtNome.BackColor           = Color.White;
            txtEmail.Enabled        = true;    txtEmail.BackColor          = Color.White;
            mskSenha.Enabled        = true;    mskSenha.BackColor          = Color.White;
            txtLogradouro.Enabled   = true;    txtLogradouro.BackColor     = Color.White;
            txtNumero.Enabled       = true;    txtNumero.BackColor         = Color.White;
            mskCep.Enabled          = true;    mskCep.BackColor            = Color.White;
            txtBairro.Enabled       = true;    txtBairro.BackColor         = Color.White;
            txtCidade.Enabled       = true;    txtCidade.BackColor         = Color.White;
            txtUf.Enabled           = true;    txtUf.BackColor             = Color.White;
            txtPais.Enabled         = true;    txtPais.BackColor           = Color.White;

            //Pessoa Física
            mskCpf.Enabled          = true;    mskCpf.BackColor            = Color.White;
            mskDataNasc.Enabled     = true;    mskDataNasc.BackColor       = Color.White;

            //Pessoa Jurídica
            mskCnpj.Enabled         = true;    mskCnpj.BackColor           = Color.White;
            mskInscEst.Enabled      = true;    mskInscEst.BackColor        = Color.White;
            txtRazaoSocial.Enabled  = true;    txtRazaoSocial.BackColor    = Color.White;
            txtNomeFantasia.Enabled = true;    txtNomeFantasia.BackColor   = Color.White;

            //Funcionário
            txtCargo.Enabled        = true;    txtCargo.BackColor          = Color.White;
            txtSetor.Enabled        = true;    txtSetor.BackColor          = Color.White;
            txtTurno.Enabled        = true;    txtTurno.BackColor          = Color.White;
        }
        private void CarregarDadosUsuario()
        {
            //Carrega os dados em comum
            txtNome.Text = pojoUsuario.getNome();
            txtEmail.Text = pojoUsuario.getEmail();
            mskSenha.Text = pojoUsuario.getSenha();
            txtLogradouro.Text = pojoUsuario.getLogradouro();
            txtNumero.Text = pojoUsuario.getNumero();
            mskCep.Text = pojoUsuario.getCep();
            txtBairro.Text = pojoUsuario.getBairro();
            txtCidade.Text = pojoUsuario.getCidade();
            txtUf.Text = pojoUsuario.getUf();
            txtPais.Text = pojoUsuario.getPais();

            //Carrega os dados Especializados
            switch (tipoUsuario)
            {
                case "PF":
                    mskCpf.Text = pojoPf.getCpf();
                    mskDataNasc.Text = pojoPf.getDataNasc();
                    break;
                case "PJ":
                    mskCnpj.Text = pojoPj.getCnpj();
                    mskInscEst.Text = pojoPj.getInscricaoEstadual();
                    txtRazaoSocial.Text = pojoPj.getRazaoSocial();
                    txtNomeFantasia.Text = pojoPj.getNomeFantasia();
                    break;
                case "FCN":
                    txtCargo.Text = pojoFcn.getCargo();
                    txtSetor.Text = pojoFcn.getSetor();
                    txtTurno.Text = pojoFcn.getTurno();
                    break;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string senhaCriptografada = MD5Hash.CalcularHash(mskSenha.Text);

            pojoUsuario.setNome(txtNome.Text);
            pojoUsuario.setEmail(txtEmail.Text);
            pojoUsuario.setSenha(senhaCriptografada);
            pojoUsuario.setLogradouro(txtLogradouro.Text);
            pojoUsuario.setNumero(txtNumero.Text);
            pojoUsuario.setCep(mskCep.Text);
            pojoUsuario.setBairro(txtBairro.Text);
            pojoUsuario.setCidade(txtCidade.Text);
            pojoUsuario.setUf(txtUf.Text);
            pojoUsuario.setPais(txtPais.Text);

            switch (tipoUsuario)
            {
                case "PF":
                    pojoPf.setCpf(mskCpf.Text);
                    pojoPf.setDataNasc(mskDataNasc.Text);
                    break;
                case "PJ":
                    pojoPj.setCnpj(mskCnpj.Text);
                    pojoPj.setInscricaoEstadual(mskInscEst.Text);
                    pojoPj.setRazaoSocial(txtRazaoSocial.Text);
                    pojoPj.setNomeFantasia(txtNomeFantasia.Text);
                    break;
                case "FCN":
                    pojoFcn.setCargo(txtCargo.Text);
                    pojoFcn.setSetor(txtSetor.Text);
                    pojoFcn.setTurno(txtTurno.Text);
                    break;
            }

            usuarioDao.AtualizarUsuario(idUsuario, tipoUsuario, pojoUsuario, pojoPf, pojoPj, pojoFcn);
            BloquearControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            bool isDeleted = usuarioDao.DeletarUsuario(idUsuario);

            if(isDeleted)
            {
                Close();
                MessageBox.Show("Dados Excluidos com sucesso", "Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir os dados", "Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
