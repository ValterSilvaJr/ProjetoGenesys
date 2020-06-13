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
            FormDetalhesUsuario formDetalhes;
            //Comando para pegar o valor da célula clicada
            string idUsuario = dgvBuscarUsuario.CurrentRow.Cells[4].Value.ToString();

            if (e.ColumnIndex == 4)
            {
                formDetalhes = new FormDetalhesUsuario(idUsuario);
                formDetalhes.Show();
            }
        }
    }
}
