using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public FormDetalhesUsuario(string idUsuario, string tipoUsuario)
        {
            InitializeComponent();
            
            BloquearControles();
            usuarioDao.ListarDetalhesUsuario(idUsuario, tipoUsuario, pojoUsuario);

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
        private void BloquearControles()
        {
            txtNome.Enabled = false;
            txtNome.BackColor = Color.LightGray;
        }
        private void DesbloquearControles()
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {           
            txtNome.Enabled = true;
            txtNome.BackColor = Color.White;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
