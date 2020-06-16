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
        bool stateAtt = false;
        string idUsuario, tipoUsuario;

        public FormDetalhesUsuario(string idUsuarioParam, string tipoUsuarioParam)
        {
            InitializeComponent();
            idUsuario = idUsuarioParam;
            tipoUsuario = tipoUsuarioParam;
            BloquearControles();
            usuarioDao.ListarDetalhesUsuario(idUsuario, tipoUsuario, pojoUsuario);
            CarregarDadosUsuario();
            /*
            if (stateAtt)
            {
                AtualizarDadosUsuario();
                usuarioDao.AtualizarUsuario(idUsuario, pojoUsuario);
            }
            else
            {
                CarregarDadosUsuario();
            }
            */
        }
        private void BloquearControles()
        {
            txtNome.Enabled = false;
            txtNome.BackColor = Color.LightGray;
        }
        private void DesbloquearControles()
        {
            
        }
        private void CarregarDadosUsuario()
        {
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
        }
        private void AtualizarDadosUsuario()
        {
            pojoUsuario.setNome(txtNome.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            pojoUsuario.setNome(txtNome.Text);
            usuarioDao.AtualizarUsuario(idUsuario, pojoUsuario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {           
            txtNome.Enabled = true;
            txtNome.BackColor = Color.White;

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
