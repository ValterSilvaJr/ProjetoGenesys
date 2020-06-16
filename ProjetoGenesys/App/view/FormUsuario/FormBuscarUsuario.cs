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
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            usuarioDao.ListarUsuarios(dgvBuscarUsuario);
        }

        private void dgvBuscarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FormDetalhesUsuario formDetalhes;
            //Comando para pegar o valor da célula clicada
            string tipoUsuario = dgvBuscarUsuario.CurrentRow.Cells[3].Value.ToString();
            string idUsuario = dgvBuscarUsuario.CurrentRow.Cells[4].Value.ToString();
            //formDetalhes = new FormDetalhesUsuario(idUsuario, tipoUsuario);

            if (e.ColumnIndex == 4)
            {
                //AbrirChildForm.exibirFormularioChild(new FormDetalhesUsuario(idUsuario, tipoUsuario), pnlChildForm);
                AbrirChildForm(new FormDetalhesUsuario(idUsuario, tipoUsuario));
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
