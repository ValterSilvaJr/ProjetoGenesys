using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGenesys.App.model;

namespace ProjetoGenesys.App.view
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
            
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            usuarioDao.BuscarUsuario(dgvBuscarUsuario);
        }

        private void dgvBuscarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                UsuarioDao usuarioDao = new UsuarioDao();
            }
        }
    }
}
