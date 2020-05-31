using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using ProjetoGenesys.App.model;

namespace ProjetoGenesys.App.view
{
    public partial class FormCadastroUsuario : Form
    {
        PojoUsuario pojoUsuario;
        PojoPessoaFisica pojoPf;
        PojoPessoaJuridica pojoPj;
        PojoFuncionario pojoFunc;
        UsuarioDao usuarioDao;
        int response;

        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            usuarioDao = new UsuarioDao();

            #region PojoUsuario
            pojoUsuario = new PojoUsuario();
            pojoUsuario.setNome(txtNome.Text);
            pojoUsuario.setEmail(txtEmail.Text);
            pojoUsuario.setSenha(mskSenha.Text);
            pojoUsuario.setLogradouro(txtLogradouro.Text);
            pojoUsuario.setNumero(txtNumero.Text);
            pojoUsuario.setCep(mskCep.Text);
            pojoUsuario.setBairro(txtBairro.Text);
            pojoUsuario.setCidade(txtCidade.Text);
            pojoUsuario.setUf(txtUf.Text);
            pojoUsuario.setPais(txtPais.Text);
            #endregion

            #region PojoPessoaFisica
            const string tipoPf = "PF";
            pojoPf = new PojoPessoaFisica();
            pojoPf.setCpf(mskCpf.Text);
            pojoPf.setDataNasc(mskDataNasc.Text);
            pojoPf.setTipo(tipoPf);
            #endregion
            /*
            #region PojoPessoaJuridica
            const string tipoPj = "PJ";
            pojoPj = new PojoPessoaJuridica();
            pojoPj.setCnpj(mskCnpj.Text);
            pojoPj.setInscricaoEstadual(mskInscEst.Text);
            pojoPj.setRazaoSocial(txtRazaoSocial.Text);
            pojoPj.setNomeFantasia(txtNomeFantasia.Text);
            pojoPj.setTipo(tipoPj);
            #endregion

            #region PojoFuncionario
            pojoFunc = new PojoFuncionario();
            pojoFunc.setCargo(txtCargo.Text);
            pojoFunc.setSetor(txtSetor.Text);
            pojoFunc.setTurno(txtTurno.Text);
            #endregion
            */
            response = usuarioDao.CadastrarUsuario(pojoUsuario, pojoPf, pojoPj, pojoFunc);

            if(response == 1)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar dados: Delta-" + response, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
