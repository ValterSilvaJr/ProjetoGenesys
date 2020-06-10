using System;
using System.Drawing.Text;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using ProjetoGenesys.App.controller;
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
        string inserirUsuario;
        int response;

        public FormCadastroUsuario(string tipoUsuario)
        {
            InitializeComponent();
            CustomizarAparencia();

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
                inserirUsuario = tipo;
            }
            else
            {
                especializacaoPanel.Visible = false;
            }
        }
        #endregion
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
             
        private void btnInserir_Click(object sender, EventArgs e)
        {

            switch (inserirUsuario)
            {
                case "PF":
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
                    pojoPf = new PojoPessoaFisica();
                    pojoPf.setCpf(mskCpf.Text);
                    pojoPf.setDataNasc(mskDataNasc.Text);
                    pojoPf.setTipo(inserirUsuario);
                    #endregion

                    response = usuarioDao.CadastrarUsuario(pojoUsuario, pojoPf);

                    if (response == 1)
                    {
                        MessageBox.Show(MessageSender.Positive.getMessage("sucessoCadastrarDados"), "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(MessageSender.Negative.getMessage("erroCadastrarDados"), "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "PJ":
                    MessageBox.Show("PJ", "GENESYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "FCN":
                    MessageBox.Show("FCN", "GENESYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    
                    break;
            }
 
            /*
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

            
            
            response = usuarioDao.CadastrarUsuario(pojoUsuario, pojoPf);

            if(response == 1)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar dados", "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }
    }
}
