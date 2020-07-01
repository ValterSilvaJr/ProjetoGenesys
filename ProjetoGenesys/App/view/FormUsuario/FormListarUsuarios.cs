using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGenesys.App.controller;
using ProjetoGenesys.App.model;

namespace ProjetoGenesys.App.view
{
    public partial class FormBuscarUsuario : Form
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        string tipoUsuario;
        public FormBuscarUsuario(string tipoUsuarioParam)
        {
            InitializeComponent();
            tipoUsuario = tipoUsuarioParam;
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            usuarioDao.ListarUsuarios(dgvBuscarUsuario, tipoUsuario);
        }

        private void dgvBuscarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tipoUsuarioDataTable = "";

            switch (tipoUsuario)
            {
                case "Cliente":
                    //Comando para pegar o valor da célula clicada
                    tipoUsuarioDataTable = dgvBuscarUsuario.CurrentRow.Cells[4].Value.ToString();
                    string idUsuario = dgvBuscarUsuario.CurrentRow.Cells[1].Value.ToString();

                    if (e.ColumnIndex == 5)
                    {
                        //AbrirChildForm.exibirFormularioChild(new FormDetalhesUsuario(idUsuario, tipoUsuario), pnlChildForm);
                        AbrirChildForm(new FormDetalhesUsuario(idUsuario, tipoUsuarioDataTable));
                    }

                    break;
                case "Funcionario":
                    idUsuario = dgvBuscarUsuario.CurrentRow.Cells[1].Value.ToString();
                    if (e.ColumnIndex == 5)
                    {
                        //AbrirChildForm.exibirFormularioChild(new FormDetalhesUsuario(idUsuario, tipoUsuario), pnlChildForm);
                        AbrirChildForm(new FormDetalhesUsuario(idUsuario, tipoUsuarioDataTable));
                    }
                    break;
            }
        }
        
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
        
        
    }
}
