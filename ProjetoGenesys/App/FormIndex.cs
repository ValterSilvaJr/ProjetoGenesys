using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGenesys.App.controller;
using ProjetoGenesys.App.view;

namespace ProjetoGenesys
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {   
            //Construtor da classe
            InitializeComponent();
            CustomizarAparencia();
        }
        private void CustomizarAparencia()
        {
            pnlUsuarioSubmenu.Visible = false;
            pnlVeiculoSubmenu.Visible = false;
            pnlLocacaoSubmenu.Visible = false;
            pnlGerarRelatorioSubmenu.Visible = false;
        }
        private void EsconderSubmenu()
        {
            if (pnlUsuarioSubmenu.Visible)
            {
                pnlUsuarioSubmenu.Visible = false;
            }
            if (pnlVeiculoSubmenu.Visible)
            {
                pnlVeiculoSubmenu.Visible = false;
            }
            if (pnlLocacaoSubmenu.Visible)
            {
                pnlLocacaoSubmenu.Visible = false;
            }
            if (pnlGerarRelatorioSubmenu.Visible)
            {
                pnlGerarRelatorioSubmenu.Visible = false;
            }
        }
        private void ExibirSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                EsconderSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region UsuarioSubmenu
        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            ExibirSubmenu(pnlUsuarioSubmenu);
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            string tipoUsuario = "PF";
            //AbrirChildForm(new FormCadastroUsuario(tipoUsuario));
            AbrirChildForm.exibirFormularioChild(new FormCadastroUsuario(tipoUsuario), pnlChildForm);
            EsconderSubmenu();
            
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            string tipoUsuario = "PJ";
            //AbrirChildForm(new FormCadastroUsuario(tipoUsuario));
            AbrirChildForm.exibirFormularioChild(new FormCadastroUsuario(tipoUsuario), pnlChildForm);
            EsconderSubmenu();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            string tipoUsuario = "FCN";
            AbrirChildForm.exibirFormularioChild(new FormCadastroUsuario(tipoUsuario), pnlChildForm);
            //AbrirChildForm(new FormCadastroUsuario(tipoUsuario));
            EsconderSubmenu();
        }
#endregion

        #region VeiculoSubmenu
        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            ExibirSubmenu(pnlVeiculoSubmenu);
        }

        private void btnVeiculoLeve_Click(object sender, EventArgs e)
        {
            //AbrirChildForm(new FormCadastroVeiculo());
            AbrirChildForm.exibirFormularioChild(new FormCadastroVeiculo(), pnlChildForm);
            EsconderSubmenu();
        }

        private void btnVeiculoPesado_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }
#endregion

        #region LocaçãoSubmenu
        private void btnLocacaoVeiculo_Click(object sender, EventArgs e)
        {
            ExibirSubmenu(pnlLocacaoSubmenu);
        }

        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnRegistrarDevolucao_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }
        #endregion

        #region GerarRelatorioSubmenu
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            ExibirSubmenu(pnlGerarRelatorioSubmenu);
        }
        private void btnConsultarUsuarios_Click(object sender, EventArgs e)
        {
            //AbrirChildForm(new FormBuscarUsuario());
            AbrirChildForm.exibirFormularioChild(new FormBuscarUsuario("Cliente"), pnlChildForm);
            EsconderSubmenu();
        }

        private void btnConsultarVeiculos_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnConsultarFcn_Click_1(object sender, EventArgs e)
        {
            AbrirChildForm.exibirFormularioChild(new FormBuscarUsuario("Funcionario"), pnlChildForm);
            EsconderSubmenu();
        }

        #endregion
        /*
        private Form formularioAtivo = null;
        private void AbrirChildForm(Form childForm)
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
            }
            formularioAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        */
    }
}
